using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            PassengerPanel passengerPanel = new PassengerPanel();

            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                form.Show();
                this.Hide();
            }

            else if (textBox1.Text == "kullanici" && textBox2.Text == "kullanici")
            {
                passengerPanel.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Geçersiz şifre veya kullanıcı adı.");
            }

            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
