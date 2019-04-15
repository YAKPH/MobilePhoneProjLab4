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
            vMyMobile.SMSProvider.SMSReceived += SMSProvider_SMSReceived;
            vMyMobile.StorageMessages.MessageAdded += StorageMessages_NotifyAdded;
            vSMSCounter = 0;
        }

        private bool StorageMessages_NotifyAdded(MyMessage message)
        {
            return this.vMyMobile.StorageMessages.ListMessages.Contains(message);
        }

        private void SMSProvider_SMSReceived(MyMessage message)
        {
            //add Message into Mobile Storage
            this.vMyMobile.StorageMessages.Add(message);

            // update User filter and display available users
            UpdateUserFilter(this.vMyMobile.StorageMessages.ListMessages);

            //Show Messsages in the Mobile Storage
            ShowMessage(this.vMyMobile.StorageMessages.ListMessages);

        }

        private void ShowMessage(List<MyMessage> listMessages)
        {
            listViewSms.Items.Clear();

            //build query for filtering
            string filterUser = (string)comboBoxUser.SelectedItem;
            string filterText = textBoxFindTxt.Text;
            DateTime toDate = dateTimeTo.Value.Date;
            DateTime fromDate = dateTimeFrom.Value.Date;
            IEnumerable<MyMessage> filterQuery = FilterMessages(listMessages, filterUser, filterText, toDate, fromDate);

            //display (filtered) messages
            foreach (MyMessage msg in filterQuery)
            {
                var formattedTxt = this.vMyMobile.SMSProvider.DoFormat(msg);
                var row = new string[] { msg.User, formattedTxt, msg.PhoneNo };
                listViewSms.Items.Add(new ListViewItem(row));
            }

        }

        public static IEnumerable<MyMessage> FilterMessages(List<MyMessage> listMessages, string filterUser, string filterText, DateTime toDate, DateTime fromDate)
        {
            return from msg in listMessages
                   where (msg.User == filterUser || filterUser == null)
                   where (msg.Text.Contains(filterText) || filterText =="")
                   where msg.ReceivingTime.Date <= toDate
                   where msg.ReceivingTime.Date >= fromDate
                   select msg;
        }

        private void UpdateUserFilter(List<MyMessage> listMessages)
        {
            foreach (MyMessage msg in listMessages)
            {
                if (!comboBoxUser.Items.Contains(msg.User))
                { comboBoxUser.Items.Add(msg.User); }

            }
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            vSMSCounter += 1;

            MyMessage vNewSubscr1Message = new MyMessage()
            {   User = "Yuliia",
                PhoneNo = "+380957777777",
                ReceivingTime = DateTime.Now,
                Text = $"Message #{vSMSCounter} is delivered"
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
                Text = $"Message #{vSMSCounter} is provided"
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

        private void listViewSms_SelectedIndexChanged(object sender, EventArgs e) {}

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e) {}

        private void FormMessageFiltering_Load(object sender, EventArgs e) {}

        private void labelMessages_Click(object sender, EventArgs e) {}
    }
} 