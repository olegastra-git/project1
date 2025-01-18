using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DocumentControl
{
    public partial class ArchiveForm : Form
    {
        public ArchiveForm()
        {
            InitializeComponent();
            LoadDocuments();
        }

        private void InitializeComponent()
        {
            this.documentsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.documentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // documentsGridView
            // 
            this.documentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.documentsGridView.Location = new System.Drawing.Point(12, 12);
            this.documentsGridView.Name = "documentsGridView";
            this.documentsGridView.Size = new System.Drawing.Size(760, 437);
            this.documentsGridView.TabIndex = 0;
            // 
            // ArchiveForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.documentsGridView);
            this.Name = "ArchiveForm";
            this.Text = "Архив документов";
            ((System.ComponentModel.ISupportInitialize)(this.documentsGridView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView documentsGridView;

        private void LoadDocuments()
        {
            // Подключение к базе данных и загрузка документов
            string connectionString = "your_connection_string_here";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Documents";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                documentsGridView.DataSource = dataTable;
            }
        }
    }
}