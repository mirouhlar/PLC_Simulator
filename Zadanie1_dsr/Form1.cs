using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1_dsr
{
    public partial class Form1 : Form
    {
        private Modbus modbus;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "192.168.1.30";
            textBox2.Text = "502";
            chart1.ChartAreas[0].AxisY.Maximum = 12;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 100;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            chart2.ChartAreas[0].AxisY.Maximum = 6;
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Maximum = 100;
            chart2.ChartAreas[0].AxisX.Minimum = 0;

            chart3.ChartAreas[0].AxisY.Maximum = 12;
            chart3.ChartAreas[0].AxisY.Minimum = -12;
            chart3.ChartAreas[0].AxisX.Maximum = 100;
            chart3.ChartAreas[0].AxisX.Minimum = 0;
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            modbus = new Modbus(textBox1.Text, Int32.Parse(textBox2.Text));
            if (modbus.Connect())
            {
                timer1.Start();
                modbus.WriteHoldingRegister(1, trackBar1.Value);

            }
            chart1.Series["vystup"].Points.Clear();
            chart1.Series["pozadovana"].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart3.Series[0].Points.Clear();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            chart1.Series["vystup"].Points.AddY(modbus.ReadInputRegister(1)/1000.0);
            chart1.Series["pozadovana"].Points.AddY(trackBar1.Value / 1000.0);
            if (chart1.Series["vystup"].Points.Count > 100)
            {
                chart1.Series["pozadovana"].Points.RemoveAt(0);
                chart1.Series["vystup"].Points.RemoveAt(0);
            }

            chart2.Series[0].Points.AddY(modbus.ReadInputRegister(3) / 1000.0);
            if (chart2.Series[0].Points.Count > 100)
            {
                chart2.Series[0].Points.RemoveAt(0);
            }

            chart3.Series[0].Points.AddY((modbus.ReadInputRegister(2) - 24000.0) / 1000);
            if (chart3.Series[0].Points.Count > 100)
            {
                chart3.Series[0].Points.RemoveAt(0);
            }


            progressBar1.Value = modbus.ReadInputRegister(1);
            progressBar2.Value = modbus.ReadInputRegister(3);
            

            for (int i = 0; i < 16; i++)
            {
                if (modbus.ReadDiscreteInput(i) == 1)
                {
                    groupBox2.Controls["button" + (i+2).ToString()].BackColor = Color.Green;
                }
                else
                {
                    groupBox2.Controls["button" + (i + 2).ToString()].BackColor =  Color.Red;
                }
            }

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (modbus != null && timer1.Enabled) 
            {
                modbus.WriteHoldingRegister(1, trackBar1.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (modbus != null && timer1.Enabled)
            {
                modbus.Disconnect();
                timer1.Stop();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++ )
            {
                if (checkedListBox1.GetItemCheckState(i).ToString() == "Checked") {
                    modbus.WriteCoil(i, 65280);
                }
                else
                {
                    modbus.WriteCoil(i, 0);
                }
            }
        }

        
    }
}
