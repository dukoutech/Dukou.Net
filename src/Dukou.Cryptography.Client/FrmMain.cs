using Dukou.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dukou.Cryptography.Client
{
    public partial class FrmMain : Form
    {
        private Dictionary<string, Type> DESedeKeyAndIVGenerators = new Dictionary<string, Type>();
        private Dictionary<string, Type> DESKeyAndIVGenerators = new Dictionary<string, Type>();
        private Dictionary<string, Type> MD5KeyAndSaltGenerators = new Dictionary<string, Type>();

        private Type IDESedeKeyAndIVGeneratorType = typeof(IDESedeKeyAndIVGenerator);
        private Type IDESKeyAndIVGeneratorType = typeof(IDESKeyAndIVGenerator);
        private Type IMD5KeyAndSaltGeneratorType = typeof(IMD5KeyAndSaltGenerator);

        private string key1 = string.Empty;
        private string key2 = string.Empty;

        public FrmMain()
        {
            InitializeComponent();

            InitKeys();

            this.cmbAlgorithm.Items.Add("DES");
            this.cmbAlgorithm.Items.Add("MD5");
            this.cmbAlgorithm.Items.Add("TripleDES/DESede");
            this.cmbAlgorithm.SelectedIndex = 2;

            this.cmbCipherMode.Items.Add("CBC");
            this.cmbCipherMode.Items.Add("CFB");
            this.cmbCipherMode.Items.Add("CTS");
            this.cmbCipherMode.Items.Add("ECB");
            this.cmbCipherMode.Items.Add("OFB");
            this.cmbCipherMode.SelectedIndex = 0;

            this.cmbPaddingMode.Items.Add("ANSIX923");
            this.cmbPaddingMode.Items.Add("ISO10126");
            this.cmbPaddingMode.Items.Add("None");
            this.cmbPaddingMode.Items.Add("PKCS7");
            this.cmbPaddingMode.Items.Add("Zeros");
            this.cmbPaddingMode.SelectedIndex = 3;

            this.cmbStringFormatType.Items.Add("BASE64");
            this.cmbStringFormatType.Items.Add("HEX");
            this.cmbStringFormatType.Items.Add("None");
            this.cmbStringFormatType.SelectedIndex = 0;
        }

        private void InitKey(Type type)
        {
            if (IDESedeKeyAndIVGeneratorType.IsAssignableFrom(type))
            {
                var attr = type.GetCustomAttribute<DescriptionAttribute>();
                if (attr != null)
                {
                    DESedeKeyAndIVGenerators.Add(attr.Description, type);
                }
            }
            else if (IDESKeyAndIVGeneratorType.IsAssignableFrom(type))
            {
                var attr = type.GetCustomAttribute<DescriptionAttribute>();
                if (attr != null)
                {
                    DESKeyAndIVGenerators.Add(attr.Description, type);
                }
            }
            else if (IMD5KeyAndSaltGeneratorType.IsAssignableFrom(type))
            {
                var attr = type.GetCustomAttribute<DescriptionAttribute>();
                if (attr != null)
                {
                    MD5KeyAndSaltGenerators.Add(attr.Description, type);
                }
            }
        }

        private void InitKeys()
        {
            foreach (var item in Assembly.GetEntryAssembly().GetTypes())
            {
                InitKey(item);
            }

            var files = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "KeyGenerators")).Where(x => x.EndsWith(".dll", StringComparison.CurrentCultureIgnoreCase));
            foreach (var file in files)
            {
                foreach (var item in Assembly.LoadFile(file).GetTypes())
                {
                    InitKey(item);
                }
            }
        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            byte[] result = null;
            try
            {
                CipherMode cipherMode = (CipherMode)Enum.Parse(typeof(CipherMode), this.cmbCipherMode.Text);
                PaddingMode paddingMode = (PaddingMode)Enum.Parse(typeof(PaddingMode), this.cmbPaddingMode.Text);

                if (this.cmbAlgorithm.Text == "DES")
                {
                    result = this.txtSource.Text.DESEncrypt(key1, key2, cipherMode, paddingMode);
                }
                else if (this.cmbAlgorithm.Text == "TripleDES/DESede")
                {
                    result = this.txtSource.Text.DESedeEncrypt(key1, key2, cipherMode, paddingMode);
                }
                else if (this.cmbAlgorithm.Text == "MD5")
                {
                    this.txtCipherText.Text = this.txtSource.Text.MD5Encrypt(key1, key2);
                }

                if (result != null)
                {
                    StringFormatTypes stringType = (StringFormatTypes)Enum.Parse(typeof(StringFormatTypes), this.cmbStringFormatType.Text);
                    if (stringType == StringFormatTypes.HEX)
                    {
                        this.txtCipherText.Text = result.ToString(StringFormatTypes.HEX);
                    }
                    else if (stringType == StringFormatTypes.BASE64)
                    {
                        this.txtCipherText.Text = result.ToString(StringFormatTypes.BASE64);
                    }
                    else
                    {
                        this.txtCipherText.Text = result.ToString(StringFormatTypes.None);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDe_Click(object sender, EventArgs e)
        {
            byte[] result = null;
            try
            {
                StringFormatTypes stringType = (StringFormatTypes)Enum.Parse(typeof(StringFormatTypes), this.cmbStringFormatType.Text);
                CipherMode cipherMode = (CipherMode)Enum.Parse(typeof(CipherMode), this.cmbCipherMode.Text);
                PaddingMode paddingMode = (PaddingMode)Enum.Parse(typeof(PaddingMode), this.cmbPaddingMode.Text);

                if (this.cmbAlgorithm.Text == "DES")
                {
                    result = this.txtCipherText.Text.DESDecrypt(key1, key2, stringType, cipherMode, paddingMode);
                }
                else if (this.cmbAlgorithm.Text == "TripleDES/DESede")
                {
                    result = this.txtCipherText.Text.DESedeDecrypt(key1, key2, stringType, cipherMode, paddingMode);
                }

                if (result != null)
                {
                    this.txtSource.Text = result.ToString(StringFormatTypes.None);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            var keys = new List<string>();
            if (cmbAlgorithm.Text == "DES")
            {
                keys = DESKeyAndIVGenerators.Select(x => x.Key).ToList();
            }
            else if (cmbAlgorithm.Text == "MD5")
            {
                keys = MD5KeyAndSaltGenerators.Select(x => x.Key).ToList();
            }
            else if (cmbAlgorithm.Text == "TripleDES/DESede")
            {
                keys = DESedeKeyAndIVGenerators.Select(x => x.Key).ToList();
            }

            cmbKeys.Items.Clear();
            if (keys.Count > 0)
            {
                foreach (var item in keys)
                {
                    cmbKeys.Items.Add(item);
                }
                cmbKeys.SelectedIndex = 0;
            }
            object obj = null;
            if (cmbAlgorithm.Text == "DES")
            {
                obj = Activator.CreateInstance(DESKeyAndIVGenerators[cmbKeys.Text]);
                key1 = DESKeyAndIVGenerators[cmbKeys.Text].GetMethod("GenerateKey").Invoke(obj, null) as string;
                key2 = DESKeyAndIVGenerators[cmbKeys.Text].GetMethod("GenerateIV").Invoke(obj, null) as string;
            }
            else if (cmbAlgorithm.Text == "MD5")
            {
                obj = Activator.CreateInstance(MD5KeyAndSaltGenerators[cmbKeys.Text]);
                key1 = MD5KeyAndSaltGenerators[cmbKeys.Text].GetMethod("GenerateKey").Invoke(obj, null) as string;
                key2 = MD5KeyAndSaltGenerators[cmbKeys.Text].GetMethod("GenerateSalt").Invoke(obj, null) as string;
            }
            else if (cmbAlgorithm.Text == "TripleDES/DESede")
            {
                obj = Activator.CreateInstance(DESedeKeyAndIVGenerators[cmbKeys.Text]);
                key1 = DESedeKeyAndIVGenerators[cmbKeys.Text].GetMethod("GenerateKey").Invoke(obj, null) as string;
                key2 = DESedeKeyAndIVGenerators[cmbKeys.Text].GetMethod("GenerateIV").Invoke(obj, null) as string;
            }
            obj = null;
        }
    }
}
