using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace cryptOS
{
    public partial class mainForm : Form
    {
        UTF8Encoding encoding;
        AES aes;
        RSA rsa;
        string openedFile;
        public mainForm()
        {
            aes = new AES();
            rsa = new RSA();
            encoding = new UTF8Encoding();
            
            InitializeComponent();
            cmbEncryptionType.SelectedIndex = 0;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            string hash = "";
            Tuple<string, string, string> fileInfo = Helper.openFile();
            if (fileInfo.Item1 != "" || fileInfo.Item2 != "" || fileInfo.Item3 != "")
            {
                hash = Helper.createHashFromFile(fileInfo.Item3);
            }
            openedFile = fileInfo.Item3;
            txtFile.Text = fileInfo.Item3;
            txtSha1.Text = hash;
            txtText.Text = fileInfo.Item1;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string text = Helper.readFromFile(openedFile);
            byte[] byteText = Helper.readBytes(openedFile);
            byte[] encryptedText;
            if ((string) cmbEncryptionType.SelectedItem == "RSA")
            {
                try
                {
                    RSA.rsaCrypto.FromXmlString(Helper.readFromFile(Helper.appPath + "\\privatni_kljuc.txt"));
                    encryptedText = rsa.encrypt(byteText, RSA.rsaCrypto.ExportParameters(false), false);
                    Helper.writeToFile(openedFile, Convert.ToBase64String(encryptedText));
                    txtText.Text = Convert.ToBase64String(encryptedText);
                    createDigitalSignature.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Invalid text format!");
                }
            }
            else if ((string) cmbEncryptionType.SelectedItem == "AES")
            {
                AES.aesCrypto.Key = Convert.FromBase64String(Helper.readFromFile(Helper.appPath + "\\tajni_kljuc.txt"));
                encryptedText = aes.encrypt(text, AES.getKey(), AES.aesCrypto.IV);
                Helper.writeToFile(openedFile, Convert.ToBase64String(encryptedText));
                txtText.Text = Convert.ToBase64String(encryptedText);
            }
        }

        private void btnRSAGenerateKeys_Click(object sender, EventArgs e)
        {
            RSA.generateRSAKeys();
        }

        private void btnGenerateAESKey_Click(object sender, EventArgs e)
        {
            AES.generateAESKey();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedText = Helper.readFromFile(openedFile);
            byte[] encryptedByteText = Helper.readBytes(openedFile);
            byte[] decryptedText;
            string decryptedString;
            if ((string) cmbEncryptionType.SelectedItem == "RSA")
            {
                try
                {
                    RSA.rsaCrypto.FromXmlString(Helper.readFromFile(Helper.appPath + "\\privatni_kljuc.txt"));
                    decryptedText = rsa.decrypt(Convert.FromBase64String(encryptedText), RSA.rsaCrypto.ExportParameters(true), false);
                    Helper.writeToFile(openedFile, encoding.GetString(decryptedText));
                    txtText.Text = encoding.GetString(decryptedText);
                }
                catch
                {
                    MessageBox.Show("Invalid base64 length, or wrong file.");
                }

            }
            else if ((string) cmbEncryptionType.SelectedItem == "AES")
            {
                try
                {
                    AES.aesCrypto.Key = Convert.FromBase64String(Helper.readFromFile(Helper.appPath + "\\tajni_kljuc.txt"));
                    decryptedString = aes.decrypt(Convert.FromBase64String(encryptedText), AES.aesCrypto.Key, AES.aesCrypto.IV);
                    Helper.writeToFile(openedFile, decryptedString);
                    txtText.Text = decryptedString;
                }
                catch
                {
                    MessageBox.Show("Wrong file length or invalid key!");
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createDigitalSignature_Click(object sender, EventArgs e)
        {
            string hashValue = txtSha1.Text;
            byte[] byteHash = encoding.GetBytes(hashValue);
            byte[] encryptedHash;
            if ((string) cmbEncryptionType.SelectedItem == "RSA")
            {
                RSA.rsaCrypto.FromXmlString(Helper.readFromFile(Helper.appPath + "\\javni_kljuc.txt"));
                encryptedHash = rsa.encrypt(byteHash, RSA.rsaCrypto.ExportParameters(false), false);
                Helper.appendToFile(openedFile, Convert.ToBase64String(encryptedHash));
                txtText.Text = Helper.readFromFile(openedFile);
            }
            else if ((string) cmbEncryptionType.SelectedItem == "AES")
            {
                MessageBox.Show("Unable to create digital signature with AES encryption!.");
            }
        }

        private void btnCheckDigitalSignature_Click(object sender, EventArgs e)
        { 
            string hash = "";
            var lines = System.IO.File.ReadAllLines(openedFile).ToList();
            string lastLine = System.IO.File.ReadLines(openedFile).Last();
            System.IO.File.WriteAllLines("help.txt", lines.GetRange(0, lines.Count - 1));
            String digitalSignatureFile = Helper.readFromFile(Helper.appPath + "help.txt");
            System.IO.File.WriteAllText("help.txt", digitalSignatureFile.TrimEnd('\r', '\n'));
            if (digitalSignatureFile != "")
            {
                hash = Helper.createHashFromFile(Helper.appPath + "\\help.txt");
            }
            RSA.rsaCrypto.FromXmlString(Helper.readFromFile(Helper.appPath + "\\privatni_kljuc.txt"));
            byte[] decryptedText = rsa.decrypt(Convert.FromBase64String(lastLine), RSA.rsaCrypto.ExportParameters(true), false);
            txtText.Text = encoding.GetString(decryptedText);
            if (hash == encoding.GetString(decryptedText))
                MessageBox.Show("Document is digitally signed. No errors found.");
            else
                MessageBox.Show("Document is corrupted. Digital signature check failed.");
        }

     

       
    }
}
