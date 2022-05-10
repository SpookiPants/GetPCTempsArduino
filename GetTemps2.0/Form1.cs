using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;
using OpenHardwareMonitor;
using System.IO.Ports;



namespace GetTemps2._0
{
    public partial class Form1 : Form
    {

        Computer myComputer;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myComputer = new Computer() { CPUEnabled = true };
            myComputer.Open();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string hardwareName = "";
            float temp = 0;
            byte count = 0;
            float totalLoad = 0, load1 = 0, load2 = 0, load3 = 0, load4 = 0;

            foreach (var hardwareItem in myComputer.Hardware)
            {

                if (hardwareItem.HardwareType == HardwareType.CPU)
                {
                    hardwareItem.Update();
                    foreach (IHardware subHardware in hardwareItem.SubHardware)
                    {

                        subHardware.Update();
                    }

                    foreach (var name in hardwareItem.Name)
                    {

                        hardwareName += name;
                    }

                    foreach (var sensor in hardwareItem.Sensors)
                    {

                        if (sensor.SensorType == SensorType.Temperature)
                        {

                            temp = sensor.Value.Value;
                        }

                        else if (sensor.SensorType == SensorType.Load)
                        {

                            count++;
                            switch (count)
                            {

                                case 1:
                                    load1 = sensor.Value.Value;
                                    break;
                                case 2:
                                    load2 = sensor.Value.Value;
                                    break;
                                case 3:
                                    load3 = sensor.Value.Value;
                                    break;
                                case 4:
                                    load4 = sensor.Value.Value;
                                    break;
                                case 5:
                                    totalLoad = sensor.Value.Value;
                                    break;
                            }
                        }
                    }

                    label_hardwareName.Text = "Processor: " + hardwareName;

                    progressBar_totalLoad.Value = Convert.ToInt32(Math.Round(totalLoad));
                    progressBar_core1Load.Value = Convert.ToInt32(Math.Round(load1));
                    progressBar_core2Load.Value = Convert.ToInt32(Math.Round(load2));
                    progressBar_core3Load.Value = Convert.ToInt32(Math.Round(load3));
                    progressBar_core4Load.Value = Convert.ToInt32(Math.Round(load4));

                    label_TotalLoad.Text = String.Format("{0:0.00}", totalLoad);
                    label_Core1Load.Text = String.Format("{0:0.00}", load1);
                    label_Core2Load.Text = String.Format("{0:0.00}", load2);
                    label_Core3Load.Text = String.Format("{0:0.00}", load3);
                    label_Core4Load.Text = String.Format("{0:0.00}", load4);

                    progressBar_cpuTemp.Value = Convert.ToInt32(Math.Round(temp));
                    label_cpuTemp.Text = string.Format("{0:0.00} °C", temp);


                    if (serialPort1.IsOpen)
                    {

                        serialPort1.Write(temp + "\n");
                    }

                }

            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void progressBar5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string[] portList = SerialPort.GetPortNames();
            comboBox_portLists.Items.Clear();
            comboBox_portLists.Items.AddRange(portList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_portLists.Text;
                serialPort1.BaudRate = 57600;
                serialPort1.Open();

                MessageBox.Show("Successfully connected to Arduino board" + "\n");

            }

            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                serialPort1.Close();
            }

            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }
    }
}
