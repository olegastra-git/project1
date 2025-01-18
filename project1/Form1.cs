using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DocumentControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.archiveButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // archiveButton
            // 
            this.archiveButton.Location = new System.Drawing.Point(12, 12);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(75, 23);
            this.archiveButton.TabIndex = 0;
            this.archiveButton.Text = "Архив";
            this.archiveButton.UseVisualStyleBackColor = true;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(93, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.archiveButton);
            this.Name = "Form1";
            this.Text = "Document Control";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button archiveButton;
        private System.Windows.Forms.Button addButton;

        private void archiveButton_Click(object sender, EventArgs e)
        {
            // Открытие окна архива
            ArchiveForm archiveForm = new ArchiveForm();
            archiveForm.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Открытие окна добавления документа
            AddDocumentForm addDocumentForm = new AddDocumentForm();
            addDocumentForm.ShowDialog();
        }
    }
}