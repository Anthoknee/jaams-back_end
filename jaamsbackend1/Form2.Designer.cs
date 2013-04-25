namespace jaamsbackend1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label projNameLabel;
            System.Windows.Forms.Label quotaLabel;
            System.Windows.Forms.Label semesterCreatedLabel;
            System.Windows.Forms.Label groupNameLabel;
            System.Windows.Forms.Label dateExpiresLabel;
            System.Windows.Forms.Label dateCreatedLabel;
            System.Windows.Forms.Label dateDeletedLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label advisor_nameLabel;
            System.Windows.Forms.Label advisor_emailLabel;
            System.Windows.Forms.Label shellLabel;
            this.projectDataSet = new jaamsbackend1.projectDataSet();
            this.project_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_infoTableAdapter = new jaamsbackend1.projectDataSetTableAdapters.project_infoTableAdapter();
            this.tableAdapterManager = new jaamsbackend1.projectDataSetTableAdapters.TableAdapterManager();
            this.project_infoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.project_infoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.project_infoDataGridView = new System.Windows.Forms.DataGridView();
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
            this.quotaTextBox = new System.Windows.Forms.TextBox();
            this.semesterCreatedTextBox = new System.Windows.Forms.TextBox();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.dateExpiresDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateCreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateDeletedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.advisor_nameTextBox = new System.Windows.Forms.TextBox();
            this.advisor_emailTextBox = new System.Windows.Forms.TextBox();
            this.shellTextBox = new System.Windows.Forms.TextBox();
            this.dataBaseAccountButton = new System.Windows.Forms.Button();
            projNameLabel = new System.Windows.Forms.Label();
            quotaLabel = new System.Windows.Forms.Label();
            semesterCreatedLabel = new System.Windows.Forms.Label();
            groupNameLabel = new System.Windows.Forms.Label();
            dateExpiresLabel = new System.Windows.Forms.Label();
            dateCreatedLabel = new System.Windows.Forms.Label();
            dateDeletedLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            advisor_nameLabel = new System.Windows.Forms.Label();
            advisor_emailLabel = new System.Windows.Forms.Label();
            shellLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_infoBindingNavigator)).BeginInit();
            this.project_infoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.project_infoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "projectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // project_infoBindingSource
            // 
            this.project_infoBindingSource.DataMember = "project_info";
            this.project_infoBindingSource.DataSource = this.projectDataSet;
            // 
            // project_infoTableAdapter
            // 
            this.project_infoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dataman_passTableAdapter = null;
            this.tableAdapterManager.project_groupTableAdapter = null;
            this.tableAdapterManager.project_historyTableAdapter = null;
            this.tableAdapterManager.project_infoTableAdapter = this.project_infoTableAdapter;
            this.tableAdapterManager.project_peopleTableAdapter = null;
            this.tableAdapterManager.tempTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = jaamsbackend1.projectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // project_infoBindingNavigator
            // 
            this.project_infoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.project_infoBindingNavigator.BindingSource = this.project_infoBindingSource;
            this.project_infoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.project_infoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.project_infoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.project_infoBindingNavigatorSaveItem});
            this.project_infoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.project_infoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.project_infoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.project_infoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.project_infoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.project_infoBindingNavigator.Name = "project_infoBindingNavigator";
            this.project_infoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.project_infoBindingNavigator.Size = new System.Drawing.Size(1186, 25);
            this.project_infoBindingNavigator.TabIndex = 0;
            this.project_infoBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // project_infoBindingNavigatorSaveItem
            // 
            this.project_infoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.project_infoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("project_infoBindingNavigatorSaveItem.Image")));
            this.project_infoBindingNavigatorSaveItem.Name = "project_infoBindingNavigatorSaveItem";
            this.project_infoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.project_infoBindingNavigatorSaveItem.Text = "Save Data";
            this.project_infoBindingNavigatorSaveItem.Click += new System.EventHandler(this.project_infoBindingNavigatorSaveItem_Click);
            // 
            // project_infoDataGridView
            // 
            this.project_infoDataGridView.AutoGenerateColumns = false;
            this.project_infoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.project_infoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.project_infoDataGridView.DataSource = this.project_infoBindingSource;
            this.project_infoDataGridView.Location = new System.Drawing.Point(25, 45);
            this.project_infoDataGridView.Name = "project_infoDataGridView";
            this.project_infoDataGridView.Size = new System.Drawing.Size(1141, 140);
            this.project_infoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "projName";
            this.dataGridViewTextBoxColumn1.HeaderText = "projName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "quota";
            this.dataGridViewTextBoxColumn2.HeaderText = "quota";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "groupName";
            this.dataGridViewTextBoxColumn4.HeaderText = "groupName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dateExpires";
            this.dataGridViewTextBoxColumn5.HeaderText = "dateExpires";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dateCreated";
            this.dataGridViewTextBoxColumn6.HeaderText = "dateCreated";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "dateDeleted";
            this.dataGridViewTextBoxColumn7.HeaderText = "dateDeleted";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn8.HeaderText = "status";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "advisor_name";
            this.dataGridViewTextBoxColumn9.HeaderText = "advisor_name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "advisor_email";
            this.dataGridViewTextBoxColumn10.HeaderText = "advisor_email";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "shell";
            this.dataGridViewTextBoxColumn11.HeaderText = "shell";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // projNameLabel
            // 
            projNameLabel.AutoSize = true;
            projNameLabel.Location = new System.Drawing.Point(29, 207);
            projNameLabel.Name = "projNameLabel";
            projNameLabel.Size = new System.Drawing.Size(58, 13);
            projNameLabel.TabIndex = 2;
            projNameLabel.Text = "proj Name:";
            // 
            // projNameTextBox
            // 
            this.projNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.project_infoBindingSource, "projName", true));
            this.projNameTextBox.Location = new System.Drawing.Point(127, 204);
            this.projNameTextBox.Name = "projNameTextBox";
            this.projNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.projNameTextBox.TabIndex = 3;
            // 
            // quotaLabel
            // 
            quotaLabel.AutoSize = true;
            quotaLabel.Location = new System.Drawing.Point(29, 233);
            quotaLabel.Name = "quotaLabel";
            quotaLabel.Size = new System.Drawing.Size(37, 13);
            quotaLabel.TabIndex = 4;
            quotaLabel.Text = "quota:";
            // 
            // quotaTextBox
            // 
            this.quotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.project_infoBindingSource, "quota", true));
            this.quotaTextBox.Location = new System.Drawing.Point(127, 230);
            this.quotaTextBox.Name = "quotaTextBox";
            this.quotaTextBox.Size = new System.Drawing.Size(200, 20);
            this.quotaTextBox.TabIndex = 5;
            // 
            // semesterCreatedLabel
            // 
            semesterCreatedLabel.AutoSize = true;
            semesterCreatedLabel.Location = new System.Drawing.Point(29, 259);
            semesterCreatedLabel.Name = "semesterCreatedLabel";
            semesterCreatedLabel.Size = new System.Drawing.Size(92, 13);
            semesterCreatedLabel.TabIndex = 6;
            semesterCreatedLabel.Text = "semester Created:";
            // 
            // semesterCreatedTextBox
            // 
            this.semesterCreatedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.project_infoBindingSource, "semesterCreated", true));
            this.semesterCreatedTextBox.Location = new System.Drawing.Point(127, 256);
            this.semesterCreatedTextBox.Name = "semesterCreatedTextBox";
            this.semesterCreatedTextBox.Size = new System.Drawing.Size(200, 20);
            this.semesterCreatedTextBox.TabIndex = 7;
            // 
            // groupNameLabel
            // 
            groupNameLabel.AutoSize = true;
            groupNameLabel.Location = new System.Drawing.Point(29, 285);
            groupNameLabel.Name = "groupNameLabel";
            groupNameLabel.Size = new System.Drawing.Size(68, 13);
            groupNameLabel.TabIndex = 8;
            groupNameLabel.Text = "group Name:";
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.project_infoBindingSource, "groupName", true));
            this.groupNameTextBox.Location = new System.Drawing.Point(127, 282);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.groupNameTextBox.TabIndex = 9;
            // 
            // dateExpiresLabel
            // 
            dateExpiresLabel.AutoSize = true;
            dateExpiresLabel.Location = new System.Drawing.Point(340, 208);
            dateExpiresLabel.Name = "dateExpiresLabel";
            dateExpiresLabel.Size = new System.Drawing.Size(68, 13);
            dateExpiresLabel.TabIndex = 10;
            dateExpiresLabel.Text = "date Expires:";
            // 
            // dateExpiresDateTimePicker
            // 
            this.dateExpiresDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.project_infoBindingSource, "dateExpires", true));
            this.dateExpiresDateTimePicker.Location = new System.Drawing.Point(438, 204);
            this.dateExpiresDateTimePicker.Name = "dateExpiresDateTimePicker";
            this.dateExpiresDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateExpiresDateTimePicker.TabIndex = 11;
            // 
            // dateCreatedLabel
            // 
            dateCreatedLabel.AutoSize = true;
            dateCreatedLabel.Location = new System.Drawing.Point(340, 234);
            dateCreatedLabel.Name = "dateCreatedLabel";
            dateCreatedLabel.Size = new System.Drawing.Size(71, 13);
            dateCreatedLabel.TabIndex = 12;
            dateCreatedLabel.Text = "date Created:";
            // 
            // dateCreatedDateTimePicker
            // 
            this.dateCreatedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.project_infoBindingSource, "dateCreated", true));
            this.dateCreatedDateTimePicker.Location = new System.Drawing.Point(438, 230);
            this.dateCreatedDateTimePicker.Name = "dateCreatedDateTimePicker";
            this.dateCreatedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateCreatedDateTimePicker.TabIndex = 13;
            // 
            // dateDeletedLabel
            // 
            dateDeletedLabel.AutoSize = true;
            dateDeletedLabel.Location = new System.Drawing.Point(340, 260);
            dateDeletedLabel.Name = "dateDeletedLabel";
            dateDeletedLabel.Size = new System.Drawing.Size(71, 13);
            dateDeletedLabel.TabIndex = 14;
            dateDeletedLabel.Text = "date Deleted:";
            // 
            // dateDeletedDateTimePicker
            // 
            this.dateDeletedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.project_infoBindingSource, "dateDeleted", true));
            this.dateDeletedDateTimePicker.Location = new System.Drawing.Point(438, 256);
            this.dateDeletedDateTimePicker.Name = "dateDeletedDateTimePicker";
            this.dateDeletedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDeletedDateTimePicker.TabIndex = 15;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(340, 285);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(38, 13);
            statusLabel.TabIndex = 16;
            statusLabel.Text = "status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.project_infoBindingSource, "status", true));
            this.statusTextBox.Location = new System.Drawing.Point(438, 282);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.statusTextBox.TabIndex = 17;
            // 
            // advisor_nameLabel
            // 
            advisor_nameLabel.AutoSize = true;
            advisor_nameLabel.Location = new System.Drawing.Point(659, 208);
            advisor_nameLabel.Name = "advisor_nameLabel";
            advisor_nameLabel.Size = new System.Drawing.Size(73, 13);
            advisor_nameLabel.TabIndex = 18;
            advisor_nameLabel.Text = "advisor name:";
            // 
            // advisor_nameTextBox
            // 
            this.advisor_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.project_infoBindingSource, "advisor_name", true));
            this.advisor_nameTextBox.Location = new System.Drawing.Point(757, 205);
            this.advisor_nameTextBox.Name = "advisor_nameTextBox";
            this.advisor_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.advisor_nameTextBox.TabIndex = 19;
            // 
            // advisor_emailLabel
            // 
            advisor_emailLabel.AutoSize = true;
            advisor_emailLabel.Location = new System.Drawing.Point(659, 234);
            advisor_emailLabel.Name = "advisor_emailLabel";
            advisor_emailLabel.Size = new System.Drawing.Size(71, 13);
            advisor_emailLabel.TabIndex = 20;
            advisor_emailLabel.Text = "advisor email:";
            // 
            // advisor_emailTextBox
            // 
            this.advisor_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.project_infoBindingSource, "advisor_email", true));
            this.advisor_emailTextBox.Location = new System.Drawing.Point(757, 231);
            this.advisor_emailTextBox.Name = "advisor_emailTextBox";
            this.advisor_emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.advisor_emailTextBox.TabIndex = 21;
            // 
            // shellLabel
            // 
            shellLabel.AutoSize = true;
            shellLabel.Location = new System.Drawing.Point(659, 260);
            shellLabel.Name = "shellLabel";
            shellLabel.Size = new System.Drawing.Size(31, 13);
            shellLabel.TabIndex = 22;
            shellLabel.Text = "shell:";
            // 
            // shellTextBox
            // 
            this.shellTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.project_infoBindingSource, "shell", true));
            this.shellTextBox.Location = new System.Drawing.Point(757, 257);
            this.shellTextBox.Name = "shellTextBox";
            this.shellTextBox.Size = new System.Drawing.Size(200, 20);
            this.shellTextBox.TabIndex = 23;
            // 
            // dataBaseAccountButton
            // 
            this.dataBaseAccountButton.Location = new System.Drawing.Point(32, 377);
            this.dataBaseAccountButton.Name = "dataBaseAccountButton";
            this.dataBaseAccountButton.Size = new System.Drawing.Size(125, 23);
            this.dataBaseAccountButton.TabIndex = 24;
            this.dataBaseAccountButton.Text = "Database Account";
            this.dataBaseAccountButton.UseVisualStyleBackColor = true;
            this.dataBaseAccountButton.Click += new System.EventHandler(this.dataBaseAccountButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 568);
            this.Controls.Add(this.dataBaseAccountButton);
            this.Controls.Add(projNameLabel);
            this.Controls.Add(this.projNameTextBox);
            this.Controls.Add(quotaLabel);
            this.Controls.Add(this.quotaTextBox);
            this.Controls.Add(semesterCreatedLabel);
            this.Controls.Add(this.semesterCreatedTextBox);
            this.Controls.Add(groupNameLabel);
            this.Controls.Add(this.groupNameTextBox);
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
            this.Controls.Add(shellLabel);
            this.Controls.Add(this.shellTextBox);
            this.Controls.Add(this.project_infoDataGridView);
            this.Controls.Add(this.project_infoBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_infoBindingNavigator)).EndInit();
            this.project_infoBindingNavigator.ResumeLayout(false);
            this.project_infoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.project_infoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private projectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource project_infoBindingSource;
        private projectDataSetTableAdapters.project_infoTableAdapter project_infoTableAdapter;
        private projectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator project_infoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton project_infoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView project_infoDataGridView;
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
        private System.Windows.Forms.TextBox quotaTextBox;
        private System.Windows.Forms.TextBox semesterCreatedTextBox;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.DateTimePicker dateExpiresDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateCreatedDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateDeletedDateTimePicker;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox advisor_nameTextBox;
        private System.Windows.Forms.TextBox advisor_emailTextBox;
        private System.Windows.Forms.TextBox shellTextBox;
        private System.Windows.Forms.Button dataBaseAccountButton;
    }
}