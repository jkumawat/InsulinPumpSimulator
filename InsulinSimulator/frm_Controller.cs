using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using InsulinSimulator.Classes;
using System.Timers;

namespace InsulinSimulator
{
    public partial class frmMainSimulator : Form
    {
        private Pump pump;
        private Sensor sensor;
        private List<DateTime> timeInject = new List<DateTime>();
        private Reading lastReading = new Reading(0, DateTime.Now);
        private double avgIncRate = 5;
        private int toleranceLevel = 10;
        private int lvlHigh = 180;
        private int lvlLow = 120;
        private Insulin insInfo = new Insulin();
        private Insulin dose;
        private Random randomGen = new Random();
        private System.Timers.Timer BlinkTimer;
        private System.Timers.Timer simTimer;
        private string MessageAlert = null;
        private int ChartDrawcounter = 15;
        private int timing =1;
        private int timeBatteryLow = 0;
        
        //for drawing chart
        private System.Drawing.Graphics g;
        private System.Drawing.Pen penReading = new System.Drawing.Pen(Color.Blue, 2F);
        private System.Drawing.Pen penAxis = new System.Drawing.Pen(Color.Black, 2F);
        private System.Drawing.Pen penLevelHigh = new System.Drawing.Pen(Color.Red, 2F);
        private System.Drawing.Pen penLevelStable = new System.Drawing.Pen(Color.Green, 2F);
        private System.Drawing.Pen penLevelLow = new System.Drawing.Pen(Color.RosyBrown, 2F);
       
	   
        public frmMainSimulator()
        {
            Start:
            try            
            {
                
                InitializeComponent();
                pump = new Pump();
                sensor = new Sensor();
                simTimer = new System.Timers.Timer(7000); // 7 seconds
                simTimer.Elapsed += new ElapsedEventHandler(OnSimTimerElapsed);
                simTimer.Enabled = true;
                simTimer.SynchronizingObject = this; // Synchronize with current form
                TimeShown.Start();
                simTimer.Start();

                BlinkTimer = new System.Timers.Timer(100);
                BlinkTimer.Elapsed += new ElapsedEventHandler(OnBlinkTimerElapsed);
                BlinkTimer.Enabled = true;
            }
            catch (Exception e)
            {
                goto Start;
            }
                       
        }

        private void OnBlinkTimerElapsed(object source, ElapsedEventArgs e)
        {
            //if (lblBatteryLow .BackColor == Color.Red)
            //    lblBatteryLow.BackColor = Color.Yellow;
            //else if (lblBatteryLow.BackColor == Color.Yellow)
            //    lblBatteryLow.BackColor = Color.Red;

            //if (lblLowSugar.BackColor == Color.Red)
            //    lblLowSugar.BackColor = Color.Yellow;
            //else if (lblLowSugar.BackColor == Color.Yellow)
            //    lblLowSugar.BackColor = Color.Red;

            //if (lblPumpFailure.BackColor == Color.Red)
            //    lblPumpFailure.BackColor = Color.Yellow;
            //else if (lblPumpFailure.BackColor == Color.Yellow)
            //    lblPumpFailure.BackColor = Color.Red;

            //if (lblSensorFailure.BackColor == Color.Red)
            //    lblSensorFailure.BackColor = Color.Yellow;
            //else if (lblSensorFailure.BackColor == Color.Yellow)
            //    lblSensorFailure.BackColor = Color.Red;

            //if (lblBloodSugarHigh.BackColor == Color.Red)
            //    lblBloodSugarHigh.BackColor = Color.Yellow;
            //else if (lblBloodSugarHigh.BackColor == Color.Yellow)
            //    lblBloodSugarHigh.BackColor = Color.Red;

            //if (lblLowInsulinLevel .BackColor == Color.Red)
            //    lblLowInsulinLevel.BackColor = Color.Yellow;
            //else if (lblLowInsulinLevel.BackColor == Color.Yellow)
            //    lblLowInsulinLevel.BackColor = Color.Red;
        }

        private void OnSimTimerElapsed(object source, ElapsedEventArgs e)
        {
            // Do something on the UI thread (same thread the form was 
            // created on)...
            // If we didn't set SynchronizingObject we would be on a 
            // worker thread...

            checkData();
        }

