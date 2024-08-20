namespace PrecisionDigitalThermometerApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxSelfTest = new GroupBox();
            buttonSelfTest = new Button();
            groupBoxBacklight = new GroupBox();
            checkBoxBacklight = new CheckBox();
            groupBoxBeep = new GroupBox();
            buttonBeep = new Button();
            groupBoxTemperature = new GroupBox();
            labelTemperature = new Label();
            checkBoxAsInteger = new CheckBox();
            groupBoxSelfTest.SuspendLayout();
            groupBoxBacklight.SuspendLayout();
            groupBoxBeep.SuspendLayout();
            groupBoxTemperature.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxSelfTest
            // 
            groupBoxSelfTest.Controls.Add(buttonSelfTest);
            groupBoxSelfTest.Location = new Point(52, 27);
            groupBoxSelfTest.Name = "groupBoxSelfTest";
            groupBoxSelfTest.Size = new Size(657, 136);
            groupBoxSelfTest.TabIndex = 1;
            groupBoxSelfTest.TabStop = false;
            groupBoxSelfTest.Text = "Self-Test";
            // 
            // buttonSelfTest
            // 
            buttonSelfTest.ImageAlign = ContentAlignment.BottomCenter;
            buttonSelfTest.Location = new Point(174, 36);
            buttonSelfTest.Name = "buttonSelfTest";
            buttonSelfTest.Size = new Size(326, 73);
            buttonSelfTest.TabIndex = 1;
            buttonSelfTest.Text = "Do Self-Test";
            buttonSelfTest.UseVisualStyleBackColor = true;
            // 
            // groupBoxBacklight
            // 
            groupBoxBacklight.Controls.Add(checkBoxBacklight);
            groupBoxBacklight.Location = new Point(54, 172);
            groupBoxBacklight.Name = "groupBoxBacklight";
            groupBoxBacklight.Size = new Size(655, 99);
            groupBoxBacklight.TabIndex = 2;
            groupBoxBacklight.TabStop = false;
            groupBoxBacklight.Text = "Backlight";
            // 
            // checkBoxBacklight
            // 
            checkBoxBacklight.AutoSize = true;
            checkBoxBacklight.Location = new Point(262, 44);
            checkBoxBacklight.Name = "checkBoxBacklight";
            checkBoxBacklight.Size = new Size(142, 24);
            checkBoxBacklight.TabIndex = 0;
            checkBoxBacklight.Text = "Backlight On/Off";
            checkBoxBacklight.UseVisualStyleBackColor = true;
            checkBoxBacklight.CheckedChanged += checkBoxBacklight_CheckedChanged;
            // 
            // groupBoxBeep
            // 
            groupBoxBeep.Controls.Add(buttonBeep);
            groupBoxBeep.Location = new Point(52, 298);
            groupBoxBeep.Name = "groupBoxBeep";
            groupBoxBeep.Size = new Size(655, 133);
            groupBoxBeep.TabIndex = 3;
            groupBoxBeep.TabStop = false;
            groupBoxBeep.Text = "Beep";
            // 
            // buttonBeep
            // 
            buttonBeep.Location = new Point(174, 32);
            buttonBeep.Name = "buttonBeep";
            buttonBeep.Size = new Size(326, 77);
            buttonBeep.TabIndex = 0;
            buttonBeep.Text = "Do Beep";
            buttonBeep.UseVisualStyleBackColor = true;
            buttonBeep.Click += buttonBeep_Click;
            // 
            // groupBoxTemperature
            // 
            groupBoxTemperature.Controls.Add(checkBoxAsInteger);
            groupBoxTemperature.Controls.Add(labelTemperature);
            groupBoxTemperature.Location = new Point(52, 467);
            groupBoxTemperature.Name = "groupBoxTemperature";
            groupBoxTemperature.Size = new Size(654, 87);
            groupBoxTemperature.TabIndex = 4;
            groupBoxTemperature.TabStop = false;
            groupBoxTemperature.Text = "Temperature";
            // 
            // labelTemperature
            // 
            labelTemperature.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold);
            labelTemperature.Location = new Point(260, 32);
            labelTemperature.Name = "labelTemperature";
            labelTemperature.Size = new Size(146, 32);
            labelTemperature.TabIndex = 0;
            labelTemperature.Text = "0";
            labelTemperature.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBoxAsInteger
            // 
            checkBoxAsInteger.AutoSize = true;
            checkBoxAsInteger.Location = new Point(31, 37);
            checkBoxAsInteger.Name = "checkBoxAsInteger";
            checkBoxAsInteger.Size = new Size(98, 24);
            checkBoxAsInteger.TabIndex = 1;
            checkBoxAsInteger.Text = "As Integer";
            checkBoxAsInteger.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 595);
            Controls.Add(groupBoxTemperature);
            Controls.Add(groupBoxBeep);
            Controls.Add(groupBoxBacklight);
            Controls.Add(groupBoxSelfTest);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Precision Digital Thermometer App";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            groupBoxSelfTest.ResumeLayout(false);
            groupBoxBacklight.ResumeLayout(false);
            groupBoxBacklight.PerformLayout();
            groupBoxBeep.ResumeLayout(false);
            groupBoxTemperature.ResumeLayout(false);
            groupBoxTemperature.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxSelfTest;
        private Button buttonSelfTest;
        private GroupBox groupBoxBacklight;
        private CheckBox checkBoxBacklight;
        private GroupBox groupBoxBeep;
        private Button buttonBeep;
        private GroupBox groupBoxTemperature;
        private Label labelTemperature;
        private CheckBox checkBoxAsInteger;
    }
}
