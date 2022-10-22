
namespace Zadanie1_dsr
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP addr:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(317, 28);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(92, 22);
            this.Button.TabIndex = 4;
            this.Button.Text = "Connect";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.TextBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "w(t)";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(103, 132);
            this.trackBar1.Maximum = 12000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(277, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(103, 103);
            this.progressBar1.Maximum = 12050;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(277, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(103, 194);
            this.progressBar2.Maximum = 12000;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(277, 23);
            this.progressBar2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Disonnect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            legend7.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(21, 252);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.Blue;
            series9.LabelBorderWidth = 2;
            series9.Legend = "Legend1";
            series9.LegendText = "y(t)";
            series9.Name = "vystup";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Color = System.Drawing.Color.Red;
            series10.Legend = "Legend1";
            series10.LegendText = "w(t)";
            series10.Name = "pozadovana";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(496, 295);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart2.Legends.Add(legend8);
            this.chart2.Location = new System.Drawing.Point(523, 252);
            this.chart2.Name = "chart2";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series11.LabelBorderWidth = 2;
            series11.Legend = "Legend1";
            series11.LegendText = "u(t)";
            series11.Name = "akcny";
            this.chart2.Series.Add(series11);
            this.chart2.Size = new System.Drawing.Size(496, 149);
            this.chart2.TabIndex = 14;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea9.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart3.Legends.Add(legend9);
            this.chart3.Location = new System.Drawing.Point(523, 398);
            this.chart3.Name = "chart3";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series12.LabelBorderWidth = 2;
            series12.Legend = "Legend1";
            series12.LegendText = "e(t)";
            series12.Name = "porucha";
            this.chart3.Series.Add(series12);
            this.chart3.Size = new System.Drawing.Size(496, 149);
            this.chart3.TabIndex = 15;
            this.chart3.Text = "chart3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button14);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button15);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button16);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button17);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(446, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 200);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Čítanie bitov";
            // 
            // button14
            // 
            this.button14.Enabled = false;
            this.button14.Location = new System.Drawing.Point(23, 156);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(35, 30);
            this.button14.TabIndex = 52;
            this.button14.Text = "X12";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(23, 115);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 30);
            this.button10.TabIndex = 52;
            this.button10.Text = "X8";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Enabled = false;
            this.button15.Location = new System.Drawing.Point(64, 156);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(35, 30);
            this.button15.TabIndex = 53;
            this.button15.Text = "X13";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(23, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 30);
            this.button6.TabIndex = 52;
            this.button6.Text = "X4";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Enabled = false;
            this.button16.Location = new System.Drawing.Point(105, 156);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(35, 30);
            this.button16.TabIndex = 54;
            this.button16.Text = "X14";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(64, 115);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(35, 30);
            this.button11.TabIndex = 53;
            this.button11.Text = "X9";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Enabled = false;
            this.button17.Location = new System.Drawing.Point(146, 156);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(35, 30);
            this.button17.TabIndex = 51;
            this.button17.Text = "X15";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(146, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 30);
            this.button5.TabIndex = 50;
            this.button5.Text = "X3";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Location = new System.Drawing.Point(105, 115);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(35, 30);
            this.button12.TabIndex = 54;
            this.button12.Text = "X10";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(64, 69);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 30);
            this.button7.TabIndex = 53;
            this.button7.Text = "X5";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Enabled = false;
            this.button13.Location = new System.Drawing.Point(146, 115);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(35, 30);
            this.button13.TabIndex = 51;
            this.button13.Text = "X11";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(105, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 30);
            this.button4.TabIndex = 50;
            this.button4.Text = "X2";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(105, 69);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 30);
            this.button8.TabIndex = 54;
            this.button8.Text = "X6";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(64, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 30);
            this.button3.TabIndex = 50;
            this.button3.Text = "X1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(146, 69);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 30);
            this.button9.TabIndex = 51;
            this.button9.Text = "X7";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(23, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "X0";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Y0",
            "Y1",
            "Y2",
            "Y3",
            "Y4",
            "Y5",
            "Y6",
            "Y7",
            "Y8",
            "Y9",
            "Y10",
            "Y11",
            "Y12",
            "Y13",
            "Y14",
            "Y15"});
            this.checkedListBox1.Location = new System.Drawing.Point(760, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(164, 229);
            this.checkedListBox1.TabIndex = 51;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 572);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

