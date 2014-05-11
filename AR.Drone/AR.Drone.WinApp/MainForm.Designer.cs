namespace AR.Drone.WinApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pbVideo = new System.Windows.Forms.PictureBox();
            this.btnFlatTrim = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEmergency = new System.Windows.Forms.Button();
            this.tmrStateUpdate = new System.Windows.Forms.Timer(this.components);
            this.btnSwitchCam = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnTurnLeft = new System.Windows.Forms.Button();
            this.btnTurnRight = new System.Windows.Forms.Button();
            this.btnHover = new System.Windows.Forms.Button();
            this.tvInfo = new System.Windows.Forms.TreeView();
            this.tmrVideoUpdate = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.btnReadConfig = new System.Windows.Forms.Button();
            this.btnSendConfig = new System.Windows.Forms.Button();
            this.btnStartRecording = new System.Windows.Forms.Button();
            this.btnStopRecording = new System.Windows.Forms.Button();
            this.btnReplay = new System.Windows.Forms.Button();
            this.btnAutopilot = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.joyLabel = new System.Windows.Forms.Label();
            this.joyValue = new System.Windows.Forms.Label();
            this.oneHoLabel = new System.Windows.Forms.Label();
            this.oneVeLabel = new System.Windows.Forms.Label();
            this.twoHoLabel = new System.Windows.Forms.Label();
            this.trigBtnLabel = new System.Windows.Forms.Label();
            this.joySettingsBtn = new System.Windows.Forms.Button();
            this.rollMultSetBox = new System.Windows.Forms.NumericUpDown();
            this.pitchMultSetBox = new System.Windows.Forms.NumericUpDown();
            this.yawMultSetBox = new System.Windows.Forms.NumericUpDown();
            this.gazMultSetBox = new System.Windows.Forms.NumericUpDown();
            this.StartBtnLabel = new System.Windows.Forms.Label();
            this.maxYaw = new System.Windows.Forms.NumericUpDown();
            this.maxVz = new System.Windows.Forms.NumericUpDown();
            this.maxYawLabel = new System.Windows.Forms.Label();
            this.maxVzLabel = new System.Windows.Forms.Label();
            this.oneHoMulLabel = new System.Windows.Forms.Label();
            this.oneVeMulLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericAnimation = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.radioSelect22Hz = new System.Windows.Forms.RadioButton();
            this.radioSelect25Hz = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollMultSetBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchMultSetBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawMultSetBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gazMultSetBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxYaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxVz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 37);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Activate (+flattrim/config)";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(107, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Deactivate";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pbVideo
            // 
            this.pbVideo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbVideo.Location = new System.Drawing.Point(12, 41);
            this.pbVideo.Name = "pbVideo";
            this.pbVideo.Size = new System.Drawing.Size(640, 360);
            this.pbVideo.TabIndex = 2;
            this.pbVideo.TabStop = false;
            // 
            // btnFlatTrim
            // 
            this.btnFlatTrim.Location = new System.Drawing.Point(12, 407);
            this.btnFlatTrim.Name = "btnFlatTrim";
            this.btnFlatTrim.Size = new System.Drawing.Size(75, 23);
            this.btnFlatTrim.TabIndex = 3;
            this.btnFlatTrim.Text = "Flat Trim";
            this.btnFlatTrim.UseVisualStyleBackColor = true;
            this.btnFlatTrim.Click += new System.EventHandler(this.btnFlatTrim_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Takeoff";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Land";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEmergency
            // 
            this.btnEmergency.Location = new System.Drawing.Point(569, 12);
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.Size = new System.Drawing.Size(83, 23);
            this.btnEmergency.TabIndex = 6;
            this.btnEmergency.Text = "Emergency";
            this.btnEmergency.UseVisualStyleBackColor = true;
            this.btnEmergency.Click += new System.EventHandler(this.btnEmergency_Click);
            // 
            // tmrStateUpdate
            // 
            this.tmrStateUpdate.Interval = 500;
            this.tmrStateUpdate.Tick += new System.EventHandler(this.tmrStateUpdate_Tick);
            // 
            // btnSwitchCam
            // 
            this.btnSwitchCam.Location = new System.Drawing.Point(563, 407);
            this.btnSwitchCam.Name = "btnSwitchCam";
            this.btnSwitchCam.Size = new System.Drawing.Size(89, 23);
            this.btnSwitchCam.TabIndex = 8;
            this.btnSwitchCam.Text = "Video Channel";
            this.btnSwitchCam.UseVisualStyleBackColor = true;
            this.btnSwitchCam.Click += new System.EventHandler(this.btnSwitchCam_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(174, 441);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 9;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(174, 471);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 10;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(256, 471);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 11;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(338, 470);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(420, 470);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 13;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(338, 441);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 23);
            this.btnForward.TabIndex = 14;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnTurnLeft
            // 
            this.btnTurnLeft.Location = new System.Drawing.Point(257, 442);
            this.btnTurnLeft.Name = "btnTurnLeft";
            this.btnTurnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnTurnLeft.TabIndex = 15;
            this.btnTurnLeft.Text = "Turn Left";
            this.btnTurnLeft.UseVisualStyleBackColor = true;
            this.btnTurnLeft.Click += new System.EventHandler(this.btnTurnLeft_Click);
            // 
            // btnTurnRight
            // 
            this.btnTurnRight.Location = new System.Drawing.Point(419, 442);
            this.btnTurnRight.Name = "btnTurnRight";
            this.btnTurnRight.Size = new System.Drawing.Size(75, 23);
            this.btnTurnRight.TabIndex = 16;
            this.btnTurnRight.Text = "Turn Right";
            this.btnTurnRight.UseVisualStyleBackColor = true;
            this.btnTurnRight.Click += new System.EventHandler(this.btnTurnRight_Click);
            // 
            // btnHover
            // 
            this.btnHover.Location = new System.Drawing.Point(338, 407);
            this.btnHover.Name = "btnHover";
            this.btnHover.Size = new System.Drawing.Size(75, 23);
            this.btnHover.TabIndex = 17;
            this.btnHover.Text = "Hover";
            this.btnHover.UseVisualStyleBackColor = true;
            this.btnHover.Click += new System.EventHandler(this.btnHover_Click);
            // 
            // tvInfo
            // 
            this.tvInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvInfo.Location = new System.Drawing.Point(661, 41);
            this.tvInfo.Name = "tvInfo";
            this.tvInfo.Size = new System.Drawing.Size(213, 612);
            this.tvInfo.TabIndex = 18;
            // 
            // tmrVideoUpdate
            // 
            this.tmrVideoUpdate.Interval = 20;
            this.tmrVideoUpdate.Tick += new System.EventHandler(this.tmrVideoUpdate_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(480, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 23);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnReadConfig
            // 
            this.btnReadConfig.Location = new System.Drawing.Point(563, 442);
            this.btnReadConfig.Name = "btnReadConfig";
            this.btnReadConfig.Size = new System.Drawing.Size(89, 23);
            this.btnReadConfig.TabIndex = 20;
            this.btnReadConfig.Text = "Read Config";
            this.btnReadConfig.UseVisualStyleBackColor = true;
            this.btnReadConfig.Click += new System.EventHandler(this.btnReadConfig_Click);
            // 
            // btnSendConfig
            // 
            this.btnSendConfig.Location = new System.Drawing.Point(563, 471);
            this.btnSendConfig.Name = "btnSendConfig";
            this.btnSendConfig.Size = new System.Drawing.Size(89, 23);
            this.btnSendConfig.TabIndex = 21;
            this.btnSendConfig.Text = "Send Config";
            this.btnSendConfig.UseVisualStyleBackColor = true;
            this.btnSendConfig.Click += new System.EventHandler(this.btnSendConfig_Click);
            // 
            // btnStartRecording
            // 
            this.btnStartRecording.Location = new System.Drawing.Point(209, 12);
            this.btnStartRecording.Name = "btnStartRecording";
            this.btnStartRecording.Size = new System.Drawing.Size(75, 23);
            this.btnStartRecording.TabIndex = 22;
            this.btnStartRecording.Text = "Start Rec.";
            this.btnStartRecording.UseVisualStyleBackColor = true;
            this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
            // 
            // btnStopRecording
            // 
            this.btnStopRecording.Location = new System.Drawing.Point(281, 12);
            this.btnStopRecording.Name = "btnStopRecording";
            this.btnStopRecording.Size = new System.Drawing.Size(75, 23);
            this.btnStopRecording.TabIndex = 23;
            this.btnStopRecording.Text = "Stop Rec.";
            this.btnStopRecording.UseVisualStyleBackColor = true;
            this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
            // 
            // btnReplay
            // 
            this.btnReplay.Location = new System.Drawing.Point(362, 12);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(75, 23);
            this.btnReplay.TabIndex = 24;
            this.btnReplay.Text = "Replay";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // btnAutopilot
            // 
            this.btnAutopilot.Location = new System.Drawing.Point(12, 471);
            this.btnAutopilot.Name = "btnAutopilot";
            this.btnAutopilot.Size = new System.Drawing.Size(75, 23);
            this.btnAutopilot.TabIndex = 25;
            this.btnAutopilot.Text = "Auto&pilot";
            this.btnAutopilot.UseVisualStyleBackColor = true;
            this.btnAutopilot.Click += new System.EventHandler(this.btnAutopilot_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // joyLabel
            // 
            this.joyLabel.AutoSize = true;
            this.joyLabel.Location = new System.Drawing.Point(12, 508);
            this.joyLabel.Name = "joyLabel";
            this.joyLabel.Size = new System.Drawing.Size(45, 13);
            this.joyLabel.TabIndex = 26;
            this.joyLabel.Text = "Joystick";
            // 
            // joyValue
            // 
            this.joyValue.AutoSize = true;
            this.joyValue.Location = new System.Drawing.Point(416, 508);
            this.joyValue.Name = "joyValue";
            this.joyValue.Size = new System.Drawing.Size(101, 13);
            this.joyValue.TabIndex = 27;
            this.joyValue.Text = "roll/pitch    yaw/gaz";
            // 
            // oneHoLabel
            // 
            this.oneHoLabel.AutoSize = true;
            this.oneHoLabel.Location = new System.Drawing.Point(359, 531);
            this.oneHoLabel.Name = "oneHoLabel";
            this.oneHoLabel.Size = new System.Drawing.Size(39, 13);
            this.oneHoLabel.TabIndex = 28;
            this.oneHoLabel.Text = "oneHo";
            this.oneHoLabel.Click += new System.EventHandler(this.oneHoLabel_Click);
            // 
            // oneVeLabel
            // 
            this.oneVeLabel.AutoSize = true;
            this.oneVeLabel.Location = new System.Drawing.Point(360, 564);
            this.oneVeLabel.Name = "oneVeLabel";
            this.oneVeLabel.Size = new System.Drawing.Size(38, 13);
            this.oneVeLabel.TabIndex = 29;
            this.oneVeLabel.Text = "oneVe";
            this.oneVeLabel.Click += new System.EventHandler(this.oneVeLabel_Click);
            // 
            // twoHoLabel
            // 
            this.twoHoLabel.AutoSize = true;
            this.twoHoLabel.Location = new System.Drawing.Point(525, 529);
            this.twoHoLabel.Name = "twoHoLabel";
            this.twoHoLabel.Size = new System.Drawing.Size(38, 13);
            this.twoHoLabel.TabIndex = 30;
            this.twoHoLabel.Text = "twoHo";
            // 
            // trigBtnLabel
            // 
            this.trigBtnLabel.AutoSize = true;
            this.trigBtnLabel.Location = new System.Drawing.Point(524, 562);
            this.trigBtnLabel.Name = "trigBtnLabel";
            this.trigBtnLabel.Size = new System.Drawing.Size(37, 13);
            this.trigBtnLabel.TabIndex = 31;
            this.trigBtnLabel.Text = "trigBtn";
            // 
            // joySettingsBtn
            // 
            this.joySettingsBtn.Location = new System.Drawing.Point(12, 531);
            this.joySettingsBtn.Name = "joySettingsBtn";
            this.joySettingsBtn.Size = new System.Drawing.Size(75, 23);
            this.joySettingsBtn.TabIndex = 32;
            this.joySettingsBtn.Text = "joySettings";
            this.joySettingsBtn.UseVisualStyleBackColor = true;
            this.joySettingsBtn.Click += new System.EventHandler(this.joySettingsBtn_Click);
            // 
            // rollMultSetBox
            // 
            this.rollMultSetBox.DecimalPlaces = 1;
            this.rollMultSetBox.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.rollMultSetBox.Location = new System.Drawing.Point(291, 529);
            this.rollMultSetBox.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rollMultSetBox.Name = "rollMultSetBox";
            this.rollMultSetBox.Size = new System.Drawing.Size(52, 20);
            this.rollMultSetBox.TabIndex = 33;
            this.rollMultSetBox.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
//            this.rollMultSetBox.ValueChanged += new System.EventHandler(this.rollMultSetBox_ValueChanged);
            // 
            // pitchMultSetBox
            // 
            this.pitchMultSetBox.DecimalPlaces = 1;
            this.pitchMultSetBox.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.pitchMultSetBox.Location = new System.Drawing.Point(290, 562);
            this.pitchMultSetBox.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.pitchMultSetBox.Name = "pitchMultSetBox";
            this.pitchMultSetBox.Size = new System.Drawing.Size(52, 20);
            this.pitchMultSetBox.TabIndex = 34;
            this.pitchMultSetBox.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.pitchMultSetBox.ValueChanged += new System.EventHandler(this.pitchMultSetBox_ValueChanged);
            // 
            // yawMultSetBox
            // 
            this.yawMultSetBox.DecimalPlaces = 1;
            this.yawMultSetBox.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.yawMultSetBox.Location = new System.Drawing.Point(578, 527);
            this.yawMultSetBox.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.yawMultSetBox.Name = "yawMultSetBox";
            this.yawMultSetBox.Size = new System.Drawing.Size(52, 20);
            this.yawMultSetBox.TabIndex = 35;
            this.yawMultSetBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.yawMultSetBox.ValueChanged += new System.EventHandler(this.yawMultSetBox_ValueChanged);
            // 
            // gazMultSetBox
            // 
            this.gazMultSetBox.DecimalPlaces = 1;
            this.gazMultSetBox.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.gazMultSetBox.Location = new System.Drawing.Point(578, 560);
            this.gazMultSetBox.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.gazMultSetBox.Name = "gazMultSetBox";
            this.gazMultSetBox.Size = new System.Drawing.Size(52, 20);
            this.gazMultSetBox.TabIndex = 36;
            this.gazMultSetBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gazMultSetBox.ValueChanged += new System.EventHandler(this.gazMultSetBox_ValueChanged);
            // 
            // StartBtnLabel
            // 
            this.StartBtnLabel.AutoSize = true;
            this.StartBtnLabel.Location = new System.Drawing.Point(607, 608);
            this.StartBtnLabel.Name = "StartBtnLabel";
            this.StartBtnLabel.Size = new System.Drawing.Size(45, 13);
            this.StartBtnLabel.TabIndex = 37;
            this.StartBtnLabel.Text = "StartBtn";
            // 
            // maxYaw
            // 
            this.maxYaw.DecimalPlaces = 1;
            this.maxYaw.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.maxYaw.Location = new System.Drawing.Point(107, 529);
            this.maxYaw.Maximum = new decimal(new int[] {
            61,
            0,
            0,
            65536});
            this.maxYaw.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            this.maxYaw.Name = "maxYaw";
            this.maxYaw.Size = new System.Drawing.Size(52, 20);
            this.maxYaw.TabIndex = 38;
            this.maxYaw.Value = new decimal(new int[] {
            61,
            0,
            0,
            65536});
            // 
            // maxVz
            // 
            this.maxVz.DecimalPlaces = 1;
            this.maxVz.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.maxVz.Location = new System.Drawing.Point(107, 562);
            this.maxVz.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.maxVz.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.maxVz.Name = "maxVz";
            this.maxVz.Size = new System.Drawing.Size(52, 20);
            this.maxVz.TabIndex = 39;
            this.maxVz.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // maxYawLabel
            // 
            this.maxYawLabel.AutoSize = true;
            this.maxYawLabel.Location = new System.Drawing.Point(171, 531);
            this.maxYawLabel.Name = "maxYawLabel";
            this.maxYawLabel.Size = new System.Drawing.Size(47, 13);
            this.maxYawLabel.TabIndex = 40;
            this.maxYawLabel.Text = "maxYaw";
            // 
            // maxVzLabel
            // 
            this.maxVzLabel.AutoSize = true;
            this.maxVzLabel.Location = new System.Drawing.Point(171, 564);
            this.maxVzLabel.Name = "maxVzLabel";
            this.maxVzLabel.Size = new System.Drawing.Size(38, 13);
            this.maxVzLabel.TabIndex = 41;
            this.maxVzLabel.Text = "maxVz";
            // 
            // oneHoMulLabel
            // 
            this.oneHoMulLabel.AutoSize = true;
            this.oneHoMulLabel.Location = new System.Drawing.Point(404, 531);
            this.oneHoMulLabel.Name = "oneHoMulLabel";
            this.oneHoMulLabel.Size = new System.Drawing.Size(39, 13);
            this.oneHoMulLabel.TabIndex = 42;
            this.oneHoMulLabel.Text = "oneHo";
            // 
            // oneVeMulLabel
            // 
            this.oneVeMulLabel.AutoSize = true;
            this.oneVeMulLabel.Location = new System.Drawing.Point(405, 564);
            this.oneVeMulLabel.Name = "oneVeMulLabel";
            this.oneVeMulLabel.Size = new System.Drawing.Size(38, 13);
            this.oneVeMulLabel.TabIndex = 43;
            this.oneVeMulLabel.Text = "oneVe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "oneVe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "oneHo";
            // 
            // numericAnimation
            // 
            this.numericAnimation.DecimalPlaces = 1;
            this.numericAnimation.Location = new System.Drawing.Point(25, 619);
            this.numericAnimation.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericAnimation.Name = "numericAnimation";
            this.numericAnimation.Size = new System.Drawing.Size(52, 20);
            this.numericAnimation.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 621);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Animation";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // radioSelect22Hz
            // 
            this.radioSelect22Hz.AutoSize = true;
            this.radioSelect22Hz.Location = new System.Drawing.Point(290, 608);
            this.radioSelect22Hz.Name = "radioSelect22Hz";
            this.radioSelect22Hz.Size = new System.Drawing.Size(104, 17);
            this.radioSelect22Hz.TabIndex = 48;
            this.radioSelect22Hz.TabStop = true;
            this.radioSelect22Hz.Text = "Ultrasound 22Hz";
            this.radioSelect22Hz.UseVisualStyleBackColor = true;
            // 
            // radioSelect25Hz
            // 
            this.radioSelect25Hz.AutoSize = true;
            this.radioSelect25Hz.Location = new System.Drawing.Point(290, 631);
            this.radioSelect25Hz.Name = "radioSelect25Hz";
            this.radioSelect25Hz.Size = new System.Drawing.Size(104, 17);
            this.radioSelect25Hz.TabIndex = 49;
            this.radioSelect25Hz.TabStop = true;
            this.radioSelect25Hz.Text = "Ultrasound 25Hz";
            this.radioSelect25Hz.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 665);
            this.Controls.Add(this.radioSelect25Hz);
            this.Controls.Add(this.radioSelect22Hz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericAnimation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oneVeMulLabel);
            this.Controls.Add(this.oneHoMulLabel);
            this.Controls.Add(this.maxVzLabel);
            this.Controls.Add(this.maxYawLabel);
            this.Controls.Add(this.maxVz);
            this.Controls.Add(this.maxYaw);
            this.Controls.Add(this.StartBtnLabel);
            this.Controls.Add(this.gazMultSetBox);
            this.Controls.Add(this.yawMultSetBox);
            this.Controls.Add(this.pitchMultSetBox);
            this.Controls.Add(this.rollMultSetBox);
            this.Controls.Add(this.joySettingsBtn);
            this.Controls.Add(this.trigBtnLabel);
            this.Controls.Add(this.twoHoLabel);
            this.Controls.Add(this.oneVeLabel);
            this.Controls.Add(this.oneHoLabel);
            this.Controls.Add(this.joyValue);
            this.Controls.Add(this.joyLabel);
            this.Controls.Add(this.btnAutopilot);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.btnStopRecording);
            this.Controls.Add(this.btnStartRecording);
            this.Controls.Add(this.btnSendConfig);
            this.Controls.Add(this.btnReadConfig);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tvInfo);
            this.Controls.Add(this.btnHover);
            this.Controls.Add(this.btnTurnRight);
            this.Controls.Add(this.btnTurnLeft);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnSwitchCam);
            this.Controls.Add(this.btnEmergency);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFlatTrim);
            this.Controls.Add(this.pbVideo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "AR.Drone Control";
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollMultSetBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchMultSetBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawMultSetBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gazMultSetBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxYaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxVz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pbVideo;
        private System.Windows.Forms.Button btnFlatTrim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEmergency;
        private System.Windows.Forms.Timer tmrStateUpdate;
        private System.Windows.Forms.Button btnSwitchCam;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnTurnLeft;
        private System.Windows.Forms.Button btnTurnRight;
        private System.Windows.Forms.Button btnHover;
        private System.Windows.Forms.TreeView tvInfo;
        private System.Windows.Forms.Timer tmrVideoUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReadConfig;
        private System.Windows.Forms.Button btnSendConfig;
        private System.Windows.Forms.Button btnStartRecording;
        private System.Windows.Forms.Button btnStopRecording;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Button btnAutopilot;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label joyLabel;
        private System.Windows.Forms.Label joyValue;
        private System.Windows.Forms.Label oneHoLabel;
        private System.Windows.Forms.Label oneVeLabel;
        private System.Windows.Forms.Label twoHoLabel;
        private System.Windows.Forms.Label trigBtnLabel;
        private System.Windows.Forms.Button joySettingsBtn;
        private System.Windows.Forms.NumericUpDown rollMultSetBox;
        private System.Windows.Forms.NumericUpDown pitchMultSetBox;
        private System.Windows.Forms.NumericUpDown yawMultSetBox;
        private System.Windows.Forms.NumericUpDown gazMultSetBox;
        private System.Windows.Forms.Label StartBtnLabel;
        private System.Windows.Forms.NumericUpDown maxYaw;
        private System.Windows.Forms.NumericUpDown maxVz;
        private System.Windows.Forms.Label maxYawLabel;
        private System.Windows.Forms.Label maxVzLabel;
        private System.Windows.Forms.Label oneHoMulLabel;
        private System.Windows.Forms.Label oneVeMulLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericAnimation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioSelect22Hz;
        private System.Windows.Forms.RadioButton radioSelect25Hz;
    }
}

