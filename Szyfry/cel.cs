using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfry
{
    public partial class cel : Form
    {
        public cel()
        {
            InitializeComponent();
        }

        private void wyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxUKW_Click(object sender, EventArgs e)
        {
            pictureBoxHappyFace.Visible = true;
        }
    }
}
