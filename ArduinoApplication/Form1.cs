using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinApplication
{
    public partial class Form1 : Form
    {
        public string name;
        ArduinoEngine engine;

        public Form1()
        {
            InitializeComponent();
            engine = new ArduinoEngine(this);
        }

        public string Changetext
        {
            set
            {
                textBoxToInsert.AppendText(value + "\n");
            }
            get
            {
                return textBoxToInsert.Text;
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            
            engine.forwardAction();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            engine.backWardAction();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            engine.leftAction();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            engine.rightAction();
        }
    }
}
