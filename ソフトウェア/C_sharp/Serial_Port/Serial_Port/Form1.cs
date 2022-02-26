using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Serial_Port
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            string[] ports = SerialPort.GetPortNames();
            comboBox3.Items.AddRange(ports);
        }

        //****COMボタン
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.BaudRate = 9600;
                serialPort1.Parity = Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;
                serialPort1.PortName = comboBox3.Text;
                serialPort1.Open();
                textBox1.Text = "Open";
            }
            catch
            {
                textBox1.Text = "Error. Close Port.";
            }
        }
        //

        //****送信 処理
        private void button2_Click(object sender, EventArgs e)
        {
            string val = Message.Text;

            if (serialPort1.IsOpen)
            {
                switch (val)
                {
                    case "ｴｸｾﾙ ｻｷﾞｮｳﾁｭｳ ﾃﾞｽ":
                        serialPort1.Write("a");
                        serialPort1.Write(Person_Names.Text);
                        break;

                    case "ｻｷﾞｮｳﾁｭｳ":
                        serialPort1.Write("b");
                        serialPort1.Write(Person_Names.Text);
                        break;

                    case "ｷｭｳｹｲﾁｭｳ":
                        serialPort1.Write("c");
                        serialPort1.Write(Person_Names.Text);
                        break;

                    case "ｻｷﾞｮｳ ｶﾞ ｼｭｳﾘｮｳ ｼﾏｼﾀ":
                        serialPort1.Write("d");
                        serialPort1.Write(Person_Names.Text);
                        break;

                    case "ﾂｷﾞﾉ ｼｼﾞ ｦ ﾏｯﾃ ｵﾘﾏｽ":
                        serialPort1.Write("e");
                        serialPort1.Write(Person_Names.Text);
                        break;

                    case "ﾀｽｹﾃｸﾀﾞｻｲ":
                        serialPort1.Write("f");
                        serialPort1.Write(Person_Names.Text);
                        break;

                    default:
                        break;
                }

            }
        }
        //


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                textBox1.Text = "Close";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Tic_good(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort1.ReadExisting();
                if (!string.IsNullOrEmpty(data))
                { 
                    Invoke((MethodInvoker)(() => Reaction.AppendText(data)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
