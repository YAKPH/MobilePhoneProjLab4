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
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.listViewSms = new System.Windows.Forms.ListView();
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SmsText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            "Lowercase"});
            this.comboBoxFormat.Location = new System.Drawing.Point(21, 12);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(245, 21);
            this.comboBoxFormat.TabIndex = 1;
            this.comboBoxFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormat_SelectedIndexChanged);
            // 
            // listViewSms
            // 
            this.listViewSms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.From,
            this.SmsText});
            this.listViewSms.FullRowSelect = true;
            this.listViewSms.GridLines = true;
            this.listViewSms.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSms.Location = new System.Drawing.Point(21, 39);
            this.listViewSms.Name = "listViewSms";
            this.listViewSms.Size = new System.Drawing.Size(358, 321);
            this.listViewSms.TabIndex = 2;
            this.listViewSms.UseCompatibleStateImageBehavior = false;
            this.listViewSms.View = System.Windows.Forms.View.Details;
            this.listViewSms.SelectedIndexChanged += new System.EventHandler(this.listViewSms_SelectedIndexChanged);
            // 
            // From
            // 
            this.From.Text = "From";
            // 
            // SmsText
            // 
            this.SmsText.Text = "Text";
            this.SmsText.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 449);
            this.Controls.Add(this.listViewSms);
            this.Controls.Add(this.comboBoxFormat);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);

        }


        #endregion
        private Timer myTimer;
        private ComboBox comboBoxFormat;
        private ListView listViewSms;
        private ColumnHeader From;
        private ColumnHeader SmsText;
    }
}

