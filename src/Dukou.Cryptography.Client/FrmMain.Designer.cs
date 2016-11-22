namespace Dukou.Cryptography.Client
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDe = new System.Windows.Forms.Button();
            this.btnEn = new System.Windows.Forms.Button();
            this.cmbKeys = new System.Windows.Forms.ComboBox();
            this.cmbStringFormatType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStringFormatType = new System.Windows.Forms.Label();
            this.lblAlgorithm = new System.Windows.Forms.Label();
            this.cmbAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblCipherMode = new System.Windows.Forms.Label();
            this.lblPaddingMode = new System.Windows.Forms.Label();
            this.cmbCipherMode = new System.Windows.Forms.ComboBox();
            this.cmbPaddingMode = new System.Windows.Forms.ComboBox();
            this.lblKeys = new System.Windows.Forms.Label();
            this.lblCipher = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtCipherText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDe
            // 
            this.btnDe.Location = new System.Drawing.Point(615, 93);
            this.btnDe.Name = "btnDe";
            this.btnDe.Size = new System.Drawing.Size(75, 23);
            this.btnDe.TabIndex = 11;
            this.btnDe.Text = "解密";
            this.btnDe.UseVisualStyleBackColor = true;
            this.btnDe.Click += new System.EventHandler(this.btnDe_Click);
            // 
            // btnEn
            // 
            this.btnEn.Location = new System.Drawing.Point(615, 63);
            this.btnEn.Name = "btnEn";
            this.btnEn.Size = new System.Drawing.Size(75, 23);
            this.btnEn.TabIndex = 10;
            this.btnEn.Text = "加密";
            this.btnEn.UseVisualStyleBackColor = true;
            this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
            // 
            // cmbKeys
            // 
            this.cmbKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cmbKeys, 3);
            this.cmbKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKeys.FormattingEnabled = true;
            this.cmbKeys.Location = new System.Drawing.Point(93, 35);
            this.cmbKeys.Name = "cmbKeys";
            this.cmbKeys.Size = new System.Drawing.Size(426, 20);
            this.cmbKeys.TabIndex = 14;
            // 
            // cmbStringFormatType
            // 
            this.cmbStringFormatType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStringFormatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStringFormatType.FormattingEnabled = true;
            this.cmbStringFormatType.Location = new System.Drawing.Point(615, 35);
            this.cmbStringFormatType.Name = "cmbStringFormatType";
            this.cmbStringFormatType.Size = new System.Drawing.Size(166, 20);
            this.cmbStringFormatType.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnDe, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAlgorithm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEn, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbAlgorithm, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCipherMode, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSource, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCipherText, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPaddingMode, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbCipherMode, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbPaddingMode, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbKeys, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblKeys, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSource, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCipher, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbStringFormatType, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStringFormatType, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 135);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // lblStringFormatType
            // 
            this.lblStringFormatType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStringFormatType.AutoSize = true;
            this.lblStringFormatType.Location = new System.Drawing.Point(525, 39);
            this.lblStringFormatType.Name = "lblStringFormatType";
            this.lblStringFormatType.Size = new System.Drawing.Size(84, 12);
            this.lblStringFormatType.TabIndex = 12;
            this.lblStringFormatType.Text = "字符串类型：";
            this.lblStringFormatType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAlgorithm
            // 
            this.lblAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlgorithm.AutoSize = true;
            this.lblAlgorithm.Location = new System.Drawing.Point(3, 9);
            this.lblAlgorithm.Name = "lblAlgorithm";
            this.lblAlgorithm.Size = new System.Drawing.Size(84, 12);
            this.lblAlgorithm.TabIndex = 2;
            this.lblAlgorithm.Text = "算法：";
            this.lblAlgorithm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbAlgorithm
            // 
            this.cmbAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgorithm.FormattingEnabled = true;
            this.cmbAlgorithm.Location = new System.Drawing.Point(93, 5);
            this.cmbAlgorithm.Name = "cmbAlgorithm";
            this.cmbAlgorithm.Size = new System.Drawing.Size(165, 20);
            this.cmbAlgorithm.TabIndex = 5;
            this.cmbAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cmbAlgorithm_SelectedIndexChanged);
            // 
            // lblSource
            // 
            this.lblSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(3, 69);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(84, 12);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "明文：";
            this.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCipherMode
            // 
            this.lblCipherMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCipherMode.AutoSize = true;
            this.lblCipherMode.Location = new System.Drawing.Point(264, 9);
            this.lblCipherMode.Name = "lblCipherMode";
            this.lblCipherMode.Size = new System.Drawing.Size(84, 12);
            this.lblCipherMode.TabIndex = 3;
            this.lblCipherMode.Text = "密码模式：";
            this.lblCipherMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPaddingMode
            // 
            this.lblPaddingMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaddingMode.AutoSize = true;
            this.lblPaddingMode.Location = new System.Drawing.Point(525, 9);
            this.lblPaddingMode.Name = "lblPaddingMode";
            this.lblPaddingMode.Size = new System.Drawing.Size(84, 12);
            this.lblPaddingMode.TabIndex = 4;
            this.lblPaddingMode.Text = "填充模式：";
            this.lblPaddingMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCipherMode
            // 
            this.cmbCipherMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCipherMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCipherMode.FormattingEnabled = true;
            this.cmbCipherMode.Location = new System.Drawing.Point(354, 5);
            this.cmbCipherMode.Name = "cmbCipherMode";
            this.cmbCipherMode.Size = new System.Drawing.Size(165, 20);
            this.cmbCipherMode.TabIndex = 6;
            // 
            // cmbPaddingMode
            // 
            this.cmbPaddingMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPaddingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaddingMode.FormattingEnabled = true;
            this.cmbPaddingMode.Location = new System.Drawing.Point(615, 5);
            this.cmbPaddingMode.Name = "cmbPaddingMode";
            this.cmbPaddingMode.Size = new System.Drawing.Size(166, 20);
            this.cmbPaddingMode.TabIndex = 7;
            // 
            // lblKeys
            // 
            this.lblKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKeys.AutoSize = true;
            this.lblKeys.Location = new System.Drawing.Point(3, 39);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(84, 12);
            this.lblKeys.TabIndex = 1;
            this.lblKeys.Text = "密钥生成器：";
            this.lblKeys.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCipher
            // 
            this.lblCipher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCipher.AutoSize = true;
            this.lblCipher.Location = new System.Drawing.Point(3, 99);
            this.lblCipher.Name = "lblCipher";
            this.lblCipher.Size = new System.Drawing.Size(84, 12);
            this.lblCipher.TabIndex = 8;
            this.lblCipher.Text = "密文：";
            this.lblCipher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtSource, 4);
            this.txtSource.Location = new System.Drawing.Point(93, 64);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(516, 21);
            this.txtSource.TabIndex = 9;
            // 
            // txtCipherText
            // 
            this.txtCipherText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtCipherText, 4);
            this.txtCipherText.Location = new System.Drawing.Point(93, 94);
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.Size = new System.Drawing.Size(516, 21);
            this.txtCipherText.TabIndex = 11;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 141);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "DUKOU加密解密";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDe;
        private System.Windows.Forms.Button btnEn;
        private System.Windows.Forms.ComboBox cmbKeys;
        private System.Windows.Forms.ComboBox cmbStringFormatType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblStringFormatType;
        private System.Windows.Forms.Label lblAlgorithm;
        private System.Windows.Forms.ComboBox cmbAlgorithm;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblCipherMode;
        private System.Windows.Forms.Label lblPaddingMode;
        private System.Windows.Forms.ComboBox cmbCipherMode;
        private System.Windows.Forms.ComboBox cmbPaddingMode;
        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.Label lblCipher;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtCipherText;
    }
}

