using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hotel_Management_System
{
    public partial class InvoiceForm : Form
    {

        InvoiceClass invoice = new InvoiceClass();
        public InvoiceForm()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.InvoiceForm_Load);
        }


        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            getTable();
        }

        private void getTable()
        {
            guna2DataGridView1.DataSource = invoice.getInvoice();
        }

       

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }





}
