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

namespace Szyfry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public static string MD5decypher(string s)
        {
            using (var provider = System.Security.Cryptography.MD5.Create())
            {
                StringBuilder builder = new StringBuilder();
                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToLower());
                return builder.ToString();
            }
        }
        #region szyfry
        public static string MD5(string s)
        {
            using (var provider = System.Security.Cryptography.MD5.Create())
            {
                StringBuilder builder = new StringBuilder();
                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToLower());
                return builder.ToString();
            }
        }
        public static string Sha1(string s)
        {
            using (var provider = System.Security.Cryptography.SHA1.Create())
            {
                StringBuilder builder = new StringBuilder();
                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToLower());
                return builder.ToString();
            }
        }
        public static string Sha256(string s)
        {
            using (var provider = System.Security.Cryptography.SHA256.Create())
            {
                StringBuilder builder = new StringBuilder();
                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToLower());
                return builder.ToString();
            }
        }
        public static string Sha384(string s)
        {
            using (var provider = System.Security.Cryptography.SHA384.Create())
            {
                StringBuilder builder = new StringBuilder();
                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToLower());
                return builder.ToString();
            }
        }
        public static string Sha512(string s)
        {
            using (var provider = System.Security.Cryptography.SHA512.Create())
            {
                StringBuilder builder = new StringBuilder();
                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToLower());
                return builder.ToString();
            }
        }
        #endregion
        #region radio button check
        private void radioButtonMD5_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxCiphered.Text = MD5(richTextBoxInput.Text);
        }
        private void radioButtonSha1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxCiphered.Text = Sha1(richTextBoxInput.Text);
        }
        private void radioButtonSha256_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxCiphered.Text = Sha256(richTextBoxInput.Text);
        }
        private void radioButtonSha384_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxCiphered.Text = Sha384(richTextBoxInput.Text);
        }
        private void radioButtonSha512_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxCiphered.Text = Sha512(richTextBoxInput.Text);
        }
        #endregion
        private void richTextBoxInput_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonMD5.Checked)
            {
                richTextBoxCiphered.Text = MD5(richTextBoxInput.Text);
            }
            if (radioButtonSha1.Checked)
            {
                richTextBoxCiphered.Text = Sha1(richTextBoxInput.Text);
            }
            if (radioButtonSha256.Checked)
            {
                richTextBoxCiphered.Text = Sha256(richTextBoxInput.Text);
            }
            if (radioButtonSha384.Checked)
            {
                richTextBoxCiphered.Text = Sha384(richTextBoxInput.Text);
            }
            if (radioButtonSha512.Checked)
            {
                richTextBoxCiphered.Text = Sha512(richTextBoxInput.Text);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (radioButtonMD5.Checked)
            {
                System.IO.File.WriteAllText(@"MD5.txt", richTextBoxCiphered.Text + Environment.NewLine);
            }
            if (radioButtonSha1.Checked)
            {
                System.IO.File.WriteAllText(@"Sha1.txt", richTextBoxCiphered.Text + Environment.NewLine);
            }
            if (radioButtonSha256.Checked)
            {
                System.IO.File.WriteAllText(@"Sha256.txt", richTextBoxCiphered.Text + Environment.NewLine);
            }
            if (radioButtonSha384.Checked)
            {
                System.IO.File.WriteAllText(@"Sha384.txt", richTextBoxCiphered.Text + Environment.NewLine);
            }
            if (radioButtonSha512.Checked)
            {
                System.IO.File.WriteAllText(@"Sha512.txt", richTextBoxCiphered.Text + Environment.NewLine);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (radioButtonMD5.Checked)
            {
                richTextBoxLoadCiphered.LoadFile(@"MD5.txt", RichTextBoxStreamType.PlainText);
            }
        }

        private void richTextBoxLoadCiphered_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}



