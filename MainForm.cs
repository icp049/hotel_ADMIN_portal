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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        

        private void button_guest_Click(object sender, EventArgs e)
        {
            

            panel_main.Controls.Clear();
            GuestForm guest = new GuestForm();
            guest.TopLevel = false;
            guest.Dock = DockStyle.Fill;
            guest.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(guest);
            guest.Show();
        }

        private void button_reception_Click(object sender, EventArgs e)
        {
           

            panel_main.Controls.Clear();
            ReservationForm reservation = new ReservationForm();
            reservation.TopLevel = false;
            reservation.Dock = DockStyle.Fill;
            reservation.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(reservation);
            reservation.Show();
        }

        private void button_room_Click(object sender, EventArgs e)
        {
            

            panel_main.Controls.Clear();
            RoomForm room = new RoomForm();
            room.TopLevel = false;
            room.Dock = DockStyle.Fill;
            room.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(room);
            room.Show();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
           

            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            InvoiceForm invoice = new InvoiceForm();
            invoice.TopLevel = false;
            invoice.Dock = DockStyle.Fill;
            invoice.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(invoice);
            invoice.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
