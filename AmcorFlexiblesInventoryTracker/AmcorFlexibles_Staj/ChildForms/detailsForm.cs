using AmcorFlexibles_Staj.ChildForms;
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


namespace AmcorFlexibles_Staj
{
    
    public partial class detailsForm : Form
    {
        string connectionString = "server = localhost; user id = root;password = Moregorkem123_ ;database = compstock;Allow User Variables=True;";
        public detailsForm(string columnSerialNo)
        {
            
            InitializeComponent();
            string selectedColumnSerialNo = columnSerialNo;
            this.Text = selectedColumnSerialNo;
            label1.Text = selectedColumnSerialNo;
            

        }
        
        private void detailsForm_Load(object sender, EventArgs e)
        {

            Details details = new Details(label1.Text);

            notTextBox.Text = details.Note;
            labelBillDate.Text                   = ": " + details.BillDate;
            labelBillChangeDate.Text             = ": " + details.BillChangeDate;
            labelBillNo.Text                     = ": " + details.BillNo.ToString();
            labelUsername.Text                   = ": " + details.Username;
            labelFirstUser.Text                  = ": " + details.FirstUser;
            labelDockStationSerialNo.Text        = ": " + details.DockStationSerialNo;
            labelDockStationAdapterSerialNo.Text = ": " + details.DockStationAdapterSerialNo;
            labelMonitorModel.Text               = ": " + details.MonitorModel;
            labelMonitorSerialNo.Text            = ": " + details.MonitorSerialNo;
            labelPrinterModel.Text               = ": " + details.PrinterModel;
            labelTcpIP.Text                      = ": " + details.TcpIp;
            labelMsOffice.Text                   = ": " + details.Msoffice;
            labelKlavyeSerialNo.Text             = ": " + details.KlavyeSerialNo;
            labelMouseSerialNo.Text              = ": " + details.MouseSerialNo;
            labelAdapterSerialNo.Text            = ": " + details.AdapterSerialNo;

            if(details.IsBroken == true)
            {
                checkBoxArizalimi.Checked = true;
            }
            else
            {
                checkBoxArizalimi.Checked = false;
            }
        }

        private void checkBoxArizalimi_CheckedChanged(object sender, EventArgs e)
        {
            
            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string commandArizalimiText;
                if (checkBoxArizalimi.Checked == true)
                {
                    commandArizalimiText = "UPDATE State Set IsBroken = 1 Where ComputerSerialNo = @SerialNo";
                }
                else
                {
                    commandArizalimiText = "UPDATE State Set IsBroken = 0 Where ComputerSerialNo = @SerialNo";
                }
                MySqlCommand command = new MySqlCommand(commandArizalimiText, connection);
                command.Parameters.Add("@SerialNo", MySqlDbType.Text).Value = label1.Text;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string commandPushText;

                commandPushText = "UPDATE State Set Note = @text Where ComputerSerialNo = @SerialNo";


                MySqlCommand command = new MySqlCommand(commandPushText, connection);
                command.Parameters.Add("@SerialNo", MySqlDbType.Text).Value = label1.Text;
                command.Parameters.Add("@text", MySqlDbType.Text).Value = notTextBox.Text;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
