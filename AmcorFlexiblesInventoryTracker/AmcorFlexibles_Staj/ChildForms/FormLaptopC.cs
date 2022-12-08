using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using DGVPrinterHelper;
using System.Drawing;
namespace AmcorFlexibles_Staj.ChildForms
{
    
    public partial class FormLaptopC : Form
    {
        

        string connectionString = "server = localhost; user id = root;password = Moregorkem123_ ;database = compstock;Allow User Variables=True;";
        public FormLaptopC()
        {            
            InitializeComponent();
            DgvRefresh();
            imageColumnCreate();
            dataGridViewLC.Columns[8].HeaderText = "Details";
            dataGridViewLC.Columns[0].HeaderText = "Model";
            dataGridViewLC.Columns[1].HeaderText = "OS";
            dataGridViewLC.Columns[2].HeaderText = "Machine Name";
            dataGridViewLC.Columns[3].HeaderText = "Serial No";
            dataGridViewLC.Columns[4].HeaderText = "HDD";
            dataGridViewLC.Columns[5].HeaderText = "Memory";
            dataGridViewLC.Columns[6].HeaderText = "Location";
            dataGridViewLC.Columns[7].HeaderText = "Connected";
            dataGridViewLC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FormLaptopC_Load(object sender, EventArgs e)
        {            
        }
        private void Cancel()
        {
            buttonUpdate.Visible = true;
            buttonSave.Visible = false;
            buttonCancel.Visible = false;
            dataGridViewLC.ReadOnly = true;
            buttonInsert.Visible = false;
            buttonDelete.Visible = false;
            countLabelLC.Visible = true;
            panelInsert.Visible = false;
            buttonPrint.Visible = true;
        }

        private void DgvRefresh()
        {

            //
            //Form load (Querye göre table oluşturup dgw pushlayan kod bölümü)
            //
            String commandText = "SELECT  Model, OS, MachineName,SerialNo,HDD,ComputerMemory,Department ,IsConnected " +
                                 "FROM computer c1 INNER JOIN location c2 ON c1.SerialNo = c2.ComputerSerialNo " +
                                 "WHERE IsConnected = TRUE and ComputerType = 'N'";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(commandText, connection);

                connection.Open();

                var dataAdapter = new MySqlDataAdapter(command);
                var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataTable dtRecordDB = new DataTable();
                dataAdapter.Fill(dtRecordDB);
                dataGridViewLC.DataSource = dtRecordDB;
                connection.Close();

            }
            //
            //DataGridView Column Header Düzenlemesi (Görsel)
            //
            

            dataGridViewLC.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewLC.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewLC.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewLC.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewLC.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewLC.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewLC.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewLC.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Count label
            countLabelLC.Text = "Ağa bağlı Notebooklar : " + dataGridViewLC.Rows.Count.ToString();
            Cancel();
        }


        private void DgvUpdate()
        {
            for (int i = 0; i < dataGridViewLC.Rows.Count  ; i++)
            {
                String commandUpdateText = "Update Computer , Location " +
                                     "SET Computer.Model = @v1 , Computer.OS = @v2 , Computer.MachineName = @v3 ," +
                                     "Computer.HDD = @v4 , Computer.ComputerMemory = @v5 , Location.Department = @v6 , computer.Isconnected = @v7 " +
                                     "Where serialno = @v0 and computerserialno = @v0 ";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(commandUpdateText, connection);
                    command.Parameters.Add("@v0", MySqlDbType.VarChar, 50).Value = dataGridViewLC.Rows[i].Cells[4].Value;
                    command.Parameters.Add("@v1", MySqlDbType.VarChar, 50).Value = dataGridViewLC.Rows[i].Cells[1].Value;
                    command.Parameters.Add("@v2", MySqlDbType.VarChar, 50).Value = dataGridViewLC.Rows[i].Cells[2].Value;
                    command.Parameters.Add("@v3", MySqlDbType.VarChar, 50).Value = dataGridViewLC.Rows[i].Cells[3].Value;
                    command.Parameters.Add("@v4", MySqlDbType.Int16, 50).Value = dataGridViewLC.Rows[i].Cells[5].Value;
                    command.Parameters.Add("@v5", MySqlDbType.Int16, 50).Value = dataGridViewLC.Rows[i].Cells[6].Value;
                    command.Parameters.Add("@v6", MySqlDbType.VarChar, 50).Value = dataGridViewLC.Rows[i].Cells[7].Value;
                    command.Parameters.Add("@v7", MySqlDbType.Int16).Value = dataGridViewLC.Rows[i].Cells[8].Value;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                
            }
            DgvRefresh();
        }

        private void DgvDelete()
        {
            DataGridViewRow row = this.dataGridViewLC.SelectedRows[0];
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
                                       "values (@I1 , @I2 , @I3 , 'N' , @I4 , @I5 , @I6 , True )";
            String commandInsertText2 = "INSERT INTO location " +
                                        "(ComputerSerialNo , Department) " +
                                        "values (@I1 , @I7)";
            if(String.IsNullOrEmpty(textBoxInsertSN.Text))
            {
            MessageBox.Show("Lütfen seri numarası giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { 
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

        private void imageColumnCreate()
        {
            DataGridViewImageColumn detailImage = new DataGridViewImageColumn();
            Image img = Image.FromFile("C:/Users/gorke/Desktop/AmcorFlexibles_Staj/AmcorFlexibles_Staj/Resources/employee1.png");

            detailImage.Image = img;
            dataGridViewLC.Columns.Add(detailImage);
            detailImage.Name = "detailImage";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //
            //DataGridview filtreleme sistemi.
            //
            var commandText = "SELECT Model, OS, MachineName,SerialNo,HDD,ComputerMemory,Department , IsConnected " +
                              " FROM Computer c1 INNER JOIN location c2 ON c1.SerialNo = c2.ComputerSerialNo" +
                              " WHERE SerialNo LIKE '%' @N '%'  and " +
                              "MachineName LIKE '%' @N2 '%'  and Model LIKE '%' @N3 '%' and " +
                              "IsConnected = True and ComputerType = 'N' ";

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

                dataGridViewLC.DataSource = dtRecordFiltered;

                connection.Close();

            }

        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            buttonUpdate.Visible = false;
            buttonSave.Visible = true;
            buttonCancel.Visible = true;
            buttonInsert.Visible = true;
            buttonDelete.Visible = true;
            countLabelLC.Visible = false;
            dataGridViewLC.ReadOnly = false;

            this.dataGridViewLC.Columns["SerialNo"].ReadOnly = true;
            buttonPrint.Visible = false;
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
                dataGridViewLC.ReadOnly = true;
                buttonInsert.Visible = false;
                buttonDelete.Visible = false;
                countLabelLC.Visible = true;
                DgvRefresh();

            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewLC.SelectedRows[0];
            string selectedSerial = row.Cells[4].Value.ToString();
            DialogResult dr = MessageBox.Show(selectedSerial +" Seri numaralı kaydı silmek istediğinize emin misiniz?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            
            if (dr == DialogResult.Yes)
            {
                DgvDelete();       
            }
            Cancel();
            DgvRefresh();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panelInsert.Visible = true;
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

            Printer.PrintDataGridView(dataGridViewLC);
        }

        private void dataGridViewLC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                DataGridViewCell cell = dataGridViewLC.SelectedCells[0];
                string columnSerialNo = dataGridViewLC.Rows[cell.RowIndex].Cells[4].Value.ToString();
                detailsForm form = new detailsForm(columnSerialNo);
                form.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewLC.Rows)
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
    }
}
