using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _233N_Michael_Baldwin_Lab4
{
    public partial class Travelers : Form
    {
        Bitmap memoryImage;
        public Travelers()
        {
            InitializeComponent();
        }



        private void Travelers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDataSet.TravelRequests' table. You can move, or remove it, as needed.
            this.travelRequestsTableAdapter.Fill(this.travelDataSet.TravelRequests);
            //saveToolStripButton.Image = Image.

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

        private void findButton_Click(object sender, EventArgs e)
        {
            searchAll(findTextBox.Text, this.travelDataSet.TravelRequests);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {


            ListViewItem newItem = new ListViewItem(new[] {   travelerIDTextBox.Text, //Create item to be added to listview.
                                                              lastNameTextBox.Text,
                                                              firstNameTextBox.Text,
                                                              purposeTextBox.Text,
                                                              destinationTextBox.Text,
                                                              tripDatesTextBox.Text,
                                                              travelCostTextBox.Text});


            foreach (ListViewItem item in travelListView.Items)
            {//Checking if an identical item exists using SubItems.
                if (item.Text == newItem.Text &&
                    item.SubItems[1].Text == newItem.SubItems[1].Text &&
                    item.SubItems[2].Text == newItem.SubItems[2].Text &&
                    item.SubItems[3].Text == newItem.SubItems[3].Text &&
                    item.SubItems[4].Text == newItem.SubItems[4].Text &&
                    item.SubItems[5].Text == newItem.SubItems[5].Text &&
                    item.SubItems[6].Text == newItem.SubItems[6].Text)
                {
                    MessageBox.Show("Item already in list, please select another.");
                    return;
                }

            }

            travelListView.Items.Add(newItem);
            updatePriceTotal();

        }

        private void updatePriceTotal()
        {
            double priceTotal = 0;
            foreach (ListViewItem trip in travelListView.Items)
            {
                try
                {
                    priceTotal = priceTotal + double.Parse(trip.SubItems[6].Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The price field of an item is incorrect so price cannot update.");
                }
            }
            totalTravelCostLabel.Text = "Cost: $" + priceTotal;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            memoryImage = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(memoryImage);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem trip in travelListView.Items)
            {
                travelListView.Items.Remove(trip);
            }
            travelerIDTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            destinationTextBox.Clear();
            travelCostTextBox.Clear();
            tripDatesTextBox.Clear();
            purposeTextBox.Clear();
            totalTravelCostLabel.Text = "Total Cost: $0.00";
            bindingNavigatorPositionItem.Text = "0";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Owner.Location.X, this.Owner.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void Travelers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to close the application?",
                "Close Form Validation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {   
            dataGridView1.Refresh();
        }
    }
}
