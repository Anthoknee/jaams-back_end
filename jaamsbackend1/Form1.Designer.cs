namespace jaamsbackend1
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
            System.Windows.Forms.Label projNameLabel;
            System.Windows.Forms.Label serverLabel;
            System.Windows.Forms.Label semesterCreatedLabel;
            System.Windows.Forms.Label dateExpiresLabel;
            System.Windows.Forms.Label dateCreatedLabel;
            System.Windows.Forms.Label dateDeletedLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label advisor_nameLabel;
            System.Windows.Forms.Label advisor_emailLabel;
            System.Windows.Forms.Label groupNameLabel;
            System.Windows.Forms.Label expiredWarningLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.datamanDataSet = new jaamsbackend1.datamanDataSet();
            this.dataman_databaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataman_databaseTableAdapter = new jaamsbackend1.datamanDataSetTableAdapters.dataman_databaseTableAdapter();
            this.tableAdapterManager = new jaamsbackend1.datamanDataSetTableAdapters.TableAdapterManager();
            this.dataman_databaseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dataman_databaseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataman_databaseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projNameTextBox = new System.Windows.Forms.TextBox();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.semesterCreatedTextBox = new System.Windows.Forms.TextBox();
            this.dateExpiresDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateCreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateDeletedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.advisor_nameTextBox = new System.Windows.Forms.TextBox();
            this.advisor_emailTextBox = new System.Windows.Forms.TextBox();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.expiredWarningTextBox = new System.Windows.Forms.TextBox();
            this.projectFormButton = new System.Windows.Forms.Button();
            projNameLabel = new System.Windows.Forms.Label();
            serverLabel = new System.Windows.Forms.Label();
            semesterCreatedLabel = new System.Windows.Forms.Label();
            dateExpiresLabel = new System.Windows.Forms.Label();
            dateCreatedLabel = new System.Windows.Forms.Label();
            dateDeletedLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            advisor_nameLabel = new System.Windows.Forms.Label();
            advisor_emailLabel = new System.Windows.Forms.Label();
            groupNameLabel = new System.Windows.Forms.Label();
            expiredWarningLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datamanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataman_databaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataman_databaseBindingNavigator)).BeginInit();
            this.dataman_databaseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataman_databaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // projNameLabel
            // 
            projNameLabel.AutoSize = true;
            projNameLabel.Location = new System.Drawing.Point(7, 208);
            projNameLabel.Name = "projNameLabel";
            projNameLabel.Size = new System.Drawing.Size(58, 13);
            projNameLabel.TabIndex = 2;
            projNameLabel.Text = "proj Name:";
            // 
            // serverLabel
            // 
            serverLabel.AutoSize = true;
            serverLabel.Location = new System.Drawing.Point(12, 232);
            serverLabel.Name = "serverLabel";
            serverLabel.Size = new System.Drawing.Size(39, 13);
            serverLabel.TabIndex = 4;
            serverLabel.Text = "server:";
            // 
            // semesterCreatedLabel
            // 
            semesterCreatedLabel.AutoSize = true;
            semesterCreatedLabel.Location = new System.Drawing.Point(7, 260);
            semesterCreatedLabel.Name = "semesterCreatedLabel";
            semesterCreatedLabel.Size = new System.Drawing.Size(92, 13);
            semesterCreatedLabel.TabIndex = 6;
            semesterCreatedLabel.Text = "semester Created:";
            // 
            // dateExpiresLabel
            // 
            dateExpiresLabel.AutoSize = true;
            dateExpiresLabel.Location = new System.Drawing.Point(336, 206);
            dateExpiresLabel.Name = "dateExpiresLabel";
            dateExpiresLabel.Size = new System.Drawing.Size(68, 13);
            dateExpiresLabel.TabIndex = 8;
            dateExpiresLabel.Text = "date Expires:";
            // 
            // dateCreatedLabel
            // 
            dateCreatedLabel.AutoSize = true;
            dateCreatedLabel.Location = new System.Drawing.Point(336, 232);
            dateCreatedLabel.Name = "dateCreatedLabel";
            dateCreatedLabel.Size = new System.Drawing.Size(71, 13);
            dateCreatedLabel.TabIndex = 10;
            dateCreatedLabel.Text = "date Created:";
            // 
            // dateDeletedLabel
            // 
            dateDeletedLabel.AutoSize = true;
            dateDeletedLabel.Location = new System.Drawing.Point(336, 258);
            dateDeletedLabel.Name = "dateDeletedLabel";
            dateDeletedLabel.Size = new System.Drawing.Size(71, 13);
            dateDeletedLabel.TabIndex = 12;
            dateDeletedLabel.Text = "date Deleted:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(672, 206);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(38, 13);
            statusLabel.TabIndex = 14;
            statusLabel.Text = "status:";
            // 
            // advisor_nameLabel
            // 
            advisor_nameLabel.AutoSize = true;
            advisor_nameLabel.Location = new System.Drawing.Point(672, 232);
            advisor_nameLabel.Name = "advisor_nameLabel";
            advisor_nameLabel.Size = new System.Drawing.Size(73, 13);
            advisor_nameLabel.TabIndex = 16;
            advisor_nameLabel.Text = "advisor name:";
            // 
            // advisor_emailLabel
            // 
            advisor_emailLabel.AutoSize = true;
            advisor_emailLabel.Location = new System.Drawing.Point(672, 258);
            advisor_emailLabel.Name = "advisor_emailLabel";
            advisor_emailLabel.Size = new System.Drawing.Size(71, 13);
            advisor_emailLabel.TabIndex = 18;
            advisor_emailLabel.Text = "advisor email:";
            // 
            // groupNameLabel
            // 
            groupNameLabel.AutoSize = true;
            groupNameLabel.Location = new System.Drawing.Point(672, 288);
            groupNameLabel.Name = "groupNameLabel";
            groupNameLabel.Size = new System.Drawing.Size(68, 13);
            groupNameLabel.TabIndex = 20;
            groupNameLabel.Text = "group Name:";
            // 
            // expiredWarningLabel
            // 
            expiredWarningLabel.AutoSize = true;
            expiredWarningLabel.Location = new System.Drawing.Point(672, 314);
            expiredWarningLabel.Name = "expiredWarningLabel";
            expiredWarningLabel.Size = new System.Drawing.Size(87, 13);
            expiredWarningLabel.TabIndex = 22;
            expiredWarningLabel.Text = "expired Warning:";
            // 
            // datamanDataSet
            // 
            this.datamanDataSet.DataSetName = "datamanDataSet";
            this.datamanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataman_databaseBindingSource
            // 
            this.dataman_databaseBindingSource.DataMember = "dataman_database";
            this.dataman_databaseBindingSource.DataSource = this.datamanDataSet;
            // 
            // dataman_databaseTableAdapter
            // 
            this.dataman_databaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dataman_databaseTableAdapter = this.dataman_databaseTableAdapter;
            this.tableAdapterManager.dataman_dbaccountsTableAdapter = null;
            this.tableAdapterManager.dataman_groupTableAdapter = null;
            this.tableAdapterManager.dataman_historyTableAdapter = null;
            this.tableAdapterManager.dataman_passTableAdapter = null;
            this.tableAdapterManager.dataman_peopleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = jaamsbackend1.datamanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataman_databaseBindingNavigator
            // 
            this.dataman_databaseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dataman_databaseBindingNavigator.BindingSource = this.dataman_databaseBindingSource;
            this.dataman_databaseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataman_databaseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dataman_databaseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dataman_databaseBindingNavigatorSaveItem});
            this.dataman_databaseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataman_databaseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataman_databaseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataman_databaseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataman_databaseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataman_databaseBindingNavigator.Name = "dataman_databaseBindingNavigator";
            this.dataman_databaseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataman_databaseBindingNavigator.Size = new System.Drawing.Size(1155, 25);
            this.dataman_databaseBindingNavigator.TabIndex = 0;
            this.dataman_databaseBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // dataman_databaseBindingNavigatorSaveItem
            // 
            this.dataman_databaseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dataman_databaseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dataman_databaseBindingNavigatorSaveItem.Image")));
            this.dataman_databaseBindingNavigatorSaveItem.Name = "dataman_databaseBindingNavigatorSaveItem";
            this.dataman_databaseBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dataman_databaseBindingNavigatorSaveItem.Text = "Save Data";
            this.dataman_databaseBindingNavigatorSaveItem.Click += new System.EventHandler(this.dataman_databaseBindingNavigatorSaveItem_Click);
            // 
            // dataman_databaseDataGridView
            // 
            this.dataman_databaseDataGridView.AutoGenerateColumns = false;
            this.dataman_databaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataman_databaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dataman_databaseDataGridView.DataSource = this.dataman_databaseBindingSource;
            this.dataman_databaseDataGridView.Location = new System.Drawing.Point(0, 28);
            this.dataman_databaseDataGridView.Name = "dataman_databaseDataGridView";
            this.dataman_databaseDataGridView.Size = new System.Drawing.Size(1135, 168);
            this.dataman_databaseDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "projName";
            this.dataGridViewTextBoxColumn1.HeaderText = "projName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "server";
            this.dataGridViewTextBoxColumn2.HeaderText = "server";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "semesterCreated";
            this.dataGridViewTextBoxColumn3.HeaderText = "semesterCreated";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dateExpires";
            this.dataGridViewTextBoxColumn4.HeaderText = "dateExpires";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dateCreated";
            this.dataGridViewTextBoxColumn5.HeaderText = "dateCreated";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dateDeleted";
            this.dataGridViewTextBoxColumn6.HeaderText = "dateDeleted";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn7.HeaderText = "status";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "advisor_name";
            this.dataGridViewTextBoxColumn8.HeaderText = "advisor_name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "advisor_email";
            this.dataGridViewTextBoxColumn9.HeaderText = "advisor_email";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "groupName";
            this.dataGridViewTextBoxColumn10.HeaderText = "groupName";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "expiredWarning";
            this.dataGridViewTextBoxColumn11.HeaderText = "expiredWarning";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // projNameTextBox
            // 
            this.projNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataman_databaseBindingSource, "projName", true));
            this.projNameTextBox.Location = new System.Drawing.Point(105, 205);
            this.projNameTextBox.Name = "projNameTextBox";
            this.projNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.projNameTextBox.TabIndex = 3;
            // 
            // serverTextBox
            // 
            this.serverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataman_databaseBindingSource, "server", true));
            this.serverTextBox.Location = new System.Drawing.Point(105, 231);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(200, 20);
            this.serverTextBox.TabIndex = 5;
            // 
            // semesterCreatedTextBox
            // 
            this.semesterCreatedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataman_databaseBindingSource, "semesterCreated", true));
            this.semesterCreatedTextBox.Location = new System.Drawing.Point(105, 257);
            this.semesterCreatedTextBox.Name = "semesterCreatedTextBox";
            this.semesterCreatedTextBox.Size = new System.Drawing.Size(200, 20);
            this.semesterCreatedTextBox.TabIndex = 7;
            // 
            // dateExpiresDateTimePicker
            // 
            this.dateExpiresDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataman_databaseBindingSource, "dateExpires", true));
            this.dateExpiresDateTimePicker.Location = new System.Drawing.Point(434, 202);
            this.dateExpiresDateTimePicker.Name = "dateExpiresDateTimePicker";
            this.dateExpiresDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateExpiresDateTimePicker.TabIndex = 9;
            // 
            // dateCreatedDateTimePicker
            // 
            this.dateCreatedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataman_databaseBindingSource, "dateCreated", true));
            this.dateCreatedDateTimePicker.Location = new System.Drawing.Point(434, 228);
            this.dateCreatedDateTimePicker.Name = "dateCreatedDateTimePicker";
            this.dateCreatedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateCreatedDateTimePicker.TabIndex = 11;
            // 
            // dateDeletedDateTimePicker
            // 
            this.dateDeletedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataman_databaseBindingSource, "dateDeleted", true));
            this.dateDeletedDateTimePicker.Location = new System.Drawing.Point(434, 254);
            this.dateDeletedDateTimePicker.Name = "dateDeletedDateTimePicker";
            this.dateDeletedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDeletedDateTimePicker.TabIndex = 13;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataman_databaseBindingSource, "status", true));
            this.statusTextBox.Location = new System.Drawing.Point(770, 203);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.statusTextBox.TabIndex = 15;
            // 
            // advisor_nameTextBox
            // 
            this.advisor_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataman_databaseBindingSource, "advisor_name", true));
            this.advisor_nameTextBox.Location = new System.Drawing.Point(770, 229);
            this.advisor_nameTextBox.Name = "advisor_nameTextBox";
            this.advisor_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.advisor_nameTextBox.TabIndex = 17;
            // 
            // advisor_emailTextBox
            // 
            this.advisor_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataman_databaseBindingSource, "advisor_email", true));
            this.advisor_emailTextBox.Location = new System.Drawing.Point(770, 255);
            this.advisor_emailTextBox.Name = "advisor_emailTextBox";
            this.advisor_emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.advisor_emailTextBox.TabIndex = 19;
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataman_databaseBindingSource, "groupName", true));
            this.groupNameTextBox.Location = new System.Drawing.Point(770, 285);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.groupNameTextBox.TabIndex = 21;
            // 
            // expiredWarningTextBox
            // 
            this.expiredWarningTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataman_databaseBindingSource, "expiredWarning", true));
            this.expiredWarningTextBox.Location = new System.Drawing.Point(770, 311);
            this.expiredWarningTextBox.Name = "expiredWarningTextBox";
            this.expiredWarningTextBox.Size = new System.Drawing.Size(200, 20);
            this.expiredWarningTextBox.TabIndex = 23;
            // 
            // projectFormButton
            // 
            this.projectFormButton.Location = new System.Drawing.Point(24, 309);
            this.projectFormButton.Name = "projectFormButton";
            this.projectFormButton.Size = new System.Drawing.Size(125, 23);
            this.projectFormButton.TabIndex = 24;
            this.projectFormButton.Text = "Project Account";
            this.projectFormButton.UseVisualStyleBackColor = true;
            this.projectFormButton.Click += new System.EventHandler(this.projectFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 639);
            this.Controls.Add(this.projectFormButton);
            this.Controls.Add(projNameLabel);
            this.Controls.Add(this.projNameTextBox);
            this.Controls.Add(serverLabel);
            this.Controls.Add(this.serverTextBox);
            this.Controls.Add(semesterCreatedLabel);
            this.Controls.Add(this.semesterCreatedTextBox);
            this.Controls.Add(dateExpiresLabel);
            this.Controls.Add(this.dateExpiresDateTimePicker);
            this.Controls.Add(dateCreatedLabel);
            this.Controls.Add(this.dateCreatedDateTimePicker);
            this.Controls.Add(dateDeletedLabel);
            this.Controls.Add(this.dateDeletedDateTimePicker);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(advisor_nameLabel);
            this.Controls.Add(this.advisor_nameTextBox);
            this.Controls.Add(advisor_emailLabel);
            this.Controls.Add(this.advisor_emailTextBox);
            this.Controls.Add(groupNameLabel);
            this.Controls.Add(this.groupNameTextBox);
            this.Controls.Add(expiredWarningLabel);
            this.Controls.Add(this.expiredWarningTextBox);
            this.Controls.Add(this.dataman_databaseDataGridView);
            this.Controls.Add(this.dataman_databaseBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datamanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataman_databaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataman_databaseBindingNavigator)).EndInit();
            this.dataman_databaseBindingNavigator.ResumeLayout(false);
            this.dataman_databaseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataman_databaseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private datamanDataSet datamanDataSet;
        private System.Windows.Forms.BindingSource dataman_databaseBindingSource;
        private datamanDataSetTableAdapters.dataman_databaseTableAdapter dataman_databaseTableAdapter;
        private datamanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dataman_databaseBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dataman_databaseBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dataman_databaseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox projNameTextBox;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.TextBox semesterCreatedTextBox;
        private System.Windows.Forms.DateTimePicker dateExpiresDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateCreatedDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateDeletedDateTimePicker;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox advisor_nameTextBox;
        private System.Windows.Forms.TextBox advisor_emailTextBox;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.TextBox expiredWarningTextBox;
        private System.Windows.Forms.Button projectFormButton;
    }
}

