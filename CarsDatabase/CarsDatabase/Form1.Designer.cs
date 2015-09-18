namespace CarsDatabase
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label vehicleRegNoLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label engineSizeLabel;
            System.Windows.Forms.Label dateRegisteredLabel;
            System.Windows.Forms.Label rentalDayLabel;
            System.Windows.Forms.Label availableLabel;
            this.hireDataSet = new CarsDatabase.HireDataSet();
            this.tblCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCarTableAdapter = new CarsDatabase.HireDataSetTableAdapters.tblCarTableAdapter();
            this.tableAdapterManager = new CarsDatabase.HireDataSetTableAdapters.TableAdapterManager();
            this.tblCarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vehicleRegNoTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.engineSizeTextBox = new System.Windows.Forms.TextBox();
            this.dateRegisteredDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rentalDayTextBox = new System.Windows.Forms.TextBox();
            this.availableCheckBox = new System.Windows.Forms.CheckBox();
            vehicleRegNoLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            engineSizeLabel = new System.Windows.Forms.Label();
            dateRegisteredLabel = new System.Windows.Forms.Label();
            rentalDayLabel = new System.Windows.Forms.Label();
            availableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingNavigator)).BeginInit();
            this.tblCarBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // hireDataSet
            // 
            this.hireDataSet.DataSetName = "HireDataSet";
            this.hireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCarBindingSource
            // 
            this.tblCarBindingSource.DataMember = "tblCar";
            this.tblCarBindingSource.DataSource = this.hireDataSet;
            // 
            // tblCarTableAdapter
            // 
            this.tblCarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCarTableAdapter = this.tblCarTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarsDatabase.HireDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCarBindingNavigator
            // 
            this.tblCarBindingNavigator.AddNewItem = null;
            this.tblCarBindingNavigator.BindingSource = this.tblCarBindingSource;
            this.tblCarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblCarBindingNavigator.DeleteItem = null;
            this.tblCarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.tblCarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblCarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblCarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblCarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblCarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblCarBindingNavigator.Name = "tblCarBindingNavigator";
            this.tblCarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblCarBindingNavigator.Size = new System.Drawing.Size(847, 25);
            this.tblCarBindingNavigator.TabIndex = 0;
            this.tblCarBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // vehicleRegNoLabel
            // 
            vehicleRegNoLabel.AutoSize = true;
            vehicleRegNoLabel.Location = new System.Drawing.Point(26, 95);
            vehicleRegNoLabel.Name = "vehicleRegNoLabel";
            vehicleRegNoLabel.Size = new System.Drawing.Size(85, 13);
            vehicleRegNoLabel.TabIndex = 1;
            vehicleRegNoLabel.Text = "Vehicle Reg No:";
            // 
            // vehicleRegNoTextBox
            // 
            this.vehicleRegNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "VehicleRegNo", true));
            this.vehicleRegNoTextBox.Location = new System.Drawing.Point(119, 92);
            this.vehicleRegNoTextBox.Name = "vehicleRegNoTextBox";
            this.vehicleRegNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.vehicleRegNoTextBox.TabIndex = 2;
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(26, 121);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(37, 13);
            makeLabel.TabIndex = 3;
            makeLabel.Text = "Make:";
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "Make", true));
            this.makeTextBox.Location = new System.Drawing.Point(119, 118);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(200, 20);
            this.makeTextBox.TabIndex = 4;
            // 
            // engineSizeLabel
            // 
            engineSizeLabel.AutoSize = true;
            engineSizeLabel.Location = new System.Drawing.Point(26, 147);
            engineSizeLabel.Name = "engineSizeLabel";
            engineSizeLabel.Size = new System.Drawing.Size(66, 13);
            engineSizeLabel.TabIndex = 5;
            engineSizeLabel.Text = "Engine Size:";
            // 
            // engineSizeTextBox
            // 
            this.engineSizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "EngineSize", true));
            this.engineSizeTextBox.Location = new System.Drawing.Point(119, 144);
            this.engineSizeTextBox.Name = "engineSizeTextBox";
            this.engineSizeTextBox.Size = new System.Drawing.Size(200, 20);
            this.engineSizeTextBox.TabIndex = 6;
            // 
            // dateRegisteredLabel
            // 
            dateRegisteredLabel.AutoSize = true;
            dateRegisteredLabel.Location = new System.Drawing.Point(26, 174);
            dateRegisteredLabel.Name = "dateRegisteredLabel";
            dateRegisteredLabel.Size = new System.Drawing.Size(87, 13);
            dateRegisteredLabel.TabIndex = 7;
            dateRegisteredLabel.Text = "Date Registered:";
            // 
            // dateRegisteredDateTimePicker
            // 
            this.dateRegisteredDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblCarBindingSource, "DateRegistered", true));
            this.dateRegisteredDateTimePicker.Location = new System.Drawing.Point(119, 170);
            this.dateRegisteredDateTimePicker.Name = "dateRegisteredDateTimePicker";
            this.dateRegisteredDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateRegisteredDateTimePicker.TabIndex = 8;
            // 
            // rentalDayLabel
            // 
            rentalDayLabel.AutoSize = true;
            rentalDayLabel.Location = new System.Drawing.Point(26, 199);
            rentalDayLabel.Name = "rentalDayLabel";
            rentalDayLabel.Size = new System.Drawing.Size(63, 13);
            rentalDayLabel.TabIndex = 9;
            rentalDayLabel.Text = "Rental Day:";
            // 
            // rentalDayTextBox
            // 
            this.rentalDayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "RentalDay", true));
            this.rentalDayTextBox.Location = new System.Drawing.Point(119, 196);
            this.rentalDayTextBox.Name = "rentalDayTextBox";
            this.rentalDayTextBox.Size = new System.Drawing.Size(200, 20);
            this.rentalDayTextBox.TabIndex = 10;
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Location = new System.Drawing.Point(26, 227);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new System.Drawing.Size(53, 13);
            availableLabel.TabIndex = 11;
            availableLabel.Text = "Available:";
            // 
            // availableCheckBox
            // 
            this.availableCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblCarBindingSource, "Available", true));
            this.availableCheckBox.Location = new System.Drawing.Point(119, 222);
            this.availableCheckBox.Name = "availableCheckBox";
            this.availableCheckBox.Size = new System.Drawing.Size(200, 24);
            this.availableCheckBox.TabIndex = 12;
            this.availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 527);
            this.Controls.Add(vehicleRegNoLabel);
            this.Controls.Add(this.vehicleRegNoTextBox);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(engineSizeLabel);
            this.Controls.Add(this.engineSizeTextBox);
            this.Controls.Add(dateRegisteredLabel);
            this.Controls.Add(this.dateRegisteredDateTimePicker);
            this.Controls.Add(rentalDayLabel);
            this.Controls.Add(this.rentalDayTextBox);
            this.Controls.Add(availableLabel);
            this.Controls.Add(this.availableCheckBox);
            this.Controls.Add(this.tblCarBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingNavigator)).EndInit();
            this.tblCarBindingNavigator.ResumeLayout(false);
            this.tblCarBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HireDataSet hireDataSet;
        private System.Windows.Forms.BindingSource tblCarBindingSource;
        private HireDataSetTableAdapters.tblCarTableAdapter tblCarTableAdapter;
        private HireDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblCarBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox vehicleRegNoTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox engineSizeTextBox;
        private System.Windows.Forms.DateTimePicker dateRegisteredDateTimePicker;
        private System.Windows.Forms.TextBox rentalDayTextBox;
        private System.Windows.Forms.CheckBox availableCheckBox;
    }
}

