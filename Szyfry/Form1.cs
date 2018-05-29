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
        licz licz = new licz();
        #region metody
        public void clear()
        {
            if (string.IsNullOrEmpty(richTextBoxInput.Text))
            {
                richTextBoxCiphered.Text = "";
            }
            return;
        }
        public void porownanie()
        {
            if (richTextBoxLoadCiphered.Text.Equals(richTextBoxCiphered.Text))
            {
                labelPorownanie.ForeColor = Color.Green;
                labelPorownanie.Text = ("Hashe są jednakowe");
            }
            else
            {
                labelPorownanie.ForeColor = Color.Red;
                labelPorownanie.Text = ("Hashe są różne");
            }
            return;
        }
        #endregion
        #region radio button check
        private void radioButtonMD5_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxCiphered.Text = licz.MD5(richTextBoxInput.Text);
        }
        private void radioButtonSha1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxCiphered.Text = licz.SHA1(richTextBoxInput.Text);
        }
        private void radioButtonSha256_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxCiphered.Text = licz.SHA256(richTextBoxInput.Text);
        }
        private void radioButtonSha384_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxCiphered.Text = licz.SHA384(richTextBoxInput.Text);
        }
        private void radioButtonSha512_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxCiphered.Text = licz.SHA512(richTextBoxInput.Text);
        }
        #endregion
        #region zmiany w tekscie
        private void richTextBoxInput_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonMD5.Checked)
            {
                richTextBoxCiphered.Text = licz.MD5(richTextBoxInput.Text);
            }
            if (radioButtonSha1.Checked)
            {
                richTextBoxCiphered.Text = licz.SHA1(richTextBoxInput.Text);
            }
            if (radioButtonSha256.Checked)
            {
                richTextBoxCiphered.Text = licz.SHA256(richTextBoxInput.Text);
            }
            if (radioButtonSha384.Checked)
            {
                richTextBoxCiphered.Text = licz.SHA384(richTextBoxInput.Text);
            }
            if (radioButtonSha512.Checked)
            {
                richTextBoxCiphered.Text = licz.SHA512(richTextBoxInput.Text);
            }
            clear();
            porownanie();
        }
        private void richTextBoxCiphered_TextChanged(object sender, EventArgs e)
        {            
            porownanie();
        }
        private void richTextBoxLoadCiphered_TextChanged(object sender, EventArgs e)
        {
            porownanie();
        }
        #endregion
        #region buttony
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (radioButtonMD5.Checked)
            {
                System.IO.File.WriteAllText(@"MD5.txt", richTextBoxCiphered.Text);
            }
            if (radioButtonSha1.Checked)
            {
                System.IO.File.WriteAllText(@"SHA1.txt", richTextBoxCiphered.Text);
            }
            if (radioButtonSha256.Checked)
            {
                System.IO.File.WriteAllText(@"SHA256.txt", richTextBoxCiphered.Text);
            }
            if (radioButtonSha384.Checked)
            {
                System.IO.File.WriteAllText(@"Sha384.txt", richTextBoxCiphered.Text);
            }
            if (radioButtonSha512.Checked)
            {
                System.IO.File.WriteAllText(@"Sha512.txt", richTextBoxCiphered.Text);
            }
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            labelPorownanie.Visible = true;
            if (radioButtonMD5Load.Checked)
            {
                richTextBoxLoadCiphered.LoadFile(@"MD5.txt", RichTextBoxStreamType.PlainText);
            }
            if (radioButtonSHA1Load.Checked)
            {
                richTextBoxLoadCiphered.LoadFile(@"SHA1.txt", RichTextBoxStreamType.PlainText);
            }
            if (radioButtonSHA256Load.Checked)
            {
                richTextBoxLoadCiphered.LoadFile(@"SHA256.txt", RichTextBoxStreamType.PlainText);
            }
            if (radioButtonSHA384Load.Checked)
            {
                richTextBoxLoadCiphered.LoadFile(@"Sha384.txt", RichTextBoxStreamType.PlainText);
            }
            if (radioButtonSHA512Load.Checked)
            {
                richTextBoxLoadCiphered.LoadFile(@"Sha512.txt", RichTextBoxStreamType.PlainText);
            }
            porownanie();
        }
        #endregion
        #region menu strip
        private void wyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
        private void celProjektuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cel cel = new cel();
            cel.Show();
        }
        private void dokumentacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            System.Diagnostics.Process.Start("Dokumentacja.pdf");
        }
        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region button clear'e
        private void buttonDecypheredClear_Click(object sender, EventArgs e)
        {
            richTextBoxCiphered.Text = "";
        }
        private void buttonInputClear_Click(object sender, EventArgs e)
        {
            richTextBoxInput.Text = "";
        }
        private void buttonLoadClear_Click(object sender, EventArgs e)
        {
            richTextBoxLoadCiphered.Text = "";
        }
        #endregion
    }
}