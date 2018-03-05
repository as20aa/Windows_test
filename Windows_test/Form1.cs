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
                label1.Text = "导入文件";
        }
        private void FileDialog(object sender,EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Multiselect = true;
            file.Title = "请选择文件";
            file.Filter = "所有文件(*.*)|*.*|excel 2013及更高(*.xlsx*)|*.xlsx*|excel 2013以前(*.xls*)|*.xls*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                string filename = file.FileName;
                MessageBox.Show("已选择文件:" + filename, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private System.Data.DataTable datatable=new DataTable();
        public void dataload()
        {
            datatable.Columns.Add("第一列", Type.GetType("System.String"));
            datatable.Columns.Add("第二列", Type.GetType("System.String"));
            DataRow row;
            row = datatable.NewRow();
            row["第一列"] = "yes";
            row["第二列"] = "no";
            datatable.Rows.Add(row);
            this.dataGridView1.DataSource = this.datatable;
        }
    }
}
