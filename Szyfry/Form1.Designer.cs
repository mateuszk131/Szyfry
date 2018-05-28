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
            this.richTextBoxDecyphered = new System.Windows.Forms.RichTextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
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
            // 
            // radioButtonSha1
            // 
            this.radioButtonSha1.AutoSize = true;
            this.radioButtonSha1.Location = new System.Drawing.Point(331, 112);
            this.radioButtonSha1.Name = "radioButtonSha1";
            this.radioButtonSha1.Size = new System.Drawing.Size(50, 17);
            this.radioButtonSha1.TabIndex = 3;
            this.radioButtonSha1.Text = "Sha1";
            this.radioButtonSha1.UseVisualStyleBackColor = true;
            this.radioButtonSha1.CheckedChanged += new System.EventHandler(this.radioButtonSha1_CheckedChanged);
            // 
            // radioButtonSha256
            // 
            this.radioButtonSha256.AutoSize = true;
            this.radioButtonSha256.Location = new System.Drawing.Point(329, 135);
            this.radioButtonSha256.Name = "radioButtonSha256";
            this.radioButtonSha256.Size = new System.Drawing.Size(62, 17);
            this.radioButtonSha256.TabIndex = 4;
            this.radioButtonSha256.Text = "Sha256";
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
            this.buttonSave.Text = "Zapisz";
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
            // richTextBoxDecyphered
            // 
            this.richTextBoxDecyphered.Location = new System.Drawing.Point(417, 264);
            this.richTextBoxDecyphered.Name = "richTextBoxDecyphered";
            this.richTextBoxDecyphered.Size = new System.Drawing.Size(301, 110);
            this.richTextBoxDecyphered.TabIndex = 9;
            this.richTextBoxDecyphered.Text = "";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(13, 381);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 10;
            this.buttonLoad.Text = "Wczytaj";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.richTextBoxDecyphered);
            this.Controls.Add(this.richTextBoxLoadCiphered);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.radioButtonSha512);
            this.Controls.Add(this.radioButtonSha384);
            this.Controls.Add(this.radioButtonSha256);
            this.Controls.Add(this.radioButtonSha1);
            this.Controls.Add(this.richTextBoxCiphered);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.radioButtonMD5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.RichTextBox richTextBoxDecyphered;
        private System.Windows.Forms.Button buttonLoad;
    }
}

