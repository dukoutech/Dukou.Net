using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Cryptography.Test
{
    public class TestMD5KeyAndSaltGenerator : IMD5KeyAndSaltGenerator
    {
        public string GenerateKey()
        {
            return "www.dukou.tech";
        }

        public string GenerateSalt()
        {
            return "123456";
        }
    }
}
