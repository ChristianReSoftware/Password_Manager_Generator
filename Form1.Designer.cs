namespace Password_Management;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private ToolStrip toolStrip1;
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label labelOutput;
    private System.Windows.Forms.Button Search;
    private TextBox textBoxWebsite;


    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Password Managementsystem";

        // ToolStrip erstellen
        toolStrip1 = new ToolStrip();
        toolStrip1.Dock = DockStyle.Top;
        

        // Schaltfläche zur ToolStrip hinzufügen
        ToolStripButton buttonNew = new ToolStripButton();
        buttonNew.Text = "New Password";
        buttonNew.Click += OpenSecondaryFormButton_Click;
        toolStrip1.Items.Add(buttonNew);

        ToolStripButton buttonChange = new ToolStripButton();
        buttonChange.Text = "Change Password";
        buttonChange.Click += ButtonNew_Click;
        toolStrip1.Items.Add(buttonChange);


        // Label erstellen und initialisieren
        labelOutput = new Label();
        labelOutput.Text = "Website: example.com, Password: ";
        labelOutput.Location = new System.Drawing.Point(50, 200);
        labelOutput.Size = new System.Drawing.Size(500, 300);

        // Button erstellen
        Search = new Button();
        Search.Text = "Search";
        Search.Location = new System.Drawing.Point(50, 50);
        Search.Size = new System.Drawing.Size(150, 50);

        // Textbox erstellen
        textBoxWebsite = new System.Windows.Forms.TextBox();
        textBoxWebsite.Location = new System.Drawing.Point(50, 100);
        textBoxWebsite.Size = new System.Drawing.Size(350, 100);
        textBoxWebsite.KeyDown += buttonEnterShowPassowrd_Click; // Ereignishandler für KeyDown-Ereignis hinzufügen

        // Addd to controls
        this.Controls.Add(toolStrip1);
        this.Controls.Add(labelOutput);
        this.Controls.Add(Search);
        this.Controls.Add(textBoxWebsite);
        this.Controls.Add(labelOutput);

        // Ereignishandler hinzufügen
        Search.Click += buttonShowPassowrd_Click;
    }

    #endregion
}
