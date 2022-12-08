using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DGVPrinterHelper;
using System.Threading.Tasks;
using System.Threading;

namespace AmcorFlexibles_Staj.ChildForms
{
    public partial class LaptopNC : Form
    {
        string connectionString = "server = localhost; user id = root;password = Moregorkem123_ ;database = compstock;Allow User Variables=True;";
        public LaptopNC()
        {
            InitializeComponent();
            DgvRefresh();
            imageColumnCreate();
            //
            //DataGridView Column Header Düzenlemesi (Görsel)
            //
            dataGridViewLNC.Columns[0].HeaderText = "Model";
            dataGridViewLNC.Columns[1].HeaderText = "OS";
            dataGridViewLNC.Columns[2].HeaderText = "Machine Name";
            dataGridViewLNC.Columns[3].HeaderText = "Serial No";
            dataGridViewLNC.Columns[4].HeaderText = "HDD";
            dataGridViewLNC.Columns[5].HeaderText = "Memory";
            dataGridViewLNC.Columns[6].HeaderText = "Location";
            dataGridViewLNC.Columns[7].HeaderText = "Connected";
            dataGridViewLNC.Columns[8].HeaderText = "Details";
            dataGridViewLNC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void LaptopNC_Load(object sender, EventArgs e)
        {

        }
        private void DgvRefresh()
        {

            //
            //Form load (Querye göre table oluşturup dgw pushlayan kod bölümü)
            //
            String commandText = "SELECT  Model, OS, MachineName,SerialNo,HDD,ComputerMemory,Department,IsConnected " +
                                 "FROM computer c1 INNER JOIN location c2 ON c1.SerialNo = c2.ComputerSerialNo " +
                                 "WHERE IsConnected = FALSE and ComputerType = 'N'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(commandText, connection);
                connection.Open();

                var dataAdapter = new MySqlDataAdapter(command);
                var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataTable dtRecordDB = new DataTable();
                dataAdapter.Fill(dtRecordDB);
                dataGridViewLNC.DataSource = dtRecordDB;
                connection.Close();

            }



            //Count label
            countLabelLC.Text = "Ağa bağlı olmayan Notebooklar : " + dataGridViewLNC.Rows.Count.ToString();

            dataGridViewLNC.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewLNC.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewLNC.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewLNC.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewLNC.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewLNC.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewLNC.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewLNC.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;


        }

        private void DgvUpdate()
        {
            for (int i = 0; i < dataGridViewLNC.Rows.Count; i++)
            {
                String commandUpdateText = "Update Computer , Location " +
                                     "SET Computer.Model = @v1 , Computer.OS = @v2 , Computer.MachineName = @v3 ," +
                                     "Computer.HDD = @v4 , Computer.ComputerMemory = @v5 , Location.Department = @v6,Computer.IsConnected = @v7  " +
                                     "Where serialno = @v0 and computerserialno = @v0 ";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(commandUpdateText, connection);
                    command.Parameters.Add("@v0", MySqlDbType.VarChar, 50).Value = dataGridViewLNC.Rows[i].Cells[4].Value;
                    command.Parameters.Add("@v1", MySqlDbType.VarChar, 50).Value = dataGridViewLNC.Rows[i].Cells[1].Value;
                    command.Parameters.Add("@v2", MySqlDbType.VarChar, 50).Value = dataGridViewLNC.Rows[i].Cells[2].Value;
                    command.Parameters.Add("@v3", MySqlDbType.VarChar, 50).Value = dataGridViewLNC.Rows[i].Cells[3].Value;
                    command.Parameters.Add("@v4", MySqlDbType.Int16, 50).Value = dataGridViewLNC.Rows[i].Cells[5].Value;
                    command.Parameters.Add("@v5", MySqlDbType.Int16, 50).Value = dataGridViewLNC.Rows[i].Cells[6].Value;
                    command.Parameters.Add("@v6", MySqlDbType.VarChar, 50).Value = dataGridViewLNC.Rows[i].Cells[7].Value;
                    command.Parameters.Add("@v7", MySqlDbType.Int16).Value = dataGridViewLNC.Rows[i].Cells[8].Value;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    
                }
            }
        }

