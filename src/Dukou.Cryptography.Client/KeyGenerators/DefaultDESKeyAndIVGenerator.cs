using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Cryptography.Client.KeyGenerators
{
    [Description("默认DES密钥生成器")]
    public class DefaultDESKeyAndIVGenerator : IDESKeyAndIVGenerator
    {
        private static readonly string KEY = "DUKOU123";

        public string GenerateIV()
        {
            return KEY;
        }

        public string GenerateKey()
        {
            return KEY;
        }
    }
}
