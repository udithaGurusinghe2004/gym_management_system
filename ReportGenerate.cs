using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace gym_management_system
{
    public partial class ReportGenerate : Form
    {
        // Replace this with your actual connection string
        private string connectionString = "Data Source=LAPTOP-LSVNQANK\\SQLEXPRESS;Initial Catalog=GymManagementSystem;Integrated Security=True";


        public ReportGenerate()
        {
            InitializeComponent();
            // Required for QuestPDF 2022+
            QuestPDF.Settings.License = LicenseType.Community;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // 1. Fetch the data
            DataTable memberData = GetGymData("SELECT * FROM Member");

            if (memberData.Rows.Count == 0)
            {
                MessageBox.Show("No records found in database.");
                return;
            }

            // 2. Open the file save window
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // 3. Generate the PDF
                GeneratePdfReport(memberData, sfd.FileName);
                MessageBox.Show("Report generated successfully!");
            }
        }

        public DataTable GetGymData(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public void GeneratePdfReport(DataTable data, string filePath)
        {
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Header().Text("Gym Management Report").FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);
                    page.Margin(20);
                    page.Content().PaddingVertical(10).Table(table =>
                    {
                        // Define columns
                        table.ColumnsDefinition(columns =>
                        {
                            foreach (DataColumn column in data.Columns)
                                columns.RelativeColumn();
                        });

                        // Header
                        table.Header(header =>
                        {
                            foreach (DataColumn column in data.Columns)
                                header.Cell()
                                    .Border(1)
                                    .Background(Colors.Blue.Lighten3)
                                    .Padding(5)
                                    .Text(column.ColumnName)
                                    .SemiBold();
                        });

                        // Rows
                        foreach (DataRow row in data.Rows)
                        {
                            foreach (var item in row.ItemArray)
                                table.Cell().Border(1).Padding(5).Text(item.ToString());
                        }
                    });
                });
            }).GeneratePdf(filePath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReportGenerate_Load(object sender, EventArgs e)
        {

        }
    }
}