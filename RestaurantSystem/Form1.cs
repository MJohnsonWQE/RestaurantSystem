using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.Text = string.Format("0");

        }

        private void button4_Click(object sender, EventArgs e)//QUIT BUTTON
        {
            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)//CALCULATE BUTTON
        {
            double subtotal = 0;
            double VAT = 0;
            double discount = 0;
            double total = 0;
            double countStarter1 = Convert.ToDouble(numericUpDown1.Value);
            double countStarter2 = Convert.ToDouble(numericUpDown2.Value);
            double countMain1 = Convert.ToDouble(numericUpDown3.Value);
            double countMain2 = Convert.ToDouble(numericUpDown4.Value);
            double countMain3 = Convert.ToDouble(numericUpDown5.Value);
            double countDrink = Convert.ToDouble(numericUpDown6.Value);

            //Starter 1
            if (comboBox1.SelectedIndex == 0) { subtotal += 0.49 * countStarter1; } //Apple?
            else if (comboBox1.SelectedIndex == 1) { subtotal += 3.49 * countStarter1; } //Garlic Bread
            else if (comboBox1.SelectedIndex == 2) { subtotal += 2.49 * countStarter1; } //Chips
            else if (comboBox1.SelectedIndex == 3) { subtotal += 4.99 * countStarter1; } //Tomato Soup
            else if (comboBox1.SelectedIndex == 4) { subtotal += 4.49 * countStarter1; } //Caesar Salad
            else if (comboBox1.SelectedIndex == 5) { subtotal += 2.99 * countStarter1; } //Chicken Wings

            //Starter 2
            if (comboBox2.SelectedIndex == 0) { subtotal += 0.49 * countStarter2; } //Apple?
            else if (comboBox2.SelectedIndex == 1) { subtotal += 3.49 * countStarter2; } //Garlic Bread
            else if (comboBox2.SelectedIndex == 2) { subtotal += 2.49 * countStarter2; } //Chips
            else if (comboBox2.SelectedIndex == 3) { subtotal += 4.99 * countStarter2; } //Tomato Soup
            else if (comboBox2.SelectedIndex == 4) { subtotal += 4.49 * countStarter2; } //Caesar Salad
            else if (comboBox2.SelectedIndex == 5) { subtotal += 2.99 * countStarter2; } //Chicken Wings

            //Main 1
            if (comboBox3.SelectedIndex == 0) { subtotal += 12.49 * countMain1; } //Steak & Chips
            else if (comboBox3.SelectedIndex == 1) { subtotal += 9.49 * countMain1; } //Fish & Chips
            else if (comboBox3.SelectedIndex == 2) { subtotal += 8.49 * countMain1; } //Carbonara
            else if (comboBox3.SelectedIndex == 3) { subtotal += 9.99 * countMain1; } //Lasagna
            else if (comboBox3.SelectedIndex == 4) { subtotal += 8.49 * countMain1; } //Bolognese
            else if (comboBox3.SelectedIndex == 5) { subtotal += 9.99 * countMain1; } //Risotto

            //Main 2
            if (comboBox4.SelectedIndex == 0) { subtotal += 12.49 * countMain2; } //Steak & Chips
            else if (comboBox4.SelectedIndex == 1) { subtotal += 9.49 * countMain2; } //Fish & Chips
            else if (comboBox4.SelectedIndex == 2) { subtotal += 8.49 * countMain2; } //Carbonara
            else if (comboBox4.SelectedIndex == 3) { subtotal += 9.99 * countMain2; } //Lasagna
            else if (comboBox4.SelectedIndex == 4) { subtotal += 8.49 * countMain2; } //Bolognese
            else if (comboBox4.SelectedIndex == 5) { subtotal += 9.99 * countMain2; } //Risotto

            //Main 3
            if (comboBox5.SelectedIndex == 0) { subtotal += 12.49 * countMain3; } //Steak & Chips
            else if (comboBox5.SelectedIndex == 1) { subtotal += 9.49 * countMain3; } //Fish & Chips
            else if (comboBox5.SelectedIndex == 2) { subtotal += 8.49 * countMain3; } //Carbonara
            else if (comboBox5.SelectedIndex == 3) { subtotal += 9.99 * countMain3; } //Lasagna
            else if (comboBox5.SelectedIndex == 4) { subtotal += 8.49 * countMain3; } //Bolognese
            else if (comboBox5.SelectedIndex == 5) { subtotal += 9.99 * countMain3; } //Risotto

            //Drinks
            if (comboBox6.SelectedIndex == 0) { subtotal += 0.89 * countDrink; } //Water
            else if (comboBox6.SelectedIndex == 1) { subtotal += 1.49 * countDrink; } //Sparkling Water
            else if (comboBox6.SelectedIndex == 2) { subtotal += 2.49 * countDrink; } //Coke
            else if (comboBox6.SelectedIndex == 3) { subtotal += 1.99 * countDrink; } //Diet Coke
            else if (comboBox6.SelectedIndex == 4) { subtotal += 2.49 * countDrink; } //Dr Pepper
            else if (comboBox6.SelectedIndex == 5) { subtotal += 1.99 * countDrink; } //Lemonade
            else if (comboBox6.SelectedIndex == 6) { subtotal += 1.29 * countDrink; } //Orange Juice
            else if (comboBox6.SelectedIndex == 7) { subtotal += 1.29 * countDrink; } //Apple Juice
            textBox1.Text = string.Format("£{0}", subtotal.ToString());
            VAT = subtotal * 0.2;
            VAT = Math.Round(VAT, 2);
            textBox2.Text = string.Format("£{0}", VAT.ToString());
            
            if ((textBox3.Text).ToString() == null) { total = (subtotal + VAT); }
            else { discount = Convert.ToDouble(textBox3.Text); total = (subtotal + VAT) - discount; }
            total = Math.Round(total, 2);
            textBox4.Text = string.Format("£{0}", total.ToString());
        }

        private void button2_Click(object sender, EventArgs e) //RESET BUTTON
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = string.Format("0");
            textBox4.Text = null;
        }
    }
}
