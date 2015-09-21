namespace CarsDatabase
{
    partial class frmCars
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
            System.Windows.Forms.Label vehicleRegNoLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label engineSizeLabel;
            System.Windows.Forms.Label dateRegisteredLabel;
            System.Windows.Forms.Label rentalDayLabel;
            System.Windows.Forms.Label availableLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCars));
            this.hireDataSet = new CarsDatabase.HireDataSet();
            this.tblCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCarTableAdapter = new CarsDatabase.HireDataSetTableAdapters.tblCarTableAdapter();
            this.tableAdapterManager = new CarsDatabase.HireDataSetTableAdapters.TableAdapterManager();
            this.tblCarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtVehicleReg = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtEngineSize = new System.Windows.Forms.TextBox();
            this.dtDateRegistered = new System.Windows.Forms.DateTimePicker();
            this.txtRentalDay = new System.Windows.Forms.TextBox();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
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
            // vehicleRegNoLabel
            // 
            vehicleRegNoLabel.AutoSize = true;
            vehicleRegNoLabel.Location = new System.Drawing.Point(8, 131);
            vehicleRegNoLabel.Name = "vehicleRegNoLabel";
            vehicleRegNoLabel.Size = new System.Drawing.Size(85, 13);
            vehicleRegNoLabel.TabIndex = 1;
            vehicleRegNoLabel.Text = "Vehicle Reg No:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(8, 157);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(37, 13);
            makeLabel.TabIndex = 3;
            makeLabel.Text = "Make:";
            // 
            // engineSizeLabel
            // 
            engineSizeLabel.AutoSize = true;
            engineSizeLabel.Location = new System.Drawing.Point(8, 183);
            engineSizeLabel.Name = "engineSizeLabel";
            engineSizeLabel.Size = new System.Drawing.Size(66, 13);
            engineSizeLabel.TabIndex = 5;
            engineSizeLabel.Text = "Engine Size:";
            // 
            // dateRegisteredLabel
            // 
            dateRegisteredLabel.AutoSize = true;
            dateRegisteredLabel.Location = new System.Drawing.Point(8, 210);
            dateRegisteredLabel.Name = "dateRegisteredLabel";
            dateRegisteredLabel.Size = new System.Drawing.Size(87, 13);
            dateRegisteredLabel.TabIndex = 7;
            dateRegisteredLabel.Text = "Date Registered:";
            // 
            // rentalDayLabel
            // 
            rentalDayLabel.AutoSize = true;
            rentalDayLabel.Location = new System.Drawing.Point(8, 235);
            rentalDayLabel.Name = "rentalDayLabel";
            rentalDayLabel.Size = new System.Drawing.Size(82, 13);
            rentalDayLabel.TabIndex = 9;
            rentalDayLabel.Text = "Rental Per Day:";
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Location = new System.Drawing.Point(8, 263);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new System.Drawing.Size(53, 13);
            availableLabel.TabIndex = 11;
            availableLabel.Text = "Available:";
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
            this.tblCarBindingNavigator.Size = new System.Drawing.Size(633, 25);
            this.tblCarBindingNavigator.TabIndex = 0;
            this.tblCarBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // txtVehicleReg
            // 
            this.txtVehicleReg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "VehicleRegNo", true));
            this.txtVehicleReg.Location = new System.Drawing.Point(101, 128);
            this.txtVehicleReg.Name = "txtVehicleReg";
            this.txtVehicleReg.Size = new System.Drawing.Size(200, 20);
            this.txtVehicleReg.TabIndex = 1;
            // 
            // txtMake
            // 
            this.txtMake.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "Make", true));
            this.txtMake.Location = new System.Drawing.Point(101, 154);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(200, 20);
            this.txtMake.TabIndex = 2;
            // 
            // txtEngineSize
            // 
            this.txtEngineSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "EngineSize", true));
            this.txtEngineSize.Location = new System.Drawing.Point(101, 180);
            this.txtEngineSize.Name = "txtEngineSize";
            this.txtEngineSize.Size = new System.Drawing.Size(200, 20);
            this.txtEngineSize.TabIndex = 3;
            // 
            // dtDateRegistered
            // 
            this.dtDateRegistered.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblCarBindingSource, "DateRegistered", true));
            this.dtDateRegistered.Location = new System.Drawing.Point(101, 206);
            this.dtDateRegistered.Name = "dtDateRegistered";
            this.dtDateRegistered.Size = new System.Drawing.Size(200, 20);
            this.dtDateRegistered.TabIndex = 4;
            // 
            // txtRentalDay
            // 
            this.txtRentalDay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "RentalDay", true));
            this.txtRentalDay.Location = new System.Drawing.Point(101, 232);
            this.txtRentalDay.Name = "txtRentalDay";
            this.txtRentalDay.Size = new System.Drawing.Size(200, 20);
            this.txtRentalDay.TabIndex = 5;
            // 
            // chkAvailable
            // 
            this.chkAvailable.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblCarBindingSource, "Available", true));
            this.chkAvailable.Location = new System.Drawing.Point(101, 258);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(200, 24);
            this.chkAvailable.TabIndex = 6;
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(540, 121);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(540, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(540, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(540, 208);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(540, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(540, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(11, 303);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.Text = "<< &First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(93, 303);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "< &Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(226, 303);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "&Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(308, 303);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 10;
            this.btnLast.Text = "&Last >>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Enabled = false;
            this.txtPosition.Location = new System.Drawing.Point(174, 306);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(46, 20);
            this.txtPosition.TabIndex = 23;
            this.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(167, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 38);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Bowman Car Hire";
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 343);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(vehicleRegNoLabel);
            this.Controls.Add(this.txtVehicleReg);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(engineSizeLabel);
            this.Controls.Add(this.txtEngineSize);
            this.Controls.Add(dateRegisteredLabel);
            this.Controls.Add(this.dtDateRegistered);
            this.Controls.Add(rentalDayLabel);
            this.Controls.Add(this.txtRentalDay);
            this.Controls.Add(availableLabel);
            this.Controls.Add(this.chkAvailable);
            this.Controls.Add(this.tblCarBindingNavigator);
            this.Name = "frmCars";
            this.Text = "Task A - Ciaran Maher - 21/09/2015";
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
        private System.Windows.Forms.TextBox txtVehicleReg;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtEngineSize;
        private System.Windows.Forms.DateTimePicker dtDateRegistered;
        private System.Windows.Forms.TextBox txtRentalDay;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblTitle;
    }
}

