using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Cryptography.Client.KeyGenerators
{
    [Description("默认DESede密钥生成器")]
    public class DefaultDESedeKeyAndIVGenerator : IDESedeKeyAndIVGenerator
    {
        private static readonly string KEY = "ovsEneD+v2iM06tbrcd/dYMlHw3aBy8p";

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
