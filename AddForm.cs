using System;
using System.Windows.Forms;

namespace Password_Management
{
    public partial class AddForm : Form
    {
        private TextBox textBox_website;
        private TextBox textBox_passwort;
        private System.Windows.Forms.Label labelPasswort;
        private System.Windows.Forms.Label labelWebsite;
        private Button button1;
        private Button button2;
        private Button button3;
        private PasswordSaveWrite helper;
        private string filePath;
        private int oldLength;
        public AddForm(PasswordSaveWrite passwordSaveWrite, string filePath, int oldLength)
        {
            InitializeComponents();
            this.helper = passwordSaveWrite;
            this.filePath = filePath;
            this.oldLength = oldLength;
        }

        private void InitializeComponents()
        {
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.BackColor = System.Drawing.Color.White;
            this.Text = "Add new Password";

            // TextBoxen erstellen
            textBox_website = new TextBox();
            textBox_website.Location = new System.Drawing.Point(100, 20);
            textBox_website.Size = new System.Drawing.Size(210, 50);
            this.Controls.Add(textBox_website);
            textBox_passwort = new TextBox();
            textBox_passwort.Location = new System.Drawing.Point(100, 60);
            textBox_passwort.Size = new System.Drawing.Size(210, 50);
            this.Controls.Add(textBox_passwort);

            // Label erstellen und initialisieren
            labelWebsite = new Label();
            labelWebsite.Text = "Website";
            labelWebsite.Location = new System.Drawing.Point(10, 20);
            labelWebsite.Size = new System.Drawing.Size(90, 30);
            this.Controls.Add(labelWebsite);
            labelPasswort = new Label();
            labelPasswort.Text = "Passwort";
            labelPasswort.Location = new System.Drawing.Point(10, 60);
            labelPasswort.Size = new System.Drawing.Size(90, 30);
            this.Controls.Add(labelPasswort);

            // Button1 erstellen
            button1 = new Button();
            button1.Text = "Save";
            button1.Location = new System.Drawing.Point(110, 100);
            button1.Size = new System.Drawing.Size(100, 80);
            button1.Click += ButtonSave_Click;
            this.Controls.Add(button1);

            // Button2 erstellen
            button2 = new Button();
            button2.Text = "Cancel";
            button2.Location = new System.Drawing.Point(210, 100);
            button2.Size = new System.Drawing.Size(100, 80);
            button2.Click += ButtonCancel_Click;
            this.Controls.Add(button2);

            // Button2 erstellen
            button3 = new Button();
            button3.Text = "Passwort Generate";
            button3.Location = new System.Drawing.Point(10, 100);
            button3.Size = new System.Drawing.Size(100, 80);
            button3.Click += ButtonGennerate_Click;
            this.Controls.Add(button3);
        }
        // Diese methode dient dazu ein Passowrt zu generieren
        private static string RandomPassword(Random random, int length)
        {
            int num;
            string passwort = "";
            for (int i = 0; i < length; i++)
            {
                num = random.Next(0, 60);
                passwort += $"{(char)('A' + num)}{random.Next(99)}";
                if (i%2==0 && i!=length-1)
                {
                    passwort += "-";
                }
            }
            return passwort;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string ausgabe = textBox_website.Text + textBox_passwort.Text;
            helper.addNewPassWeb(textBox_website.Text,textBox_passwort.Text);
            helper.WriteDataToTxt(filePath, oldLength, true);
            // MessageBox.Show($"Website: {textBox_website.Text}; Passwort: {textBox_passwort.Text} Saved");
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonGennerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string newPass = RandomPassword(random,6);
            textBox_passwort.Text = newPass;
        }
        public PasswordSaveWrite GetPasswordSaveWrite()
        {
            return this.helper;
        }
    }
}