        public void checkData()
        {
            double expReading;
            double rate = 0;
            showStatus();


            if ((sensor.runSelfTest() == (int)Sensor_Status.Ok || sensor.runSelfTest() == (int)Sensor_Status.LowBaterry)
                && (sensor.CurrentStatus  == (int)Sensor_Status.Ok || sensor.CurrentStatus  == Sensor_Status.LowBaterry))
            {
                double currentReading = sensor.readData();
                txtLastValue.Text = lastReading.Read.ToString();
                txtCurrentValue.Text = currentReading.ToString();
                drawChart(currentReading, lastReading.Read);

                if (pump.runSelfTest() == (int)Pump_Status.Ok && pump.CurrentStatus == (int)Pump_Status .Ok )
                {
                    // Pump=Ok
                    pbPump.Image = Image.FromFile("pump_ok.png");
                    gbWarning.Enabled = false;
                    pbWarning.Image = Image.FromFile("warning-icon-disabled.png");

                    if (timeInject.Count != 0)
                    {
                        for (int i = 0; i < timeInject.Count; i++)
                        {
                            DateTime tmp = timeInject[i];
                            long t = (long)(lastReading.TimeStamp - tmp).TotalSeconds;

                            if (t > (insInfo.TimeOfEffect + insInfo.TimeToEffect))
                            {
                                timeInject.Remove(tmp);
                                i--;
                                ShowTimeInject();
                            }

                            else
                            {
                                if (t >= insInfo.TimeToEffect)
                                {
                                    rate += insInfo.EffectPerUnit * Math.Exp(-0.694 * (t - insInfo.TimeToEffect) / insInfo.HalfLife);
                                }
                            }
                        }

                        rate = Math.Round(rate, 2);
                        expReading = lastReading.Read + avgIncRate - rate;
                        expReading = expReading < 0 ? 0 : expReading;

                        if (((currentReading - expReading) > toleranceLevel) && (currentReading > lvlHigh))
                        {

                            if (newInjNeeded())
                            {
                                gbWarning.Enabled = true;
                                gbGlucose.Enabled = true;
                                pbBloodSugar.Image = Image.FromFile("Blood-Sugar-Rising.png");
                                pbWarning.Image = Image.FromFile("warning-icon.png");
                                CheckReservior();
                            }
                        }

                        else if (currentReading > lvlHigh)
                        {
                            gbWarning.Enabled = true;
                            gbGlucose.Enabled = true;
                            pbBloodSugar.Image = Image.FromFile("Blood-Sugar-Rising.png");
                            pbWarning.Image = Image.FromFile("warning-icon.png");

                            if (currentReading > 220)
                            {
                                gbCallDoc.Enabled = true;
                                pbCallDoctor.Image = Image.FromFile("CallDoctor.png");
                                if (currentReading > 250)
                                {
                                    gbDead.Enabled = true;
                                    pbDead.Image = Image.FromFile("Diseased.png");
                                    for (int i = 0; i < 1000; i++)
                                    {
                                        //
                                    }
                                    simTimer.Stop();
                                    TimeShown.Stop();
                                    MessageBox.Show("He's dead Jim T_T, prepare Application restart...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Application.Restart();
                                }
                            }
                        }

                        else if (currentReading < lvlLow)
                        {
                            // Warning - lvlLow
                            gbWarning.Enabled = true;
                            gbEat.Enabled = true;
                            gbGlucose.Enabled = true;

                            pbEat.Image = Image.FromFile("Apple-64.png");
                            pbBloodSugar.Image = Image.FromFile("Blood-Sugar-Falling.png");
                            pbWarning.Image = Image.FromFile("warning-icon.png");

                            if (currentReading < 80)
                            {
                                gbCallDoc.Enabled = true;
                                pbCallDoctor.Image = Image.FromFile("CallDoctor.png");
                                if (currentReading < 10)
                                {
                                    gbDead.Enabled = true;
                                    pbDead.Image = Image.FromFile("Diseased.png");
                                    for (int i = 0; i < 1000; i++)
                                    {
                                        //
                                    }
                                    simTimer.Stop();
                                    TimeShown.Stop();
                                    MessageBox.Show("He's dead Jim T_T, prepare Application restart...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Application.Restart();
                                    
                                }
                            }
                        }

                        else
                        {
                            // Warning - Ok
                            gbWarning.Enabled = false ;
                            pbBloodSugar.Image = Image.FromFile("Blood-Sugar.png");
                            pbWarning.Image = Image.FromFile("warning-icon-disabled.png");
                        }
                    }

                    else
                    {
                        if (currentReading > lvlHigh)
                        {
                            gbWarning.Enabled = true;
                            gbGlucose.Enabled = true;
                            pbBloodSugar.Image = Image.FromFile("Blood-Sugar-Rising.png");
                            pbWarning.Image = Image.FromFile("warning-icon.png");


                            if (currentReading > 220)
                            {
                                gbCallDoc.Enabled = true;
                                pbCallDoctor.Image = Image.FromFile("CallDoctor.png");
                                if (currentReading > 250)
                                {
                                    gbDead.Enabled = true;
                                    pbDead.Image = Image.FromFile("Diseased.png");
                                    for (int i = 0; i < 1000; i++)
                                    {
                                        //
                                    }
                                    simTimer.Stop();
                                    TimeShown.Stop();
                                    MessageBox.Show("He's dead Jim T_T, prepare Application restart...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Application.Restart();
                                }
                            }
                            CheckReservior();
                          


                        }

                        else if (currentReading < lvlLow)
                        {
                            // Warning - lvlLow
                            gbWarning.Enabled = true;
                            gbEat.Enabled = true;
                            gbGlucose.Enabled = true;

                            pbEat.Image = Image.FromFile("Apple-64.png");
                            pbBloodSugar.Image = Image.FromFile("Blood-Sugar-Falling.png");
                            pbWarning.Image = Image.FromFile("warning-icon.png");

                            if (currentReading < 80)
                            {
                                gbCallDoc.Enabled = true;
                                pbCallDoctor.Image = Image.FromFile("CallDoctor.png");
                                if (currentReading < 10)
                                {
                                    gbDead.Enabled = true;
                                    pbDead.Image = Image.FromFile("Diseased.png");
                                    for (int i = 0; i < 1000; i++)
                                    {
                                        //
                                    }
                                    simTimer.Stop();
                                    TimeShown.Stop();
                                    MessageBox.Show("He's dead Jim T_T, prepare Application restart...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Application.Restart();
                                }
                            }
                        }

                        else
                        {
                            // Warning - Ok
                            gbWarning.Enabled = false;
                            gbEat.Enabled = false;
                            pbEat.Image = Image.FromFile("Apple-64-disabled.png");
                            pbBloodSugar.Image = Image.FromFile("Blood-Sugar.png");
                            pbWarning.Image = Image.FromFile("warning-icon-disabled.png");
                        }
                    }
                    lastReading.Read = currentReading;
                    lastReading.TimeStamp = DateTime.Now;
                }

                else
                {
                    //lblPumpFailure.BackColor = Color.Red;
                    gbWarning.Enabled = true;
                    gbWarning.Enabled = true;
                    pbWarning.Image = Image.FromFile("warning-icon.png");
                    pbPump.Image = Image.FromFile("pump_failure.png");
                    

                    if (currentReading > lvlHigh)
                    {
                        //MessageBox.Show("No Injecction Availaible ---> inject");
                        gbWarning.Enabled = true;
                        gbGlucose.Enabled = true;
                        pbBloodSugar.Image = Image.FromFile("Blood-Sugar-Rising.png");
                        pbWarning.Image = Image.FromFile("warning-icon.png");

                        if (currentReading > 220)
                        {
                            gbCallDoc.Enabled = true;
                            pbCallDoctor.Image = Image.FromFile("CallDoctor.png");
                            if (currentReading > 250)
                            {
                                gbDead.Enabled = true;
                                pbDead.Image = Image.FromFile("Diseased.png");
                                for (int i = 0; i < 1000; i++)
                                {
                                    //
                                }
                                simTimer.Stop();
                                TimeShown.Stop();
                                MessageBox.Show("He's dead Jim T_T, prepare Application restart...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Restart();
                            }
                        }
                    }

                    else if (currentReading < lvlLow)
                    {
                        // Warning - lvlLow
                        gbWarning.Enabled = true;
                        gbEat.Enabled = true;
                        gbGlucose.Enabled = true;

                        pbBloodSugar.Image = Image.FromFile("Blood-Sugar-Falling.png");
                        pbEat.Image = Image.FromFile("Apple-64.png");
                        pbWarning.Image = Image.FromFile("warning-icon.png");

                        if (currentReading < 80)
                        {
                            gbCallDoc.Enabled = true;
                            pbCallDoctor.Image = Image.FromFile("CallDoctor.png");
                            if (currentReading < 10)
                            {
                                gbDead.Enabled = true;
                                pbDead.Image = Image.FromFile("Diseased.png");
                                for (int i = 0; i < 1000; i++)
                                {
                                    //
                                }

                                simTimer.Stop();
                                TimeShown.Stop();
                                MessageBox.Show("He's dead Jim T_T, prepare Application restart...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Restart();
                            }
                        }
                    }

                    else
                    {
                        // Warning - Ok
                        gbEat.Enabled = false;
                        pbEat.Image = Image.FromFile("Apple-64-disabled.png");
                        pbBloodSugar.Image = Image.FromFile("Blood-Sugar.png");
                    }
                    lastReading.Read = currentReading;
                    lastReading.TimeStamp = DateTime.Now;
                }
            }

            else
            {
                simTimer.Stop();
                TimeShown.Stop();
                if (Convert.ToDouble (txtCurrentValue.Text) > lvlHigh || Convert.ToDouble(txtCurrentValue.Text) < lvlLow)
                {
                    gbWarning.Enabled = true;
                    gbCallDoc.Enabled = true;
                    pbWarning.Image = Image.FromFile("warning-icon.png");
                    pbSensor .Image =Image.FromFile ("Sensor_Failed.png");
                    pbCallDoctor.Image = Image.FromFile("CallDoctor.png"); 
                    MessageBox.Show("Please Consult your Doctor Immediately.Application Will Restart Again.", "Sensor Malfunction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Restart();
                }
                else
                {
                    gbWarning.Enabled = true;
                    pbWarning.Image = Image.FromFile("warning-icon.png");
                    pbSensor .Image =Image .FromFile ("Sensor_Failed.png");
                    MessageBox.Show("Error: Preparing Emergency Restart !!", "Sensor Malfunctioning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Restart();

                }

                
            }
       
        }

        public void drawChart(double current,double previous)
        {
         ab:      
  
            g = pbGraph.CreateGraphics();

            //For X Axis
            Point Xcord1 = new Point(0, (pbGraph .Height));
            Point Xcord2 = new Point(pbGraph.Width , (pbGraph .Height));
            g.DrawLine(penAxis, Xcord1, Xcord2);
            g.DrawString("In Time", new Font("Cambria", 8), new SolidBrush(Color.Black), pbGraph.Width - (pbGraph.Width / 2), (pbGraph .Height+30) - 45);

            //For Y- Axis
            Point Ycord1 = new Point(pbGraph .Width -(pbGraph .Width -15), 0);
            Point Ycord2 = new Point(pbGraph.Width - (pbGraph.Width - 15),(pbGraph .Height+30));
            g.DrawLine(penAxis, Ycord1, Ycord2);
            g.DrawString("BloodSugar", new Font("Cambria", 8), new SolidBrush(Color.Black), 0, 70);

            //For Level High--Line (Red) (In GUI = 180 -- 60)
            Point Highcord1 = new Point(pbGraph.Width - (pbGraph.Width - 15), (pbGraph .Height+30) - (int)lvlHigh);
            Point Highcord2 = new Point(pbGraph .Width , (pbGraph .Height+30) - (int)lvlHigh);
            g.DrawLine(penLevelHigh, Highcord1, Highcord2);
            g.DrawString("[High]", new Font("Cambria", 11), new SolidBrush(Color.Red), pbGraph.Width - 50, (pbGraph .Height+30) - (int)lvlHigh);

            //For Level low--Line (Brown) (In GUI = 120 -- 100) 
            Point Lowcord1 = new Point(pbGraph.Width - (pbGraph.Width - 15), (pbGraph .Height+30) - (int)lvlLow);
            Point Lowcord2 = new Point(pbGraph.Width, (pbGraph .Height+30) - (int)lvlLow);
            g.DrawLine(penLevelLow, Lowcord1, Lowcord2);
            g.DrawString("[Low]", new Font("Cambria", 11), new SolidBrush(Color.Brown), pbGraph.Width - 50, (pbGraph .Height+30) - (int)lvlLow);

            //For Level stable--Line (Green) (IN GUI = 150 --- (210-150)=-60 )
            Point Stablecord1 = new Point(pbGraph.Width - (pbGraph.Width - 15), (pbGraph .Height+30) - 150);
            Point Stablecord2 = new Point(pbGraph.Width, (pbGraph .Height+30) - 150);
            g.DrawLine(penLevelStable, Stablecord1, Stablecord2);
            g.DrawString("[Stable]", new Font("Cambria", 11), new SolidBrush(Color.Green), pbGraph.Width - 50, (pbGraph .Height+30) - 150);

            if (ChartDrawcounter > (pbGraph.Width - 15))
            {
                ChartDrawcounter = pbGraph.Width - (pbGraph.Width - 15);
                pbGraph.Refresh();
                goto ab;
            }

            Point coord1 = new Point(ChartDrawcounter, (pbGraph .Height+30) - (int)previous);
            Point coord2 = new Point(ChartDrawcounter + 7, (pbGraph .Height+30) - (int)current);
            g.DrawLine(penReading, coord1, coord2);
            ChartDrawcounter += 7;
        }

        public string displayData()
        {
            if (MessageAlert != "")
            {
                return MessageAlert;

            }
            else
                return null;
        }

        public void setDose()
        {
        }

        public void showStatus()
        {
            //if (sensor.runSelfTest() == 0)
            //    lblSensorFailure.BackColor = Color.Red;
            //else
            //    lblSensorFailure.BackColor = Color.Green ;

        }

        public int InsulinIsEmpty()
        {
            return (int)Pump.CurrentStatus;
        }

        public void inject()
        {
            try
            {
                // compute Dose (optional)
                if (pump.runSelfTest() == (int)Pump_Status.Ok)
                {
                    pump.PumpInsulin();
                    DateTime tmp = DateTime.Now;
                    timeInject.Add(tmp);
                    sensor.addTimeInject(tmp);
                    //MessageBox.Show(timeInject.Count.ToString());  

                    // SimTimer.addTimeInject(DateTime.Now);
                }

                else
                {
                    // Warning - PumpFailure
                }
            }
            catch (Exception e)
            {
                // reset normal behaviour
            }
        }

        public bool newInjNeeded()
        {
            foreach (DateTime tmp in timeInject)
            {
                if ((long)(lastReading.TimeStamp - tmp).TotalSeconds < insInfo.TimeToEffect)
                    return false;
            }

            return true;
        }

        public Pump Pump
        {
            get { return pump; }
        }

        public Sensor Sensor
        {
            get { return sensor; }
        }

        public List<DateTime> TimeInject
        {
            get { return timeInject; }
            set { timeInject = value; }
        }

        public Reading LastReading
        {
            get { return lastReading; }
            set { lastReading = value; }
        }

        public Insulin Dose
        {
            get { return dose; }
            set { dose = value; }
        }

        public double AvgIncRate
        {
            get { return avgIncRate; }
        }

        public int ToleranceLevel
        {
            get { return toleranceLevel; }
        }

        private void frmMainSimulator_Load(object sender, EventArgs e)
        {
            cmbErrorGenerate.SelectedIndex = 0;
           
        }

        public void ShowTimeInject()
        {
            switch (timeInject.Count) 
            {
                case 0:
                    pbInjection.Image = Image.FromFile("Insulin_Injection_None.png");
                    break;
                case 1:
                    pbInjection.Image = Image.FromFile("Insulin_Injection_one.png");
                    break;
                case 2:
                    pbInjection.Image = Image.FromFile("Insulin_Injection_two.png");
                    break;
                case 3:
                    pbInjection.Image = Image.FromFile("Insulin_Injection_three.png");
                    break;
                case 4:
                    pbInjection.Image = Image.FromFile("Insulin_Injection_four.png");
                    break;
                case 5:
                    pbInjection.Image = Image.FromFile("Insulin_Injection_five.png");
                    break;
                default:
                    pbInjection.Image = Image.FromFile("Insulin_Injection_None.png");
                    break;

            }
        }

        private void TimeShown_Tick(object sender, EventArgs e)
        {
            if (sensor.CurrentStatus == Sensor_Status.LowBaterry)
            {
                timeBatteryLow++;
            }

            if (timeBatteryLow > 30)
            {
                timeBatteryLow = 0;
                sensor.CurrentStatus = Sensor_Status.Malfunctioning;
            }

            if (timing > 60)
            {
                timing++;
                lblTimer.Text = Convert.ToString(timing / 60) + ":" + Convert.ToString(timing % 60) + "  Seconds";

                // Battery life is 4 Minute So check if 4 min over then Battery Charge Require
                if (((timing / 60) % 2) == 0 && (timing % 60) == 0)
                {
                    sensor.CurrentStatus = Sensor_Status.LowBaterry;
                    pbBattery.Image = Image.FromFile("battery_low.png");
                    pbWarning.Image = Image.FromFile("warning-icon.png");
                }
            }
            else
            { 
                lblTimer.Text = Convert.ToString(timing++) + "  Seconds"; 
            }
        }

        private void btnFillInsuline_Click(object sender, EventArgs e)
        {
            pump.CurrentReserve = 20;
            pbRepository.Image = Image.FromFile("Repository3of3.png");

            if (Convert.ToDouble(txtCurrentValue.Text) < lvlHigh &&
                Convert.ToDouble(txtCurrentValue.Text) > lvlLow &&
                pump.CurrentStatus == Pump_Status.Ok &&
                sensor.CurrentStatus == Sensor_Status.Ok)
            {                
                pbWarning.Image = Image.FromFile("warning-icon-disabled.png");
            }
         }

        private void btnChargeBattery_Click(object sender, EventArgs e)
        {
            //lblBatteryLow.BackColor = Color.Green;

            sensor.CurrentStatus = Sensor_Status.Ok;
            pbBattery.Image = Image.FromFile("battery_high.png");

            if (Convert.ToDouble(txtCurrentValue.Text) < lvlHigh &&
                Convert.ToDouble(txtCurrentValue.Text) > lvlLow &&
                pump.CurrentStatus == Pump_Status.Ok &&
                sensor.CurrentStatus == Sensor_Status.Ok)
            {
                
                pbWarning.Image = Image.FromFile("warning-icon-disabled.png");
            }
        }

        private void btnFailureGenerate_Click_1(object sender, EventArgs e)
        {
            switch (cmbErrorGenerate.SelectedIndex)
            {
                case 0:
                    // All Error Reset
                    pump.CurrentStatus = Pump_Status.Ok;
                    sensor.CurrentStatus = Sensor_Status.Ok;
                    break;
                case 1:
                    //sensor Fail
                    sensor.CurrentStatus = Sensor_Status.Malfunctioning;
                    break;
                case 2:
                    //pump fail
                    pump.CurrentStatus = Pump_Status.Malfunctioning;
                    break;
                case 3:
                    //Remain in Low level
                    for (int i = 0; i < 2; i++)
                    {
                        CheckReservior();
                        ShowTimeInject();
                    }
                    break;
                case 4:
                    //Remain in high level
                    pump.CurrentStatus = Pump_Status.Malfunctioning;
                    break;
                default:
                    break;
            }                  

        }

        public void CheckReservior()
        {          
            if (pump.CurrentReserve >= 20 || pump.CurrentReserve >= 15 )
            {            
                inject();
                pbRepository.Image = Image.FromFile("Repository2of3.png");                
            }

            else if (pump.CurrentReserve >= 10)
            {
                
                inject();
                pbRepository.Image = Image.FromFile("Repository1of3.png");
            }

            else if (pump.CurrentReserve >= 5)
            {
               
                inject();
                pbRepository.Image = Image.FromFile("Repository0of3.png");
                pbWarning.Image = Image.FromFile("warning-icon.png");
            }

            ShowTimeInject();
        }
    }
}
