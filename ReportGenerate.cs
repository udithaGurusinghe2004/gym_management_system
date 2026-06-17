using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace gym_management_system
{
    public partial class ReportGenerate : Form
    {
        private static readonly string ConnectionString =
            "Data Source=LAPTOP-LSVNQANK\\SQLEXPRESS;Initial Catalog=GymManagementSystem;Integrated Security=True";

        public object Document { get; private set; }

        public ReportGenerate()
        {
            InitializeComponent();
        }

        private void ReportGenerate_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = GetData("SELECT * FROM NewStaff");
                string path = BuildPdf(table, "Staff List Report", "StaffReport");
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(path) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not generate staff report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMemberReport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = GetData("SELECT * FROM Member");
                string path = BuildPdf(table, "Member Report", "MemberReport");
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(path) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not generate member report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GetData(string query)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        private string BuildPdf(DataTable table, string title, string fileNamePrefix)
        {
            if (table.Rows.Count == 0)
                throw new InvalidOperationException("No records found to include in the report.");

            string folder = Path.Combine(Application.StartupPath, "Reports");
            Directory.CreateDirectory(folder);

            string filePath = Path.Combine(folder, $"{fileNamePrefix}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");

            object generatedDocument = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4.Landscape());
                    page.Margin(30);
                    page.DefaultTextStyle(x => x.FontSize(9));

                    page.Header().Column(col =>
                    {
                        col.Item().Text(title).FontSize(18).Bold();
                        col.Item().PaddingTop(2).Text($"Generated on {DateTime.Now:dd MMM yyyy, hh:mm tt}")
                            .FontSize(9).FontColor(Colors.Grey.Darken1);
                    });

                    page.Content().PaddingVertical(10).Table(tbl =>
                    {
                        tbl.ColumnsDefinition(columns =>
                        {
                            foreach (DataColumn dc in table.Columns)
                                columns.RelativeColumn();
                        });

                        tbl.Header(header =>
                        {
                            foreach (DataColumn dc in table.Columns)
                            {
                                header.Cell().Background(Colors.Grey.Lighten3).Padding(4)
                                    .Text(dc.ColumnName).Bold();
                            }
                        });

                        foreach (DataRow row in table.Rows)
                        {
                            foreach (var value in row.ItemArray)
                            {
                                tbl.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten2)
                                    .Padding(4).Text(value?.ToString() ?? "");
                            }
                        }
                    });

                    page.Footer().AlignCenter().Text(t =>
                    {
                        t.Span("Page ");
                        t.CurrentPageNumber();
                        t.Span(" of ");
                        t.TotalPages();
                    });
                });
            }).GeneratePdf(filePath);

            return filePath;
        }
    }
}