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
    public partial class AddExpenditureFrom : Form
    {
        public AddExpenditureFrom()
        {
            InitializeComponent();
            this.btnsave.Click += btnsave_Click;
            this.btncancle.Click += btncancle_Click;
        }

        void btncancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnsave_Click(object sender, EventArgs e)
        {
            DateTime date = this.dtpDate.Value;
            string note = this.textBox1.Text;
            int price = Decimal.ToInt32(this.nudPrice.Value);
            var expenditure = new Expenditure();
            expenditure.Date = date;
            expenditure.Note = note;
            expenditure.Price = price;
            var db = new OOPCSEntities();
            db.Expenditures.Add(expenditure);
            db.SaveChanges();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nudPrike_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
