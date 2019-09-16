using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project3
{
    public partial class Assigment3 : Form
    {
        const int arraySize = 20;
        string[] customerName = new string[arraySize];
        string[] customerContract = new string[arraySize];
        string[] customerAddress = new string[arraySize];
        string[] Order = new string[arraySize];
        int[] Quantity = new int[arraySize];
        double[] totalPrice = new double[arraySize];
        string Result;
        int Index = 0;
        public Assigment3()
        {
            InitializeComponent();
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Index < arraySize)
            {
                if (customerNameTextBox.Text != "" && contactTextBox.Text != "" && addressTextBox.Text != "" && orderComboBox.Text != "")
                {
                    customerName[Index] = customerNameTextBox.Text;
                    customerContract[Index] = contactTextBox.Text;
                    customerAddress[Index] = addressTextBox.Text;
                    Order[Index] = orderComboBox.Text;
                   
                    totalPrice[Index] = Quantity[Index] * PiceCount(orderComboBox.Text);
                    DisplayCustomerInformation(Index);
                    Index++;
                }
                else
                {
                    MessageBox.Show("Wrong Input!");
                }
            }
            else
            {
                MessageBox.Show("Memory full..!!");
            }
        }

        private double PiceCount(string item)
        {
            if (item == "Black")
            {
                return 120;
            }
            else if (item == "Cold")
            {
                return 100;
            }
            else if (item == "Hot")
            {
                return 90;
            }
            else if (item == "Regular")
            {
                return 80;
            }
            else
            {
                return 0;
            }
        }

        private void DisplayCustomerInformation(int indexCount)
        {
            Result = "";
            for (int i = 0; i <= indexCount; i++)
            {
                Result += "\n\n No: " + i + "\n Name: " + customerName[i] + "\n Contarcrt No: " + customerContract[i] +
                    "\n Addesess: " + customerAddress[i] + "\n Item: " + Order[i] + "\n Quantity: " + Quantity[i] + "\n Total Price: " + totalPrice[i] + "\n \n \n";
            }

            resultRichTextBox.Text = "Customer Information.. " + Result;
        }

       
    }
}
