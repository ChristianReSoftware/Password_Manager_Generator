using System.Runtime.CompilerServices;

namespace Password_Management;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private ToolStrip toolStrip1;
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label labelWebsite;
    private System.Windows.Forms.Button Search;
    private System.Windows.Forms.Button buttonShow;
    private TextBox textBoxWebsite;
    private TextBox textBoxAusgabe_1;
    private TextBox textBoxAusgabe_2;

    private string filePath = "";

    
    


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
        this.BackColor = System.Drawing.Color.White;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(500, 300);
        this.Text = "Password Managementsystem";

        // ToolStrip erstellen
        toolStrip1 = new ToolStrip();
        toolStrip1.Dock = DockStyle.Top;
        

        // Schaltfläche zur ToolStrip hinzufügen
        ToolStripButton buttonOpenDialog = new ToolStripButton();
        buttonOpenDialog.Text = "OpenFile";
        buttonOpenDialog.Click += OpenFileButton_Click;
        toolStrip1.Items.Add(buttonOpenDialog);

        ToolStripButton buttonNew = new ToolStripButton();
        buttonNew.Text = "New Password";
        buttonNew.Click += OpenAddFormButton_Click;
        toolStrip1.Items.Add(buttonNew);

        ToolStripButton buttonChange = new ToolStripButton();
        buttonChange.Text = "Change Password";
        buttonChange.Click += OpenChangeFormButton_Click;
        toolStrip1.Items.Add(buttonChange);

        // Button erstellen
        Search = new Button();
        Search.Text = "Search";
        Search.Location = new System.Drawing.Point(100, 100);
        Search.Size = new System.Drawing.Size(150, 50);
        Search.Click += ButtonShowPassowrd_Click;

        buttonShow = new Button();
        buttonShow.Text = "Show Pass";
        buttonShow.Location = new System.Drawing.Point(300, 100);
        buttonShow.Size = new System.Drawing.Size(150, 50);
        buttonShow.Click += ButtonShowAll_Click;

        // Label erstellen 
        labelWebsite = new System.Windows.Forms.Label();
        labelWebsite.Location = new System.Drawing.Point(10,50);
        labelWebsite.Size = new System.Drawing.Size(90,50);
        labelWebsite.Text = "Website";

        // Textbox erstellen
        textBoxWebsite = new System.Windows.Forms.TextBox();
        textBoxWebsite.Location = new System.Drawing.Point(100, 50);
        textBoxWebsite.Size = new System.Drawing.Size(200, 50);
        textBoxWebsite.KeyDown += ButtonEnterShowPassowrd_Click; // Ereignishandler für KeyDown-Ereignis hinzufügen

        textBoxAusgabe_1 = new System.Windows.Forms.TextBox();
        textBoxAusgabe_1.ReadOnly = true;
        textBoxAusgabe_1.BorderStyle = BorderStyle.None;
        textBoxAusgabe_1.BackColor = System.Drawing.Color.White;
        textBoxAusgabe_1.Location = new System.Drawing.Point(10, 170);
        textBoxAusgabe_1.Size = new System.Drawing.Size(200, 50);
        textBoxAusgabe_1.Text = ($"Website:");

        textBoxAusgabe_2 = new System.Windows.Forms.TextBox();
        textBoxAusgabe_2.ReadOnly = true;
        textBoxAusgabe_2.BorderStyle = BorderStyle.None;
        textBoxAusgabe_2.BackColor = System.Drawing.Color.White;
        textBoxAusgabe_2.Location = new System.Drawing.Point(10, 200);
        textBoxAusgabe_2.Size = new System.Drawing.Size(400, 50);
        textBoxAusgabe_2.Text = ("Password:");
        

        // Addd to controls
        this.Controls.Add(toolStrip1);
        this.Controls.Add(Search);
        this.Controls.Add(buttonShow);
        this.Controls.Add(textBoxWebsite);
        this.Controls.Add(textBoxAusgabe_1);
        this.Controls.Add(textBoxAusgabe_2);
        this.Controls.Add(labelWebsite);

        
    }

    #endregion
}
