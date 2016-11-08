using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Cryptography.Client.KeyGenerators
{
    [Description("默认DES密钥和向量生成器")]
    public class DefaultDESKeyAndIVGenerator : IDESKeyAndIVGenerator
    {
        public string GenerateIV()
        {
            throw new NotImplementedException();
        }

        public string GenerateKey()
        {
            throw new NotImplementedException();
        }
    }
}
