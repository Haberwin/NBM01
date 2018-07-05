using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace NBM01_StressTest
{
    public partial class AT : Form
    {
        //ExSerialPort this.SerialPort;
        public delegate void printDelegate(string str);
        public delegate void TimesDelegate(int times);
        public delegate void TimeDelegate(DateTime time);
        
        StringBuilder ReceiverData = new StringBuilder();
        StringBuilder ReceiverError = new StringBuilder();
        String SavePath = String.Empty;
        DateTime SendTime = new DateTime(1111,11,11,11,11,11);
        int FaidTimes = 0, PassTimes = 0,RegisterTimes=0, ANR_Times = 0,Sendtimes=0;
        RunType TypeRun;
        enum RunType : int
        {
            Random = 0,
            Cycle = 1,

        }
        public AT() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel_Time.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            this.Timer_Time.Interval = 1000;
            this.Timer_Random.Interval = 3000;
            this.Timer_Time.Start();
            //PrintLog("" + Properties.Settings.Default.Command_list);
            Load_Setting();
        }
        private void ComboBox_Port_MouseDown(object sender, MouseEventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();//检查是否含有串口 
            ComboBox_Port.Items.Clear();
            if (ports == null)
            {
                return;
            }

            foreach (string port in ports)   //添加串口
            {

                ComboBox_Port.Items.Add(port);
            }
        }
        private void Timer_Time_Tick(object sender, EventArgs e)
        {
            if(this.SerialPort.PortName != "COM1")
            {
                String PortStatus = "Closed";
                this.toolStripStatusLabel_Time.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                PortStatus = this.SerialPort.IsOpen ? "Opened" : "Closed";
                this.toolStripStatusLabel_Port.Text = String.Format("{0}:{1}    {2}bps,{3},{4},{5}", this.SerialPort.PortName, PortStatus, this.SerialPort.BaudRate, this.SerialPort.Parity, this.SerialPort.DataBits, this.SerialPort.StopBits);
            }
        }

        private void PrintLog(String log)
        {
            if (this.LogBox.InvokeRequired)
            {
                printDelegate printInvoke = new printDelegate(PrintLog);
                this.LogBox.Invoke(printInvoke, log);
            }
            else {
                log = Regex.Replace(String.Format("{0}|{1}\n", DateTime.Now.ToString("hh:mm:ss.fff"), log), @"[\r\n]+", "\r\n");
                this.LogBox.AppendText(log);
                byte[] LogByte = this.SerialPort.Encoding.GetBytes(log);
                if (this.CheckBox_SaveLog.Checked)
                {
                    using (FileStream SaveFileWrite = new FileStream(@SavePath, FileMode.Append))
                    {
                        SaveFileWrite.Write(LogByte, 0, LogByte.Length);
                    }
                }
                if (LogBox.Lines.Length > 100)
                {
                    int index = LogBox.Text.IndexOf("\n");
                    String newString = LogBox.Text.Remove(0, index + 2);
                    LogBox.Clear();
                    LogBox.AppendText(newString);
                }
            }         
        }
        private void SetPassTime(int times)
        {
            if (this.PassTime.InvokeRequired)
            {
                TimesDelegate timesInvoke = new TimesDelegate(SetPassTime);
                this.PassTime.Invoke(timesInvoke, times);
            }
            else
            {
                this.PassTime.Text = times.ToString();
            }
        }
        private void SetSendTime(int times)
        {
            if (this.SendTimes.InvokeRequired)
            {
                TimesDelegate timesInvoke = new TimesDelegate(SetSendTime);
                this.SendTimes.Invoke(timesInvoke, times);
            }
            else
            {
                this.SendTimes.Text = times.ToString();
            }
        }
        private void SetFailTime(int times)
        {
            if (this.FailedTime.InvokeRequired)
            {
                TimesDelegate timesInvoke = new TimesDelegate(SetFailTime);
                this.FailedTime.Invoke(timesInvoke, times);
            }
            else
            {
                this.FailedTime.Text = times.ToString();
            }
        }
        private void SetANRTime(int times)
        {
            if (this.ANR_Time.InvokeRequired)
            {
                TimesDelegate timesInvoke = new TimesDelegate(SetANRTime);
                this.ANR_Time.Invoke(timesInvoke, times);
            }
            else
            {
                this.ANR_Time.Text = times.ToString();
            }
        }

        private void SetRegisterTime(int times)
        {
            if (this.Register_Times.InvokeRequired)
            {
                TimesDelegate timesInvoke = new TimesDelegate(SetRegisterTime);
                this.Register_Times.Invoke(timesInvoke, times);
            }
            else
            {
                this.Register_Times.Text = times.ToString();
            }
        }
        private void SetStartTime(DateTime time)
        {
            if (this.StartTime.InvokeRequired)
            {
                TimeDelegate timeInvoke = new TimeDelegate(SetStartTime);
                this.StartTime.Invoke(timeInvoke, time);
            }
            else
            {
                this.StartTime.Text = time.ToString();
            }
        }
        private void SetLastTime(DateTime time)
        {
            if (this.SuccessTime.InvokeRequired)
            {
                TimeDelegate timeInvoke = new TimeDelegate(SetLastTime);
                this.SuccessTime.Invoke(timeInvoke, time);
            }
            else
            {
                this.SuccessTime.Text = time.ToString();
            }
        }

        private void Button_Load_Click(object sender, EventArgs e) => Load_Setting();
        private void Button_SelectAll_Click(object sender, EventArgs e) => SelectAll(true);
        private void Button_Unselect_Click(object sender, EventArgs e) => SelectAll(false);
        private void Load_Setting()
        {
            List_Command.Items.Clear();
            foreach (string DefaultCommand in Properties.Settings.Default.Command_list.Split(','))
            {
                if (DefaultCommand != "")
                { List_Command.Items.Add(DefaultCommand); }

            }
        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            String AtCMD = Interaction.InputBox("请输入要添加的AT命令", "AT输入", "AT+", -1, -1);
            if(AtCMD != "") {
                List_Command.Items.Add(AtCMD);
            }
            
        }

        private void Button_Del_Click(object sender, EventArgs e)
        {
            for (int i = this.List_Command.Items.Count - 1; i >= 0; i--)
            {
                this.List_Command.Items.Remove(this.List_Command.SelectedItem);
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Command_list = "";
            foreach (String AtCMD in List_Command.Items)
            {
                Properties.Settings.Default.Command_list += AtCMD + ",";
            }
            Properties.Settings.Default.Save();
        }
        private void SelectAll(bool b)
        {
            for (int i = 0; i < List_Command.Items.Count; i++)
            {

                List_Command.SetSelected(i, b);
            }
        }

        private void List_Command_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = List_Command.IndexFromPoint(e.X, e.Y);
            List_Command.SelectedIndex = index;
            if (List_Command.SelectedIndex != -1)
            {
                this.SendBox.Text=List_Command.Items[index].ToString();
            }
        }

        private void Bt_OpenPort_Click(object sender, EventArgs e)
        {
            if(ComboBox_Port.Text != "" && ComboBox_Baud.Text != "")
            {


                this.SerialPort.PortName = this.ComboBox_Port.Text;
                this.SerialPort.BaudRate = Convert.ToInt32(this.ComboBox_Baud.Text);
                this.SerialPort.DataBits = Convert.ToInt32(this.ComboBox_Data.Text);
                this.SerialPort.Parity = this.ComboBox_Parity.Text == "None" ? Parity.None : Parity.None;
                this.SerialPort.StopBits = this.comboBox_Stop.Text == "1" ? StopBits.One : StopBits.One;

                this.SerialPort.Open();
                Bt_OpenPort.Enabled = false;
                Bt_ClosePort.Enabled = true;
                PrintLog(String.Format("Open port {0} success",this.SerialPort.PortName));

            }
            else
            {
                PrintLog("Please select Port Name and Baud Rate!");
            }
            
        }

        private void Bt_ClosePort_Click(object sender, EventArgs e)
        {
            if(this.SerialPort.IsOpen)
            {
                this.SerialPort.Close();
            }
            Bt_OpenPort.Enabled = true;
            Bt_ClosePort.Enabled = false;
            PrintLog(String.Format("Close port {0} success", this.SerialPort.PortName));
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            if(this.SerialPort.PortName == "COM1")
            {
                PrintLog("No Port select!");
                return;
            }
            else if(!this.SerialPort.IsOpen)
            {
                PrintLog("Port "+ this.SerialPort.PortName +" is closed! please open it first!");
                return;
            }
            else if(this.SendBox.Text != "")
            {
                String CMD = this.SendBox.Text.IndexOf("\n") > 0 ? SendBox.Text : SendBox.Text + "\r\n";
                this.SerialPort.Write(CMD); 
                PrintLog("<<<" + CMD);
                SendTime = DateTime.Now;
                SetSendTime(++Sendtimes);
                    
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(20);
            int n = this.SerialPort.BytesToRead;
            byte[] buf = new byte[n];
            this.SerialPort.Read(buf, 0, n);
            ReceiverData.Append(this.SerialPort.Encoding.GetString(buf));
            String Feedback = ReceiverData.ToString();
            if(Feedback.EndsWith("\n"))
            {
                PrintLog(">>>" + Feedback);
                ReceiverData.Clear();
                if(SendTime != new DateTime(1111, 11, 11, 11, 11, 11) && DateTime.Now > SendTime && (Feedback.Contains("\r\nOK\r\n")|| Feedback.Contains("\r\nERROR")))
                {
                    if(Feedback.Contains("\r\nOK\r\n"))
                    {
                        
                        SetPassTime(++PassTimes);
                        SetLastTime(DateTime.Now);
                    }
                    else if (Feedback.Contains("\r\nERROR"))
                    {
                        SetFailTime(++FaidTimes);
                    }
                    SetANRTime(Sendtimes - PassTimes - FaidTimes);



                }
                if (Feedback.Contains("registered"))
                {
                    SetRegisterTime(++RegisterTimes);
                }

                
            }
        }

        private void Button_Random_Click(object sender, EventArgs e)
        {
            TypeRun = RunType.Random;
            this.SetStartTime(DateTime.Now);
            this.Timer_Random.Start();
            this.BT_Stop.Enabled = true;
        }
        private void Timer_Random_Tick(object sender, EventArgs e)
        {
            int i = 0;
            //PrintLog(e.ToString());
            if (TypeRun==RunType.Random) {
                Random rd = new Random();
                i = rd.Next(0, this.List_Command.Items.Count);
            }
            else
            {
                i = this.List_Command.SelectedIndex;
                //PrintLog("index:" + List_Command.SelectedIndex + "count:" + List_Command.Items.Count);
                if (this.List_Command.SelectedIndex == this.List_Command.Items.Count-1)
                {
                    this.List_Command.SelectedIndex = 0;
                    i = 0;
                }
                else { this.List_Command.SelectedIndex = ++i; }
               
            }
            //PrintLog("index:" + List_Command.SelectedIndex + "count:"+List_Command.Items.Count);
            
            
            List_Command.SelectedIndex = i;
            this.SendBox.Text = List_Command.Items[i].ToString();
            Button_Send_Click(sender, e);
        }

        private void BT_Stop_Click(object sender, EventArgs e)
        {
            this.Timer_Random.Stop();
            this.BT_Stop.Enabled = false;
        }

        private void Button_Cycle_Click(object sender, EventArgs e)
        {

            TypeRun = RunType.Cycle;
            this.SetStartTime(DateTime.Now);
            this.Timer_Random.Start();
            this.BT_Stop.Enabled = true;
        }

        private void CheckBox_SaveLog_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                SavePath = this.SaveFile.FileName;
                PrintLog("Set Save Path:"+SavePath);
                byte[] LogByte = this.SerialPort.Encoding.GetBytes("Log Start : " + DateTime.Now.ToString()+"\r\n-----------------------------------------------------------------------\r\n");
                using (FileStream SaveFileWrite = new FileStream(@SavePath, FileMode.Append))
                {
                    SaveFileWrite.Write(LogByte, 0, LogByte.Length);
                }
            }
                

        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            FaidTimes = 0;
            PassTimes = 0;
            RegisterTimes = 0;
            ANR_Times = 0;
            Sendtimes = 0;
            SetSendTime(0);
            SetRegisterTime(0);
            SetANRTime(0);
            SetPassTime(0);
            SetFailTime(0);
        }

        private void BT_Stop_EnabledChanged(object sender, EventArgs e)
        {
            this.button_Cycle.Enabled = !BT_Stop.Enabled;
            this.button_Random.Enabled= !BT_Stop.Enabled;
        }

        private void SerialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            int n = this.SerialPort.BytesToRead;
            byte[] buf = new byte[n];
            this.SerialPort.Read(buf, 0, n);
            ReceiverError.Append(this.SerialPort.Encoding.GetString(buf));
            if (ReceiverError.ToString().EndsWith("\r\n"))
            {
                PrintLog(">>>" + ReceiverError.ToString());
                ReceiverError.Clear();
            }
            FaidTimes += 1;
            SetFailTime(FaidTimes);

        }

        private void ComboBox_Port_TextChanged(object sender, EventArgs e)
        {
            if(this.ComboBox_Port.Text != "")
            {
                if (this.SerialPort.IsOpen)
                {
                    this.Bt_ClosePort_Click(sender,e);
                }
                this.SerialPort.PortName = this.ComboBox_Port.Text;
            }
        }

        private void ComboBox_Baud_TextChanged(object sender, EventArgs e)
        {
            if (this.ComboBox_Baud.Text != "")
            {
                this.SerialPort.BaudRate = Convert.ToInt32(this.ComboBox_Baud.Text);
            }

        }
    }
    
}
