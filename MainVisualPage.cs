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
namespace DWSerialPortSniffer
{
    public partial class MainVisualPage : Form
    {
        public MainVisualPage()
        {
            InitializeComponent();

            var portnames = SerialPort.GetPortNames();
            foreach (var item in portnames)
            {
                portnameA.Items.Add(item);
                portnameB.Items.Add(item);
            }
            BaudrateA.SelectedIndex = 4;
            BaudrateB.SelectedIndex = 4;
            
        }
        SerialPort p1;
        SerialPort p2;
        private void button1_Click(object sender, EventArgs e)
        {
            p1 = new SerialPort();
            p2 = new SerialPort();
            p1.PortName = portnameA.Text;
            p2.PortName = portnameB.Text;
            p1.BaudRate = int.Parse(BaudrateA.Text);
            p2.BaudRate = int.Parse(BaudrateB.Text);
            try
            {
                p1.DataReceived += TransferIncommingData;
                p2.DataReceived += TransferIncommingData;
                p1.Open();
                p2.Open();
                BTNInitConnection.Enabled = false;
            }
            catch (Exception ex)
            {
                richTextBox1.SelectionColor = Color.Violet; richTextBox1.AppendText(ex.Message);
                if (p1 != null)
                {
                    p1.Close();
                    p1.Dispose();
                }
                if (p2 != null)
                {
                    p2.Dispose();
                    p2.Close();
                }
            }
        }
        string firstsport = string.Empty;
        bool first = false;
        private void TransferIncommingData(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            if (string.IsNullOrEmpty(firstsport))
                firstsport = sp.PortName;
            if (sp.PortName == firstsport)
            {
                if (!first)
                    Invoke(new MethodInvoker(delegate { richTextBox1.SelectionColor = Color.DarkViolet; richTextBox1.AppendText($"\r\n[{sp.PortName}:{DateTime.Now.ToString("HH:mm:ss.fff")}]\t"); }));
                first = true;
                int available = sp.BytesToRead;
                byte[] buffer = new byte[available];
                sp.Read(buffer, 0, available);
                Invoke(new MethodInvoker(delegate { richTextBox1.SelectionColor = Color.Blue; richTextBox1.AppendText(ByteArrayToString(buffer)); }));
                if (p1.PortName == firstsport) { p2.Write(buffer, 0, available); }
                else { p1.Write(buffer, 0, available); }
            }
            else
            {
                if (first)
                    Invoke(new MethodInvoker(delegate { richTextBox1.SelectionColor = Color.DarkViolet; richTextBox1.AppendText($"\r\n[{sp.PortName}:{DateTime.Now.ToString("HH:mm:ss.fff")}]\t"); }));


                first = false;
                int available = sp.BytesToRead;
                byte[] buffer = new byte[available];
                sp.Read(buffer, 0, available);
                Invoke(new MethodInvoker(delegate { richTextBox1.SelectionColor = Color.Red; richTextBox1.AppendText(ByteArrayToString(buffer)); }));
                if (p1.PortName == firstsport) { p1.Write(buffer, 0, available); }
                else { p2.Write(buffer, 0, available); }
            }

        }
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2} ", b);
            return hex.ToString();
        }

        private void ClearConsole(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void TerminateSnife(object sender, EventArgs e)
        {
            try
            {
                if (p1 != null)
                {
                    p1.Close();
                    p1.Dispose();
                }
                if (p2 != null)
                {
                    p2.Dispose();
                    p2.Close();
                }
            }
            catch (Exception ex)
            {
                richTextBox1.SelectionColor = Color.Violet; richTextBox1.AppendText(ex.Message);
            }
            BTNInitConnection.Enabled = true;
        }
    }
}
