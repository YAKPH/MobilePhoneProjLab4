using Common;
using Output;
using System;
using System.Windows.Forms;

namespace MobilePhoneProjLab2WinForm
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
            this.richTextSMSBox = new System.Windows.Forms.RichTextBox();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextSMSBox
            // 
            this.richTextSMSBox.Location = new System.Drawing.Point(21, 48);
            this.richTextSMSBox.Name = "richTextSMSBox";
            this.richTextSMSBox.Size = new System.Drawing.Size(414, 321);
            this.richTextSMSBox.TabIndex = 0;
            this.richTextSMSBox.Text = "";
            this.richTextSMSBox.TextChanged += new System.EventHandler(this.richTextSMSBox_TextChanged);
            // 
            // myTimer
            // 
            this.myTimer.Enabled = true;
            this.myTimer.Interval = 2000;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Items.AddRange(new object[] {
            "None",
            "Start with DateTime",
            "End with DateTime",
            "Uppercase",
            "Lowercase",
            "Short representation"});
            this.comboBoxFormat.Location = new System.Drawing.Point(21, 12);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(245, 21);
            this.comboBoxFormat.TabIndex = 1;
            this.comboBoxFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormat_SelectedIndexChanged);
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 449);
            this.Controls.Add(this.comboBoxFormat);
            this.Controls.Add(this.richTextSMSBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }


        #endregion

        private RichTextBox richTextSMSBox;
        private Timer myTimer;
        private ComboBox comboBoxFormat;
    }
}

