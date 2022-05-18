
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.comboBoxType.Location = new System.Drawing.Point(17, 28);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(92, 25);
            this.comboBoxType.TabIndex = 0;
            // 
            // data
            // 
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Location = new System.Drawing.Point(112, 29);
            this.data.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(423, 23);
            this.data.TabIndex = 1;
            // 
            // btnOpenfile
            // 
            this.btnOpenfile.Location = new System.Drawing.Point(539, 28);
            this.btnOpenfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenfile.Name = "btnOpenfile";
            this.btnOpenfile.Size = new System.Drawing.Size(56, 23);
            this.btnOpenfile.TabIndex = 2;
            this.btnOpenfile.Text = "Open";
            this.btnOpenfile.UseVisualStyleBackColor = true;
            // 
            // tbMD5
            // 
            this.tbMD5.Location = new System.Drawing.Point(112, 120);
            this.tbMD5.Name = "tbMD5";
            this.tbMD5.Size = new System.Drawing.Size(423, 20);
            this.tbMD5.TabIndex = 3;
            // 
            // tbSHA1
            // 
            this.tbSHA1.Location = new System.Drawing.Point(112, 189);
            this.tbSHA1.Name = "tbSHA1";
            this.tbSHA1.Size = new System.Drawing.Size(423, 20);
            this.tbSHA1.TabIndex = 4;
            // 
            // tbSHA3
            // 
            this.tbSHA3.Location = new System.Drawing.Point(112, 268);
            this.tbSHA3.Name = "tbSHA3";
            this.tbSHA3.Size = new System.Drawing.Size(423, 20);
            this.tbSHA3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(248, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cbMD5
            // 
            this.cbMD5.AutoSize = true;
            this.cbMD5.Location = new System.Drawing.Point(33, 123);
            this.cbMD5.Name = "cbMD5";
            this.cbMD5.Size = new System.Drawing.Size(49, 17);
            this.cbMD5.TabIndex = 7;
            this.cbMD5.Text = "MD5";
            this.cbMD5.UseVisualStyleBackColor = true;
            // 
            // cbSHA1
            // 
            this.cbSHA1.AutoSize = true;
            this.cbSHA1.Location = new System.Drawing.Point(33, 192);
            this.cbSHA1.Name = "cbSHA1";
            this.cbSHA1.Size = new System.Drawing.Size(54, 17);
            this.cbSHA1.TabIndex = 8;
            this.cbSHA1.Text = "SHA1";
            this.cbSHA1.UseVisualStyleBackColor = true;
            // 
            // cbSHA3
            // 
            this.cbSHA3.AutoSize = true;
            this.cbSHA3.Location = new System.Drawing.Point(33, 271);
            this.cbSHA3.Name = "cbSHA3";
            this.cbSHA3.Size = new System.Drawing.Size(54, 17);
            this.cbSHA3.TabIndex = 9;
            this.cbSHA3.Text = "SHA3";
            this.cbSHA3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data Format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSHA3);
            this.Controls.Add(this.cbSHA1);
            this.Controls.Add(this.cbMD5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSHA3);
            this.Controls.Add(this.tbSHA1);
            this.Controls.Add(this.tbMD5);
            this.Controls.Add(this.btnOpenfile);
            this.Controls.Add(this.data);
            this.Controls.Add(this.comboBoxType);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Hash Calculate";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbMD5;
        private System.Windows.Forms.CheckBox cbSHA1;
        private System.Windows.Forms.CheckBox cbSHA3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

