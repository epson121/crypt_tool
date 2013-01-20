namespace cryptOS
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtSha1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.cmbEncryptionType = new System.Windows.Forms.ComboBox();
            this.btnRSAGenerateKeys = new System.Windows.Forms.Button();
            this.btnGenerateAESKey = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.createDigitalSignature = new System.Windows.Forms.Button();
            this.btnCheckDigitalSignature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(471, 12);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(49, 12);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(406, 20);
            this.txtFile.TabIndex = 1;
            // 
            // txtSha1
            // 
            this.txtSha1.Location = new System.Drawing.Point(49, 38);
            this.txtSha1.Name = "txtSha1";
            this.txtSha1.Size = new System.Drawing.Size(406, 20);
            this.txtSha1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SHA-1:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(155, 64);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // cmbEncryptionType
            // 
            this.cmbEncryptionType.FormattingEnabled = true;
            this.cmbEncryptionType.Items.AddRange(new object[] {
            "AES",
            "RSA"});
            this.cmbEncryptionType.Location = new System.Drawing.Point(49, 66);
            this.cmbEncryptionType.Name = "cmbEncryptionType";
            this.cmbEncryptionType.Size = new System.Drawing.Size(79, 21);
            this.cmbEncryptionType.TabIndex = 6;
            // 
            // btnRSAGenerateKeys
            // 
            this.btnRSAGenerateKeys.Location = new System.Drawing.Point(20, 318);
            this.btnRSAGenerateKeys.Name = "btnRSAGenerateKeys";
            this.btnRSAGenerateKeys.Size = new System.Drawing.Size(97, 38);
            this.btnRSAGenerateKeys.TabIndex = 7;
            this.btnRSAGenerateKeys.Text = "Generate RSA keys";
            this.btnRSAGenerateKeys.UseVisualStyleBackColor = true;
            this.btnRSAGenerateKeys.Click += new System.EventHandler(this.btnRSAGenerateKeys_Click);
            // 
            // btnGenerateAESKey
            // 
            this.btnGenerateAESKey.Location = new System.Drawing.Point(123, 318);
            this.btnGenerateAESKey.Name = "btnGenerateAESKey";
            this.btnGenerateAESKey.Size = new System.Drawing.Size(97, 38);
            this.btnGenerateAESKey.TabIndex = 8;
            this.btnGenerateAESKey.Text = "Generate AES key";
            this.btnGenerateAESKey.UseVisualStyleBackColor = true;
            this.btnGenerateAESKey.Click += new System.EventHandler(this.btnGenerateAESKey_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(252, 64);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 98);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtText.Size = new System.Drawing.Size(525, 214);
            this.txtText.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "File:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(462, 326);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // createDigitalSignature
            // 
            this.createDigitalSignature.Location = new System.Drawing.Point(230, 318);
            this.createDigitalSignature.Name = "createDigitalSignature";
            this.createDigitalSignature.Size = new System.Drawing.Size(97, 38);
            this.createDigitalSignature.TabIndex = 13;
            this.createDigitalSignature.Text = "Create digital signature";
            this.createDigitalSignature.UseVisualStyleBackColor = true;
            this.createDigitalSignature.Click += new System.EventHandler(this.createDigitalSignature_Click);
            // 
            // btnCheckDigitalSignature
            // 
            this.btnCheckDigitalSignature.Location = new System.Drawing.Point(333, 318);
            this.btnCheckDigitalSignature.Name = "btnCheckDigitalSignature";
            this.btnCheckDigitalSignature.Size = new System.Drawing.Size(97, 38);
            this.btnCheckDigitalSignature.TabIndex = 14;
            this.btnCheckDigitalSignature.Text = "Check digital signature";
            this.btnCheckDigitalSignature.UseVisualStyleBackColor = true;
            this.btnCheckDigitalSignature.Click += new System.EventHandler(this.btnCheckDigitalSignature_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 359);
            this.Controls.Add(this.btnCheckDigitalSignature);
            this.Controls.Add(this.createDigitalSignature);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnGenerateAESKey);
            this.Controls.Add(this.btnRSAGenerateKeys);
            this.Controls.Add(this.cmbEncryptionType);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSha1);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnLoadFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "cryptOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtSha1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.ComboBox cmbEncryptionType;
        private System.Windows.Forms.Button btnRSAGenerateKeys;
        private System.Windows.Forms.Button btnGenerateAESKey;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button createDigitalSignature;
        private System.Windows.Forms.Button btnCheckDigitalSignature;
    }
}

