using _233N_Michael_Baldwin_Lab4.TravelDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (MessageBox.Show("Are you sure you would like to close this page?",
                "Close Form Validation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "TravelDetails.xls";
            saveFile.Filter = "Excel (*.xls)|*.xls|All files (*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                {
                    sw.WriteLine("test");
                }
            }
        }

 
    }
}
