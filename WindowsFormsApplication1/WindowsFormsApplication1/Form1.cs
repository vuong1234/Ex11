using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnViewEx.Click += btnViewEx_Click;
        }

        void btnViewEx_Click(object sender, EventArgs e)
        {
            //   (new ViewExpenditureFrom()).ShowDialog();show ẩn danh
            var from = new ViewExpenditureFrom(); 
            from.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
