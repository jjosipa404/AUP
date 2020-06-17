using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AUP_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Random g = new Random();
            shift = g.Next(1,25);//za vigenere-ovo šifriranje odabire se random pomak od 1 do 25 
        }

        private int shift;
        private string VigenereKey;

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (!StringCheck(txtPlain.Text.ToCharArray()) || !StringCheck(txtKey.Text.ToCharArray()))
            {
                MessageBox.Show("Input text and keyword must contain only letters!");
                return;
            }
            else
            {
                try
                {
                    string message = txtPlain.Text;
                    string key = txtKey.Text;

                    if (((key == "" || message == "" ) && (!rbtnCeasar.Checked && !rbtnXOR.Checked)) || ( message == "" && (rbtnCeasar.Checked || rbtnXOR.Checked)))
                    {
                        MessageBox.Show("Check if you have entered right all needed data!");
                        return;
                    }  

                    if (rbtnKeyword.Checked)
                    {
                        string encoded = KeywordCipher.Encoder(key.ToCharArray());//šifrirana abeceda
                        string ciphered = KeywordCipher.CipherIt(message, encoded);
                        txtEncrypted.Text = ciphered;
                    }
                    else if (rbtnCeasar.Checked)
                    {
                        string ciphered = CeasarCipher.Encrypt(message, shift);
                        txtEncrypted.Text = ciphered.ToString();
                    }
                    else if (rbtnVigenere.Checked)
                    {
                        if (message.Count() >= key.Count())
                        {
                            string _key = VigenereCipher.GenerateKey(message, key);
                            VigenereKey = _key;
                            string ciphered = VigenereCipher.Encription(message, _key);
                            txtEncrypted.Text = ciphered;
                        }
                        else
                        {
                            MessageBox.Show("Enter longer or equal length message than key!");
                            return;
                        }
                    }
                    else if (rbtnXOR.Checked)
                    {
                        string ciphered = XORCipher.EncryptDecrypt(message);
                        txtEncrypted.Text = ciphered;
                    }
                }
                catch
                {
                    MessageBox.Show("Check if you have entered right all needed data!");
                    return;
                }
            }
            

            txtPlain.ReadOnly = true;
            txtKey.ReadOnly = true;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string key = txtKey.Text;
                string message = txtPlain.Text;
                string cryptedMessage = txtEncrypted.Text;
                //if ((key == "" || message == "" || cryptedMessage == "") && (!rbtnCeasar.Checked && !rbtnXOR.Checked) || (message == "" && (rbtnCeasar.Checked || rbtnXOR.Checked)))
                //{
                //    MessageBox.Show("Check if you have entered right all needed data!");
                //    return;
                //}

                if (rbtnKeyword.Checked)
                {
                    string encoded = KeywordCipher.Encoder(key.ToCharArray());
                    string deciphered = KeywordCipher.DecipherIt(cryptedMessage, encoded);
                    txtDecrypted.Text = deciphered;
                }
                else if (rbtnCeasar.Checked)
                {
                    int s = 26 - shift;
                    string deciphered = CeasarCipher.Encrypt(cryptedMessage, s);
                    txtDecrypted.Text = deciphered.ToString();
                }
                else if (rbtnVigenere.Checked)
                {
                    string deciphered = VigenereCipher.Decryption(txtEncrypted.Text, VigenereKey);
                    txtDecrypted.Text = deciphered;
                }
                else if (rbtnXOR.Checked)
                {
                    string ciphered = XORCipher.EncryptDecrypt(message);
                    string deciphered = XORCipher.EncryptDecrypt(ciphered);
                    txtDecrypted.Text = deciphered;
                }
            }
            catch 
            {
                MessageBox.Show("Check if you have entered right all needed data!");
                return;
            }
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void rbtnKeyword_CheckedChanged(object sender, EventArgs e)
        {
            txtKey.Enabled = true;
            txtPlain.CharacterCasing = CharacterCasing.Upper;
            Clear();
        }

        private void rbtnCeasar_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            txtPlain.CharacterCasing = CharacterCasing.Upper;
            txtKey.Enabled = false;
        }

        private void rbtnVigenere_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            txtPlain.CharacterCasing = CharacterCasing.Upper;
            txtKey.Enabled = true;
        }

        private void rbtnXOR_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            txtPlain.CharacterCasing = CharacterCasing.Upper;
            txtKey.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtPlain.ReadOnly = false;
            txtKey.ReadOnly = false;
            txtPlain.Text = "";
            txtKey.Text = "";
            txtEncrypted.Text = "";
            txtDecrypted.Text = "";
        }

        private bool StringCheck(char[] input)
        {
            string others = "!#$%&€/()=?*/\'\"-+:;,.><[]{}@\\|÷×¤ß~ˇˇ^^˘˘°°˛˛˙˙`˝˝¨¸˙˙`_";
            foreach (char c in input)
            {
                bool b = int.TryParse(c.ToString(),out int r);
                if (b)
                {
                    return false;
                }
                if (others.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
        }
    }
}
