using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jaamsbackend1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataman_databaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataman_databaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.datamanDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datamanDataSet.dataman_database' table. You can move, or remove it, as needed.
            this.dataman_databaseTableAdapter.Fill(this.datamanDataSet.dataman_database);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {

        }

        private void projectFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
            
        }
    }
}
