﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unnamedProject.Forms
{
    public partial class ViewTicketForm : Form
    {
        Users current;
        public ViewTicketForm(Users cur)
        {
            InitializeComponent();
            current = cur;
        }

        private void ViewTicketForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
