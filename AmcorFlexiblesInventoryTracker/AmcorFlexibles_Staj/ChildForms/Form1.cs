using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace AmcorFlexibles_Staj
{
    
    public partial class Form1 : Form
    {
        string connectionString = "server = localhost; user id = root;password = Moregorkem123_ ;database = compstock;Allow User Variables=True;";
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = string.Empty;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void OpenChildForm(Form childForm , object btnSender)   
        {
            
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Add(childForm);
            this.panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CircularCalculator();
            buttonCloseCForm.Visible = false;
        }

        private void CircularCalculator()
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                String commandText = "Select COUNT(SerialNo) as NumberOfConnectedNotebooks From Computer Where IsConnected = 1 and ComputerType = 'N' ";
                MySqlCommand command = new MySqlCommand(commandText, connection);

                connection.Open();

                var dataAdapter = new MySqlDataAdapter(command);
                var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataTable dtRecordDB = new DataTable();
                dataAdapter.Fill(dtRecordDB);
                chart1.Series["s1"].IsValueShownAsLabel = true;
                chart1.Series["s1"].ToolTip = "VALX , #VAL";
                chart1.Series["s1"].Points.AddXY("1", Int32.Parse(dtRecordDB.Rows[0][0].ToString()));
                /***********************************************************************************************************************************/
                String commandText2 = "Select COUNT(SerialNo) as NumberOfConnectedDesktops From Computer Where IsConnected = 1 and ComputerType = 'D' ";
                MySqlCommand command2 = new MySqlCommand(commandText2, connection);

                var dataAdapter2 = new MySqlDataAdapter(command2);
                var commandBuilder2 = new MySqlCommandBuilder(dataAdapter2);
                DataTable dtRecordDB2 = new DataTable();
                dataAdapter2.Fill(dtRecordDB2);
                chart1.Series["s1"].Points.AddXY("2", Int32.Parse(dtRecordDB2.Rows[0][0].ToString()));
                /***********************************************************************************************************************************/
                String commandText3 = "Select COUNT(SerialNo) as NumberOfNConnectedDesktops From Computer Where IsConnected = 0 and ComputerType = 'D' ";
                MySqlCommand command3 = new MySqlCommand(commandText3, connection);

                var dataAdapter3 = new MySqlDataAdapter(command3);
                var commandBuilder3 = new MySqlCommandBuilder(dataAdapter3);
                DataTable dtRecordDB3 = new DataTable();
                dataAdapter3.Fill(dtRecordDB3);
                chart1.Series["s1"].Points.AddXY("3", Int32.Parse(dtRecordDB3.Rows[0][0].ToString()));
                /***********************************************************************************************************************************/

                String commandText4 = "Select COUNT(SerialNo) as NumberOfNConnectedNotebooks From Computer Where IsConnected = 0 and ComputerType = 'N' ";
                MySqlCommand command4 = new MySqlCommand(commandText4, connection);

                var dataAdapter4 = new MySqlDataAdapter(command4);
                var commandBuilder4 = new MySqlCommandBuilder(dataAdapter4);
                DataTable dtRecordDB4 = new DataTable();
                dataAdapter4.Fill(dtRecordDB4);
                chart1.Series["s1"].Points.AddXY("4", Int32.Parse(dtRecordDB4.Rows[0][0].ToString()));

                /***********************************************************************************************************************************/
                String commandText5 = "Select COUNT(ComputerSerialNo) as NumberOfComps From State Where IsBroken = 1 ";
                MySqlCommand command5 = new MySqlCommand(commandText5, connection);

                var dataAdapter5 = new MySqlDataAdapter(command5);
                var commandBuilder5 = new MySqlCommandBuilder(dataAdapter5);
                DataTable dtRecordDB5 = new DataTable();
                dataAdapter5.Fill(dtRecordDB5);
                chart2.Series["s1"].AxisLabel = "Comps";
                chart2.Series["s1"].Points.AddXY("#PERCENT", Int32.Parse(dtRecordDB5.Rows[0][0].ToString()));
                /***********************************************************************************************************************************/

                String commandText6 = "Select COUNT(ComputerSerialNo) as NumberOfBrokens From State Where IsBroken = 0 ";
                MySqlCommand command6 = new MySqlCommand(commandText6, connection);

                var dataAdapter6 = new MySqlDataAdapter(command6);
                var commandBuilder6 = new MySqlCommandBuilder(dataAdapter6);
                DataTable dtRecordDB6 = new DataTable();
                dataAdapter6.Fill(dtRecordDB6);
                chart2.Series["s1"].Points.AddXY("CompsArızalı", Int32.Parse(dtRecordDB6.Rows[0][0].ToString()));

            }
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDesktopC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.FormDesktopC() , sender);
            buttonCloseCForm.Visible = true;
        }

        private void btnLaptopC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.FormLaptopC(), sender);
            buttonCloseCForm.Visible = true;
        }

        private void btnDesktopNC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.DesktopNC(), sender);
            buttonCloseCForm.Visible = true;
        }

        private void btnLaptopNC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.LaptopNC(), sender);
            buttonCloseCForm.Visible = true;
        }

        private void buttonCloseCForm_Click(object sender, EventArgs e)
        {
            if (ActiveForm != null)
                activeForm.Close();

            Reset();    
        }

        private void Reset()
        {
            buttonCloseCForm.Visible = false;
            labelTitle.Text = "Anasayfa";
        }
    }  
}
