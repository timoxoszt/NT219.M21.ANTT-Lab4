using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using HashLib;

namespace HashCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string md5_output;
        string sha1_output;
        string sha256_output;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input = data.Text;

            switch (comboBoxType.Text.ToString())
            {
                case "Text":
                    md5_output = TextMd5Hash(input);
                    sha1_output = TextSHA1Hash(input);
                    sha256_output = TextSha256Hash(input);
                    break;
                case "Hex":
                    md5_output = HexMd5Hash(input);
                    sha1_output = HexSHA1Hash(input);
                    sha256_output = HexSha256Hash(input);
                    break;
                case "File":
                    md5_output = "hehe";
                    break;
            }
            tbMD5.Text = md5_output;
            tbSHA1.Text = sha1_output;
            tbSHA3.Text = sha256_output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
        }

        public static string TextMd5Hash(string message)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] input = Encoding.UTF8.GetBytes(message);
                byte[] hash = md5.ComputeHash(input);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2")); // print in hexadecimal format
                }
                return sb.ToString().ToLower();
            }
        }

        public static string HextoString(string message, Encoding encoding)
        {
            int numberChars = message.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(message.Substring(i, 2), 16);
            }
            return encoding.GetString(bytes);
        }

        public static string HexMd5Hash(string message)
        {
            return TextMd5Hash(HextoString(message, Encoding.UTF8));
        }

        static string TextSHA1Hash(string message)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(message));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString().ToLower();
            }
        }

        public static string HexSHA1Hash(string message)
        {
            return TextSHA1Hash(HextoString(message, Encoding.UTF8));
        }

        static string TextSha256Hash(string message)
        {
            var hashAlgorithm = new Org.BouncyCastle.Crypto.Digests.Sha3Digest(256);
            byte[] input = Encoding.ASCII.GetBytes(message);

            hashAlgorithm.BlockUpdate(input, 0, input.Length);

            byte[] result = new byte[32]; // 256 / 8 = 32
            hashAlgorithm.DoFinal(result, 0);

            string hashString = BitConverter.ToString(result);
            hashString = hashString.Replace("-", "").ToLowerInvariant();

            return hashString;
        }

        static string HexSha256Hash(string message)
        {
            return TextSha256Hash(HextoString(message, Encoding.UTF8));
        }
    }
}
