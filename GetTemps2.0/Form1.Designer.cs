namespace GetTemps2._0
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
            this.label_hardwareName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label_Core4Load = new System.Windows.Forms.Label();
            this.progressBar_core4Load = new System.Windows.Forms.ProgressBar();
            this.Core4Load = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_Core3Load = new System.Windows.Forms.Label();
            this.progressBar_core3Load = new System.Windows.Forms.ProgressBar();
            this.Core3Load = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Core2Load = new System.Windows.Forms.Label();
            this.progressBar_core2Load = new System.Windows.Forms.ProgressBar();
            this.Core2Load = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Core1Load = new System.Windows.Forms.Label();
            this.progressBar_core1Load = new System.Windows.Forms.ProgressBar();
            this.Core1Load = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_TotalLoad = new System.Windows.Forms.Label();
            this.progressBar_totalLoad = new System.Windows.Forms.ProgressBar();
            this.totalLoad = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_cpuTemp = new System.Windows.Forms.Label();
            this.progressBar_cpuTemp = new System.Windows.Forms.ProgressBar();
            this.cpuTemp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox_portLists = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_hardwareName
            // 
            this.label_hardwareName.AutoSize = true;
            this.label_hardwareName.Location = new System.Drawing.Point(15, 23);
            this.label_hardwareName.Name = "label_hardwareName";
            this.label_hardwareName.Size = new System.Drawing.Size(71, 13);
            this.label_hardwareName.TabIndex = 0;
            this.label_hardwareName.Text = "HARDWARE";
            this.label_hardwareName.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label_Core4Load);
            this.groupBox1.Controls.Add(this.progressBar_core4Load);
            this.groupBox1.Controls.Add(this.Core4Load);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label_Core3Load);
            this.groupBox1.Controls.Add(this.progressBar_core3Load);
            this.groupBox1.Controls.Add(this.Core3Load);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label_Core2Load);
            this.groupBox1.Controls.Add(this.progressBar_core2Load);
            this.groupBox1.Controls.Add(this.Core2Load);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_Core1Load);
            this.groupBox1.Controls.Add(this.progressBar_core1Load);
            this.groupBox1.Controls.Add(this.Core1Load);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_TotalLoad);
            this.groupBox1.Controls.Add(this.progressBar_totalLoad);
            this.groupBox1.Controls.Add(this.totalLoad);
            this.groupBox1.Location = new System.Drawing.Point(16, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPU LOAD";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(663, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "%";
            // 
            // label_Core4Load
            // 
            this.label_Core4Load.AutoSize = true;
            this.label_Core4Load.Location = new System.Drawing.Point(619, 161);
            this.label_Core4Load.Name = "label_Core4Load";
            this.label_Core4Load.Size = new System.Drawing.Size(27, 13);
            this.label_Core4Load.TabIndex = 18;
            this.label_Core4Load.Text = "... %";
            // 
            // progressBar_core4Load
            // 
            this.progressBar_core4Load.Location = new System.Drawing.Point(76, 161);
            this.progressBar_core4Load.Name = "progressBar_core4Load";
            this.progressBar_core4Load.Size = new System.Drawing.Size(537, 23);
            this.progressBar_core4Load.TabIndex = 17;
            // 
            // Core4Load
            // 
            this.Core4Load.AutoSize = true;
            this.Core4Load.Location = new System.Drawing.Point(25, 161);
            this.Core4Load.Name = "Core4Load";
            this.Core4Load.Size = new System.Drawing.Size(45, 13);
            this.Core4Load.TabIndex = 16;
            this.Core4Load.Text = "Core #4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(663, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "%";
            // 
            // label_Core3Load
            // 
            this.label_Core3Load.AutoSize = true;
            this.label_Core3Load.Location = new System.Drawing.Point(619, 132);
            this.label_Core3Load.Name = "label_Core3Load";
            this.label_Core3Load.Size = new System.Drawing.Size(27, 13);
            this.label_Core3Load.TabIndex = 14;
            this.label_Core3Load.Text = "... %";
            // 
            // progressBar_core3Load
            // 
            this.progressBar_core3Load.Location = new System.Drawing.Point(76, 132);
            this.progressBar_core3Load.Name = "progressBar_core3Load";
            this.progressBar_core3Load.Size = new System.Drawing.Size(537, 23);
            this.progressBar_core3Load.TabIndex = 13;
            // 
            // Core3Load
            // 
            this.Core3Load.AutoSize = true;
            this.Core3Load.Location = new System.Drawing.Point(25, 132);
            this.Core3Load.Name = "Core3Load";
            this.Core3Load.Size = new System.Drawing.Size(45, 13);
            this.Core3Load.TabIndex = 12;
            this.Core3Load.Text = "Core #3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "%";
            // 
            // label_Core2Load
            // 
            this.label_Core2Load.AutoSize = true;
            this.label_Core2Load.Location = new System.Drawing.Point(619, 103);
            this.label_Core2Load.Name = "label_Core2Load";
            this.label_Core2Load.Size = new System.Drawing.Size(27, 13);
            this.label_Core2Load.TabIndex = 10;
            this.label_Core2Load.Text = "... %";
            // 
            // progressBar_core2Load
            // 
            this.progressBar_core2Load.Location = new System.Drawing.Point(76, 103);
            this.progressBar_core2Load.Name = "progressBar_core2Load";
            this.progressBar_core2Load.Size = new System.Drawing.Size(537, 23);
            this.progressBar_core2Load.TabIndex = 9;
            // 
            // Core2Load
            // 
            this.Core2Load.AutoSize = true;
            this.Core2Load.Location = new System.Drawing.Point(25, 103);
            this.Core2Load.Name = "Core2Load";
            this.Core2Load.Size = new System.Drawing.Size(45, 13);
            this.Core2Load.TabIndex = 8;
            this.Core2Load.Text = "Core #2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(663, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "%";
            // 
            // label_Core1Load
            // 
            this.label_Core1Load.AutoSize = true;
            this.label_Core1Load.Location = new System.Drawing.Point(619, 74);
            this.label_Core1Load.Name = "label_Core1Load";
            this.label_Core1Load.Size = new System.Drawing.Size(27, 13);
            this.label_Core1Load.TabIndex = 6;
            this.label_Core1Load.Text = "... %";
            // 
            // progressBar_core1Load
            // 
            this.progressBar_core1Load.Location = new System.Drawing.Point(76, 74);
            this.progressBar_core1Load.Name = "progressBar_core1Load";
            this.progressBar_core1Load.Size = new System.Drawing.Size(537, 23);
            this.progressBar_core1Load.TabIndex = 5;
            // 
            // Core1Load
            // 
            this.Core1Load.AutoSize = true;
            this.Core1Load.Location = new System.Drawing.Point(25, 74);
            this.Core1Load.Name = "Core1Load";
            this.Core1Load.Size = new System.Drawing.Size(45, 13);
            this.Core1Load.TabIndex = 4;
            this.Core1Load.Text = "Core #1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "%";
            // 
            // label_TotalLoad
            // 
            this.label_TotalLoad.AutoSize = true;
            this.label_TotalLoad.Location = new System.Drawing.Point(619, 45);
            this.label_TotalLoad.Name = "label_TotalLoad";
            this.label_TotalLoad.Size = new System.Drawing.Size(27, 13);
            this.label_TotalLoad.TabIndex = 2;
            this.label_TotalLoad.Text = "... %";
            // 
            // progressBar_totalLoad
            // 
            this.progressBar_totalLoad.Location = new System.Drawing.Point(76, 45);
            this.progressBar_totalLoad.Name = "progressBar_totalLoad";
            this.progressBar_totalLoad.Size = new System.Drawing.Size(537, 23);
            this.progressBar_totalLoad.TabIndex = 1;
            // 
            // totalLoad
            // 
            this.totalLoad.AutoSize = true;
            this.totalLoad.Location = new System.Drawing.Point(12, 45);
            this.totalLoad.Name = "totalLoad";
            this.totalLoad.Size = new System.Drawing.Size(58, 13);
            this.totalLoad.TabIndex = 0;
            this.totalLoad.Text = "Total Load";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_cpuTemp);
            this.groupBox2.Controls.Add(this.progressBar_cpuTemp);
            this.groupBox2.Controls.Add(this.cpuTemp);
            this.groupBox2.Location = new System.Drawing.Point(16, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 96);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPU Temperature";
            // 
            // label_cpuTemp
            // 
            this.label_cpuTemp.AutoSize = true;
            this.label_cpuTemp.Location = new System.Drawing.Point(619, 42);
            this.label_cpuTemp.Name = "label_cpuTemp";
            this.label_cpuTemp.Size = new System.Drawing.Size(30, 13);
            this.label_cpuTemp.TabIndex = 22;
            this.label_cpuTemp.Text = "... °C";
            // 
            // progressBar_cpuTemp
            // 
            this.progressBar_cpuTemp.Location = new System.Drawing.Point(76, 42);
            this.progressBar_cpuTemp.Name = "progressBar_cpuTemp";
            this.progressBar_cpuTemp.Size = new System.Drawing.Size(537, 23);
            this.progressBar_cpuTemp.TabIndex = 21;
            // 
            // cpuTemp
            // 
            this.cpuTemp.AutoSize = true;
            this.cpuTemp.Location = new System.Drawing.Point(12, 42);
            this.cpuTemp.Name = "cpuTemp";
            this.cpuTemp.Size = new System.Drawing.Size(59, 13);
            this.cpuTemp.TabIndex = 20;
            this.cpuTemp.Text = "CPU Temp";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox_portLists
            // 
            this.comboBox_portLists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_portLists.FormattingEnabled = true;
            this.comboBox_portLists.Location = new System.Drawing.Point(490, 23);
            this.comboBox_portLists.Name = "comboBox_portLists";
            this.comboBox_portLists.Size = new System.Drawing.Size(123, 21);
            this.comboBox_portLists.TabIndex = 3;
            this.comboBox_portLists.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OPEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_portLists);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_hardwareName);
            this.Name = "Form1";
            this.Text = "CPU Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_hardwareName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_Core4Load;
        private System.Windows.Forms.ProgressBar progressBar_core4Load;
        private System.Windows.Forms.Label Core4Load;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_Core3Load;
        private System.Windows.Forms.ProgressBar progressBar_core3Load;
        private System.Windows.Forms.Label Core3Load;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Core2Load;
        private System.Windows.Forms.ProgressBar progressBar_core2Load;
        private System.Windows.Forms.Label Core2Load;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Core1Load;
        private System.Windows.Forms.ProgressBar progressBar_core1Load;
        private System.Windows.Forms.Label Core1Load;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_TotalLoad;
        private System.Windows.Forms.ProgressBar progressBar_totalLoad;
        private System.Windows.Forms.Label totalLoad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_cpuTemp;
        private System.Windows.Forms.ProgressBar progressBar_cpuTemp;
        private System.Windows.Forms.Label cpuTemp;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox_portLists;
        private System.Windows.Forms.Button button1;
    }
}