        private void DgvDelete()
        {
            DataGridViewRow row = this.dataGridViewLNC.SelectedRows[0];
            string selectedSerial = row.Cells[3].Value.ToString();
            String commandDeleteText = "DELETE C1 , L1 FROM COMPUTER C1 " +
                                        "INNER JOIN Location L1 " +
                                        "on C1.SerialNo = L1.ComputerSerialNo " +
                                        "WHERE SerialNo = @s1";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(commandDeleteText, connection);
                command.Parameters.Add("@s1", MySqlDbType.VarChar, 200).Value = selectedSerial;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void DgvInsert()
        {
            String commandInsertText = "INSERT INTO computer " +
                                       "(SerialNo , MachineName , Model , ComputerType , OS , HDD , ComputerMemory , Isconnected) " +
                                       "values (@I1 , @I2 , @I3 , 'N' , @I4 , @I5 , @I6 , False )";
            String commandInsertText2 = "INSERT INTO location " +
                                        "(ComputerSerialNo , Department) " +
                                        "values (@I1 , @I7)";
            if (String.IsNullOrEmpty(textBoxInsertSN.Text))
            {
                MessageBox.Show("Lütfen seri numarası giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(commandInsertText, connection);
                    MySqlCommand command2 = new MySqlCommand(commandInsertText2, connection);

                    command.Parameters.Add("@I1", MySqlDbType.VarChar, 200).Value = textBoxInsertSN.Text;
                    command.Parameters.Add("@I2", MySqlDbType.VarChar, 200).Value = textBoxInsertMN.Text;
                    command.Parameters.Add("@I3", MySqlDbType.VarChar, 200).Value = textBoxInsertMdN.Text;
                    command.Parameters.Add("@I4", MySqlDbType.VarChar, 200).Value = textBoxInsertOS.Text;
                    command.Parameters.Add("@I5", MySqlDbType.Int16, 200).Value = textBoxInsertHDD.Text;
                    command.Parameters.Add("@I6", MySqlDbType.Int16, 200).Value = textBoxInsertMemory.Text;
                    command2.Parameters.Add("@I1", MySqlDbType.VarChar, 200).Value = textBoxInsertSN.Text;
                    command2.Parameters.Add("@I7", MySqlDbType.VarChar, 200).Value = textBoxInsertLocation.Text;


                    connection.Open();
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    connection.Close();
                    Cancel();
                    DgvRefresh();
                }
            }
        }

        private void Cancel()
        {
            buttonUpdate.Visible = true;
            buttonSave.Visible = false;
            buttonCancel.Visible = false;
            dataGridViewLNC.ReadOnly = true;
            buttonInsert.Visible = false;
            buttonDelete.Visible = false;
            countLabelLC.Visible = true;
            panelInsert.Visible = false;
            buttonPrint.Visible = true;

        }

        private void imageColumnCreate()
        {
            DataGridViewImageColumn detailImage = new DataGridViewImageColumn();
            Image img = Image.FromFile("C:/Users/gorke/Desktop/AmcorFlexibles_Staj/AmcorFlexibles_Staj/Resources/employee1.png");

            detailImage.Image = img;
            dataGridViewLNC.Columns.Add(detailImage);
            detailImage.Name = "detailImage";
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //
            //DataGridview filtreleme sistemi.
            //
            var commandText = "SELECT Model, OS, MachineName,SerialNo,HDD,ComputerMemory,Department,IsConnected " +
                              " FROM Computer c1 INNER JOIN location c2 ON c1.SerialNo = c2.ComputerSerialNo" +
                              " WHERE SerialNo LIKE '%' @N '%'  and " +
                              "MachineName LIKE '%' @N2 '%'  and Model LIKE '%' @N3 '%' and " +
                              "IsConnected = FALSE and ComputerType = 'N' ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(commandText, connection);

                command.Parameters.Add("@N", MySqlDbType.VarChar, 50).Value = textBox1.Text;
                command.Parameters.Add("@N2", MySqlDbType.VarChar, 50).Value = textBox2.Text;
                command.Parameters.Add("@N3", MySqlDbType.VarChar, 50).Value = textBox3.Text;
                connection.Open();

                var dataAdapter = new MySqlDataAdapter(command);
                var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataTable dtRecordFiltered = new DataTable();
                dataAdapter.Fill(dtRecordFiltered);

                dataGridViewLNC.DataSource = dtRecordFiltered;

                connection.Close();

            }
            
        }
        
       
        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Değişiklikleri kaydetmek istediğine emin misin?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                DgvUpdate();
                buttonUpdate.Visible = true;
                buttonSave.Visible = false;
                buttonCancel.Visible = false;
                dataGridViewLNC.ReadOnly = true;
                buttonInsert.Visible = false;
                buttonDelete.Visible = false;
                label2.Visible = true;
                DgvRefresh();

            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panelInsert.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewLNC.SelectedRows[0];
            string selectedSerial = row.Cells[3].Value.ToString();
            DialogResult dr = MessageBox.Show(selectedSerial + " Seri numaralı kaydı silmek istediğinize emin misiniz?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                DgvDelete();
            }
            DgvRefresh();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            buttonUpdate.Visible = false;
            buttonSave.Visible = true;
            buttonCancel.Visible = true;
            buttonInsert.Visible = true;
            buttonDelete.Visible = true;
            countLabelLC.Visible = false;
            buttonPrint.Visible = false;
            dataGridViewLNC.ReadOnly = false;
            this.dataGridViewLNC.Columns["SerialNo"].ReadOnly = true;
        }

        private void buttonInsert2_Click(object sender, EventArgs e)
        {
            DgvInsert();
            panel2.Visible = false;
            panelInsert.Visible = false;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter Printer = new DGVPrinter();

            Printer.Title = "Compstock Report";

            Printer.SubTitle = "";

            Printer.SubTitleFormatFlags = System.Drawing.StringFormatFlags.LineLimit | System.Drawing.StringFormatFlags.NoClip;

            Printer.PageNumbers = true;

            Printer.PageNumberInHeader = false;

            Printer.PorportionalColumns = true;

            Printer.HeaderCellAlignment = System.Drawing.StringAlignment.Near;

            Printer.Footer = "AMCOR FLEXIBLES";

            Printer.FooterSpacing = 15;

            Printer.PrintDataGridView(dataGridViewLNC);
        }

        private void dataGridViewLNC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                DataGridViewCell cell = dataGridViewLNC.SelectedCells[0];
                string columnSerialNo = dataGridViewLNC.Rows[cell.RowIndex].Cells[4].Value.ToString();
                detailsForm form = new detailsForm(columnSerialNo);
                form.Show();
               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewLNC.Rows)
            {
                Details dty = new Details(row.Cells[4].Value.ToString());
                if (dty.IsBroken == true)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(191, 191, 201);
                }
            }
        }

        private void dataGridViewLNC_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;

            string txt = "Hatalı " + dataGridViewLNC.Columns[e.ColumnIndex].HeaderText + " girişi. " + "\n\n" + e.Exception.Message;
            MessageBox.Show(txt, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            e.Cancel = false;
        }
    }
}
