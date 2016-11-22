using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Dukou.Cryptography.Test
{
    [TestClass]
    public class MD5ExtensionTest
    {
        private IMD5KeyAndSaltGenerator keyAndSaltGenerator = new TestMD5KeyAndSaltGenerator();

        [TestMethod]
        public void TestMD5Encrypt()
        {
            var a = "123".MD5Encrypt(keyAndSaltGenerator.GenerateKey());
            var b = ToMD5("123", keyAndSaltGenerator.GenerateKey());
            Assert.AreEqual(a, b);

            a = "123555".MD5Encrypt(keyAndSaltGenerator.GenerateKey());
            b = ToMD5("123555", keyAndSaltGenerator.GenerateKey());
            Assert.AreEqual(a, b);

            a = "www.dukou.tech".MD5Encrypt(keyAndSaltGenerator.GenerateKey());
            b = ToMD5("www.dukou.tech", keyAndSaltGenerator.GenerateKey());
            Assert.AreEqual(a, b);

            a = "www.dukou.tech".MD5Encrypt(keyAndSaltGenerator.GenerateKey());
            b = ToMD5("www.dukou1.tech", keyAndSaltGenerator.GenerateKey());
            Assert.AreNotEqual(a, b);

            a = "www.dukou.tech".MD5Encrypt(keyAndSaltGenerator.GenerateKey(), keyAndSaltGenerator.GenerateSalt());
            b = ToMD5("www.dukou.tech", keyAndSaltGenerator.GenerateKey(), keyAndSaltGenerator.GenerateSalt());
            Assert.AreEqual(a, b);
        }

        private string ToMD5(string source, string key, string salt = null)
        {
            var md5 = new MD5CryptoServiceProvider();
            byte[] bytes = Encoding.UTF8.GetBytes($"{source}&key={key}{(string.IsNullOrEmpty(salt) ? string.Empty : $"&salt={salt}")}");
            bytes = md5.ComputeHash(bytes);
            md5.Clear();

            string ret = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                ret += Convert.ToString(bytes[i], 16).PadLeft(2, '0');
            }

            return ret.PadLeft(32, '0').ToUpper();
        }
    }
}
