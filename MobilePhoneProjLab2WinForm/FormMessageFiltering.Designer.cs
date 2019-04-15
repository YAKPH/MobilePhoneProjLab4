using Common;
using Output;
using System;
using System.Windows.Forms;

namespace MobilePhoneProjLab2WinForm
{
    partial class FormMessageFiltering
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
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelFormat = new System.Windows.Forms.Label();
            this.textBoxFindTxt = new System.Windows.Forms.TextBox();
            this.labelFindTxt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.PhoneNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
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
            this.comboBoxFormat.Location = new System.Drawing.Point(80, 215);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(245, 21);
            this.comboBoxFormat.TabIndex = 1;
            this.comboBoxFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormat_SelectedIndexChanged);
            // 
            // listViewSms
            // 
            this.listViewSms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.From,
            this.SmsText,
            this.PhoneNo});
            this.listViewSms.FullRowSelect = true;
            this.listViewSms.GridLines = true;
            this.listViewSms.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSms.Location = new System.Drawing.Point(12, 257);
            this.listViewSms.Name = "listViewSms";
            this.listViewSms.Size = new System.Drawing.Size(619, 341);
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
            this.SmsText.Width = 400;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.AllowDrop = true;
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(13, 47);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUser.TabIndex = 3;
            this.comboBoxUser.UseWaitCursor = true;
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(10, 28);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(32, 13);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "User:";
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(9, 215);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(63, 13);
            this.labelFormat.TabIndex = 5;
            this.labelFormat.Text = "Text format:";
            // 
            // textBoxFindTxt
            // 
            this.textBoxFindTxt.Location = new System.Drawing.Point(13, 98);
            this.textBoxFindTxt.Name = "textBoxFindTxt";
            this.textBoxFindTxt.Size = new System.Drawing.Size(156, 20);
            this.textBoxFindTxt.TabIndex = 6;
            // 
            // labelFindTxt
            // 
            this.labelFindTxt.AutoSize = true;
            this.labelFindTxt.Location = new System.Drawing.Point(10, 82);
            this.labelFindTxt.Name = "labelFindTxt";
            this.labelFindTxt.Size = new System.Drawing.Size(64, 13);
            this.labelFindTxt.TabIndex = 8;
            this.labelFindTxt.Text = "Search text:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimeTo);
            this.groupBox1.Controls.Add(this.dateTimeFrom);
            this.groupBox1.Controls.Add(this.labelFindTxt);
            this.groupBox1.Controls.Add(this.textBoxFindTxt);
            this.groupBox1.Controls.Add(this.labelUser);
            this.groupBox1.Controls.Add(this.comboBoxUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 190);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "To Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "From Date:";
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTo.Location = new System.Drawing.Point(125, 155);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(96, 20);
            this.dateTimeTo.TabIndex = 10;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFrom.Location = new System.Drawing.Point(13, 155);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(92, 20);
            this.dateTimeFrom.TabIndex = 9;
            // 
            // PhoneNo
            // 
            this.PhoneNo.Text = "Phone number";
            this.PhoneNo.Width = 150;
            // 
            // FormMessageFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(641, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.listViewSms);
            this.Controls.Add(this.comboBoxFormat);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMessageFiltering";
            this.Text = "Message Filtering";
            this.Load += new System.EventHandler(this.FormMessageFiltering_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private Timer myTimer;
        private ComboBox comboBoxFormat;
        private ListView listViewSms;
        private ColumnHeader From;
        private ColumnHeader SmsText;
        private ComboBox comboBoxUser;
        private Label labelUser;
        private Label labelFormat;
        private TextBox textBoxFindTxt;
        private Label labelFindTxt;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimeTo;
        private DateTimePicker dateTimeFrom;
        private ColumnHeader PhoneNo;
    }
}

