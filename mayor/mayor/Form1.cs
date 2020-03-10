using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayor
{
    public partial class Form1 : Form
    {
        List<Mayor> mayorList;
        public Form1()
        {
            InitializeComponent();
            refresMayors();
            dgv.DataSource = mayorList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Mayor may = new Mayor(tbName.Text, tbSoo.Text, tbEoo.Text);
            mayorList.Add(may);
            //dgv.DataSource = null;
            //refresMayors();
            dgv.DataSource = mayorList;
        }

        private void refresMayors()
        {
            mayorList = Mayor.GetMayors();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbSoo.Text = "";
            tbEoo.Text = "";
        }


    }
}
