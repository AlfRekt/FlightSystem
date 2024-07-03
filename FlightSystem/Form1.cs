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
    public partial class Form1 : Form
    {
        public ArrayList yolcular;
        public ArrayList ucuslar;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            panelLeft.Height = button3.Height;
            panelLeft.Top = button3.Top;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            button2.Visible = false;
            listBox1.Visible = false;
            listBox2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox12.Visible = false;
            comboBox1.Visible = false;


            yolcular = new ArrayList();
            ucuslar = new ArrayList();

            comboBox1.Items.Add("ID");
            comboBox1.Items.Add("Kullanıcı Adı");
            comboBox1.Items.Add("Ad");
            comboBox1.Items.Add("Soyad");
            comboBox1.Items.Add("Kalkış Şehri");
            comboBox1.Items.Add("Varış Şehri");
            comboBox1.Items.Add("Kalkış Saati");
            comboBox1.Items.Add("Varış Saati");
            comboBox1.Items.Add("Uçuş Tarihi");
            comboBox1.Items.Add("Uçuş Fiyatı");


            var lines = File.ReadLines("passenger.txt");
            foreach (var line in lines)
            {
                
                String [] features = line.Split(',');

                Passenger yolcu = new Passenger(features[0], features[1], features[2], features[3],
                features[4], features[5], features[6],
                features[7], features[8], features[9], features[10]);

                yolcular.Add(yolcu);
                listBox1.Items.Add(line);
            }

            var lines_ = File.ReadLines("Administrator.txt");
            foreach (var line in lines_)
            {

                String[] features = line.Split(',');

                Administrator ucus = new Administrator(features[0], features[1], features[2], features[3],
                features[4], features[5]);

                ucuslar.Add(ucus);
                listBox3.Items.Add(line);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            for (int i = 0; i < yolcular.Count; i++)
            {
                Passenger yolcu = (Passenger)yolcular[i];

                if ( comboBox1.SelectedItem == "ID" && yolcu.getID().ToLower() == textBox12.Text.ToLower() )
                {
                    listBox2.Items.Add(yolcu.getID() + ", " + yolcu.getName() + ", " + yolcu.getSurname());
                }

                if (comboBox1.SelectedItem == "Kullanıcı Adı" && yolcu.getUsername().ToLower() == textBox12.Text.ToLower())
                {
                    listBox2.Items.Add(yolcu.getID() + ", " + yolcu.getName() + ", " + yolcu.getSurname());
                }

                if (comboBox1.SelectedItem == "Ad" && yolcu.getName().ToLower() == textBox12.Text.ToLower())
                {
                    listBox2.Items.Add(yolcu.getID() + ", " + yolcu.getName() + ", " + yolcu.getSurname());
                }

                if (comboBox1.SelectedItem == "Soyad" && yolcu.getSurname().ToLower() == textBox12.Text.ToLower())
                {
                    listBox2.Items.Add(yolcu.getID() + ", " + yolcu.getName() + ", " + yolcu.getSurname());
                }

                if (comboBox1.SelectedItem == "Kalkış Şehri" && yolcu.getDepartureCity().ToLower() == textBox12.Text.ToLower())
                {
                    listBox2.Items.Add(yolcu.getID() + ", " + yolcu.getName() + ", " + yolcu.getSurname());
                }

                if (comboBox1.SelectedItem == "Varış Şehri" && yolcu.getArrivalCity().ToLower() == textBox12.Text.ToLower())
                {
                    listBox2.Items.Add(yolcu.getID() + ", " + yolcu.getName() + ", " + yolcu.getSurname());
                }

                if (comboBox1.SelectedItem == "Kalkış Saati" && yolcu.departureTime.ToLower() == textBox12.Text.ToLower())
                {
                    listBox2.Items.Add(yolcu.getID() + ", " + yolcu.getName() + ", " + yolcu.getSurname());
                }

                if (comboBox1.SelectedItem == "Varış Saati" && yolcu.arrivalTime.ToLower() == textBox12.Text.ToLower())
                {
                    listBox2.Items.Add(yolcu.getID() + ", " + yolcu.getName() + ", " + yolcu.getSurname());
                }

                if (comboBox1.SelectedItem == "Uçuş Tarihi" && yolcu.flightDate.ToLower() == textBox12.Text.ToLower())
                {
                    listBox2.Items.Add(yolcu.getID() + ", " + yolcu.getName() + ", " + yolcu.getSurname());
                }

                if (comboBox1.SelectedItem == "Uçuş Fiyatı" && yolcu.flightPrice.ToLower() == textBox12.Text.ToLower())
                {
                    listBox2.Items.Add(yolcu.getID() + ", " + yolcu.getName() + ", " + yolcu.getSurname());
                }
            }

            textBox12.Text = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void label12_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button4.Height;
            panelLeft.Top = button4.Top;

            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label14.Visible = true;
            label15.Visible = true;

            UcusEkle.Visible = false;
            button2.Visible = true;

            listBox1.Visible = true;
            listBox2.Visible = true;
            listBox3.Visible = false;

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;

            textBox12.Visible = true;

            comboBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button3.Height;
            panelLeft.Top = button3.Top;

            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label14.Visible = false;
            label15.Visible = false;

            UcusEkle.Visible = true;
            button2.Visible = false;

            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = true;

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox12.Visible = false;

            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;

            comboBox1.Visible = false;
        }

        private void UcusEkle_Click(object sender, EventArgs e)
        {
            PassengerPanel passengerPanel = new PassengerPanel(); 

            Administrator flights = new Administrator(textBox6.Text,textBox7.Text,textBox8.Text,textBox9.Text,textBox10.Text,textBox11.Text);

            ucuslar.Add(flights);


            if (textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "")
            {
                listBox3.Items.Clear();
                using (StreamWriter writetext = new StreamWriter("Administrator.txt"))
                {
                    for (int i = 0; i < ucuslar.Count; i++)
                    {

                        Administrator ucus = (Administrator)ucuslar[i];
                        writetext.WriteLine(ucus.departureCity + "," + ucus.arrivalCity + "," + ucus.departureTime + "," + ucus.arrivalTime + "," + ucus.flightDate + "," + ucus.flightPrice + ",");

                        listBox3.Items.Add(ucus.departureCity + "," + ucus.arrivalCity + "," + ucus.departureTime + "," + ucus.arrivalTime + "," + ucus.flightDate + "," + ucus.flightPrice + ",");

                    }
                }
            }

            else
            {
                MessageBox.Show("Lütfen 'Uçuş Ekle' kısmındaki bütün boşlukları doldurunuz.");
            }

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UcusEkle_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void UcusEkle_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void UcusEkle_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }


    }
}
