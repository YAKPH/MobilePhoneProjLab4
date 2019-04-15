using Chargers;
using Common;
using Headset;
using PhoneComponents;
using PhoneLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Headset.HeadsetFactory;
using static System.Windows.Forms.CheckedListBox;

namespace MobilePhoneProjLab2WinForm
{
    public partial class FormMessageFiltering : Form
    {
        private IOutput vOutputType;
        private Mobile vMyMobile;
        private int vSMSCounter;
        private string[] vFilterUsers;


        public FormMessageFiltering(IOutput myOutputType, Mobile mymobile)
        {
            InitializeComponent();
            InitializeComponentOutput(myOutputType);
            InitializeComponentMobile(mymobile);
            this.comboBoxFormat.SelectedIndex = 0;  //set default value for Format = "None"    
        }

        private void InitializeComponentOutput(IOutput myOutputType)
        {
            vOutputType = myOutputType;

        }

        private void InitializeComponentMobile(Mobile mymobile)
        {
            vMyMobile = mymobile;
            vMyMobile.SMSProvider.SMSReceived += SMSProvider_SMSReceived; //add listener
            vSMSCounter = 0;
        }


        private void SMSProvider_SMSReceived(MyMessage message)   //implement listener
        {
            //Show message
            this.vMyMobile.StorageMessages.Add(message);
            ShowMessage(this.vMyMobile.StorageMessages.ListMessages);
            
        }

        private void ShowMessage(List<MyMessage> listMessages)
        {
            listViewSms.Items.Clear();

            //display available users
            foreach (MyMessage msg in listMessages)
            {
                if (!comboBoxUser.Items.Contains(msg.User))
                { comboBoxUser.Items.Add(msg.User); }
            
            }

            //build query

            var query = from msg in listMessages
                        where (msg.User == (string)comboBoxUser.SelectedItem || comboBoxUser.SelectedItem==null)
                        where msg.ReceivingTime.Date <= dateTimeTo.Value.Date
                        where msg.ReceivingTime.Date >= dateTimeFrom.Value.Date
                        select msg;

            //display message
            foreach (MyMessage msg in query)
            {
                var formattedTxt = this.vMyMobile.SMSProvider.DoFormat(msg);
                var row = new string[] { msg.User, formattedTxt };
                listViewSms.Items.Add(new ListViewItem(row));
            }


        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            vSMSCounter += 1;

            MyMessage vNewSubscr1Message = new MyMessage()
            {   User = "Yuliia",
                PhoneNo = "+380957777777",
                ReceivingTime = DateTime.Now,
                Text = $"Message #{vSMSCounter} is received"
            };

            vSMSCounter += 1;
            MyMessage vNewSubscr2Message = new MyMessage()
            {
                User = "Sviatoslav",
                PhoneNo = "+380955555555",
                ReceivingTime = DateTime.Now,
                Text = $"Message #{vSMSCounter} is received"
            };

            vSMSCounter += 1;
            MyMessage vNewSubscr3Message = new MyMessage()
            {
                User = "Roman",
                PhoneNo = "+380955555554",
                ReceivingTime = DateTime.Now,
                Text = $"Message #{vSMSCounter} is received"
            };

            this.vMyMobile.SMSProvider.DoSMSReceived(vNewSubscr1Message);
            this.vMyMobile.SMSProvider.DoSMSReceived(vNewSubscr2Message);
            this.vMyMobile.SMSProvider.DoSMSReceived(vNewSubscr3Message);
        }

        private void richTextSMSBox_TextChanged(object sender, EventArgs e)
        { }

        private void comboBoxFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var  selectedFormatItem = comboBoxFormat.SelectedItem;
        
            switch (selectedFormatItem.ToString())
            { case "None":  { vMyMobile.SMSProvider.Formatter += SMSProvider_FormatterNone; break; }
              case "Start with DateTime": { vMyMobile.SMSProvider.Formatter += SMSProvider_FormatterWithTime;  break; }
              case "End with DateTime": { vMyMobile.SMSProvider.Formatter += SMSProvider_FormatterWithTimeEnd;  break; }
              case "Uppercase": { vMyMobile.SMSProvider.Formatter += SMSProvider_FormatterUpper; break; }
              case "Lowercase": { vMyMobile.SMSProvider.Formatter += SMSProvider_FormatterLower;  break; }
            }
            
        }
        public static string SMSProvider_FormatterNone(MyMessage message)
        {
            return $"{message.Text}";
        }

        public static string SMSProvider_FormatterWithTime(MyMessage message)
        {
            return $"[{message.ReceivingTime}]: {message.Text}";
        }

        public static string SMSProvider_FormatterWithTimeEnd(MyMessage message)
        {
           return $"{message.Text} [{message.ReceivingTime}]";
        }
        public static string SMSProvider_FormatterUpper(MyMessage message)
        {
            return $"{message.Text.ToUpper()}";
        }
        public static string SMSProvider_FormatterLower(MyMessage message)
        {
            return $"{message.Text.ToLower()}";
        }

        private void listViewSms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }
    }
} 