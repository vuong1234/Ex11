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
    public partial class ViewExpenditureFrom : Form
    {
        public ViewExpenditureFrom()
        {
            InitializeComponent();
            this.Load += ViewExpenditureFrom_Load;
            this.btnAddExpenditure.Click += btnAddExpenditure_Click;
            this.grdExpenditures.KeyDown += grdExpenditures_KeyDown;
            
        }

        void grdExpenditures_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                if (this.grdExpenditures.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("do you want to delete this?") == System.Windows.Forms.DialogResult.OK)
                    {
                        ExpenditureView selected = (ExpenditureView)
                            this.grdExpenditures.SelectedRows[0].DataBoundItem;
                        var db = new OOPCSEntities();
                        Expenditure deleted = db .Expenditures.Find(selected.id);
                        db.Expenditures.Remove(deleted);
                        db.SaveChanges();
                        this.ViewAllExpenditure();

                    }
                }
            }
                
        }

        void btnAddExpenditure_Click(object sender, EventArgs e)
        {
            (new AddExpenditureFrom()).ShowDialog();
            this.ViewAllExpenditure();

        }

        void ViewExpenditureFrom_Load(object sender, EventArgs e)
        {
            this.ViewAllExpenditure();
            
        }
        private void ViewAllExpenditure()
        {
            var db = new OOPCSEntities();
            var expenditures = db.Expenditures.ToArray();
            var expenditureViews = new ExpenditureView[expenditures.Length];
            for (int i = 0; i < expenditureViews.Length; i++)
                expenditureViews[i] = new ExpenditureView(expenditures[i]);
            this.grdExpenditures.DataSource = expenditureViews;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
