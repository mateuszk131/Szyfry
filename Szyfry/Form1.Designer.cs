namespace Szyfry
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonMD5 = new System.Windows.Forms.RadioButton();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCiphered = new System.Windows.Forms.RichTextBox();
            this.radioButtonSha1 = new System.Windows.Forms.RadioButton();
            this.radioButtonSha256 = new System.Windows.Forms.RadioButton();
            this.radioButtonSha384 = new System.Windows.Forms.RadioButton();
            this.radioButtonSha512 = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.richTextBoxLoadCiphered = new System.Windows.Forms.RichTextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelPorownanie = new System.Windows.Forms.Label();
            this.radioButtonSHA512Load = new System.Windows.Forms.RadioButton();
            this.radioButtonSHA384Load = new System.Windows.Forms.RadioButton();
            this.radioButtonSHA256Load = new System.Windows.Forms.RadioButton();
            this.radioButtonSHA1Load = new System.Windows.Forms.RadioButton();
            this.radioButtonMD5Load = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.celProjektuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAutorzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDecypheredClear = new System.Windows.Forms.Button();
            this.buttonLoadClear = new System.Windows.Forms.Button();
            this.buttonClearLoad = new System.Windows.Forms.Button();
            this.dokumentacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonMD5
            // 
            this.radioButtonMD5.AutoSize = true;
            this.radioButtonMD5.Location = new System.Drawing.Point(331, 88);
            this.radioButtonMD5.Name = "radioButtonMD5";
            this.radioButtonMD5.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMD5.TabIndex = 0;
            this.radioButtonMD5.Text = "MD5";
            this.radioButtonMD5.UseVisualStyleBackColor = true;
            this.radioButtonMD5.CheckedChanged += new System.EventHandler(this.radioButtonMD5_CheckedChanged);
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(13, 88);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(301, 110);
            this.richTextBoxInput.TabIndex = 1;
            this.richTextBoxInput.Text = "";
            this.richTextBoxInput.TextChanged += new System.EventHandler(this.richTextBoxInput_TextChanged);
            // 
            // richTextBoxCiphered
            // 
            this.richTextBoxCiphered.Location = new System.Drawing.Point(417, 88);
            this.richTextBoxCiphered.Name = "richTextBoxCiphered";
            this.richTextBoxCiphered.ReadOnly = true;
            this.richTextBoxCiphered.Size = new System.Drawing.Size(310, 110);
            this.richTextBoxCiphered.TabIndex = 2;
            this.richTextBoxCiphered.Text = "";
            this.richTextBoxCiphered.TextChanged += new System.EventHandler(this.richTextBoxCiphered_TextChanged);
            // 
            // radioButtonSha1
            // 
            this.radioButtonSha1.AutoSize = true;
            this.radioButtonSha1.Location = new System.Drawing.Point(331, 112);
            this.radioButtonSha1.Name = "radioButtonSha1";
            this.radioButtonSha1.Size = new System.Drawing.Size(53, 17);
            this.radioButtonSha1.TabIndex = 3;
            this.radioButtonSha1.Text = "SHA1";
            this.radioButtonSha1.UseVisualStyleBackColor = true;
            this.radioButtonSha1.CheckedChanged += new System.EventHandler(this.radioButtonSha1_CheckedChanged);
            // 
            // radioButtonSha256
            // 
            this.radioButtonSha256.AutoSize = true;
            this.radioButtonSha256.Location = new System.Drawing.Point(329, 135);
            this.radioButtonSha256.Name = "radioButtonSha256";
            this.radioButtonSha256.Size = new System.Drawing.Size(65, 17);
            this.radioButtonSha256.TabIndex = 4;
            this.radioButtonSha256.Text = "SHA256";
            this.radioButtonSha256.UseVisualStyleBackColor = true;
            this.radioButtonSha256.CheckedChanged += new System.EventHandler(this.radioButtonSha256_CheckedChanged);
            // 
            // radioButtonSha384
            // 
            this.radioButtonSha384.AutoSize = true;
            this.radioButtonSha384.Location = new System.Drawing.Point(329, 158);
            this.radioButtonSha384.Name = "radioButtonSha384";
            this.radioButtonSha384.Size = new System.Drawing.Size(62, 17);
            this.radioButtonSha384.TabIndex = 5;
            this.radioButtonSha384.Text = "Sha384";
            this.radioButtonSha384.UseVisualStyleBackColor = true;
            this.radioButtonSha384.CheckedChanged += new System.EventHandler(this.radioButtonSha384_CheckedChanged);
            // 
            // radioButtonSha512
            // 
            this.radioButtonSha512.AutoSize = true;
            this.radioButtonSha512.Location = new System.Drawing.Point(329, 181);
            this.radioButtonSha512.Name = "radioButtonSha512";
            this.radioButtonSha512.Size = new System.Drawing.Size(62, 17);
            this.radioButtonSha512.TabIndex = 6;
            this.radioButtonSha512.Text = "Sha512";
            this.radioButtonSha512.UseVisualStyleBackColor = true;
            this.radioButtonSha512.CheckedChanged += new System.EventHandler(this.radioButtonSha512_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(652, 204);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Zapisz Hash";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // richTextBoxLoadCiphered
            // 
            this.richTextBoxLoadCiphered.Location = new System.Drawing.Point(13, 264);
            this.richTextBoxLoadCiphered.Name = "richTextBoxLoadCiphered";
            this.richTextBoxLoadCiphered.ReadOnly = true;
            this.richTextBoxLoadCiphered.Size = new System.Drawing.Size(310, 110);
            this.richTextBoxLoadCiphered.TabIndex = 8;
            this.richTextBoxLoadCiphered.Text = "";
            this.richTextBoxLoadCiphered.TextChanged += new System.EventHandler(this.richTextBoxLoadCiphered_TextChanged);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(125, 415);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(83, 23);
            this.buttonLoad.TabIndex = 10;
            this.buttonLoad.Text = "Wczytaj Hash";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelPorownanie
            // 
            this.labelPorownanie.AutoSize = true;
            this.labelPorownanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPorownanie.Location = new System.Drawing.Point(329, 264);
            this.labelPorownanie.Name = "labelPorownanie";
            this.labelPorownanie.Size = new System.Drawing.Size(70, 25);
            this.labelPorownanie.TabIndex = 11;
            this.labelPorownanie.Text = "label1";
            this.labelPorownanie.Visible = false;
            // 
            // radioButtonSHA512Load
            // 
            this.radioButtonSHA512Load.AutoSize = true;
            this.radioButtonSHA512Load.Location = new System.Drawing.Point(264, 380);
            this.radioButtonSHA512Load.Name = "radioButtonSHA512Load";
            this.radioButtonSHA512Load.Size = new System.Drawing.Size(65, 17);
            this.radioButtonSHA512Load.TabIndex = 19;
            this.radioButtonSHA512Load.Text = "SHA512";
            this.radioButtonSHA512Load.UseVisualStyleBackColor = true;
            // 
            // radioButtonSHA384Load
            // 
            this.radioButtonSHA384Load.AutoSize = true;
            this.radioButtonSHA384Load.Location = new System.Drawing.Point(196, 380);
            this.radioButtonSHA384Load.Name = "radioButtonSHA384Load";
            this.radioButtonSHA384Load.Size = new System.Drawing.Size(65, 17);
            this.radioButtonSHA384Load.TabIndex = 18;
            this.radioButtonSHA384Load.Text = "SHA384";
            this.radioButtonSHA384Load.UseVisualStyleBackColor = true;
            // 
            // radioButtonSHA256Load
            // 
            this.radioButtonSHA256Load.AutoSize = true;
            this.radioButtonSHA256Load.Location = new System.Drawing.Point(125, 380);
            this.radioButtonSHA256Load.Name = "radioButtonSHA256Load";
            this.radioButtonSHA256Load.Size = new System.Drawing.Size(65, 17);
            this.radioButtonSHA256Load.TabIndex = 17;
            this.radioButtonSHA256Load.Text = "SHA256";
            this.radioButtonSHA256Load.UseVisualStyleBackColor = true;
            // 
            // radioButtonSHA1Load
            // 
            this.radioButtonSHA1Load.AutoSize = true;
            this.radioButtonSHA1Load.Location = new System.Drawing.Point(66, 380);
            this.radioButtonSHA1Load.Name = "radioButtonSHA1Load";
            this.radioButtonSHA1Load.Size = new System.Drawing.Size(53, 17);
            this.radioButtonSHA1Load.TabIndex = 16;
            this.radioButtonSHA1Load.Text = "SHA1";
            this.radioButtonSHA1Load.UseVisualStyleBackColor = true;
            // 
            // radioButtonMD5Load
            // 
            this.radioButtonMD5Load.AutoSize = true;
            this.radioButtonMD5Load.Location = new System.Drawing.Point(12, 380);
            this.radioButtonMD5Load.Name = "radioButtonMD5Load";
            this.radioButtonMD5Load.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMD5Load.TabIndex = 15;
            this.radioButtonMD5Load.Text = "MD5";
            this.radioButtonMD5Load.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tekst do zaszyfrowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tekst zaszyfrowany";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tekst zaszyfrowany wczytany z pliku";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.inneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 23;
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
            // inneToolStripMenuItem
            // 
            this.inneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.celProjektuToolStripMenuItem,
            this.oAutorzeToolStripMenuItem,
            this.dokumentacjaToolStripMenuItem});
            this.inneToolStripMenuItem.Name = "inneToolStripMenuItem";
            this.inneToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.inneToolStripMenuItem.Text = "Inne";
            // 
            // celProjektuToolStripMenuItem
            // 
            this.celProjektuToolStripMenuItem.Name = "celProjektuToolStripMenuItem";
            this.celProjektuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.celProjektuToolStripMenuItem.Text = "Cel projektu";
            this.celProjektuToolStripMenuItem.Click += new System.EventHandler(this.celProjektuToolStripMenuItem_Click);
            // 
            // oAutorzeToolStripMenuItem
            // 
            this.oAutorzeToolStripMenuItem.Name = "oAutorzeToolStripMenuItem";
            this.oAutorzeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oAutorzeToolStripMenuItem.Text = "O autorze";
            this.oAutorzeToolStripMenuItem.Click += new System.EventHandler(this.oAutorzeToolStripMenuItem_Click);
            // 
            // buttonDecypheredClear
            // 
            this.buttonDecypheredClear.Image = global::Szyfry.Properties.Resources.error1;
            this.buttonDecypheredClear.Location = new System.Drawing.Point(704, 173);
            this.buttonDecypheredClear.Name = "buttonDecypheredClear";
            this.buttonDecypheredClear.Size = new System.Drawing.Size(23, 25);
            this.buttonDecypheredClear.TabIndex = 14;
            this.buttonDecypheredClear.UseVisualStyleBackColor = true;
            this.buttonDecypheredClear.Click += new System.EventHandler(this.buttonDecypheredClear_Click);
            // 
            // buttonLoadClear
            // 
            this.buttonLoadClear.BackColor = System.Drawing.SystemColors.Window;
            this.buttonLoadClear.Image = global::Szyfry.Properties.Resources.error1;
            this.buttonLoadClear.Location = new System.Drawing.Point(291, 173);
            this.buttonLoadClear.Name = "buttonLoadClear";
            this.buttonLoadClear.Size = new System.Drawing.Size(23, 25);
            this.buttonLoadClear.TabIndex = 13;
            this.buttonLoadClear.UseVisualStyleBackColor = false;
            this.buttonLoadClear.Click += new System.EventHandler(this.buttonInputClear_Click);
            // 
            // buttonClearLoad
            // 
            this.buttonClearLoad.BackColor = System.Drawing.SystemColors.Control;
            this.buttonClearLoad.Image = global::Szyfry.Properties.Resources.error1;
            this.buttonClearLoad.Location = new System.Drawing.Point(300, 349);
            this.buttonClearLoad.Name = "buttonClearLoad";
            this.buttonClearLoad.Size = new System.Drawing.Size(23, 25);
            this.buttonClearLoad.TabIndex = 12;
            this.buttonClearLoad.UseVisualStyleBackColor = false;
            this.buttonClearLoad.Click += new System.EventHandler(this.buttonLoadClear_Click);
            // 
            // dokumentacjaToolStripMenuItem
            // 
            this.dokumentacjaToolStripMenuItem.Name = "dokumentacjaToolStripMenuItem";
            this.dokumentacjaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dokumentacjaToolStripMenuItem.Text = "Dokumentacja";
            this.dokumentacjaToolStripMenuItem.Click += new System.EventHandler(this.dokumentacjaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonSHA512Load);
            this.Controls.Add(this.radioButtonSHA384Load);
            this.Controls.Add(this.radioButtonSHA256Load);
            this.Controls.Add(this.radioButtonSHA1Load);
            this.Controls.Add(this.radioButtonMD5Load);
            this.Controls.Add(this.buttonDecypheredClear);
            this.Controls.Add(this.buttonLoadClear);
            this.Controls.Add(this.buttonClearLoad);
            this.Controls.Add(this.labelPorownanie);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.richTextBoxLoadCiphered);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.radioButtonSha512);
            this.Controls.Add(this.radioButtonSha384);
            this.Controls.Add(this.radioButtonSha256);
            this.Controls.Add(this.radioButtonSha1);
            this.Controls.Add(this.richTextBoxCiphered);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.radioButtonMD5);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonMD5;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.RichTextBox richTextBoxCiphered;
        private System.Windows.Forms.RadioButton radioButtonSha1;
        private System.Windows.Forms.RadioButton radioButtonSha256;
        private System.Windows.Forms.RadioButton radioButtonSha384;
        private System.Windows.Forms.RadioButton radioButtonSha512;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RichTextBox richTextBoxLoadCiphered;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelPorownanie;
        private System.Windows.Forms.Button buttonClearLoad;
        private System.Windows.Forms.Button buttonLoadClear;
        private System.Windows.Forms.Button buttonDecypheredClear;
        private System.Windows.Forms.RadioButton radioButtonSHA512Load;
        private System.Windows.Forms.RadioButton radioButtonSHA384Load;
        private System.Windows.Forms.RadioButton radioButtonSHA256Load;
        private System.Windows.Forms.RadioButton radioButtonSHA1Load;
        private System.Windows.Forms.RadioButton radioButtonMD5Load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjdźToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem celProjektuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAutorzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumentacjaToolStripMenuItem;
    }
}

