﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk2
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)this.Tag).Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void value_enter(object sender, EventArgs e)
        {
            NumericUpDown valueBox = sender as NumericUpDown;

            if (valueBox != null)
            {
                int lengthOfAnswer = valueBox.Value.ToString().Length;
                valueBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
