using Dukou.Cryptography;
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
        private IKeyGenerator keyGenerator;

        public PropertyPlaceholderConfigurer(IKeyGenerator keyGenerator)
        {
            this.keyGenerator = keyGenerator;
        }

        protected override string ResolvePlaceholder(string placeholder, NameValueCollection props)
        {
            string value = props.Get(placeholder);

            if (value.StartsWith("encrypt:{") && value.EndsWith("}"))
            {
                value = value.Substring(9, value.Length - 10);

                value = value.DESedeDecrypt(keyGenerator.Generate()).ToString(StringFormatType.None);

                props.Set(placeholder, value);
            }

            return base.ResolvePlaceholder(placeholder, props);
        }
    }
}
