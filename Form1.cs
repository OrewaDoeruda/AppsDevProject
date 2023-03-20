using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACTIVITY_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = wishlist.GetItemText(wishlist.SelectedItem);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            wishlist.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = Convert.ToString(wishlist.Items.Count);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wishlist.Items.Add("iPhone 14 Pro Max Fully Paid");
            wishlist.Items.Add("Gaming PC");
            wishlist.Items.Add("Ticket to Japan");
            wishlist.Items.Add("House and Lot");
            wishlist.Items.Add("Gun License");
            wishlist.Items.Add("Gym  Equipments");
            wishlist.Items.Add("Build a Bussiness");
            wishlist.Items.Add("Buy a Big Bike");
            wishlist.Items.Add("Buy a Bugatti");
        }

        private void CountingBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wishlist.Sorted = true;
        }
    }
}
