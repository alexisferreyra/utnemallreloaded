﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTNEmallReports
{
    public partial class InformePersonalizado : Form
    {
        public InformePersonalizado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.ExportToExcel(this.axPivotTable1);
        }
    }
}
