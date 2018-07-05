namespace NBM01_StressTest
{
    partial class AT
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PortSetting = new System.Windows.Forms.GroupBox();
            this.comboBox_Stop = new System.Windows.Forms.ComboBox();
            this.ComboBox_Parity = new System.Windows.Forms.ComboBox();
            this.ComboBox_Data = new System.Windows.Forms.ComboBox();
            this.ComboBox_Baud = new System.Windows.Forms.ComboBox();
            this.ComboBox_Port = new System.Windows.Forms.ComboBox();
            this.label_Stop_Bit = new System.Windows.Forms.Label();
            this.label_Parity = new System.Windows.Forms.Label();
            this.label_Data_bit = new System.Windows.Forms.Label();
            this.label_Baud = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.Bt_OpenPort = new System.Windows.Forms.Button();
            this.Bt_ClosePort = new System.Windows.Forms.Button();
            this.SendBox = new System.Windows.Forms.TextBox();
            this.StatusStrip_AT = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Port = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer_Time = new System.Windows.Forms.Timer(this.components);
            this.LogBox = new System.Windows.Forms.TextBox();
            this.List_Command = new System.Windows.Forms.ListBox();
            this.Command_Box = new System.Windows.Forms.GroupBox();
            this.BT_Stop = new System.Windows.Forms.Button();
            this.button_Random = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cycle = new System.Windows.Forms.Button();
            this.button_SelectAll = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Unselect = new System.Windows.Forms.Button();
            this.Button_Send = new System.Windows.Forms.Button();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.Group_Result = new System.Windows.Forms.GroupBox();
            this.Register_Times = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.Label();
            this.label_StartTime = new System.Windows.Forms.Label();
            this.SendTimes = new System.Windows.Forms.Label();
            this.label_SendTimes = new System.Windows.Forms.Label();
            this.SuccessTime = new System.Windows.Forms.Label();
            this.ANR_Time = new System.Windows.Forms.Label();
            this.FailedTime = new System.Windows.Forms.Label();
            this.PassTime = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_ANR = new System.Windows.Forms.Label();
            this.label_Failed = new System.Windows.Forms.Label();
            this.label_Success = new System.Windows.Forms.Label();
            this.Timer_Random = new System.Windows.Forms.Timer(this.components);
            this.CheckBox_SaveLog = new System.Windows.Forms.CheckBox();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.PortSetting.SuspendLayout();
            this.StatusStrip_AT.SuspendLayout();
            this.Command_Box.SuspendLayout();
            this.Group_Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortSetting
            // 
            this.PortSetting.Controls.Add(this.comboBox_Stop);
            this.PortSetting.Controls.Add(this.ComboBox_Parity);
            this.PortSetting.Controls.Add(this.ComboBox_Data);
            this.PortSetting.Controls.Add(this.ComboBox_Baud);
            this.PortSetting.Controls.Add(this.ComboBox_Port);
            this.PortSetting.Controls.Add(this.label_Stop_Bit);
            this.PortSetting.Controls.Add(this.label_Parity);
            this.PortSetting.Controls.Add(this.label_Data_bit);
            this.PortSetting.Controls.Add(this.label_Baud);
            this.PortSetting.Controls.Add(this.label_port);
            this.PortSetting.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PortSetting.Location = new System.Drawing.Point(12, 12);
            this.PortSetting.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PortSetting.Name = "PortSetting";
            this.PortSetting.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PortSetting.Size = new System.Drawing.Size(304, 224);
            this.PortSetting.TabIndex = 0;
            this.PortSetting.TabStop = false;
            this.PortSetting.Text = "串口设置";
            // 
            // comboBox_Stop
            // 
            this.comboBox_Stop.Enabled = false;
            this.comboBox_Stop.FormattingEnabled = true;
            this.comboBox_Stop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBox_Stop.Location = new System.Drawing.Point(142, 175);
            this.comboBox_Stop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox_Stop.Name = "comboBox_Stop";
            this.comboBox_Stop.Size = new System.Drawing.Size(120, 29);
            this.comboBox_Stop.TabIndex = 9;
            this.comboBox_Stop.Text = "1";
            // 
            // ComboBox_Parity
            // 
            this.ComboBox_Parity.Enabled = false;
            this.ComboBox_Parity.FormattingEnabled = true;
            this.ComboBox_Parity.Items.AddRange(new object[] {
            "None"});
            this.ComboBox_Parity.Location = new System.Drawing.Point(142, 137);
            this.ComboBox_Parity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ComboBox_Parity.Name = "ComboBox_Parity";
            this.ComboBox_Parity.Size = new System.Drawing.Size(120, 29);
            this.ComboBox_Parity.TabIndex = 8;
            this.ComboBox_Parity.Text = "None";
            // 
            // ComboBox_Data
            // 
            this.ComboBox_Data.Enabled = false;
            this.ComboBox_Data.FormattingEnabled = true;
            this.ComboBox_Data.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.ComboBox_Data.Location = new System.Drawing.Point(142, 101);
            this.ComboBox_Data.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ComboBox_Data.Name = "ComboBox_Data";
            this.ComboBox_Data.Size = new System.Drawing.Size(120, 29);
            this.ComboBox_Data.TabIndex = 7;
            this.ComboBox_Data.Text = "8";
            // 
            // ComboBox_Baud
            // 
            this.ComboBox_Baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Baud.FormattingEnabled = true;
            this.ComboBox_Baud.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox_Baud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "230400",
            "256000",
            "512000"});
            this.ComboBox_Baud.Location = new System.Drawing.Point(142, 61);
            this.ComboBox_Baud.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ComboBox_Baud.Name = "ComboBox_Baud";
            this.ComboBox_Baud.Size = new System.Drawing.Size(120, 29);
            this.ComboBox_Baud.TabIndex = 6;
            this.ComboBox_Baud.TextChanged += new System.EventHandler(this.ComboBox_Baud_TextChanged);
            // 
            // ComboBox_Port
            // 
            this.ComboBox_Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Port.FormattingEnabled = true;
            this.ComboBox_Port.Location = new System.Drawing.Point(142, 25);
            this.ComboBox_Port.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ComboBox_Port.Name = "ComboBox_Port";
            this.ComboBox_Port.Size = new System.Drawing.Size(120, 29);
            this.ComboBox_Port.TabIndex = 5;
            this.ComboBox_Port.TextChanged += new System.EventHandler(this.ComboBox_Port_TextChanged);
            this.ComboBox_Port.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ComboBox_Port_MouseDown);
            // 
            // label_Stop_Bit
            // 
            this.label_Stop_Bit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Stop_Bit.Location = new System.Drawing.Point(6, 176);
            this.label_Stop_Bit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Stop_Bit.Name = "label_Stop_Bit";
            this.label_Stop_Bit.Size = new System.Drawing.Size(90, 25);
            this.label_Stop_Bit.TabIndex = 4;
            this.label_Stop_Bit.Text = "Stop Bit";
            this.label_Stop_Bit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Parity
            // 
            this.label_Parity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Parity.Location = new System.Drawing.Point(6, 141);
            this.label_Parity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Parity.Name = "label_Parity";
            this.label_Parity.Size = new System.Drawing.Size(90, 25);
            this.label_Parity.TabIndex = 3;
            this.label_Parity.Text = "Parity";
            this.label_Parity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Data_bit
            // 
            this.label_Data_bit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Data_bit.Location = new System.Drawing.Point(7, 101);
            this.label_Data_bit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Data_bit.Name = "label_Data_bit";
            this.label_Data_bit.Size = new System.Drawing.Size(90, 25);
            this.label_Data_bit.TabIndex = 2;
            this.label_Data_bit.Text = "Data Bit";
            this.label_Data_bit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Baud
            // 
            this.label_Baud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Baud.Location = new System.Drawing.Point(7, 61);
            this.label_Baud.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Baud.Name = "label_Baud";
            this.label_Baud.Size = new System.Drawing.Size(90, 25);
            this.label_Baud.TabIndex = 1;
            this.label_Baud.Text = "Baud Rate";
            this.label_Baud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_port
            // 
            this.label_port.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_port.Location = new System.Drawing.Point(7, 29);
            this.label_port.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(90, 25);
            this.label_port.TabIndex = 0;
            this.label_port.Text = "Serial Port";
            this.label_port.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Bt_OpenPort
            // 
            this.Bt_OpenPort.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bt_OpenPort.Location = new System.Drawing.Point(13, 242);
            this.Bt_OpenPort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Bt_OpenPort.Name = "Bt_OpenPort";
            this.Bt_OpenPort.Size = new System.Drawing.Size(96, 31);
            this.Bt_OpenPort.TabIndex = 1;
            this.Bt_OpenPort.Text = "Open";
            this.Bt_OpenPort.UseVisualStyleBackColor = true;
            this.Bt_OpenPort.Click += new System.EventHandler(this.Bt_OpenPort_Click);
            // 
            // Bt_ClosePort
            // 
            this.Bt_ClosePort.Enabled = false;
            this.Bt_ClosePort.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bt_ClosePort.Location = new System.Drawing.Point(154, 242);
            this.Bt_ClosePort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Bt_ClosePort.Name = "Bt_ClosePort";
            this.Bt_ClosePort.Size = new System.Drawing.Size(100, 31);
            this.Bt_ClosePort.TabIndex = 2;
            this.Bt_ClosePort.Text = "Close";
            this.Bt_ClosePort.UseVisualStyleBackColor = true;
            this.Bt_ClosePort.Click += new System.EventHandler(this.Bt_ClosePort_Click);
            // 
            // SendBox
            // 
            this.SendBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendBox.Location = new System.Drawing.Point(322, 626);
            this.SendBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SendBox.Multiline = true;
            this.SendBox.Name = "SendBox";
            this.SendBox.Size = new System.Drawing.Size(425, 113);
            this.SendBox.TabIndex = 4;
            // 
            // StatusStrip_AT
            // 
            this.StatusStrip_AT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Time,
            this.toolStripStatusLabel_Port});
            this.StatusStrip_AT.Location = new System.Drawing.Point(0, 749);
            this.StatusStrip_AT.Name = "StatusStrip_AT";
            this.StatusStrip_AT.Size = new System.Drawing.Size(1317, 26);
            this.StatusStrip_AT.TabIndex = 5;
            this.StatusStrip_AT.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Time
            // 
            this.toolStripStatusLabel_Time.Name = "toolStripStatusLabel_Time";
            this.toolStripStatusLabel_Time.Size = new System.Drawing.Size(131, 21);
            this.toolStripStatusLabel_Time.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel_Time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel_Port
            // 
            this.toolStripStatusLabel_Port.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel_Port.Name = "toolStripStatusLabel_Port";
            this.toolStripStatusLabel_Port.Size = new System.Drawing.Size(1171, 21);
            this.toolStripStatusLabel_Port.Spring = true;
            this.toolStripStatusLabel_Port.Text = "No SerialPort Selected";
            this.toolStripStatusLabel_Port.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Timer_Time
            // 
            this.Timer_Time.Tick += new System.EventHandler(this.Timer_Time_Tick);
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LogBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogBox.Location = new System.Drawing.Point(322, 12);
            this.LogBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(548, 579);
            this.LogBox.TabIndex = 6;
            // 
            // List_Command
            // 
            this.List_Command.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.List_Command.ForeColor = System.Drawing.SystemColors.WindowText;
            this.List_Command.FormattingEnabled = true;
            this.List_Command.ItemHeight = 21;
            this.List_Command.Items.AddRange(new object[] {
            "AT+CGMI",
            "AT+CGMM",
            "ATI"});
            this.List_Command.Location = new System.Drawing.Point(6, 28);
            this.List_Command.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.List_Command.Name = "List_Command";
            this.List_Command.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.List_Command.ScrollAlwaysVisible = true;
            this.List_Command.Size = new System.Drawing.Size(326, 550);
            this.List_Command.Sorted = true;
            this.List_Command.TabIndex = 7;
            this.List_Command.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.List_Command_MouseDoubleClick);
            // 
            // Command_Box
            // 
            this.Command_Box.Controls.Add(this.BT_Stop);
            this.Command_Box.Controls.Add(this.button_Random);
            this.Command_Box.Controls.Add(this.List_Command);
            this.Command_Box.Controls.Add(this.button_Load);
            this.Command_Box.Controls.Add(this.button_Save);
            this.Command_Box.Controls.Add(this.button_Cycle);
            this.Command_Box.Controls.Add(this.button_SelectAll);
            this.Command_Box.Controls.Add(this.button_Del);
            this.Command_Box.Controls.Add(this.button_Add);
            this.Command_Box.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Command_Box.Location = new System.Drawing.Point(877, 12);
            this.Command_Box.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Command_Box.Name = "Command_Box";
            this.Command_Box.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Command_Box.Size = new System.Drawing.Size(338, 727);
            this.Command_Box.TabIndex = 8;
            this.Command_Box.TabStop = false;
            this.Command_Box.Text = "Command List";
            // 
            // BT_Stop
            // 
            this.BT_Stop.Enabled = false;
            this.BT_Stop.Location = new System.Drawing.Point(136, 632);
            this.BT_Stop.Name = "BT_Stop";
            this.BT_Stop.Size = new System.Drawing.Size(66, 80);
            this.BT_Stop.TabIndex = 17;
            this.BT_Stop.Text = "STOP";
            this.BT_Stop.UseVisualStyleBackColor = true;
            this.BT_Stop.EnabledChanged += new System.EventHandler(this.BT_Stop_EnabledChanged);
            this.BT_Stop.Click += new System.EventHandler(this.BT_Stop_Click);
            // 
            // button_Random
            // 
            this.button_Random.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Random.Location = new System.Drawing.Point(207, 680);
            this.button_Random.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Random.Name = "button_Random";
            this.button_Random.Size = new System.Drawing.Size(125, 32);
            this.button_Random.TabIndex = 16;
            this.button_Random.Text = "Send by Random";
            this.button_Random.UseVisualStyleBackColor = true;
            this.button_Random.Click += new System.EventHandler(this.Button_Random_Click);
            // 
            // button_Load
            // 
            this.button_Load.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Load.Location = new System.Drawing.Point(136, 583);
            this.button_Load.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(74, 33);
            this.button_Load.TabIndex = 11;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.Button_Load_Click);
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Save.Location = new System.Drawing.Point(254, 583);
            this.button_Save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(78, 33);
            this.button_Save.TabIndex = 12;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // button_Cycle
            // 
            this.button_Cycle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Cycle.Location = new System.Drawing.Point(6, 680);
            this.button_Cycle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Cycle.Name = "button_Cycle";
            this.button_Cycle.Size = new System.Drawing.Size(125, 32);
            this.button_Cycle.TabIndex = 15;
            this.button_Cycle.Text = "Send by Cycle";
            this.button_Cycle.UseVisualStyleBackColor = true;
            this.button_Cycle.Click += new System.EventHandler(this.Button_Cycle_Click);
            // 
            // button_SelectAll
            // 
            this.button_SelectAll.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_SelectAll.Location = new System.Drawing.Point(6, 632);
            this.button_SelectAll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_SelectAll.Name = "button_SelectAll";
            this.button_SelectAll.Size = new System.Drawing.Size(125, 32);
            this.button_SelectAll.TabIndex = 13;
            this.button_SelectAll.Text = "Select All";
            this.button_SelectAll.UseVisualStyleBackColor = true;
            this.button_SelectAll.Click += new System.EventHandler(this.Button_SelectAll_Click);
            // 
            // button_Del
            // 
            this.button_Del.AutoSize = true;
            this.button_Del.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Del.Location = new System.Drawing.Point(72, 584);
            this.button_Del.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(32, 32);
            this.button_Del.TabIndex = 10;
            this.button_Del.Text = "-";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.Button_Del_Click);
            // 
            // button_Add
            // 
            this.button_Add.AutoSize = true;
            this.button_Add.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Add.Location = new System.Drawing.Point(6, 585);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(32, 32);
            this.button_Add.TabIndex = 9;
            this.button_Add.Text = "+";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // button_Unselect
            // 
            this.button_Unselect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Unselect.Location = new System.Drawing.Point(1084, 644);
            this.button_Unselect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Unselect.Name = "button_Unselect";
            this.button_Unselect.Size = new System.Drawing.Size(125, 32);
            this.button_Unselect.TabIndex = 14;
            this.button_Unselect.Text = "Unselect";
            this.button_Unselect.UseVisualStyleBackColor = true;
            this.button_Unselect.Click += new System.EventHandler(this.Button_Unselect_Click);
            // 
            // Button_Send
            // 
            this.Button_Send.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Send.Location = new System.Drawing.Point(754, 626);
            this.Button_Send.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(116, 113);
            this.Button_Send.TabIndex = 15;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // SerialPort
            // 
            this.SerialPort.BaudRate = 115200;
            this.SerialPort.DtrEnable = true;
            this.SerialPort.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.SerialPort_ErrorReceived);
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // Group_Result
            // 
            this.Group_Result.Controls.Add(this.Button_Clear);
            this.Group_Result.Controls.Add(this.Register_Times);
            this.Group_Result.Controls.Add(this.label2);
            this.Group_Result.Controls.Add(this.StartTime);
            this.Group_Result.Controls.Add(this.label_StartTime);
            this.Group_Result.Controls.Add(this.SendTimes);
            this.Group_Result.Controls.Add(this.label_SendTimes);
            this.Group_Result.Controls.Add(this.SuccessTime);
            this.Group_Result.Controls.Add(this.ANR_Time);
            this.Group_Result.Controls.Add(this.FailedTime);
            this.Group_Result.Controls.Add(this.PassTime);
            this.Group_Result.Controls.Add(this.label_Time);
            this.Group_Result.Controls.Add(this.label_ANR);
            this.Group_Result.Controls.Add(this.label_Failed);
            this.Group_Result.Controls.Add(this.label_Success);
            this.Group_Result.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Group_Result.Location = new System.Drawing.Point(13, 308);
            this.Group_Result.Name = "Group_Result";
            this.Group_Result.Size = new System.Drawing.Size(303, 431);
            this.Group_Result.TabIndex = 16;
            this.Group_Result.TabStop = false;
            this.Group_Result.Text = "Result";
            // 
            // Register_Times
            // 
            this.Register_Times.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Register_Times.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Register_Times.Location = new System.Drawing.Point(161, 228);
            this.Register_Times.Name = "Register_Times";
            this.Register_Times.Size = new System.Drawing.Size(100, 30);
            this.Register_Times.TabIndex = 13;
            this.Register_Times.Text = "0";
            this.Register_Times.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "驻网次数";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StartTime
            // 
            this.StartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.StartTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartTime.Location = new System.Drawing.Point(6, 324);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(203, 27);
            this.StartTime.TabIndex = 11;
            this.StartTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_StartTime
            // 
            this.label_StartTime.AutoSize = true;
            this.label_StartTime.BackColor = System.Drawing.Color.White;
            this.label_StartTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_StartTime.Location = new System.Drawing.Point(6, 301);
            this.label_StartTime.Name = "label_StartTime";
            this.label_StartTime.Size = new System.Drawing.Size(93, 20);
            this.label_StartTime.TabIndex = 10;
            this.label_StartTime.Text = "循环开始时间";
            this.label_StartTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SendTimes
            // 
            this.SendTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SendTimes.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendTimes.Location = new System.Drawing.Point(161, 39);
            this.SendTimes.Name = "SendTimes";
            this.SendTimes.Size = new System.Drawing.Size(100, 30);
            this.SendTimes.TabIndex = 9;
            this.SendTimes.Text = "0";
            this.SendTimes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_SendTimes
            // 
            this.label_SendTimes.BackColor = System.Drawing.Color.White;
            this.label_SendTimes.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SendTimes.Location = new System.Drawing.Point(16, 39);
            this.label_SendTimes.Name = "label_SendTimes";
            this.label_SendTimes.Size = new System.Drawing.Size(100, 30);
            this.label_SendTimes.TabIndex = 8;
            this.label_SendTimes.Text = "发送次数";
            this.label_SendTimes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SuccessTime
            // 
            this.SuccessTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SuccessTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SuccessTime.Location = new System.Drawing.Point(6, 372);
            this.SuccessTime.Name = "SuccessTime";
            this.SuccessTime.Size = new System.Drawing.Size(203, 27);
            this.SuccessTime.TabIndex = 7;
            this.SuccessTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ANR_Time
            // 
            this.ANR_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ANR_Time.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ANR_Time.Location = new System.Drawing.Point(161, 182);
            this.ANR_Time.Name = "ANR_Time";
            this.ANR_Time.Size = new System.Drawing.Size(100, 30);
            this.ANR_Time.TabIndex = 6;
            this.ANR_Time.Text = "0";
            this.ANR_Time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FailedTime
            // 
            this.FailedTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FailedTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FailedTime.Location = new System.Drawing.Point(161, 133);
            this.FailedTime.Name = "FailedTime";
            this.FailedTime.Size = new System.Drawing.Size(100, 30);
            this.FailedTime.TabIndex = 5;
            this.FailedTime.Text = "0";
            this.FailedTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PassTime
            // 
            this.PassTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PassTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PassTime.Location = new System.Drawing.Point(161, 89);
            this.PassTime.Name = "PassTime";
            this.PassTime.Size = new System.Drawing.Size(100, 30);
            this.PassTime.TabIndex = 4;
            this.PassTime.Text = "0";
            this.PassTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.BackColor = System.Drawing.Color.White;
            this.label_Time.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Time.Location = new System.Drawing.Point(6, 349);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(149, 20);
            this.label_Time.TabIndex = 3;
            this.label_Time.Text = "最后一次成功发送时间";
            this.label_Time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ANR
            // 
            this.label_ANR.BackColor = System.Drawing.Color.White;
            this.label_ANR.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ANR.Location = new System.Drawing.Point(16, 182);
            this.label_ANR.Name = "label_ANR";
            this.label_ANR.Size = new System.Drawing.Size(100, 30);
            this.label_ANR.TabIndex = 2;
            this.label_ANR.Text = "其他次数";
            this.label_ANR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Failed
            // 
            this.label_Failed.BackColor = System.Drawing.Color.White;
            this.label_Failed.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Failed.Location = new System.Drawing.Point(16, 133);
            this.label_Failed.Name = "label_Failed";
            this.label_Failed.Size = new System.Drawing.Size(100, 30);
            this.label_Failed.TabIndex = 1;
            this.label_Failed.Text = "发送错误次数";
            this.label_Failed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Success
            // 
            this.label_Success.BackColor = System.Drawing.Color.White;
            this.label_Success.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Success.Location = new System.Drawing.Point(16, 89);
            this.label_Success.Name = "label_Success";
            this.label_Success.Size = new System.Drawing.Size(100, 30);
            this.label_Success.TabIndex = 0;
            this.label_Success.Text = "发送成功次数";
            this.label_Success.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Timer_Random
            // 
            this.Timer_Random.Tick += new System.EventHandler(this.Timer_Random_Tick);
            // 
            // CheckBox_SaveLog
            // 
            this.CheckBox_SaveLog.AutoSize = true;
            this.CheckBox_SaveLog.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox_SaveLog.Location = new System.Drawing.Point(322, 594);
            this.CheckBox_SaveLog.Name = "CheckBox_SaveLog";
            this.CheckBox_SaveLog.Size = new System.Drawing.Size(173, 26);
            this.CheckBox_SaveLog.TabIndex = 17;
            this.CheckBox_SaveLog.Text = "同时输出保存到文件";
            this.CheckBox_SaveLog.UseVisualStyleBackColor = true;
            this.CheckBox_SaveLog.CheckedChanged += new System.EventHandler(this.CheckBox_SaveLog_CheckedChanged);
            // 
            // SaveFile
            // 
            this.SaveFile.DefaultExt = "txt";
            this.SaveFile.FileName = "NBIoT-log";
            this.SaveFile.Filter = "\"*.txt|*.*\"";
            this.SaveFile.Title = "请选择保存路径";
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(158, 274);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(103, 38);
            this.Button_Clear.TabIndex = 14;
            this.Button_Clear.Text = "Clear Data";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // AT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 775);
            this.Controls.Add(this.CheckBox_SaveLog);
            this.Controls.Add(this.Group_Result);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.button_Unselect);
            this.Controls.Add(this.Command_Box);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.StatusStrip_AT);
            this.Controls.Add(this.SendBox);
            this.Controls.Add(this.Bt_ClosePort);
            this.Controls.Add(this.Bt_OpenPort);
            this.Controls.Add(this.PortSetting);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AT";
            this.Text = "AT Stress";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PortSetting.ResumeLayout(false);
            this.StatusStrip_AT.ResumeLayout(false);
            this.StatusStrip_AT.PerformLayout();
            this.Command_Box.ResumeLayout(false);
            this.Command_Box.PerformLayout();
            this.Group_Result.ResumeLayout(false);
            this.Group_Result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PortSetting;
        private System.Windows.Forms.Label label_Stop_Bit;
        private System.Windows.Forms.Label label_Parity;
        private System.Windows.Forms.Label label_Data_bit;
        private System.Windows.Forms.Label label_Baud;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.Button Bt_OpenPort;
        private System.Windows.Forms.Button Bt_ClosePort;
        private System.Windows.Forms.ComboBox comboBox_Stop;
        private System.Windows.Forms.ComboBox ComboBox_Parity;
        private System.Windows.Forms.ComboBox ComboBox_Data;
        private System.Windows.Forms.ComboBox ComboBox_Baud;
        private System.Windows.Forms.ComboBox ComboBox_Port;
        private System.Windows.Forms.TextBox SendBox;
        private System.Windows.Forms.StatusStrip StatusStrip_AT;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Time;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Port;
        private System.Windows.Forms.Timer Timer_Time;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.ListBox List_Command;
        private System.Windows.Forms.GroupBox Command_Box;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Random;
        private System.Windows.Forms.Button button_Cycle;
        private System.Windows.Forms.Button button_SelectAll;
        private System.Windows.Forms.Button button_Unselect;
        private System.Windows.Forms.Button Button_Send;
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.GroupBox Group_Result;
        private System.Windows.Forms.Label SuccessTime;
        private System.Windows.Forms.Label ANR_Time;
        private System.Windows.Forms.Label FailedTime;
        private System.Windows.Forms.Label PassTime;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_ANR;
        private System.Windows.Forms.Label label_Failed;
        private System.Windows.Forms.Label label_Success;
        private System.Windows.Forms.Label SendTimes;
        private System.Windows.Forms.Label label_SendTimes;
        private System.Windows.Forms.Timer Timer_Random;
        private System.Windows.Forms.Button BT_Stop;
        private System.Windows.Forms.Label Register_Times;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StartTime;
        private System.Windows.Forms.Label label_StartTime;
        private System.Windows.Forms.CheckBox CheckBox_SaveLog;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.Button Button_Clear;
    }
}

