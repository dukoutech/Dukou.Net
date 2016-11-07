using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Cryptography
{
    public interface IDESKeyAndIVGenerator
    {
        string GenerateKey();

        string GenerateIV();
    }
}
