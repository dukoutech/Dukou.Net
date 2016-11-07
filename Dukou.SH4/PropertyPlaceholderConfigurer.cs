using Dukou.Cryptography;
using Dukou.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.SH4
{
    public class PropertyPlaceholderConfigurer : Spring.Objects.Factory.Config.PropertyPlaceholderConfigurer
    {
        private IDESedeKeyAndIVGenerator keyAndIVGenerator;

        public PropertyPlaceholderConfigurer(IDESedeKeyAndIVGenerator keyGenerator)
        {
            this.keyAndIVGenerator = keyGenerator;
        }

        protected override string ResolvePlaceholder(string placeholder, NameValueCollection props)
        {
            string value = props.Get(placeholder);

            if (value.StartsWith("encrypt:{") && value.EndsWith("}"))
            {
                value = value.Substring(9, value.Length - 10);

                value = value.DESedeDecrypt(keyAndIVGenerator.GenerateKey(), keyAndIVGenerator.GenerateIV()).ToString(StringFormatTypes.None);

                props.Set(placeholder, value);
            }

            return base.ResolvePlaceholder(placeholder, props);
        }
    }
}
