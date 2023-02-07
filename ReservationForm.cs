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
    public partial class ReservationForm : Form
    {
        ReservationClass booking = new ReservationClass();
        
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {

            dataGridView_reserv.DefaultCellStyle.ForeColor = Color.Black;
            getReservTable();


        }
        public void getReservTable()
        {
            dataGridView_reserv.DataSource = booking.getBooking();
        }

        private void comboBox_roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
           comboBox_roomType.DataSource = booking.getRoomType();
            comboBox_roomType.DisplayMember = "Label";
            comboBox_roomType.ValueMember = "room_type";

            
            
        }

        private void button_save_Click(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_reservId.Text == "")
            {
                MessageBox.Show("Required Field - Booking ID", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = textBox_reservId.Text;
                    Boolean deleteGuest = booking.removeBooking(id);
                    if (deleteGuest)
                    {
                        MessageBox.Show("guest data remove successfuly", "Guest Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getReservTable ();
                       
                        button_clean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - guest not Remove", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void dataGridView_reserv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_guestId.Text = dataGridView_reserv.CurrentRow.Cells[6].Value.ToString();
            textBox_reservId.Text = dataGridView_reserv.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void button_clean_Click(object sender, EventArgs e)
        {

            textBox_guestId.Clear();
            textBox_reservId.Clear();
          

        }

        private void button_update_Click(object sender, EventArgs e)
        {
           
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

        private void dataGridView_reserv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
