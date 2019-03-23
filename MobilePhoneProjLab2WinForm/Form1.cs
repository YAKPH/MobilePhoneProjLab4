using Chargers;
using Common;
using Headset;
using PhoneComponents;
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

namespace MobilePhoneProjLab2WinForm
{
    public partial class Form1 : Form
    {
        private IPlayback vHeadset;
        private ICharger vCharger;
        private IOutput vOutputType;

        public Form1(IOutput myOutputType)
        {
            InitializeComponent();
            InitializeComponentOutput(myOutputType);
        }

        private void InitializeComponentOutput(IOutput myOutputType)
        {
            vOutputType = myOutputType;

        }

        public  void rbHeadSetiPhone_CheckedChanged(object sender, EventArgs e)
        { }
        public void rbHeadSetSamsung_CheckedChanged(object sender, EventArgs e)
        { }
        public void rbHeadSetEFStealth_CheckedChanged(object sender, EventArgs e)
        { }
        public void rbChargerCar_CheckedChanged(object sender, EventArgs e)
        { }
        public void rbChargerPowerbank_CheckedChanged(object sender, EventArgs e)
        { }
        public void rbChargerWall_CheckedChanged(object sender, EventArgs e)
        { }

        private void showInfob_Click(object sender, EventArgs e)
        {
            SetHeadSetType();
            SetChargerType();

            if (vCharger != null)
                if (vHeadset != null)
                {
                    var mymobile = new SimCorpMobile(vHeadset, vCharger, vOutputType);
                    mymobile.ToString();
                }

        }

        private void SetChargerType()
        {
            if (this.rbChargerCar.Checked)
            { vCharger = ChargerFactory.GetCharger(ChargerTypes.Car); }
            else if (this.rbChargerPowerbank.Checked)
            { vCharger = ChargerFactory.GetCharger(ChargerTypes.Powerbk); }
            else if (this.rbChargerWall.Checked)
            { vCharger = ChargerFactory.GetCharger(ChargerTypes.Wall); }
        }

        private void SetHeadSetType()
        {
            if (this.rbHeadSetiPhone.Checked)
            {
                vHeadset = HeadsetFactory.GetHeadSet(this.vOutputType, HeadsetTypes.iPhone);
            }
            else if (this.rbHeadSetSamsung.Checked)
            { vHeadset = HeadsetFactory.GetHeadSet(this.vOutputType, HeadsetTypes.Samsung); }
            else if (this.rbHeadSetEFStealth.Checked)
            { vHeadset = HeadsetFactory.GetHeadSet(this.vOutputType, HeadsetTypes.EarForceStealth); }
        }
    }
}
