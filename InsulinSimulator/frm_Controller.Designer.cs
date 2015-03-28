namespace InsulinSimulator
{
    partial class frmMainSimulator
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbReading = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCurrentValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeShown = new System.Windows.Forms.Timer(this.components);
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.gbCallDoc = new System.Windows.Forms.GroupBox();
            this.pbCallDoctor = new System.Windows.Forms.PictureBox();
            this.gbGlucose = new System.Windows.Forms.GroupBox();
            this.pbBloodSugar = new System.Windows.Forms.PictureBox();
            this.gbEat = new System.Windows.Forms.GroupBox();
            this.pbEat = new System.Windows.Forms.PictureBox();
            this.gbSensor = new System.Windows.Forms.GroupBox();
            this.pbSensor = new System.Windows.Forms.PictureBox();
            this.gbPump = new System.Windows.Forms.GroupBox();
            this.pbPump = new System.Windows.Forms.PictureBox();
            this.gbDead = new System.Windows.Forms.GroupBox();
            this.pbDead = new System.Windows.Forms.PictureBox();
            this.gbRepository = new System.Windows.Forms.GroupBox();
            this.pbRepository = new System.Windows.Forms.PictureBox();
            this.gbBattery = new System.Windows.Forms.GroupBox();
            this.pbBattery = new System.Windows.Forms.PictureBox();
            this.gbInjections = new System.Windows.Forms.GroupBox();
            this.pbInjection = new System.Windows.Forms.PictureBox();
            this.gbWarning = new System.Windows.Forms.GroupBox();
            this.pbWarning = new System.Windows.Forms.PictureBox();
            this.gbGraph = new System.Windows.Forms.GroupBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pbGraph = new System.Windows.Forms.PictureBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gbClockTimer = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.gbHardwareReset = new System.Windows.Forms.GroupBox();
            this.btnFillInsuline = new System.Windows.Forms.Button();
            this.btnChargeBattery = new System.Windows.Forms.Button();
            this.gbGenerateEvents = new System.Windows.Forms.GroupBox();
            this.cmbErrorGenerate = new System.Windows.Forms.ComboBox();
            this.btnFailureGenerate = new System.Windows.Forms.Button();
            this.gbReading.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbCallDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCallDoctor)).BeginInit();
            this.gbGlucose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBloodSugar)).BeginInit();
            this.gbEat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEat)).BeginInit();
            this.gbSensor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor)).BeginInit();
            this.gbPump.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPump)).BeginInit();
            this.gbDead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDead)).BeginInit();
            this.gbRepository.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRepository)).BeginInit();
            this.gbBattery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBattery)).BeginInit();
            this.gbInjections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInjection)).BeginInit();
            this.gbWarning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarning)).BeginInit();
            this.gbGraph.SuspendLayout();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).BeginInit();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.gbClockTimer.SuspendLayout();
            this.gbHardwareReset.SuspendLayout();
            this.gbGenerateEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Value";
            // 
            // gbReading
            // 
            this.gbReading.BackColor = System.Drawing.Color.Transparent;
            this.gbReading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbReading.Controls.Add(this.label4);
            this.gbReading.Controls.Add(this.label3);
            this.gbReading.Controls.Add(this.txtLastValue);
            this.gbReading.Controls.Add(this.label10);
            this.gbReading.Controls.Add(this.txtCurrentValue);
            this.gbReading.Controls.Add(this.label2);
            this.gbReading.Controls.Add(this.label1);
            this.gbReading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbReading.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbReading.Location = new System.Drawing.Point(6, 15);
            this.gbReading.Name = "gbReading";
            this.gbReading.Size = new System.Drawing.Size(589, 59);
            this.gbReading.TabIndex = 1;
            this.gbReading.TabStop = false;
            this.gbReading.Text = "Sensor Reading Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "mg/dL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "mg/dL";
            // 
            // txtLastValue
            // 
            this.txtLastValue.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastValue.Location = new System.Drawing.Point(353, 23);
            this.txtLastValue.Name = "txtLastValue";
            this.txtLastValue.Size = new System.Drawing.Size(64, 26);
            this.txtLastValue.TabIndex = 4;
            this.txtLastValue.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(267, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Last Value";
            // 
            // txtCurrentValue
            // 
            this.txtCurrentValue.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentValue.Location = new System.Drawing.Point(115, 23);
            this.txtCurrentValue.Name = "txtCurrentValue";
            this.txtCurrentValue.Size = new System.Drawing.Size(67, 26);
            this.txtCurrentValue.TabIndex = 2;
            this.txtCurrentValue.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            // 
            // TimeShown
            // 
            this.TimeShown.Enabled = true;
            this.TimeShown.Interval = 1000;
            this.TimeShown.Tick += new System.EventHandler(this.TimeShown_Tick);
            // 
            // gbStatus
            // 
            this.gbStatus.BackColor = System.Drawing.Color.Transparent;
            this.gbStatus.Controls.Add(this.gbCallDoc);
            this.gbStatus.Controls.Add(this.gbGlucose);
            this.gbStatus.Controls.Add(this.gbEat);
            this.gbStatus.Controls.Add(this.gbSensor);
            this.gbStatus.Controls.Add(this.gbPump);
            this.gbStatus.Controls.Add(this.gbDead);
            this.gbStatus.Controls.Add(this.gbRepository);
            this.gbStatus.Controls.Add(this.gbBattery);
            this.gbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbStatus.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbStatus.Location = new System.Drawing.Point(6, 340);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(417, 199);
            this.gbStatus.TabIndex = 5;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Simulator Status";
            // 
            // gbCallDoc
            // 
            this.gbCallDoc.BackColor = System.Drawing.Color.Transparent;
            this.gbCallDoc.Controls.Add(this.pbCallDoctor);
            this.gbCallDoc.Enabled = false;
            this.gbCallDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbCallDoc.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCallDoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbCallDoc.Location = new System.Drawing.Point(8, 100);
            this.gbCallDoc.Name = "gbCallDoc";
            this.gbCallDoc.Size = new System.Drawing.Size(90, 90);
            this.gbCallDoc.TabIndex = 11;
            this.gbCallDoc.TabStop = false;
            this.gbCallDoc.Text = "Call Doc";
            // 
            // pbCallDoctor
            // 
            this.pbCallDoctor.ErrorImage = null;
            this.pbCallDoctor.Image = global::InsulinSimulator.Properties.Resources.CallDoctor_disabled;
            this.pbCallDoctor.InitialImage = null;
            this.pbCallDoctor.Location = new System.Drawing.Point(13, 17);
            this.pbCallDoctor.Name = "pbCallDoctor";
            this.pbCallDoctor.Size = new System.Drawing.Size(64, 64);
            this.pbCallDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCallDoctor.TabIndex = 10;
            this.pbCallDoctor.TabStop = false;
            // 
            // gbGlucose
            // 
            this.gbGlucose.BackColor = System.Drawing.Color.Transparent;
            this.gbGlucose.Controls.Add(this.pbBloodSugar);
            this.gbGlucose.Enabled = false;
            this.gbGlucose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbGlucose.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGlucose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbGlucose.Location = new System.Drawing.Point(213, 100);
            this.gbGlucose.Name = "gbGlucose";
            this.gbGlucose.Size = new System.Drawing.Size(90, 90);
            this.gbGlucose.TabIndex = 14;
            this.gbGlucose.TabStop = false;
            this.gbGlucose.Text = "Glucose";
            // 
            // pbBloodSugar
            // 
            this.pbBloodSugar.Enabled = false;
            this.pbBloodSugar.ErrorImage = null;
            this.pbBloodSugar.Image = global::InsulinSimulator.Properties.Resources.Blood_Sugar_disabled;
            this.pbBloodSugar.InitialImage = null;
            this.pbBloodSugar.Location = new System.Drawing.Point(13, 17);
            this.pbBloodSugar.Name = "pbBloodSugar";
            this.pbBloodSugar.Size = new System.Drawing.Size(64, 64);
            this.pbBloodSugar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBloodSugar.TabIndex = 10;
            this.pbBloodSugar.TabStop = false;
            // 
            // gbEat
            // 
            this.gbEat.BackColor = System.Drawing.Color.Transparent;
            this.gbEat.Controls.Add(this.pbEat);
            this.gbEat.Enabled = false;
            this.gbEat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbEat.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbEat.Location = new System.Drawing.Point(318, 100);
            this.gbEat.Name = "gbEat";
            this.gbEat.Size = new System.Drawing.Size(90, 90);
            this.gbEat.TabIndex = 12;
            this.gbEat.TabStop = false;
            this.gbEat.Text = "Eat";
            // 
            // pbEat
            // 
            this.pbEat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pbEat.ErrorImage = null;
            this.pbEat.Image = global::InsulinSimulator.Properties.Resources.Apple_64_disabled;
            this.pbEat.InitialImage = null;
            this.pbEat.Location = new System.Drawing.Point(14, 17);
            this.pbEat.Name = "pbEat";
            this.pbEat.Size = new System.Drawing.Size(64, 64);
            this.pbEat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEat.TabIndex = 10;
            this.pbEat.TabStop = false;
            // 
            // gbSensor
            // 
            this.gbSensor.BackColor = System.Drawing.Color.Transparent;
            this.gbSensor.Controls.Add(this.pbSensor);
            this.gbSensor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbSensor.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSensor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbSensor.Location = new System.Drawing.Point(111, 11);
            this.gbSensor.Name = "gbSensor";
            this.gbSensor.Size = new System.Drawing.Size(90, 90);
            this.gbSensor.TabIndex = 13;
            this.gbSensor.TabStop = false;
            this.gbSensor.Text = "Sensor";
            // 
            // pbSensor
            // 
            this.pbSensor.ErrorImage = null;
            this.pbSensor.Image = global::InsulinSimulator.Properties.Resources.Sensor_Workin;
            this.pbSensor.InitialImage = null;
            this.pbSensor.Location = new System.Drawing.Point(13, 18);
            this.pbSensor.Name = "pbSensor";
            this.pbSensor.Size = new System.Drawing.Size(64, 64);
            this.pbSensor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSensor.TabIndex = 10;
            this.pbSensor.TabStop = false;
            // 
            // gbPump
            // 
            this.gbPump.BackColor = System.Drawing.Color.Transparent;
            this.gbPump.Controls.Add(this.pbPump);
            this.gbPump.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbPump.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPump.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbPump.Location = new System.Drawing.Point(8, 11);
            this.gbPump.Name = "gbPump";
            this.gbPump.Size = new System.Drawing.Size(90, 90);
            this.gbPump.TabIndex = 12;
            this.gbPump.TabStop = false;
            this.gbPump.Text = "Pump";
            // 
            // pbPump
            // 
            this.pbPump.ErrorImage = null;
            this.pbPump.Image = global::InsulinSimulator.Properties.Resources.pump_ok1;
            this.pbPump.InitialImage = null;
            this.pbPump.Location = new System.Drawing.Point(14, 18);
            this.pbPump.Name = "pbPump";
            this.pbPump.Size = new System.Drawing.Size(64, 64);
            this.pbPump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPump.TabIndex = 10;
            this.pbPump.TabStop = false;
            // 
            // gbDead
            // 
            this.gbDead.BackColor = System.Drawing.Color.Transparent;
            this.gbDead.Controls.Add(this.pbDead);
            this.gbDead.Enabled = false;
            this.gbDead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbDead.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDead.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbDead.Location = new System.Drawing.Point(111, 100);
            this.gbDead.Name = "gbDead";
            this.gbDead.Size = new System.Drawing.Size(90, 90);
            this.gbDead.TabIndex = 13;
            this.gbDead.TabStop = false;
            this.gbDead.Text = "Dead";
            // 
            // pbDead
            // 
            this.pbDead.ErrorImage = null;
            this.pbDead.Image = global::InsulinSimulator.Properties.Resources.Diseased_disabled;
            this.pbDead.InitialImage = null;
            this.pbDead.Location = new System.Drawing.Point(13, 15);
            this.pbDead.Name = "pbDead";
            this.pbDead.Size = new System.Drawing.Size(64, 64);
            this.pbDead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDead.TabIndex = 10;
            this.pbDead.TabStop = false;
            // 
            // gbRepository
            // 
            this.gbRepository.BackColor = System.Drawing.Color.Transparent;
            this.gbRepository.Controls.Add(this.pbRepository);
            this.gbRepository.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbRepository.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRepository.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbRepository.Location = new System.Drawing.Point(318, 11);
            this.gbRepository.Name = "gbRepository";
            this.gbRepository.Size = new System.Drawing.Size(90, 90);
            this.gbRepository.TabIndex = 11;
            this.gbRepository.TabStop = false;
            this.gbRepository.Text = "Repository";
            // 
            // pbRepository
            // 
            this.pbRepository.ErrorImage = null;
            this.pbRepository.Image = global::InsulinSimulator.Properties.Resources.Repository3of3;
            this.pbRepository.InitialImage = null;
            this.pbRepository.Location = new System.Drawing.Point(13, 18);
            this.pbRepository.Name = "pbRepository";
            this.pbRepository.Size = new System.Drawing.Size(64, 64);
            this.pbRepository.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRepository.TabIndex = 10;
            this.pbRepository.TabStop = false;
            // 
            // gbBattery
            // 
            this.gbBattery.BackColor = System.Drawing.Color.Transparent;
            this.gbBattery.Controls.Add(this.pbBattery);
            this.gbBattery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbBattery.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBattery.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbBattery.Location = new System.Drawing.Point(213, 11);
            this.gbBattery.Name = "gbBattery";
            this.gbBattery.Size = new System.Drawing.Size(90, 90);
            this.gbBattery.TabIndex = 9;
            this.gbBattery.TabStop = false;
            this.gbBattery.Text = "Battery";
            // 
            // pbBattery
            // 
            this.pbBattery.ErrorImage = null;
            this.pbBattery.Image = global::InsulinSimulator.Properties.Resources.battery_high;
            this.pbBattery.InitialImage = null;
            this.pbBattery.Location = new System.Drawing.Point(14, 18);
            this.pbBattery.Name = "pbBattery";
            this.pbBattery.Size = new System.Drawing.Size(64, 64);
            this.pbBattery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBattery.TabIndex = 10;
            this.pbBattery.TabStop = false;
            // 
            // gbInjections
            // 
            this.gbInjections.BackColor = System.Drawing.Color.Transparent;
            this.gbInjections.Controls.Add(this.pbInjection);
            this.gbInjections.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbInjections.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInjections.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbInjections.Location = new System.Drawing.Point(601, 81);
            this.gbInjections.Name = "gbInjections";
            this.gbInjections.Size = new System.Drawing.Size(120, 119);
            this.gbInjections.TabIndex = 7;
            this.gbInjections.TabStop = false;
            this.gbInjections.Text = "Injections";
            // 
            // pbInjection
            // 
            this.pbInjection.ErrorImage = null;
            this.pbInjection.Image = global::InsulinSimulator.Properties.Resources.Insulin_Injection_None;
            this.pbInjection.InitialImage = null;
            this.pbInjection.Location = new System.Drawing.Point(25, 32);
            this.pbInjection.Name = "pbInjection";
            this.pbInjection.Size = new System.Drawing.Size(64, 64);
            this.pbInjection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInjection.TabIndex = 11;
            this.pbInjection.TabStop = false;
            // 
            // gbWarning
            // 
            this.gbWarning.BackColor = System.Drawing.Color.Transparent;
            this.gbWarning.Controls.Add(this.pbWarning);
            this.gbWarning.Enabled = false;
            this.gbWarning.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbWarning.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWarning.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbWarning.Location = new System.Drawing.Point(601, 206);
            this.gbWarning.Name = "gbWarning";
            this.gbWarning.Size = new System.Drawing.Size(120, 126);
            this.gbWarning.TabIndex = 8;
            this.gbWarning.TabStop = false;
            this.gbWarning.Text = "Warning";
            // 
            // pbWarning
            // 
            this.pbWarning.ErrorImage = null;
            this.pbWarning.Image = global::InsulinSimulator.Properties.Resources.warning_icon_disabled;
            this.pbWarning.InitialImage = null;
            this.pbWarning.Location = new System.Drawing.Point(25, 36);
            this.pbWarning.Name = "pbWarning";
            this.pbWarning.Size = new System.Drawing.Size(64, 64);
            this.pbWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarning.TabIndex = 10;
            this.pbWarning.TabStop = false;
            // 
            // gbGraph
            // 
            this.gbGraph.BackColor = System.Drawing.Color.Transparent;
            this.gbGraph.Controls.Add(this.groupBox17);
            this.gbGraph.Controls.Add(this.pbGraph);
            this.gbGraph.Controls.Add(this.groupBox15);
            this.gbGraph.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbGraph.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGraph.ForeColor = System.Drawing.Color.Black;
            this.gbGraph.Location = new System.Drawing.Point(6, 81);
            this.gbGraph.Name = "gbGraph";
            this.gbGraph.Size = new System.Drawing.Size(589, 253);
            this.gbGraph.TabIndex = 9;
            this.gbGraph.TabStop = false;
            this.gbGraph.Text = "Graphical View";
            // 
            // groupBox17
            // 
            this.groupBox17.BackColor = System.Drawing.Color.Transparent;
            this.groupBox17.Controls.Add(this.pictureBox7);
            this.groupBox17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox17.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox17.Location = new System.Drawing.Point(356, 360);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(77, 88);
            this.groupBox17.TabIndex = 14;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Glucose";
            // 
            // pictureBox7
            // 
            this.pictureBox7.ErrorImage = null;
            this.pictureBox7.Image = global::InsulinSimulator.Properties.Resources.Blood_Sugar;
            this.pictureBox7.InitialImage = null;
            this.pictureBox7.Location = new System.Drawing.Point(6, 17);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 64);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // pbGraph
            // 
            this.pbGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGraph.BackColor = System.Drawing.Color.White;
            this.pbGraph.Enabled = false;
            this.pbGraph.Location = new System.Drawing.Point(6, 22);
            this.pbGraph.Name = "pbGraph";
            this.pbGraph.Size = new System.Drawing.Size(577, 225);
            this.pbGraph.TabIndex = 6;
            this.pbGraph.TabStop = false;
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.Transparent;
            this.groupBox15.Controls.Add(this.pictureBox5);
            this.groupBox15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox15.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox15.Location = new System.Drawing.Point(436, 359);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(75, 88);
            this.groupBox15.TabIndex = 13;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Dead";
            // 
            // pictureBox5
            // 
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.Image = global::InsulinSimulator.Properties.Resources.Diseased;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(6, 17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // gbClockTimer
            // 
            this.gbClockTimer.BackColor = System.Drawing.Color.Transparent;
            this.gbClockTimer.Controls.Add(this.lblTimer);
            this.gbClockTimer.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbClockTimer.Location = new System.Drawing.Point(601, 15);
            this.gbClockTimer.Name = "gbClockTimer";
            this.gbClockTimer.Size = new System.Drawing.Size(120, 60);
            this.gbClockTimer.TabIndex = 10;
            this.gbClockTimer.TabStop = false;
            this.gbClockTimer.Text = "Clock";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(6, 23);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(46, 19);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "Time";
            // 
            // gbHardwareReset
            // 
            this.gbHardwareReset.BackColor = System.Drawing.Color.Transparent;
            this.gbHardwareReset.Controls.Add(this.btnFillInsuline);
            this.gbHardwareReset.Controls.Add(this.btnChargeBattery);
            this.gbHardwareReset.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbHardwareReset.Location = new System.Drawing.Point(429, 441);
            this.gbHardwareReset.Name = "gbHardwareReset";
            this.gbHardwareReset.Size = new System.Drawing.Size(292, 96);
            this.gbHardwareReset.TabIndex = 11;
            this.gbHardwareReset.TabStop = false;
            this.gbHardwareReset.Text = "Hardware Reset";
            // 
            // btnFillInsuline
            // 
            this.btnFillInsuline.Location = new System.Drawing.Point(16, 61);
            this.btnFillInsuline.Name = "btnFillInsuline";
            this.btnFillInsuline.Size = new System.Drawing.Size(165, 23);
            this.btnFillInsuline.TabIndex = 3;
            this.btnFillInsuline.Text = "Fill Insulin Repository";
            this.btnFillInsuline.UseVisualStyleBackColor = true;
            this.btnFillInsuline.Click += new System.EventHandler(this.btnFillInsuline_Click);
            // 
            // btnChargeBattery
            // 
            this.btnChargeBattery.Location = new System.Drawing.Point(16, 25);
            this.btnChargeBattery.Name = "btnChargeBattery";
            this.btnChargeBattery.Size = new System.Drawing.Size(168, 23);
            this.btnChargeBattery.TabIndex = 0;
            this.btnChargeBattery.Text = "Charge Battery";
            this.btnChargeBattery.UseVisualStyleBackColor = true;
            this.btnChargeBattery.Click += new System.EventHandler(this.btnChargeBattery_Click);
            // 
            // gbGenerateEvents
            // 
            this.gbGenerateEvents.Controls.Add(this.cmbErrorGenerate);
            this.gbGenerateEvents.Controls.Add(this.btnFailureGenerate);
            this.gbGenerateEvents.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbGenerateEvents.Location = new System.Drawing.Point(429, 340);
            this.gbGenerateEvents.Name = "gbGenerateEvents";
            this.gbGenerateEvents.Size = new System.Drawing.Size(292, 93);
            this.gbGenerateEvents.TabIndex = 4;
            this.gbGenerateEvents.TabStop = false;
            this.gbGenerateEvents.Text = "Generate Events";
            // 
            // cmbErrorGenerate
            // 
            this.cmbErrorGenerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbErrorGenerate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbErrorGenerate.FormattingEnabled = true;
            this.cmbErrorGenerate.Items.AddRange(new object[] {
            "(None)",
            "Sensor Failure",
            "Pump Failure",
            "Remain Low Level",
            "Remain High Level"});
            this.cmbErrorGenerate.Location = new System.Drawing.Point(13, 22);
            this.cmbErrorGenerate.Name = "cmbErrorGenerate";
            this.cmbErrorGenerate.Size = new System.Drawing.Size(229, 23);
            this.cmbErrorGenerate.TabIndex = 4;
            // 
            // btnFailureGenerate
            // 
            this.btnFailureGenerate.Location = new System.Drawing.Point(13, 57);
            this.btnFailureGenerate.Name = "btnFailureGenerate";
            this.btnFailureGenerate.Size = new System.Drawing.Size(147, 23);
            this.btnFailureGenerate.TabIndex = 3;
            this.btnFailureGenerate.Text = "Failure Generate";
            this.btnFailureGenerate.UseVisualStyleBackColor = true;
            this.btnFailureGenerate.Click += new System.EventHandler(this.btnFailureGenerate_Click_1);
            // 
            // frmMainSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(730, 541);
            this.Controls.Add(this.gbGenerateEvents);
            this.Controls.Add(this.gbHardwareReset);
            this.Controls.Add(this.gbClockTimer);
            this.Controls.Add(this.gbGraph);
            this.Controls.Add(this.gbWarning);
            this.Controls.Add(this.gbInjections);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbReading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainSimulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insulin Pump Simulator";
            this.Load += new System.EventHandler(this.frmMainSimulator_Load);
            this.gbReading.ResumeLayout(false);
            this.gbReading.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbCallDoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCallDoctor)).EndInit();
            this.gbGlucose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBloodSugar)).EndInit();
            this.gbEat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEat)).EndInit();
            this.gbSensor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor)).EndInit();
            this.gbPump.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPump)).EndInit();
            this.gbDead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDead)).EndInit();
            this.gbRepository.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRepository)).EndInit();
            this.gbBattery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBattery)).EndInit();
            this.gbInjections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbInjection)).EndInit();
            this.gbWarning.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWarning)).EndInit();
            this.gbGraph.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).EndInit();
            this.groupBox15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.gbClockTimer.ResumeLayout(false);
            this.gbClockTimer.PerformLayout();
            this.gbHardwareReset.ResumeLayout(false);
            this.gbGenerateEvents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbReading;
        private System.Windows.Forms.TextBox txtCurrentValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer TimeShown;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.TextBox txtLastValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbGraph;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbInjections;
        private System.Windows.Forms.GroupBox gbWarning;
        private System.Windows.Forms.GroupBox gbGraph;
        private System.Windows.Forms.GroupBox gbClockTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.GroupBox gbHardwareReset;
        private System.Windows.Forms.Button btnChargeBattery;
        private System.Windows.Forms.Button btnFillInsuline;
        private System.Windows.Forms.PictureBox pbWarning;
        private System.Windows.Forms.GroupBox gbCallDoc;
        private System.Windows.Forms.PictureBox pbCallDoctor;
        private System.Windows.Forms.GroupBox gbEat;
        private System.Windows.Forms.PictureBox pbEat;
        private System.Windows.Forms.GroupBox gbGlucose;
        private System.Windows.Forms.PictureBox pbBloodSugar;
        private System.Windows.Forms.GroupBox gbDead;
        private System.Windows.Forms.PictureBox pbDead;
        private System.Windows.Forms.GroupBox gbBattery;
        private System.Windows.Forms.PictureBox pbBattery;
        private System.Windows.Forms.GroupBox gbRepository;
        private System.Windows.Forms.PictureBox pbRepository;
        private System.Windows.Forms.GroupBox gbSensor;
        private System.Windows.Forms.PictureBox pbSensor;
        private System.Windows.Forms.GroupBox gbPump;
        private System.Windows.Forms.PictureBox pbPump;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pbInjection;
        private System.Windows.Forms.GroupBox gbGenerateEvents;
        private System.Windows.Forms.ComboBox cmbErrorGenerate;
        private System.Windows.Forms.Button btnFailureGenerate;
    }
}

