﻿using Chargers;
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
        private IOutput vOutputType;
        private Mobile vMyMobile;


        public Form1(IOutput myOutputType, Mobile mymobile)
        {
            InitializeComponent();
            InitializeComponentOutput(myOutputType);
            InitializeComponentMobile(mymobile);
        }

        private void InitializeComponentMobile(Mobile mymobile)
        {
            vMyMobile = mymobile;
        }

        private void InitializeComponentOutput(IOutput myOutputType)
        {
            vOutputType = myOutputType;

        }
   

        private void richTextSMSBox_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
