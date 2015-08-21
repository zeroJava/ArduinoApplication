using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGApplication
{
    class ArduinoEngine
    {
        public readonly string forward = "FORWARD";
        public readonly string backward = "BACKWARD";
        public readonly string right = "RIGHT";
        public readonly string left = "LEFT";

        private Form1 form;
        private SerialPort serial;

        public ArduinoEngine(Form1 form)
        {
            this.form = form;
            serial = new SerialPort();
            serial.PortName = "COM5";
            serial.BaudRate = 9600;
        }

        public string received()
        {
            string data = null;
            try
            {
                data = serial.ReadLine();
                form.Changetext = data;
            } 
            catch(Exception e)
            {
                System.Console.WriteLine(e);
            }
            return data;
        }

        public void forwardAction()
        {
            this.openConnection();
            this.action(forward);
        }

        public void backWardAction()
        {
            this.openConnection();
            this.action(backward);
        }

        public void rightAction()
        {
            this.openConnection();
            this.action(right);
        }

        public void leftAction()
        {
            this.openConnection();
            this.action(left);
        }

        private void openConnection()
        {
            if (!serial.IsOpen)
            {
                try
                {
                    serial.Open();
                }
                catch(Exception e)
                {
                    System.Console.WriteLine(e);
                }
            }
        }

        private void action(string action)
        {
            try
            {
                serial.Write(action);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
            finally
            {
                if (serial.IsOpen)
                {
                    serial.Close();
                }
            }
        }
    }
}
