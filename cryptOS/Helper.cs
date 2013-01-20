using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace cryptOS
{
    class Helper
    {
        public static string appPath = AppDomain.CurrentDomain.BaseDirectory;

        public static string readFromFile(string name)
        {
            string text = "";
            StreamReader sr = new StreamReader(name);
            text = sr.ReadToEnd();
            sr.Close();
            return text;
        }

        public static void writeToFile(string name, string text)
        {
            StreamWriter sw = new StreamWriter(name);
            sw.Write(text);
            sw.Close();
        }
        public static void appendToFile(string name, string text)
        {
            StreamWriter sw = new StreamWriter(name, true);
            sw.Write("\n" + text);
            sw.Close();
        }

        public static byte[] readBytes(string name)
        {
            return File.ReadAllBytes(name);
        }

        public static void writeBytes(string name, byte[] array)
        {
            File.WriteAllBytes(name, array);
        }


        public static Tuple<string, string, string> openFile()
        {

            string text = "";
            string fileName = "";
            string filePath = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files (.txt)|*.txt";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePath = dialog.FileName;
                int index = filePath.LastIndexOf('\\');
                fileName = filePath.Substring(index + 1);
                try
                {
                    text = File.ReadAllText(filePath);
                }
                catch (IOException)
                {
                    MessageBox.Show("Error while opening file!");
                }
                
            }
            return new Tuple<string, string, string>(text, fileName, filePath);   
        }


        public static string createHashFromFile(string filePath)
        {
            using (HashAlgorithm hashAlg = new SHA1Managed())   //sha1 hash
            {
                //otvaranje datoteke nad kojim se kreira hash
                using (Stream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    //računanje hasha
                    byte[] hash = hashAlg.ComputeHash(file);
                    // vraćanje vrijednosti hasha u obliku stringa
                    return BitConverter.ToString(hash);
                }
            }
        }
    }
}
