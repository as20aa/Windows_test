using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Windows_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Button_Click(object sender,EventArgs e)
        {
            if (((Button)sender).Name == "button1")
                label1.Text = "打开文件以浏览";
            else
                label1.Text = "导入文件";
        }
    }
}
