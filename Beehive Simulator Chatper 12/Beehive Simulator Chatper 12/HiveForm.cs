﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive_Simulator_Chapter_12
{
    public partial class HiveForm : Form
    {
        public HiveForm()
        {
            InitializeComponent();
            BackgroundImage = Renderer.ResizeImage (Properties.Resources.Hive__inside_, ClientRectangle.Width, ClientRectangle.Height);
        }

    }
}
