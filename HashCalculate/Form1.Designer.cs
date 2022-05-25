
namespace HashCalculate
{
    partial class Form1
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
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.data = new System.Windows.Forms.TextBox();
            this.btnOpenfile = new System.Windows.Forms.Button();
            this.tbMD5 = new System.Windows.Forms.TextBox();
            this.tbSHA1 = new System.Windows.Forms.TextBox();
            this.tbSHA3 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cbMD5 = new System.Windows.Forms.CheckBox();
            this.cbSHA1 = new System.Windows.Forms.CheckBox();
            this.cbSHA3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.AllowDrop = true;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Text",
            "Hex",
            "File"});
            this.comboBoxType.Location = new System.Drawing.Point(23, 34);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 28);
            this.comboBoxType.TabIndex = 0;
            // 
            // data
            // 
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Location = new System.Drawing.Point(149, 36);
            this.data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(563, 27);
            this.data.TabIndex = 1;
            // 
            // btnOpenfile
            // 
            this.btnOpenfile.Location = new System.Drawing.Point(719, 34);
            this.btnOpenfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenfile.Name = "btnOpenfile";
            this.btnOpenfile.Size = new System.Drawing.Size(75, 28);
            this.btnOpenfile.TabIndex = 2;
            this.btnOpenfile.Text = "Open";
            this.btnOpenfile.UseVisualStyleBackColor = true;
            this.btnOpenfile.Click += new System.EventHandler(this.btnOpenfile_Click);
            // 
            // tbMD5
            // 
            this.tbMD5.Location = new System.Drawing.Point(149, 148);
            this.tbMD5.Margin = new System.Windows.Forms.Padding(4);
            this.tbMD5.Name = "tbMD5";
            this.tbMD5.Size = new System.Drawing.Size(563, 22);
            this.tbMD5.TabIndex = 3;
            // 
            // tbSHA1
            // 
            this.tbSHA1.Location = new System.Drawing.Point(149, 233);
            this.tbSHA1.Margin = new System.Windows.Forms.Padding(4);
            this.tbSHA1.Name = "tbSHA1";
            this.tbSHA1.Size = new System.Drawing.Size(563, 22);
            this.tbSHA1.TabIndex = 4;
            // 
            // tbSHA3
            // 
            this.tbSHA3.Location = new System.Drawing.Point(149, 330);
            this.tbSHA3.Margin = new System.Windows.Forms.Padding(4);
            this.tbSHA3.Name = "tbSHA3";
            this.tbSHA3.Size = new System.Drawing.Size(563, 22);
            this.tbSHA3.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Silver;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(331, 389);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(196, 47);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cbMD5
            // 
            this.cbMD5.AutoSize = true;
            this.cbMD5.Location = new System.Drawing.Point(44, 151);
            this.cbMD5.Margin = new System.Windows.Forms.Padding(4);
            this.cbMD5.Name = "cbMD5";
            this.cbMD5.Size = new System.Drawing.Size(59, 21);
            this.cbMD5.TabIndex = 7;
            this.cbMD5.Text = "MD5";
            this.cbMD5.UseVisualStyleBackColor = true;
            // 
            // cbSHA1
            // 
            this.cbSHA1.AutoSize = true;
            this.cbSHA1.Location = new System.Drawing.Point(44, 236);
            this.cbSHA1.Margin = new System.Windows.Forms.Padding(4);
            this.cbSHA1.Name = "cbSHA1";
            this.cbSHA1.Size = new System.Drawing.Size(66, 21);
            this.cbSHA1.TabIndex = 8;
            this.cbSHA1.Text = "SHA1";
            this.cbSHA1.UseVisualStyleBackColor = true;
            // 
            // cbSHA3
            // 
            this.cbSHA3.AutoSize = true;
            this.cbSHA3.Location = new System.Drawing.Point(44, 334);
            this.cbSHA3.Margin = new System.Windows.Forms.Padding(4);
            this.cbSHA3.Name = "cbSHA3";
            this.cbSHA3.Size = new System.Drawing.Size(66, 21);
            this.cbSHA3.TabIndex = 9;
            this.cbSHA3.Text = "SHA3";
            this.cbSHA3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data Format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSHA3);
            this.Controls.Add(this.cbSHA1);
            this.Controls.Add(this.cbMD5);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbSHA3);
            this.Controls.Add(this.tbSHA1);
            this.Controls.Add(this.tbMD5);
            this.Controls.Add(this.btnOpenfile);
            this.Controls.Add(this.data);
            this.Controls.Add(this.comboBoxType);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Hash Calculate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.Button btnOpenfile;
        private System.Windows.Forms.TextBox tbMD5;
        private System.Windows.Forms.TextBox tbSHA1;
        private System.Windows.Forms.TextBox tbSHA3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox cbMD5;
        private System.Windows.Forms.CheckBox cbSHA1;
        private System.Windows.Forms.CheckBox cbSHA3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

