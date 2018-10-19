namespace ISSHW
{
    partial class FormMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.btnKeyGenerator = new System.Windows.Forms.Button();
            this.btnConvertImageToByte = new System.Windows.Forms.Button();
            this.btnDecryptImage = new System.Windows.Forms.Button();
            this.btnEncryptImage = new System.Windows.Forms.Button();
            this.lblImageStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.fileOpen = new System.Windows.Forms.OpenFileDialog();
            this.pbExitWithoutDelete = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pbExitWithDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitWithoutDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitWithDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(163, 101);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.ReadOnly = true;
            this.txtImagePath.Size = new System.Drawing.Size(443, 22);
            this.txtImagePath.TabIndex = 53;
            this.txtImagePath.Text = "Image Path";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(612, 99);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(165, 27);
            this.btnUploadImage.TabIndex = 52;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // btnKeyGenerator
            // 
            this.btnKeyGenerator.Location = new System.Drawing.Point(294, 463);
            this.btnKeyGenerator.Name = "btnKeyGenerator";
            this.btnKeyGenerator.Size = new System.Drawing.Size(165, 27);
            this.btnKeyGenerator.TabIndex = 51;
            this.btnKeyGenerator.Text = "Key Generator";
            this.btnKeyGenerator.UseVisualStyleBackColor = true;
            this.btnKeyGenerator.Click += new System.EventHandler(this.btnKeyGenerator_Click);
            // 
            // btnConvertImageToByte
            // 
            this.btnConvertImageToByte.Location = new System.Drawing.Point(122, 463);
            this.btnConvertImageToByte.Name = "btnConvertImageToByte";
            this.btnConvertImageToByte.Size = new System.Drawing.Size(165, 27);
            this.btnConvertImageToByte.TabIndex = 50;
            this.btnConvertImageToByte.Text = "Convert Image To Byte";
            this.btnConvertImageToByte.UseVisualStyleBackColor = true;
            this.btnConvertImageToByte.Click += new System.EventHandler(this.btnConvertImageToByte_Click);
            // 
            // btnDecryptImage
            // 
            this.btnDecryptImage.Location = new System.Drawing.Point(636, 463);
            this.btnDecryptImage.Name = "btnDecryptImage";
            this.btnDecryptImage.Size = new System.Drawing.Size(165, 27);
            this.btnDecryptImage.TabIndex = 45;
            this.btnDecryptImage.Text = "Decrypt Image";
            this.btnDecryptImage.UseVisualStyleBackColor = true;
            this.btnDecryptImage.Click += new System.EventHandler(this.btnDecryptImage_Click);
            // 
            // btnEncryptImage
            // 
            this.btnEncryptImage.Location = new System.Drawing.Point(465, 463);
            this.btnEncryptImage.Name = "btnEncryptImage";
            this.btnEncryptImage.Size = new System.Drawing.Size(165, 27);
            this.btnEncryptImage.TabIndex = 44;
            this.btnEncryptImage.Text = "Encrypt Image";
            this.btnEncryptImage.UseVisualStyleBackColor = true;
            this.btnEncryptImage.Click += new System.EventHandler(this.btnEncryptImage_Click);
            // 
            // lblImageStatus
            // 
            this.lblImageStatus.AutoSize = true;
            this.lblImageStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblImageStatus.Location = new System.Drawing.Point(4, 6);
            this.lblImageStatus.Name = "lblImageStatus";
            this.lblImageStatus.Size = new System.Drawing.Size(153, 25);
            this.lblImageStatus.TabIndex = 47;
            this.lblImageStatus.Text = "[Image Status]";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(172, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(586, 25);
            this.lblTitle.TabIndex = 46;
            this.lblTitle.Text = "RSA IMAGE ENCRYPTION AND DECRYPTION PROGRAM";
            // 
            // fileOpen
            // 
            this.fileOpen.FileName = "fileOpen";
            // 
            // pbExitWithoutDelete
            // 
            this.pbExitWithoutDelete.Image = global::ISSHW.Properties.Resources.ExitWithoutDelete;
            this.pbExitWithoutDelete.Location = new System.Drawing.Point(857, 6);
            this.pbExitWithoutDelete.Name = "pbExitWithoutDelete";
            this.pbExitWithoutDelete.Size = new System.Drawing.Size(35, 38);
            this.pbExitWithoutDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExitWithoutDelete.TabIndex = 54;
            this.pbExitWithoutDelete.TabStop = false;
            this.pbExitWithoutDelete.Click += new System.EventHandler(this.pbExitWithoutDelete_Click);
            // 
            // pbImage
            // 
            this.pbImage.Image = global::ISSHW.Properties.Resources.Warning;
            this.pbImage.Location = new System.Drawing.Point(306, 145);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(300, 300);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 49;
            this.pbImage.TabStop = false;
            // 
            // pbExitWithDelete
            // 
            this.pbExitWithDelete.Image = global::ISSHW.Properties.Resources.ExitWithDelete;
            this.pbExitWithDelete.Location = new System.Drawing.Point(898, 6);
            this.pbExitWithDelete.Name = "pbExitWithDelete";
            this.pbExitWithDelete.Size = new System.Drawing.Size(35, 38);
            this.pbExitWithDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExitWithDelete.TabIndex = 48;
            this.pbExitWithDelete.TabStop = false;
            this.pbExitWithDelete.Click += new System.EventHandler(this.pbExitWithDelete_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(937, 496);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.btnKeyGenerator);
            this.Controls.Add(this.btnConvertImageToByte);
            this.Controls.Add(this.btnDecryptImage);
            this.Controls.Add(this.btnEncryptImage);
            this.Controls.Add(this.lblImageStatus);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbExitWithoutDelete);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.pbExitWithDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbExitWithoutDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitWithDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Button btnKeyGenerator;
        private System.Windows.Forms.Button btnConvertImageToByte;
        private System.Windows.Forms.Button btnDecryptImage;
        private System.Windows.Forms.Button btnEncryptImage;
        private System.Windows.Forms.Label lblImageStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.OpenFileDialog fileOpen;
        private System.Windows.Forms.PictureBox pbExitWithoutDelete;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.PictureBox pbExitWithDelete;
    }
}

