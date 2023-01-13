namespace AdvancedHMICS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ethernetIPforCLXCom1 = new AdvancedHMIDrivers.EthernetIPforCLXCom(this.components);
            this.pilotLight1 = new AdvancedHMIControls.PilotLight();
            this.pilotLight2 = new AdvancedHMIControls.PilotLight();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVO CONTROL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(28, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 120);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.PictureBox1);
            this.panel2.Controls.Add(this.pilotLight2);
            this.panel2.Controls.Add(this.pilotLight1);
            this.panel2.Location = new System.Drawing.Point(28, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 346);
            this.panel2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 22);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(475, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(314, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 22);
            this.textBox3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "PLC STATUS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "AXIS STATUS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "JOG SPEED";
            // 
            // ethernetIPforCLXCom1
            // 
            this.ethernetIPforCLXCom1.CIPConnectionSize = 508;
            this.ethernetIPforCLXCom1.DisableMultiServiceRequest = false;
            this.ethernetIPforCLXCom1.DisableSubscriptions = false;
            this.ethernetIPforCLXCom1.IniFileName = "";
            this.ethernetIPforCLXCom1.IniFileSection = null;
            this.ethernetIPforCLXCom1.IPAddress = "192.168.0.10";
            this.ethernetIPforCLXCom1.PollRateOverride = 500;
            this.ethernetIPforCLXCom1.Port = 44818;
            this.ethernetIPforCLXCom1.ProcessorSlot = 0;
            this.ethernetIPforCLXCom1.RoutePath = null;
            this.ethernetIPforCLXCom1.Timeout = 4000;
            // 
            // pilotLight1
            // 
            this.pilotLight1.Blink = false;
            this.pilotLight1.ComComponent = this.ethernetIPforCLXCom1;
            this.pilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White;
            this.pilotLight1.Location = new System.Drawing.Point(69, 70);
            this.pilotLight1.Name = "pilotLight1";
            this.pilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotLight1.PLCAddressClick = "";
            this.pilotLight1.PLCAddressText = "";
            this.pilotLight1.PLCAddressValue = "";
            this.pilotLight1.PLCAddressVisible = "";
            this.pilotLight1.Size = new System.Drawing.Size(106, 155);
            this.pilotLight1.TabIndex = 0;
            this.pilotLight1.Text = "pilotLight1";
            this.pilotLight1.Value = false;
            this.pilotLight1.ValueToWrite = 0;
            // 
            // pilotLight2
            // 
            this.pilotLight2.Blink = false;
            this.pilotLight2.ComComponent = this.ethernetIPforCLXCom1;
            this.pilotLight2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotLight2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotLight2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White;
            this.pilotLight2.Location = new System.Drawing.Point(530, 70);
            this.pilotLight2.Name = "pilotLight2";
            this.pilotLight2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotLight2.PLCAddressClick = "";
            this.pilotLight2.PLCAddressText = "";
            this.pilotLight2.PLCAddressValue = "";
            this.pilotLight2.PLCAddressVisible = "";
            this.pilotLight2.Size = new System.Drawing.Size(106, 155);
            this.pilotLight2.TabIndex = 1;
            this.pilotLight2.Text = "pilotLight2";
            this.pilotLight2.Value = false;
            this.pilotLight2.ValueToWrite = 0;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(260, 70);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(181, 151);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 377;
            this.PictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(69, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(530, 257);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 34);
            this.button5.TabIndex = 378;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 579);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "AXIS STATUS";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(454, 597);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(28, 599);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 22);
            this.textBox4.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 579);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "AXIS STATUS";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(170, 599);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 22);
            this.textBox5.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 578);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "AXIS STATUS";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(312, 598);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(136, 22);
            this.textBox6.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(770, 632);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "AdvancedHMI V3.99x";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private AdvancedHMIDrivers.EthernetIPforCLXCom ethernetIPforCLXCom1;
        private AdvancedHMIControls.PilotLight pilotLight2;
        private AdvancedHMIControls.PilotLight pilotLight1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
    }
}

