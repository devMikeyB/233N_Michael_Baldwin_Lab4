namespace _233N_Michael_Baldwin_Lab4
{
    partial class Travelers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Travelers));
            this.planePictureBox = new System.Windows.Forms.PictureBox();
            this.travelerIDTextBox = new System.Windows.Forms.TextBox();
            this.travelRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelDataSet = new _233N_Michael_Baldwin_Lab4.TravelDataSet();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.travelCostTextBox = new System.Windows.Forms.TextBox();
            this.tripDatesTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.travelerIDLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.travelCostLabel = new System.Windows.Forms.Label();
            this.tripDatesLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.purposeLabel = new System.Windows.Forms.Label();
            this.purposeTextBox = new System.Windows.Forms.TextBox();
            this.travelListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Purpose = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.travelCostGroupBox = new System.Windows.Forms.GroupBox();
            this.totalTravelCostLabel = new System.Windows.Forms.Label();
            this.travelRequestsTableAdapter = new _233N_Michael_Baldwin_Lab4.TravelDataSetTableAdapters.TravelRequestsTableAdapter();
            this.accessDataGroupBox = new System.Windows.Forms.GroupBox();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purposeforTravelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripDatesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.planePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.travelCostGroupBox.SuspendLayout();
            this.accessDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.controlsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // planePictureBox
            // 
            this.planePictureBox.Image = global::_233N_Michael_Baldwin_Lab4.Properties.Resources.plane;
            this.planePictureBox.Location = new System.Drawing.Point(12, 58);
            this.planePictureBox.Name = "planePictureBox";
            this.planePictureBox.Size = new System.Drawing.Size(419, 122);
            this.planePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planePictureBox.TabIndex = 0;
            this.planePictureBox.TabStop = false;
            // 
            // travelerIDTextBox
            // 
            this.travelerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.travelRequestsBindingSource, "EmployeeID", true));
            this.travelerIDTextBox.Location = new System.Drawing.Point(106, 186);
            this.travelerIDTextBox.Name = "travelerIDTextBox";
            this.travelerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.travelerIDTextBox.TabIndex = 1;
            // 
            // travelRequestsBindingSource
            // 
            this.travelRequestsBindingSource.DataMember = "TravelRequests";
            this.travelRequestsBindingSource.DataSource = this.travelDataSetBindingSource;
            // 
            // travelDataSetBindingSource
            // 
            this.travelDataSetBindingSource.DataSource = this.travelDataSet;
            this.travelDataSetBindingSource.Position = 0;
            // 
            // travelDataSet
            // 
            this.travelDataSet.DataSetName = "TravelDataSet";
            this.travelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.travelRequestsBindingSource, "Location", true));
            this.destinationTextBox.Location = new System.Drawing.Point(106, 217);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(100, 20);
            this.destinationTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.travelRequestsBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(106, 247);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // travelCostTextBox
            // 
            this.travelCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.travelRequestsBindingSource, "TravelCost", true));
            this.travelCostTextBox.Location = new System.Drawing.Point(331, 186);
            this.travelCostTextBox.Name = "travelCostTextBox";
            this.travelCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.travelCostTextBox.TabIndex = 4;
            // 
            // tripDatesTextBox
            // 
            this.tripDatesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.travelRequestsBindingSource, "TripDates", true));
            this.tripDatesTextBox.Location = new System.Drawing.Point(331, 217);
            this.tripDatesTextBox.Name = "tripDatesTextBox";
            this.tripDatesTextBox.Size = new System.Drawing.Size(100, 20);
            this.tripDatesTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.travelRequestsBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(331, 247);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // travelerIDLabel
            // 
            this.travelerIDLabel.AutoSize = true;
            this.travelerIDLabel.Location = new System.Drawing.Point(25, 192);
            this.travelerIDLabel.Name = "travelerIDLabel";
            this.travelerIDLabel.Size = new System.Drawing.Size(66, 13);
            this.travelerIDLabel.TabIndex = 7;
            this.travelerIDLabel.Text = "Traveler ID: ";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(25, 224);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(66, 13);
            this.destinationLabel.TabIndex = 8;
            this.destinationLabel.Text = "Destination: ";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(25, 254);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(64, 13);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Last Name: ";
            // 
            // travelCostLabel
            // 
            this.travelCostLabel.AutoSize = true;
            this.travelCostLabel.Location = new System.Drawing.Point(257, 193);
            this.travelCostLabel.Name = "travelCostLabel";
            this.travelCostLabel.Size = new System.Drawing.Size(64, 13);
            this.travelCostLabel.TabIndex = 10;
            this.travelCostLabel.Text = "Travel Cost:";
            // 
            // tripDatesLabel
            // 
            this.tripDatesLabel.AutoSize = true;
            this.tripDatesLabel.Location = new System.Drawing.Point(257, 224);
            this.tripDatesLabel.Name = "tripDatesLabel";
            this.tripDatesLabel.Size = new System.Drawing.Size(59, 13);
            this.tripDatesLabel.TabIndex = 11;
            this.tripDatesLabel.Text = "Trip Dates:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(257, 254);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 12;
            this.firstNameLabel.Text = "First Name:";
            // 
            // purposeLabel
            // 
            this.purposeLabel.AutoSize = true;
            this.purposeLabel.Location = new System.Drawing.Point(9, 286);
            this.purposeLabel.Name = "purposeLabel";
            this.purposeLabel.Size = new System.Drawing.Size(100, 13);
            this.purposeLabel.TabIndex = 13;
            this.purposeLabel.Text = "Purpose For Travel:";
            // 
            // purposeTextBox
            // 
            this.purposeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.travelRequestsBindingSource, "PurposeforTravel", true));
            this.purposeTextBox.Location = new System.Drawing.Point(115, 283);
            this.purposeTextBox.Name = "purposeTextBox";
            this.purposeTextBox.Size = new System.Drawing.Size(316, 20);
            this.purposeTextBox.TabIndex = 14;
            // 
            // travelListView
            // 
            this.travelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.LastName,
            this.FirstName,
            this.Purpose,
            this.Location,
            this.Date,
            this.Cost});
            this.travelListView.HideSelection = false;
            this.travelListView.Location = new System.Drawing.Point(492, 58);
            this.travelListView.Name = "travelListView";
            this.travelListView.Size = new System.Drawing.Size(614, 241);
            this.travelListView.TabIndex = 15;
            this.travelListView.UseCompatibleStateImageBehavior = false;
            this.travelListView.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            // 
            // Purpose
            // 
            this.Purpose.Text = "Purpose";
            // 
            // Location
            // 
            this.Location.Text = "Destination";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // Cost
            // 
            this.Cost.Text = "Cost";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.travelRequestsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.saveToolStripButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1118, 25);
            this.bindingNavigator1.TabIndex = 16;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // travelCostGroupBox
            // 
            this.travelCostGroupBox.Controls.Add(this.totalTravelCostLabel);
            this.travelCostGroupBox.Location = new System.Drawing.Point(859, 305);
            this.travelCostGroupBox.Name = "travelCostGroupBox";
            this.travelCostGroupBox.Size = new System.Drawing.Size(247, 58);
            this.travelCostGroupBox.TabIndex = 18;
            this.travelCostGroupBox.TabStop = false;
            this.travelCostGroupBox.Text = "Travel Cost: $0";
            // 
            // totalTravelCostLabel
            // 
            this.totalTravelCostLabel.AutoSize = true;
            this.totalTravelCostLabel.Location = new System.Drawing.Point(25, 20);
            this.totalTravelCostLabel.Name = "totalTravelCostLabel";
            this.totalTravelCostLabel.Size = new System.Drawing.Size(34, 13);
            this.totalTravelCostLabel.TabIndex = 0;
            this.totalTravelCostLabel.Text = "Cost: ";
            // 
            // travelRequestsTableAdapter
            // 
            this.travelRequestsTableAdapter.ClearBeforeFill = true;
            // 
            // accessDataGroupBox
            // 
            this.accessDataGroupBox.Controls.Add(this.findTextBox);
            this.accessDataGroupBox.Controls.Add(this.findButton);
            this.accessDataGroupBox.Location = new System.Drawing.Point(28, 310);
            this.accessDataGroupBox.Name = "accessDataGroupBox";
            this.accessDataGroupBox.Size = new System.Drawing.Size(463, 54);
            this.accessDataGroupBox.TabIndex = 21;
            this.accessDataGroupBox.TabStop = false;
            this.accessDataGroupBox.Text = "Access Data";
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(78, 22);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(100, 20);
            this.findTextBox.TabIndex = 1;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(190, 20);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 0;
            this.findButton.Text = "Search";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.purposeforTravelDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.tripDatesDataGridViewTextBoxColumn,
            this.travelCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.travelRequestsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 105);
            this.dataGridView1.TabIndex = 22;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // purposeforTravelDataGridViewTextBoxColumn
            // 
            this.purposeforTravelDataGridViewTextBoxColumn.DataPropertyName = "PurposeforTravel";
            this.purposeforTravelDataGridViewTextBoxColumn.HeaderText = "PurposeforTravel";
            this.purposeforTravelDataGridViewTextBoxColumn.Name = "purposeforTravelDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // tripDatesDataGridViewTextBoxColumn
            // 
            this.tripDatesDataGridViewTextBoxColumn.DataPropertyName = "TripDates";
            this.tripDatesDataGridViewTextBoxColumn.HeaderText = "TripDates";
            this.tripDatesDataGridViewTextBoxColumn.Name = "tripDatesDataGridViewTextBoxColumn";
            // 
            // travelCostDataGridViewTextBoxColumn
            // 
            this.travelCostDataGridViewTextBoxColumn.DataPropertyName = "TravelCost";
            this.travelCostDataGridViewTextBoxColumn.HeaderText = "TravelCost";
            this.travelCostDataGridViewTextBoxColumn.Name = "travelCostDataGridViewTextBoxColumn";
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.exitButton);
            this.controlsGroupBox.Controls.Add(this.clearButton);
            this.controlsGroupBox.Controls.Add(this.printButton);
            this.controlsGroupBox.Controls.Add(this.displayButton);
            this.controlsGroupBox.Controls.Add(this.reportButton);
            this.controlsGroupBox.Location = new System.Drawing.Point(12, 481);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(744, 87);
            this.controlsGroupBox.TabIndex = 23;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controls";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(581, 37);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(354, 37);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(273, 37);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(192, 37);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 23);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(111, 37);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 0;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // Travelers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 592);
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.accessDataGroupBox);
            this.Controls.Add(this.travelCostGroupBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.travelListView);
            this.Controls.Add(this.purposeTextBox);
            this.Controls.Add(this.purposeLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.tripDatesLabel);
            this.Controls.Add(this.travelCostLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.travelerIDLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.tripDatesTextBox);
            this.Controls.Add(this.travelCostTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.travelerIDTextBox);
            this.Controls.Add(this.planePictureBox);
            this.Name = "Travelers";
            this.Text = "Travelers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Travelers_FormClosing);
            this.Load += new System.EventHandler(this.Travelers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.travelCostGroupBox.ResumeLayout(false);
            this.travelCostGroupBox.PerformLayout();
            this.accessDataGroupBox.ResumeLayout(false);
            this.accessDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.controlsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox planePictureBox;
        private System.Windows.Forms.TextBox travelerIDTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox travelCostTextBox;
        private System.Windows.Forms.TextBox tripDatesTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label travelerIDLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label travelCostLabel;
        private System.Windows.Forms.Label tripDatesLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label purposeLabel;
        private System.Windows.Forms.TextBox purposeTextBox;
        private System.Windows.Forms.ListView travelListView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.GroupBox travelCostGroupBox;
        private System.Windows.Forms.Label totalTravelCostLabel;
        private System.Windows.Forms.BindingSource travelDataSetBindingSource;
        private TravelDataSet travelDataSet;
        private System.Windows.Forms.BindingSource travelRequestsBindingSource;
        private TravelDataSetTableAdapters.TravelRequestsTableAdapter travelRequestsTableAdapter;
        private System.Windows.Forms.GroupBox accessDataGroupBox;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purposeforTravelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripDatesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader Purpose;
        private System.Windows.Forms.ColumnHeader Location;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button reportButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
    }
}