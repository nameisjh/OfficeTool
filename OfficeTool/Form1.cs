using OfficeTool.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadExcel_Click(object sender, EventArgs e)
        {
            dgvShow.DataSource= ExcelHelper.ExcelToDataTable("C:/Users/melon/Desktop/123.xls", true);
        }
    }
}
