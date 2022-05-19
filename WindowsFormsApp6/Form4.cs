using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp6
{
        
    public partial class Form4 : Form
    {
        SC1 model = new SC1();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
            date();
        }
        void date()
        {
            txtDate.Text = DateTime.Today.ToString("MM/dd/yy");
            txtDate.ReadOnly = true;
            
        }
        void Clear()
        {
            txtName.Text = comboBox1.Text = txtTimeIn.Text = txtTimeOut.Text = "";
            btnSAVE.Text = "Save";
            model.ID = 0;
        }
        void PopulateDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dataGridView1.DataSource = db.SC1.ToList<SC1>();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    model = db.SC1.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtName.Text = model.NAME;
                    comboBox1.Text = model.STATUS;
                    txtTimeIn.Text = model.TIME_IN;
                    txtTimeOut.Text = model.TIME_OUT;
                    txtDate.Text = model.DATE;
                }
                btnSAVE.Text = "Update";
                
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            model.NAME = txtName.Text.Trim();
            model.STATUS = comboBox1.Text.Trim();
            model.TIME_IN = txtTimeIn.Text.Trim();
            model.TIME_OUT = txtTimeOut.Text.Trim();
            model.DATE = txtDate.Text.Trim();
            using (DBEntities db = new DBEntities())
            {
                if (model.ID == 0)//Insert
                    db.SC1.Add(model);
                else //Update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted Successfully");
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
