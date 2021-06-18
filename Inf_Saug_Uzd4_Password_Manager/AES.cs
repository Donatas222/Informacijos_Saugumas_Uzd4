using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Inf_Saug_Uzd4_Password_Manager
{
    class AES
    {
        public string CipherCBC(string text)
        {
            byte[] src = Encoding.UTF8.GetBytes(text);
            byte[] key = Encoding.ASCII.GetBytes("0123456789abcdef");
            RijndaelManaged aes = new RijndaelManaged();
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.Zeros;
            aes.KeySize = 128;
            Startform.IV = aes.IV;

            using (ICryptoTransform encrypt = aes.CreateEncryptor(key, Startform.IV))
            {
                byte[] dest = encrypt.TransformFinalBlock(src, 0, src.Length);
                encrypt.Dispose();
                return Convert.ToBase64String(dest);
            }
        }

        public string DecipherCBC(string text)
        {
            byte[] src = Convert.FromBase64String(text);
            RijndaelManaged aes = new RijndaelManaged();
            byte[] key = Encoding.ASCII.GetBytes("0123456789abcdef");
            aes.KeySize = 128;
            aes.Padding = PaddingMode.Zeros;
            aes.Mode = CipherMode.CBC;
            using (ICryptoTransform decrypt = aes.CreateDecryptor(key, Startform.IV))
            {
                byte[] dest = decrypt.TransformFinalBlock(src, 0, src.Length);
                decrypt.Dispose();
                return Encoding.UTF8.GetString(dest);
            }
        }
    }
}
