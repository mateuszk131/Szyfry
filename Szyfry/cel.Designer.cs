namespace Szyfry
{
    partial class cel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCel = new System.Windows.Forms.Label();
            this.pictureBoxHappyFace = new System.Windows.Forms.PictureBox();
            this.pictureBoxUKW = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHappyFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUKW)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyjdźToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wyjdźToolStripMenuItem
            // 
            this.wyjdźToolStripMenuItem.Name = "wyjdźToolStripMenuItem";
            this.wyjdźToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.wyjdźToolStripMenuItem.Text = "Wyjdź";
            this.wyjdźToolStripMenuItem.Click += new System.EventHandler(this.wyjdźToolStripMenuItem_Click);
            // 
            // labelCel
            // 
            this.labelCel.AutoSize = true;
            this.labelCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCel.Location = new System.Drawing.Point(29, 253);
            this.labelCel.Name = "labelCel";
            this.labelCel.Size = new System.Drawing.Size(704, 29);
            this.labelCel.TabIndex = 2;
            this.labelCel.Text = "Projekt zaliczeniowy z Bezpieczeństwa Systemów Internetowych ";
            // 
            // pictureBoxHappyFace
            // 
            this.pictureBoxHappyFace.Image = global::Szyfry.Properties.Resources.HappyFace;
            this.pictureBoxHappyFace.Location = new System.Drawing.Point(310, 288);
            this.pictureBoxHappyFace.Name = "pictureBoxHappyFace";
            this.pictureBoxHappyFace.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxHappyFace.TabIndex = 3;
            this.pictureBoxHappyFace.TabStop = false;
            this.pictureBoxHappyFace.Visible = false;
            // 
            // pictureBoxUKW
            // 
            this.pictureBoxUKW.Image = global::Szyfry.Properties.Resources.UKW_logo1;
            this.pictureBoxUKW.Location = new System.Drawing.Point(34, 35);
            this.pictureBoxUKW.Name = "pictureBoxUKW";
            this.pictureBoxUKW.Size = new System.Drawing.Size(698, 202);
            this.pictureBoxUKW.TabIndex = 0;
            this.pictureBoxUKW.TabStop = false;
            this.pictureBoxUKW.Click += new System.EventHandler(this.pictureBoxUKW_Click);
            // 
            // cel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxHappyFace);
            this.Controls.Add(this.labelCel);
            this.Controls.Add(this.pictureBoxUKW);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "cel";
            this.Text = "cel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHappyFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUKW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUKW;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjdźToolStripMenuItem;
        private System.Windows.Forms.Label labelCel;
        private System.Windows.Forms.PictureBox pictureBoxHappyFace;
    }
}