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
            this.rbHeadSetiPhone = new System.Windows.Forms.RadioButton();
            this.rbHeadSetSamsung = new System.Windows.Forms.RadioButton();
            this.rbHeadSetEFStealth = new System.Windows.Forms.RadioButton();
            this.rbChargerCar = new System.Windows.Forms.RadioButton();
            this.rbChargerPowerbank = new System.Windows.Forms.RadioButton();
            this.rbChargerWall = new System.Windows.Forms.RadioButton();
            this.HeadSets = new System.Windows.Forms.GroupBox();
            this.Chargers = new System.Windows.Forms.GroupBox();
            this.showInfob = new System.Windows.Forms.Button();
            this.HeadSets.SuspendLayout();
            this.Chargers.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbHeadSetiPhone
            // 
            this.rbHeadSetiPhone.AutoSize = true;
            this.rbHeadSetiPhone.Checked = true;
            this.rbHeadSetiPhone.Location = new System.Drawing.Point(8, 15);
            this.rbHeadSetiPhone.Name = "rbHeadSetiPhone";
            this.rbHeadSetiPhone.Size = new System.Drawing.Size(58, 17);
            this.rbHeadSetiPhone.TabIndex = 0;
            this.rbHeadSetiPhone.TabStop = true;
            this.rbHeadSetiPhone.Text = "iPhone";
            this.rbHeadSetiPhone.UseVisualStyleBackColor = true;
            this.rbHeadSetiPhone.CheckedChanged += new System.EventHandler(this.rbHeadSetiPhone_CheckedChanged);
            // 
            // rbHeadSetSamsung
            // 
            this.rbHeadSetSamsung.AutoSize = true;
            this.rbHeadSetSamsung.Location = new System.Drawing.Point(8, 39);
            this.rbHeadSetSamsung.Name = "rbHeadSetSamsung";
            this.rbHeadSetSamsung.Size = new System.Drawing.Size(69, 17);
            this.rbHeadSetSamsung.TabIndex = 1;
            this.rbHeadSetSamsung.Text = "Samsung";
            this.rbHeadSetSamsung.UseVisualStyleBackColor = true;
            this.rbHeadSetSamsung.CheckedChanged += new System.EventHandler(this.rbHeadSetSamsung_CheckedChanged);
            // 
            // rbHeadSetEFStealth
            // 
            this.rbHeadSetEFStealth.AutoSize = true;
            this.rbHeadSetEFStealth.Location = new System.Drawing.Point(8, 63);
            this.rbHeadSetEFStealth.Name = "rbHeadSetEFStealth";
            this.rbHeadSetEFStealth.Size = new System.Drawing.Size(107, 17);
            this.rbHeadSetEFStealth.TabIndex = 2;
            this.rbHeadSetEFStealth.Text = "Ear Force Stealth";
            this.rbHeadSetEFStealth.UseVisualStyleBackColor = true;
            this.rbHeadSetEFStealth.CheckedChanged += new System.EventHandler(this.rbHeadSetEFStealth_CheckedChanged);
            // 
            // rbChargerCar
            // 
            this.rbChargerCar.AutoSize = true;
            this.rbChargerCar.Checked = true;
            this.rbChargerCar.Location = new System.Drawing.Point(8, 19);
            this.rbChargerCar.Name = "rbChargerCar";
            this.rbChargerCar.Size = new System.Drawing.Size(81, 17);
            this.rbChargerCar.TabIndex = 5;
            this.rbChargerCar.TabStop = true;
            this.rbChargerCar.Text = "Car Charger";
            this.rbChargerCar.UseVisualStyleBackColor = true;
            this.rbChargerCar.CheckedChanged += new System.EventHandler(this.rbChargerCar_CheckedChanged);
            // 
            // rbChargerPowerbank
            // 
            this.rbChargerPowerbank.AutoSize = true;
            this.rbChargerPowerbank.Location = new System.Drawing.Point(8, 42);
            this.rbChargerPowerbank.Name = "rbChargerPowerbank";
            this.rbChargerPowerbank.Size = new System.Drawing.Size(79, 17);
            this.rbChargerPowerbank.TabIndex = 6;
            this.rbChargerPowerbank.Text = "Powerbank";
            this.rbChargerPowerbank.UseVisualStyleBackColor = true;
            this.rbChargerPowerbank.CheckedChanged += new System.EventHandler(this.rbChargerPowerbank_CheckedChanged);
            // 
            // rbChargerWall
            // 
            this.rbChargerWall.AutoSize = true;
            this.rbChargerWall.Location = new System.Drawing.Point(8, 65);
            this.rbChargerWall.Name = "rbChargerWall";
            this.rbChargerWall.Size = new System.Drawing.Size(86, 17);
            this.rbChargerWall.TabIndex = 7;
            this.rbChargerWall.Text = "Wall Charger";
            this.rbChargerWall.UseVisualStyleBackColor = true;
            this.rbChargerWall.CheckedChanged += new System.EventHandler(this.rbChargerWall_CheckedChanged);
            // 
            // HeadSets
            // 
            this.HeadSets.Controls.Add(this.rbHeadSetEFStealth);
            this.HeadSets.Controls.Add(this.rbHeadSetSamsung);
            this.HeadSets.Controls.Add(this.rbHeadSetiPhone);
            this.HeadSets.Location = new System.Drawing.Point(20, 12);
            this.HeadSets.Name = "HeadSets";
            this.HeadSets.Size = new System.Drawing.Size(172, 110);
            this.HeadSets.TabIndex = 8;
            this.HeadSets.TabStop = false;
            this.HeadSets.Text = "Choose type of HeadSet";
            // 
            // Chargers
            // 
            this.Chargers.Controls.Add(this.rbChargerWall);
            this.Chargers.Controls.Add(this.rbChargerPowerbank);
            this.Chargers.Controls.Add(this.rbChargerCar);
            this.Chargers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Chargers.Location = new System.Drawing.Point(226, 12);
            this.Chargers.Name = "Chargers";
            this.Chargers.Size = new System.Drawing.Size(193, 110);
            this.Chargers.TabIndex = 9;
            this.Chargers.TabStop = false;
            this.Chargers.Text = "Choose type of Charger";
            // 
            // showInfob
            // 
            this.showInfob.Location = new System.Drawing.Point(139, 140);
            this.showInfob.Name = "showInfob";
            this.showInfob.Size = new System.Drawing.Size(133, 31);
            this.showInfob.TabIndex = 8;
            this.showInfob.Text = "Show more info";
            this.showInfob.UseVisualStyleBackColor = true;
            this.showInfob.Click += new System.EventHandler(this.showInfob_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 197);
            this.Controls.Add(this.showInfob);
            this.Controls.Add(this.Chargers);
            this.Controls.Add(this.HeadSets);
            this.Name = "Form1";
            this.Text = "Form1";
            this.HeadSets.ResumeLayout(false);
            this.HeadSets.PerformLayout();
            this.Chargers.ResumeLayout(false);
            this.Chargers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButton rbHeadSetiPhone;
        private RadioButton rbHeadSetSamsung;
        private RadioButton rbHeadSetEFStealth;

        private RadioButton rbChargerCar;
        private RadioButton rbChargerPowerbank;
        private RadioButton rbChargerWall;

        private GroupBox HeadSets;
        private GroupBox Chargers;
        private Button showInfob;


    }
}

