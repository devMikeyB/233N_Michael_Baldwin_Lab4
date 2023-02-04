using _233N_Michael_Baldwin_Lab4.TravelDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _233N_Michael_Baldwin_Lab4
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void searchAll(string searchValue, TravelDataSet.TravelRequestsDataTable tableAdapter)
        {
            try
            {
                this.travelRequestsTableAdapter.FillByName(tableAdapter, searchValue, searchValue, searchValue, searchValue, searchValue);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDataSet.TravelRequests' table. You can move, or remove it, as needed.
            this.travelRequestsTableAdapter.Fill(this.travelDataSet.TravelRequests);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //searchAll(searchForTextBox.Text, this.travelDataSet.TravelRequests);
        }

        private void ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(true)
            {
                this.Close();
            }
        }
    }
}
