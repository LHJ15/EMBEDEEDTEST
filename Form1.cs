using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace _01BASIC
{
    public partial class Form1 : Form
    {

        private SerialPort serialPort = new SerialPort();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("HELLO WORLD")
            //Console.WriteLine("OBJECT: " sender);
            //Console.WriteLine("EVENTARGS : " + e)
          /*  ComboBox cb = (ComboBox)sender;
            Console.Write("Selected Index : " + cb.SelectedIndex + " ");
            Console.WriteLine("Selected Value : " + cb.Items[cb.SelectedIndex]);*/
        }


        private void SerialPort_DataRecv(object sender,SerialDataReceivedEventArgs e)
        {
            String recvData = this.serialPort.ReadExisting();
            Console.WriteLine(recvData);
        }


        private void conn_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString()+" CONN");
          
              
                this.serialPort.PortName = this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString();
            textBox.Text = "MESSAGE : \r\n"+ this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString()+" CONN";




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01 OFF CLICKED");
            textBox.Text = "MESSAGE : \r\n" + "LED_01 OFF CLICKED";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 ON CLICKED");
            textBox.Text = "MESSAGE : \r\n" + "LED_02 ON CLICKED";
        }

        private void LED01_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01 ON CLICKED");
            textBox.Text = "MESSAGE : \r\n" + "LED_01 ON CLICKED";

        }

        private void LED04_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 OFF CLICKED");
            textBox.Text = "MESSAGE : \r\n" + "LED_02 OFF CLICKED";
        }
    }

}

    

