using System;
using System.Windows.Forms;

namespace Password_Management
{
    public partial class SecondaryForm : Form
    {
        private TextBox textBox;
        private Button button1;
        private Button button2;

        public SecondaryForm()
        {
            //InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // TextBox erstellen
            textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(50, 50);
            textBox.Size = new System.Drawing.Size(200, 50);
            this.Controls.Add(textBox);

            // Button1 erstellen
            button1 = new Button();
            button1.Text = "Button1";
            button1.Location = new System.Drawing.Point(50, 100);
            button1.Size = new System.Drawing.Size(100, 50);
            button1.Click += Button1_Click;
            this.Controls.Add(button1);

            // Button2 erstellen
            button2 = new Button();
            button2.Text = "Button2";
            button2.Location = new System.Drawing.Point(150, 100);
            button2.Size = new System.Drawing.Size(100, 50);
            button2.Click += Button2_Click;
            this.Controls.Add(button2);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button1 clicked");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button2 clicked");
        }
    }
}
