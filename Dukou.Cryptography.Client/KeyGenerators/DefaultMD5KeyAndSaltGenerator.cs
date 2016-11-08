using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Cryptography.Client.KeyGenerators
{
    [Description("默认MD5密钥和盐生成器")]
    public class DefaultMD5KeyAndSaltGenerator : IMD5KeyAndSaltGenerator
    {
        private static readonly string DEFAULT = "default";

        public string GenerateKey()
        {
            return DEFAULT;
        }

        public string GenerateSalt()
        {
            return DEFAULT;
        }
    }
}
