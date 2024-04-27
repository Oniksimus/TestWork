using Aspose.Cells;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Windows.Forms;

namespace TestWork
{
    public partial class TestWork : Form
    {
        public TestWork()
        {
            InitializeComponent();
            openFileDialogExcel.Filter = "Excel files(*.xlsx)|*.xlsx";              // ������
            openFileDialogExcel.InitialDirectory = Environment.CurrentDirectory;    // ���� � ����� �� ���������
        }
        private void buttonExcel_Click(object sender, EventArgs e)
        {
            if (openFileDialogExcel.ShowDialog() == DialogResult.Cancel)    // ����� Excel-�������
                return;
            try
            {
                Workbook wb = new Workbook(openFileDialogExcel.FileName);    // ��������� �������
                Worksheet worksheet = wb.Worksheets[0];
                int rows = worksheet.Cells.MaxDataRow + 1;
                int cols = worksheet.Cells.MaxDataColumn + 1;
                string[] value = new string[cols];

                using (var con = new SqliteConnection("Data Source=TestWork.db"))   // ���������� � ��
                {
                    con.Open();
                    SqliteCommand cmd = new SqliteCommand();
                    cmd.Connection = con;

                    try
                    {
                        cmd.CommandText = "CREATE TABLE 'Days' ('id' INTEGER NOT NULL UNIQUE,'date' TEXT NOT NULL,'name' TEXT NOT NULL," +
                            " 'workinholiday' TEXT,PRIMARY KEY('id' AUTOINCREMENT))";

                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        cmd.CommandText = "DROP TABLE 'Days';";     // ������, ���� ��� ���� ������� 'Days'
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE TABLE 'Days' ('id' INTEGER NOT NULL UNIQUE,'date' TEXT NOT NULL,'name' TEXT NOT NULL," +
                            " 'workinholiday' TEXT,PRIMARY KEY('id' AUTOINCREMENT))";

                        cmd.ExecuteNonQuery();
                    }

                    for (int i = 1; i < rows; i++)  // ���������� ������� 'Days' �� �xcel
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            if (worksheet.Cells[i, j].Value != null)
                            {
                                value[j] = worksheet.Cells[i, j].Value.ToString();
                            }
                            else { value[j] = ""; }
                        }
                        cmd.CommandText = "INSERT INTO Days (date, name, workinholiday) VALUES ('" + String.Join("', '", value) + "')";
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                buttonSolv.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void buttonSolv_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime[] days = Enumerable.Range(1, (int)(dateTimePickerEnd.Value - dateTimePickerBegin.Value).TotalDays).  // �����, ��� ����� �� ��������� ��������� ����
                    Select(d => dateTimePickerBegin.Value.AddDays(d)).ToArray();

                var workdays = new List<DateTime>(days);    // ������� ���, var ��� ��������
                var workinholidays = new List<DateTime>();  // ������ ������� ���� � ��������

                using (var con = new SqliteConnection("Data Source=TestWork.db"))  // �������� ����������� ���� �� ������ ����
                {
                    con.Open();
                    SqliteCommand cmd = new SqliteCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT date, workinholiday FROM 'Days';";
                    cmd.ExecuteNonQuery();
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (workdays.Contains(reader.GetDateTime("date")))  // �������� �� ���������� � ��������� ��������� ���
                                {
                                    if (reader.GetInt32("workinholiday") != 1)
                                    {
                                        workdays.Remove(reader.GetDateTime("date"));
                                    }
                                    else workinholidays.Add(reader.GetDateTime("date"));
                                }
                            }
                        }
                    }
                    con.Close();
                }

                var result = new List<DateTime>(workdays);  // ��������� ������ ��� ��������� ��������� ������ ��� (��� �� �� ������ ������)

                for (int i = 0; i < workdays.Count; i++)
                {
                    if (!workinholidays.Contains(workdays[i]))
                    {
                        if (workdays[i].DayOfWeek == DayOfWeek.Saturday || workdays[i].DayOfWeek == DayOfWeek.Sunday)
                        {
                            result.Remove(workdays[i]);
                        }
                    }
                }
                textBoxWorkD.Text = result.Count.ToString();    // ������� ����������
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void dateTimePickerBegin_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.MinDate = dateTimePickerBegin.Value.AddDays(1);   // ���������� ���, � ������ ���������� ���
        }
        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerBegin.MaxDate = dateTimePickerEnd.Value.AddDays(-1);
        }
    }
}
