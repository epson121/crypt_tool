using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace cryptOS
{
    class RSA
    {
        public static RSACryptoServiceProvider rsaCrypto;
        public RSA()
        {
            rsaCrypto = new RSACryptoServiceProvider();
        }

        public byte[] encrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider. 
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    //Import the RSA Key information. This only needs 
                    //toinclude the public key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Encrypt the passed byte array and specify OAEP padding.   
                    //OAEP padding is only available on Microsoft Windows XP or 
                    //later.  
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }

                return encryptedData;
            }
            //Catch and display a CryptographicException   
            //to the console. 
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }

        }

        public byte[] decrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider. 
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //Import the RSA Key information. This needs 
                    //to include the private key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Decrypt the passed byte array and specify OAEP padding.   
                    //OAEP padding is only available on Microsoft Windows XP or 
                    //later.  
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }
            //Catch and display a CryptographicException   
            //to the console. 
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }

        }

        public static void generateRSAKeys()
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            string publicKeyRSA = RSA.ToXmlString(false);
            string privateKeyRSA = RSA.ToXmlString(true);
            Helper.writeToFile(Helper.appPath + "\\javni_kljuc.txt", publicKeyRSA);
            Helper.writeToFile(Helper.appPath + "\\privatni_kljuc.txt", privateKeyRSA);
        }

    }
}
