using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ISSHW
{
    public partial class FormMain : Form
    {
        public static byte[] ImageByteArray;
        public static int[] IntArray;
        public static int[] EncryptedArray;
        public static int[] DecryptedArray;
        public static int e;
        public static int n;
        public static int d;
        public static int c;
        public string FilePath = "";
        public string OriginalUrl = Application.StartupPath + "\\Original.txt";
        public string OriginalImageUrl = Application.StartupPath + "\\OriginalImage.png";
        public string KeyGenerateUrl = Application.StartupPath + "\\KeyGenerate.txt";
        public string EncryptUrl = Application.StartupPath + "\\Encrypted.txt";
        public string EncryptedImageUrl = Application.StartupPath + "\\EncryptedImage.png";
        public string DecryptUrl = Application.StartupPath + "\\Decrypted.txt";
        public string DecryptedImageUrl = Application.StartupPath + "\\DecryptedImage.png";

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            File.Delete(OriginalUrl);
            File.Delete(KeyGenerateUrl);
            File.Delete(EncryptUrl);
            File.Delete(DecryptUrl);
            File.Delete(OriginalImageUrl);
            File.Delete(EncryptedImageUrl);
            File.Delete(DecryptedImageUrl);
            FileStream original = File.Create(@""+OriginalUrl+"");
            original.Close();
            FileStream key = File.Create(@"" + KeyGenerateUrl + "");
            key.Close();
            FileStream encrypt = File.Create(@"" + EncryptUrl + "");
            encrypt.Close();
            FileStream decrypt = File.Create(@"" + DecryptUrl + "");
            decrypt.Close();
        }

        public void UploadImage()
        {
            fileOpen.Title = "Choose Image";
            fileOpen.Filter = "(*.bmp)|*.bmp|(*.png)|*.png|(*.jpg)|*.jpg|(*.gif)|*.gif";
            fileOpen.ShowDialog();
            FilePath = fileOpen.FileName;
            txtImagePath.Text = FilePath;
            pbImage.ImageLocation = FilePath;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            UploadImage();
            lblImageStatus.Text = "[Image Was Uploaded]";
        }

        public byte[] ConvertImageToByteArray(System.Drawing.Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }

        private void btnConvertImageToByte_Click(object sender, EventArgs e)
        {
            ImageByteArray = new byte[0];
            ImageByteArray = ConvertImageToByteArray(pbImage.Image);
            FileStream fs = new FileStream(OriginalUrl, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            IntArray = ImageByteArray.Select(x => (int)x).ToArray();
            for (int j = 0; j < ImageByteArray.Length; j++)
            {
                sw.Write(IntArray[j] + " ");
            }
            sw.Flush();
            sw.Close();
            fs.Close();
            File.WriteAllBytes(OriginalImageUrl, ImageByteArray);
            lblImageStatus.Text = "[Image Was Converted From Image To Byte Array]";
        }

        public int InverseModulo(int Reverse, int Modulo)
        {
            int i = Modulo, v = 0, d = 1;
            while (Reverse > 0)
            {
                int t = i / Reverse, x = Reverse;
                Reverse = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= Modulo;
            if (v < 0) v = (v + Modulo) % Modulo;
            return v;
        }

        public int GcdControl(int less, int more)
        {
            Random r = new Random();
            int gcd = 1;
            int i;
            for (i = 1; i <= more; i++)
            {
                if ((less % i == 0) && (more % i == 0))
                {
                    gcd = i;
                }
                if (gcd != 1)
                {
                    less = r.Next(2, more);
                    i = 0;
                }
            }
            return less;
        }

        public Tuple<int, int> RandomPrime(int num1, int num2)
        {
            Random r = new Random();
            int[] numbers = new int[2] { num1, num2 };
            int i;
            int j;
            for (j = 0; j <= 1; j++)
            {
                for (i = 2; i < numbers[j]; i++)
                {
                    int counter = 0;
                    if (numbers[j] != 2)
                    {
                        if (numbers[j] % i == 0)
                        {
                            counter++;
                        }
                        if (counter > 0)
                        {
                            numbers[j] = r.Next(17, 98);
                            j = 0;
                            i = 1;
                            if (numbers[0] == numbers[1])
                            {
                                numbers[j] = r.Next(17, 98);
                                j = 0;
                                i = 1;
                                if (numbers[0] % 2 == 0 || numbers[1] % 2 == 0)
                                {
                                    numbers[j] = r.Next(17, 98);
                                    j = 0;
                                    i = 1;
                                }
                            }
                        }
                    }
                }
            }
            num1 = numbers[0];
            num2 = numbers[1];
            return new Tuple<int, int>(num1, num2);
        }

        public void KeyGenerate()
        {
            FileStream fs = new FileStream(KeyGenerateUrl, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Random r = new Random();
            int p = r.Next(17, 98);
            int q = r.Next(17, 98);
            var tuple = RandomPrime(p, q);
            p = tuple.Item1;
            q = tuple.Item2;
            n = p * q;
            int totient = (p - 1) * (q - 1);
            e = r.Next(2, totient);
            e = GcdControl(e, totient);
            d = InverseModulo(e, totient);
            sw.WriteLine("p=" + p);
            sw.WriteLine("q=" + q);
            sw.WriteLine("n=" + n);
            sw.WriteLine("totient=" + totient);
            sw.WriteLine("e=" + e);
            sw.WriteLine("d=" + d);
            sw.WriteLine("Public Keys:" + " n=" + n + " e=" + e);
            sw.WriteLine("Private Keys:" + " n=" + n + " d=" + d);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void btnKeyGenerator_Click(object sender, EventArgs e)
        {
            KeyGenerate();
            lblImageStatus.Text = "[Keys Was Generated]";
        }

        public int Encrypt(int m)
        {
            int temp = m;
            for (int i = 1; i < e; i++)
            {
                m *= temp;
                m %= n;
            }
            c = m;
            return c;
        }

        public int Decrypt(int c)
        {
            int des;
            int temp = c;
            for (int i = 1; i < d; i++)
            {
                c *= temp;
                c %= n;
            }
            des = c;
            return des;
        }

        private void btnEncryptImage_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(EncryptUrl, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            EncryptedArray = new int[IntArray.Length];
            for (int j = 0; j < ImageByteArray.Length; j++)
            {
                EncryptedArray[j] = Encrypt(IntArray[j]);
                sw.Write(EncryptedArray[j] + " ");
            }
            sw.Flush();
            sw.Close();
            fs.Close();
            for (int i = 0; i < ImageByteArray.Length; i++)
            {
                ImageByteArray[i] = (byte)EncryptedArray[i];
            }
            File.WriteAllBytes(EncryptedImageUrl, ImageByteArray);
            lblImageStatus.Text = "[Image Was Encrypted]";
        }

        private void btnDecryptImage_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(DecryptUrl, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            DecryptedArray = new int[EncryptedArray.Length];
            for (int j = 0; j < ImageByteArray.Length; j++)
            {
                DecryptedArray[j] = Decrypt(EncryptedArray[j]);
                sw.Write(DecryptedArray[j] + " ");
            }
            sw.Flush();
            sw.Close();
            fs.Close();
            for (int i = 0; i < ImageByteArray.Length; i++)
            {
                ImageByteArray[i] = (byte)DecryptedArray[i];
            }
            File.WriteAllBytes(DecryptedImageUrl, ImageByteArray);
            lblImageStatus.Text = "[Image Was Decrypted]";
        }

        private void pbExitWithoutDelete_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Unregister();
            MessageBoxManager.Yes = "Yes";
            MessageBoxManager.No = "No";
            MessageBoxManager.Register();
            DialogResult choose = MessageBox.Show("Are You Sure To Exit Without Delete Text And Image Files?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choose == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pbExitWithDelete_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Unregister();
            MessageBoxManager.Yes = "Yes";
            MessageBoxManager.No = "No";
            MessageBoxManager.Register();
            DialogResult choose = MessageBox.Show("Are You Sure To Exit With Delete Text And Image Files?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choose == DialogResult.Yes)
            {
                File.Delete(OriginalUrl);
                File.Delete(KeyGenerateUrl);
                File.Delete(EncryptUrl);
                File.Delete(DecryptUrl);
                File.Delete(DecryptedImageUrl);
                File.Delete(EncryptedImageUrl);
                File.Delete(OriginalImageUrl);
                Application.Exit();
            }
        }
    }
}
