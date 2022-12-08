using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace AmcorFlexibles_Staj
{
    class Details
    {
        private string columnSerialNo;
        private string username;
        private string monitorModel;
        private string printerModel;
        private string tcpIp;
        private string msoffice;
        private string billDate;
        private string billChangeDate;
        private string billNo;
        private string firstUser;
        private string monitorSerialNo;
        private string klavyeSerialNo;
        private string mouseSerialNo;
        private string adapterSerialNo;
        private string dockStationSerialNo;
        private string dockStationAdapterSerialNo;
        private string note;
        public bool IsBroken;
        string connectionString = "server = localhost; user id = root;password = Moregorkem123_ ;database = compstock;Allow User Variables=True;";

        public Details(string columnSerialNo)
        {
            this.columnSerialNo = columnSerialNo;
            string commandText = "SELECT bill.BillNo ," +
                                 "bill.BillDate , bill.BillChangeDate , user.UserName , user.FirstUser , " +
                                 "dock.DockStationSerialNo , dock.DockStationAdapterSerialNo , monitor.MonitorModel , " +
                                 "monitor.MonitorSerialNo , component.PrinterModel , Component.TcpIP , component.MsOffice , " +
                                 "component.KeyboardSerialNo , component.MouseSerialNo , component.AdapterSerialNo , State.IsBroken , State.Note " +
                                 "FROM  bill " +
                                 "LEFT JOIN user on bill.ComputerSerialNo = user.SerialNo " +
                                 "LEFT JOIN dock on bill.ComputerSerialNo = dock.ComputerSerialNo " +
                                 "LEFT JOIN monitor on bill.ComputerSerialNo = monitor.ComputerSerialNo " +
                                 "LEFT JOIN component on bill.ComputerSerialNo = component.ComputerSerialNo " +
                                 "LEFT JOIN state on bill.ComputerSerialNo = State.ComputerSerialNo " +
                                 "Where bill.ComputerSerialNo = @columnSerialNo ";                                 

           
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(commandText, connection);
                command.Parameters.Add("@columnSerialNo", MySqlDbType.VarChar, 200).Value = columnSerialNo;
                connection.Open();

                var dataAdapter = new MySqlDataAdapter(command);
                var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataSet dtRecordDB = new DataSet();
                dataAdapter.Fill(dtRecordDB);

                
                connection.Close();
                foreach (DataRow dr in dtRecordDB.Tables[0].Rows)
                {
                    this.BillDate= dtRecordDB.Tables[0].Rows[0]["BillDate"].ToString();
                    this.BillNo =  dtRecordDB.Tables[0].Rows[0]["BillNo"].ToString();
                    this.BillChangeDate = dtRecordDB.Tables[0].Rows[0]["BillChangeDate"].ToString();
                    this.Username = dtRecordDB.Tables[0].Rows[0]["UserName"].ToString();
                    this.FirstUser = dtRecordDB.Tables[0].Rows[0]["FirstUser"].ToString();
                    this.DockStationSerialNo = dtRecordDB.Tables[0].Rows[0]["DockStationSerialNo"].ToString();
                    this.DockStationAdapterSerialNo = dtRecordDB.Tables[0].Rows[0]["DockStationAdapterSerialNo"].ToString();
                    this.MonitorModel = dtRecordDB.Tables[0].Rows[0]["MonitorModel"].ToString();
                    this.MonitorSerialNo = dtRecordDB.Tables[0].Rows[0]["MonitorSerialNo"].ToString();
                    this.PrinterModel = dtRecordDB.Tables[0].Rows[0]["PrinterModel"].ToString();
                    this.TcpIp = dtRecordDB.Tables[0].Rows[0]["TcpIP"].ToString();
                    this.Msoffice = dtRecordDB.Tables[0].Rows[0]["MsOffice"].ToString();
                    this.KlavyeSerialNo = dtRecordDB.Tables[0].Rows[0]["KeyboardSerialNo"].ToString();
                    this.MouseSerialNo = dtRecordDB.Tables[0].Rows[0]["MouseSerialNo"].ToString();
                    this.AdapterSerialNo = dtRecordDB.Tables[0].Rows[0]["AdapterSerialNo"].ToString();
                    this.IsBroken = (bool)dtRecordDB.Tables[0].Rows[0]["IsBroken"];
                    this.note = dtRecordDB.Tables[0].Rows[0]["Note"].ToString();
                }

            }

        }
        
        public string BillNo { get => billNo; set => billNo = value; }
        public string BillDate { get => billDate; set => billDate = value; }
        public string BillChangeDate { get => billChangeDate; set => billChangeDate = value; }
        public string FirstUser { get => firstUser; set => firstUser = value; }
        public string Username { get => username; set => username = value; }
        public string MonitorModel { get => monitorModel; set => monitorModel = value; }
        public string MonitorSerialNo { get => monitorSerialNo; set => monitorSerialNo = value; }
        public string DockStationSerialNo { get => dockStationSerialNo; set => dockStationSerialNo = value; }
        public string DockStationAdapterSerialNo { get => dockStationAdapterSerialNo; set => dockStationAdapterSerialNo = value; }
        public string PrinterModel { get => printerModel; set => printerModel = value; }
        public string TcpIp { get => tcpIp; set => tcpIp = value; }
        public string Msoffice { get => msoffice; set => msoffice = value; }
        public string KlavyeSerialNo { get => klavyeSerialNo; set => klavyeSerialNo = value; }
        public string MouseSerialNo { get => mouseSerialNo; set => mouseSerialNo = value; }
        public string AdapterSerialNo { get => adapterSerialNo; set => adapterSerialNo = value; }
        public string Note { get => note; set => note = value; }
    }
}
