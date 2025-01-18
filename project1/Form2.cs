using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DocumentControl
{
    public partial class AddDocumentForm : Form
    {
        public AddDocumentForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.managerComboBox = new System.Windows.Forms.ComboBox();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Items.AddRange(new object[] {
            "ОК",
            "ОО",
            "АР"});
            this.departmentComboBox.Location = new System.Drawing.Point(12, 12);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(121, 21);
            this.departmentComboBox.TabIndex = 0;
            // 
            // managerComboBox
            // 
            this.managerComboBox.FormattingEnabled = true;
            this.managerComboBox.Location = new System.Drawing.Point(12, 39);
            this.managerComboBox.Name = "managerComboBox";
            this.managerComboBox.Size = new System.Drawing.Size(121, 21);
            this.managerComboBox.TabIndex = 1;
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(12, 66);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(121, 21);
            this.employeeComboBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 93);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddDocumentForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.managerComboBox);
            this.Controls.Add(this.departmentComboBox);
            this.Name = "AddDocumentForm";
            this.Text = "Добавление документа";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.ComboBox managerComboBox;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.Button addButton;

        private void addButton_Click(object sender, EventArgs e)
        {
            // Добавление нового документа в базу данных
            string connectionString = "your_connection_string_here";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Documents (Department, Manager, Employee) VALUES (@Department, @Manager, @Employee)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Department", departmentComboBox.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Manager", managerComboBox.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Employee", employeeComboBox.SelectedItem.ToString());
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            this.Close();
        }
    }
}