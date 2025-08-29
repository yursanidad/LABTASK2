﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QueuingForm : Form
    {

        public static CashierWindowQueueForm cashierWindowQueueForm;
        private CashierClass cashier;
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            cashierWindowQueueForm = new CashierWindowQueueForm();
            cashierWindowQueueForm.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");


            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}
