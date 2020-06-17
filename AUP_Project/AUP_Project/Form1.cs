//#define MyDebug
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace AUP_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
#if MyDebug
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

#endif
   
        string hash = "pr0gr@m";//ključna riječ za šifriranje i dešifriranje

        private void Form1_Load(object sender, EventArgs e)
        {
            //ispis korisnika iz datoteke u dictionary
            string dat = "Data.txt";
            try
            {
                using (StreamReader sr = new StreamReader(dat))
                {
                    string linija;
                    while ((linija = sr.ReadLine()) != null)
                    {
                        string[] niz = linija.Split(';');
                        if (!dict.ContainsKey(niz[0]))
                            dict.Add(niz[0], niz[1]);
                      //u dict dodajemo username i password
                    }
                    sr.Close();
                }
            }
            catch (Exception)//ako ne pronadje datoteku, napravi novu
            {
                FileStream fs = File.Create(dat);
                fs.Close();
                return;
            }


        }


        private void rbtnSignup_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            btnLogin.Enabled = false;
            btnSignup.Enabled = true;
            txtAge.Enabled = true;
            txtName.Enabled = true;
        }

        private void rbtnLogin_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            btnLogin.Enabled = true;
            btnSignup.Enabled = false;
            txtAge.Enabled = false;
            txtName.Enabled = false;
        }

        private bool AgeCheck(string inputText)
        {
            char[] input = inputText.ToCharArray();
            string others = "!#$%&€/()=?*/\'\"-+:;,.><[]{}@\\|÷×¤ß~ˇˇ^^˘˘°°˛˛˙˙`˝˝¨¸˙˙`_";
            foreach (char c in input)
            {
                bool b = int.TryParse(c.ToString(), out int r);
                if (!b)
                {
                    return false;
                }
                if (others.Contains(c.ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        private bool NameCheck(string inputText)
        {
            char[] input = inputText.ToCharArray();
            string others = "!#$%€&/()=?*/\'\"-+:;,.><[]{}@\\|÷×¤ß~ˇˇ^^˘˘°°˛˛˙˙`˝˝¨¸˙˙`_";
            foreach (char c in input)
            {
                bool b = int.TryParse(c.ToString(), out int r);
                if (b)
                {
                    return false;
                }
                if (others.Contains(c.ToString()))
                {
                    return false;
                }
                if (c == ' ')
                {
                    return false;
                }
            }
            return true;
        }

        Dictionary<string, string> dict = new Dictionary<string, string>();

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "" && txtPassword.Text != "" && txtName.Text != "" && txtAge.Text != "")
                {

                    string pass = "";
                    byte[] data = Encoding.UTF8.GetBytes(txtPassword.Text);
                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {
                        byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(hash));
                        using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider())
                        {
                            tripDes.Key = keys;
                            tripDes.Mode = CipherMode.ECB;
                            tripDes.Padding = PaddingMode.PKCS7;
                            ICryptoTransform transform = tripDes.CreateEncryptor();
                            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                            pass = Convert.ToBase64String(result, 0, result.Length);
                        }
                    }

                    string user = "";
                    string name = "";
                    string age = "";
                    if (NameCheck(txtUsername.Text))
                    {
                        user = txtUsername.Text;
                    }
                    else
                    {
                        MessageBox.Show("Invalid username input!");
                        return;
                    }
                    if (NameCheck(txtName.Text))
                    {
                        name = txtName.Text;
                    }
                    else
                    {
                        MessageBox.Show("Invalid name input!");
                        return;
                    }
                    if (AgeCheck(txtAge.Text))
                    {
                        age = txtAge.Text;
                    }
                    else
                    {
                        MessageBox.Show("Invalid age input!");
                        return;
                    }


                    if (dict.ContainsKey(user))
                    {
                        MessageBox.Show("User already exists! Check Log in!");
                        return;
                    }
                    else
                    {
                        string dat = "Data.txt";
                        using (StreamWriter sw = new StreamWriter(dat, true))
                        {
                            string alldata = user + ';' + pass + ';' + name + ';' + age;
                            sw.WriteLine(alldata);
                            dict[user] = pass;
                        }
                        MessageBox.Show("Account created.\n\nUser: " + user + "\n\nEncrypted password: " + pass + "\n\nFirst name: " + name + "\n\nAge: " + age);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong.Please try again!");
                    return;
                }
            }
            catch 
            {
                MessageBox.Show("Something went wrong.Please try again!");
                return;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {
                    string dat = "Data.txt";
                    using (StreamReader sr = new StreamReader(dat))
                    {
                        string linija;
                        while ((linija = sr.ReadLine()) != null)
                        {
                            if (!dict.ContainsKey(txtUsername.Text))
                            {
                                MessageBox.Show("This user does not exist!");
                                return;
                            }
                            else
                            {
                                string[] niz = linija.Split(';');
                                string user = niz[0];
                                if (txtUsername.Text == user)
                                {
                                    string name = niz[2];
                                    string age = niz[3];

                                    string pass = niz[1];
                                    byte[] data = Convert.FromBase64String(pass);
                                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                                    {
                                        byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(hash));
                                        using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider())
                                        {
                                            tripDes.Key = keys;
                                            tripDes.Mode = CipherMode.ECB;
                                            tripDes.Padding = PaddingMode.PKCS7;
                                            ICryptoTransform transform = tripDes.CreateDecryptor();
                                            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                                            pass = Encoding.UTF8.GetString(result);
                                        }
                                    }

                                    if (pass == txtPassword.Text)
                                    {
                                        MessageBox.Show("Account details:\n" + "\nUser: " + user + "\n\nPassword: " + pass + "\n\nFirst name: " + name + "\n\nAge: " + age);
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Password is wrong!");
                                        return;
                                    }
                                }


                            }
                        }
                        sr.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrog.Please try again!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Something went wrog.Please try again!");
                return;
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtAge.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
    }
}
