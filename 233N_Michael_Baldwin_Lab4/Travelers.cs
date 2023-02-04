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


            foreach(ListViewItem item in travelListView.Items)
            {//Checking if an identical item exists using SubItems.
                if(item.Text == newItem.Text &&
                    item.SubItems[1].Text == newItem.SubItems[1].Text &&
                    item.SubItems[2].Text == newItem.SubItems[2].Text &&
                    item.SubItems[3].Text == newItem.SubItems[3].Text &&
                    item.SubItems[4].Text == newItem.SubItems[4].Text &&
                    item.SubItems[5].Text == newItem.SubItems[5].Text &&
                    item.SubItems[6].Text == newItem.SubItems[6].Text){
                    MessageBox.Show("Item already in list, please select another.");
                    return;
                }
                
            }

            travelListView.Items.Add(newItem);
            updatePriceTotal();

        }

        private void updatePriceTotal()
        { double priceTotal = 0;
           foreach(ListViewItem trip in travelListView.Items)
            {
                try
                {
                    priceTotal = priceTotal + double.Parse(trip.SubItems[6].Text);
                }catch(Exception ex)
                {
                    MessageBox.Show("The price field of an item is incorrect so price cannot update.");
                }
            }
            totalTravelCostLabel.Text = "Cost: $" + priceTotal;
        }

        private void printButton_Click(object sender, EventArgs e)
        {/*
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            PrintDocument.Print();

            PrintPreviewDialog myPrintMentu = new PrintPreviewDialog();
            myPrintMentu.ShowDialog(); 
        */}

        private void clearButton_Click(object sender, EventArgs e)
        {
            travelListView.Clear();
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

        }
    }
}
