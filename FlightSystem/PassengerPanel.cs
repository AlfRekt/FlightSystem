using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace FlightSystem
{
    public partial class PassengerPanel : Form
    {
        public ArrayList yolcular;
        public ArrayList ucuslar;
        public PassengerPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 administratorPanel = new Form1();
            Login login = new Login();
            
            administratorPanel.listBox1.Items.Clear();
 
            Passenger passenger = new Passenger(textBox1.Text, textBox2.Text, textBox3.Text, "kullanici",
            "kullanici", comboBox1.Text, comboBox2.Text,
            comboBox3.Text, comboBox4.Text, comboBox5.Text, textBox9.Text);

            yolcular.Add(passenger);

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "" && comboBox5.Text != "" && textBox9.Text != "")
            {
                using (StreamWriter writetext = new StreamWriter("passenger.txt"))
                {
                    for (int i = 0; i < yolcular.Count; i++)
                    {
                        Passenger yolcu = (Passenger)yolcular[i];
                        writetext.WriteLine(yolcu.getID() + ","
                          + yolcu.getName() + ","
                          + yolcu.getSurname() + ","
                          + yolcu.getUsername() + ","
                          + yolcu.getPassword() + ","
                          + yolcu.getDepartureCity() + ","
                          + yolcu.getArrivalCity() + ","
                          + yolcu.departureTime + ","
                          + yolcu.arrivalTime + ","
                          + yolcu.flightDate + ","
                          + yolcu.flightPrice + ",");

                        administratorPanel.listBox1.Items.Add(yolcu.getID() + ","
                          + yolcu.getName() + ","
                          + yolcu.getSurname() + ","
                          + yolcu.getUsername() + ","
                          + yolcu.getPassword() + ","
                          + yolcu.getDepartureCity() + ","
                          + yolcu.getArrivalCity() + ","
                          + yolcu.departureTime + ","
                          + yolcu.arrivalTime + ","
                          + yolcu.flightDate + ","
                          + yolcu.flightPrice + ",");
                    }

                    MessageBox.Show("Rezervasyon Alınmıştır.");

                }
            }

            else
            {
                MessageBox.Show("Bütün boşlukları doldurunuz.");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassengerPanel_Load(object sender, EventArgs e)
        {
            yolcular = new ArrayList();
            ucuslar = new ArrayList();

            Form1 admin= new Form1();

            var lines_ = File.ReadLines("Administrator.txt");
            foreach (var line in lines_)
            {

                String[] features = line.Split(',');

                Administrator ucus = new Administrator(features[0], features[1], features[2], features[3],
                features[4], features[5]);
                if (!comboBox1.Items.Contains(features[0]))
                {
                    comboBox1.Items.Add(features[0]);
                }
                if (!comboBox2.Items.Contains(features[1]))
                {
                    comboBox2.Items.Add(features[1]);
                }
                if (!comboBox3.Items.Contains(features[2]))
                {
                    comboBox3.Items.Add(features[2]);
                }
                if (!comboBox4.Items.Contains(features[3]))
                {
                    comboBox4.Items.Add(features[3]);
                }
                if (!comboBox5.Items.Contains(features[4]))
                {
                    comboBox5.Items.Add(features[4]);
                }

                SortComboBoxItems(comboBox1);
                SortComboBoxItems(comboBox2);
                SortComboBoxItemsByTime(comboBox3);
                SortComboBoxItemsByTime(comboBox4);
                SortComboBoxItemsByDate(comboBox5);

                ucuslar.Add(ucus);
                listBox1.Items.Add(line);
            }
        }

        private void SortComboBoxItems(ComboBox comboBox)
        {
            List<string> sortedItems = comboBox.Items.Cast<string>().ToList();

            sortedItems.Sort();

            comboBox.Items.Clear();
            comboBox.Items.AddRange(sortedItems.ToArray());
        }
        private void SortComboBoxItemsByTime(ComboBox comboBox)
        {
            List<string> sortedItems = comboBox.Items.Cast<string>()
            .OrderBy(time => DateTime.Parse(time))
            .ToList();

            comboBox.Items.Clear();
            comboBox.Items.AddRange(sortedItems.ToArray());
        }

        private void SortComboBoxItemsByDate(ComboBox comboBox)
        {
            List<string> sortedItems = comboBox.Items.Cast<string>()
                .OrderBy(date => DateTime.ParseExact(date, "dd.MM.yyyy", null))
                .ToList();

            comboBox.Items.Clear();
            comboBox.Items.AddRange(sortedItems.ToArray());
        }
        private void label5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PassengerPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }     
}
