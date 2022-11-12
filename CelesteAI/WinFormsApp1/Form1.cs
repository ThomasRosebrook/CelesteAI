using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;
using CeletseAI;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Inputs i = new Inputs();
        private void button1_Click(object sender,EventArgs e)
        {
            i.openCeleste();
            i.holdKey(VirtualKeyCode.RIGHT, 2000);
        }
    }
}