namespace AUP_Project
{
    partial class Form4
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
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnKeyword = new System.Windows.Forms.RadioButton();
            this.rbtnCeasar = new System.Windows.Forms.RadioButton();
            this.rbtnVigenere = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rbtnXOR = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDecrypt.Location = new System.Drawing.Point(482, 513);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(184, 41);
            this.btnDecrypt.TabIndex = 15;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEncrypt.Location = new System.Drawing.Point(485, 385);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(184, 41);
            this.btnEncrypt.TabIndex = 14;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(25, 579);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Decrypted";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(23, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Encrypted";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Input text";
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDecrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDecrypted.Location = new System.Drawing.Point(142, 573);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.ReadOnly = true;
            this.txtDecrypted.Size = new System.Drawing.Size(527, 34);
            this.txtDecrypted.TabIndex = 10;
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEncrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEncrypted.Location = new System.Drawing.Point(139, 451);
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.ReadOnly = true;
            this.txtEncrypted.Size = new System.Drawing.Size(530, 34);
            this.txtEncrypted.TabIndex = 9;
            // 
            // txtPlain
            // 
            this.txtPlain.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPlain.Location = new System.Drawing.Point(142, 241);
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(527, 34);
            this.txtPlain.TabIndex = 8;
            // 
            // txtKey
            // 
            this.txtKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKey.Location = new System.Drawing.Point(142, 314);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(527, 34);
            this.txtKey.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(79, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Key";
            // 
            // rbtnKeyword
            // 
            this.rbtnKeyword.AutoSize = true;
            this.rbtnKeyword.Checked = true;
            this.rbtnKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnKeyword.Location = new System.Drawing.Point(139, 21);
            this.rbtnKeyword.Name = "rbtnKeyword";
            this.rbtnKeyword.Size = new System.Drawing.Size(207, 33);
            this.rbtnKeyword.TabIndex = 18;
            this.rbtnKeyword.TabStop = true;
            this.rbtnKeyword.Text = "Keyword Cipher";
            this.rbtnKeyword.UseVisualStyleBackColor = true;
            this.rbtnKeyword.CheckedChanged += new System.EventHandler(this.rbtnKeyword_CheckedChanged);
            // 
            // rbtnCeasar
            // 
            this.rbtnCeasar.AutoSize = true;
            this.rbtnCeasar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnCeasar.Location = new System.Drawing.Point(139, 122);
            this.rbtnCeasar.Name = "rbtnCeasar";
            this.rbtnCeasar.Size = new System.Drawing.Size(189, 33);
            this.rbtnCeasar.TabIndex = 19;
            this.rbtnCeasar.Text = "Ceasar Cipher";
            this.rbtnCeasar.UseVisualStyleBackColor = true;
            this.rbtnCeasar.CheckedChanged += new System.EventHandler(this.rbtnCeasar_CheckedChanged);
            // 
            // rbtnVigenere
            // 
            this.rbtnVigenere.AutoSize = true;
            this.rbtnVigenere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnVigenere.Location = new System.Drawing.Point(139, 70);
            this.rbtnVigenere.Name = "rbtnVigenere";
            this.rbtnVigenere.Size = new System.Drawing.Size(210, 33);
            this.rbtnVigenere.TabIndex = 20;
            this.rbtnVigenere.Text = "Vigenere Cipher";
            this.rbtnVigenere.UseVisualStyleBackColor = true;
            this.rbtnVigenere.CheckedChanged += new System.EventHandler(this.rbtnVigenere_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.Location = new System.Drawing.Point(485, 648);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(184, 41);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear all";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(249, 716);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 46);
            this.button1.TabIndex = 23;
            this.button1.Text = "Password encription example";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtnXOR
            // 
            this.rbtnXOR.AutoSize = true;
            this.rbtnXOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnXOR.Location = new System.Drawing.Point(139, 180);
            this.rbtnXOR.Name = "rbtnXOR";
            this.rbtnXOR.Size = new System.Drawing.Size(165, 33);
            this.rbtnXOR.TabIndex = 24;
            this.rbtnXOR.Text = "XOR Cipher";
            this.rbtnXOR.UseVisualStyleBackColor = true;
            this.rbtnXOR.CheckedChanged += new System.EventHandler(this.rbtnXOR_CheckedChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 774);
            this.Controls.Add(this.rbtnXOR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rbtnVigenere);
            this.Controls.Add(this.rbtnCeasar);
            this.Controls.Add(this.rbtnKeyword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.txtPlain);
            this.Name = "Form4";
            this.Text = "Cipher";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnKeyword;
        private System.Windows.Forms.RadioButton rbtnCeasar;
        private System.Windows.Forms.RadioButton rbtnVigenere;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtnXOR;
    }
}