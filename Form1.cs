namespace Password_Management;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    //Function to show Passowrod
    private void buttonShowPassowrd_Click(object sender, EventArgs e)
    {
        string ausgabe = textBoxWebsite.Text;
        // Text im Label ändern, wenn der Button geklickt wird
        labelOutput.Text = "Website: " + ausgabe + ", Password: Pass321";
    }

    private void buttonEnterShowPassowrd_Click(object sender, KeyEventArgs e)
    {
        // Überprüfen, ob die Eingabetaste (Enter) gedrückt wurde
        if (e.KeyData == Keys.Enter)
        {
            string ausgabe = textBoxWebsite.Text;
            // Text im Label ändern, wenn der Button geklickt wird
            labelOutput.Text = "Website: " + ausgabe + ", Password: Pass321";
        }

    }
    private void ButtonNew_Click(object sender, EventArgs e)
    {
        // Aktion ausführen, wenn die Schaltfläche "Neu" geklickt wird
        MessageBox.Show("Neues Element wurde erstellt!");
    }

    private void OpenSecondaryFormButton_Click(object sender, EventArgs e)
    {
        // Neue Form öffnen
        SecondaryForm secondaryForm = new SecondaryForm();
        secondaryForm.Show();
    }

}
