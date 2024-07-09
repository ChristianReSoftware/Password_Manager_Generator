namespace Password_Management;

public partial class Form1 : Form
{
    public PasswordSaveWrite passwordSaveWrite = new PasswordSaveWrite();
    AddForm addForm;
    ChangePassForm changePassForm;
    int oldLength;
    public Form1()
    {
        InitializeComponent();
        this.Load += Form1_Load;
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        // Hier wird das Auswählen der Datenbank direkt nach dem start der App gestartet
        ChoseDataBase();
        passwordSaveWrite.setLists(passwordSaveWrite.getData(filePath));
        oldLength = passwordSaveWrite.getLength();
    }
    // Function to show Passowrod
    private void ButtonShowPassowrd_Click(object sender, EventArgs e)
    {
        string ausgabe = textBoxWebsite.Text;
        string ausgabe2= passwordSaveWrite.SearchPass(ausgabe, filePath);
        // Text im Label ändern, wenn der Button geklickt wird
        textBoxAusgabe_1.Text = $"Website: {ausgabe}";
        textBoxAusgabe_2.Text = $"Password: {ausgabe2}";
    }
    private void ButtonEnterShowPassowrd_Click(object sender, KeyEventArgs e)
    {
        // Überprüfen, ob die Eingabetaste (Enter) gedrückt wurde
        if (e.KeyData == Keys.Enter)
        {
            string ausgabe = textBoxWebsite.Text;
            // Text im Label ändern, wenn der Button geklickt wird
            textBoxAusgabe_1.Text = $"Website: {ausgabe}";
            textBoxAusgabe_2.Text = $"Password: Pass321";
        }

    }
    private void ButtonShowAll_Click(object sender, EventArgs e)
    {
        passwordSaveWrite.showPass();
    }
    private void ButtonNew_Click(object sender, EventArgs e)
    {
        // Aktion ausführen, wenn die Schaltfläche "Neu" geklickt wird
        MessageBox.Show("Neues Element wurde erstellt!");
    }
    private void OpenChangeFormButton_Click(object sender, EventArgs e)
    {
        this.changePassForm = new ChangePassForm(passwordSaveWrite,filePath);
        changePassForm.Show();
    }
    private void OpenAddFormButton_Click(object sender, EventArgs e)
    {
        if (filePath != "")
        {
            // Neue Form öffnen
            this.addForm = new AddForm(passwordSaveWrite, filePath, oldLength);
            addForm.Show();
        }
        else
        {
            MessageBox.Show("Need to Select the database");
        }

    }
    private void OpenFileButton_Click(object sender, EventArgs e)
    {
        ChoseDataBase();
    }

    private void ChoseDataBase()
    {
        // OpenFileDialog erstellen
        OpenFileDialog openFileDialog = new OpenFileDialog();

        // Filter festlegen (optional)
        openFileDialog.Filter = "Textdateien (*.txt)|*.txt|CSVdateien (*.csv)|*.csv";

        // Dialog anzeigen und Ergebnis prüfen
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            // Gewählte Datei verarbeiten
            filePath = openFileDialog.FileName;
            // Debug
            // MessageBox.Show("Gewählte Datenbank: " + filePath);
        }
    }
}
