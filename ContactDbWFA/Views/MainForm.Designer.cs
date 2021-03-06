﻿namespace ContactDbWFA
{
    partial class MainForm
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
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactdbDataSet = new ContactDbWFA.contactdbDataSet();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstSearchResults = new System.Windows.Forms.ListView();
            this.colContacts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.gridAddresses = new System.Windows.Forms.DataGridView();
            this.gridPhones = new System.Windows.Forms.DataGridView();
            this.gridDates = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dateTableAdapter = new ContactDbWFA.contactdbDataSetTableAdapters.DateTableAdapter();
            this.colContactId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddressId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddressType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colStreetApt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colAreaCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDates)).BeginInit();
            this.SuspendLayout();
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataMember = "Contact";
            this.contactBindingSource.DataSource = this.contactdbDataSetBindingSource;
            // 
            // contactdbDataSetBindingSource
            // 
            this.contactdbDataSetBindingSource.DataSource = this.contactdbDataSet;
            this.contactdbDataSetBindingSource.Position = 0;
            // 
            // contactdbDataSet
            // 
            this.contactdbDataSet.DataSetName = "contactdbDataSet";
            this.contactdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "Address";
            this.addressBindingSource.DataSource = this.contactdbDataSetBindingSource;
            // 
            // phoneBindingSource
            // 
            this.phoneBindingSource.DataMember = "Phone";
            this.phoneBindingSource.DataSource = this.contactdbDataSetBindingSource;
            // 
            // dateBindingSource
            // 
            this.dateBindingSource.DataMember = "Date";
            this.dateBindingSource.DataSource = this.contactdbDataSetBindingSource;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(28, 27);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(786, 20);
            this.tbSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(837, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstSearchResults
            // 
            this.lstSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colContactId,
            this.colContacts});
            this.lstSearchResults.HideSelection = false;
            this.lstSearchResults.Location = new System.Drawing.Point(28, 83);
            this.lstSearchResults.MultiSelect = false;
            this.lstSearchResults.Name = "lstSearchResults";
            this.lstSearchResults.Size = new System.Drawing.Size(200, 330);
            this.lstSearchResults.TabIndex = 2;
            this.lstSearchResults.UseCompatibleStateImageBehavior = false;
            this.lstSearchResults.View = System.Windows.Forms.View.List;
            this.lstSearchResults.SelectedIndexChanged += new System.EventHandler(this.lstSearchResults_SelectedIndexChanged);
            // 
            // colContacts
            // 
            this.colContacts.DisplayIndex = 0;
            this.colContacts.Width = 200;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(330, 86);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(152, 20);
            this.tbFirstName.TabIndex = 3;
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(571, 86);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(100, 20);
            this.tbMiddleName.TabIndex = 4;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(752, 86);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(160, 20);
            this.tbLastName.TabIndex = 5;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(267, 89);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(496, 89);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lblMiddleName.TabIndex = 6;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(688, 89);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // gridAddresses
            // 
            this.gridAddresses.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAddresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAddressId,
            this.colAddressType,
            this.colStreetApt,
            this.colCityName,
            this.colStateName,
            this.colZipCode});
            this.gridAddresses.Location = new System.Drawing.Point(270, 136);
            this.gridAddresses.Name = "gridAddresses";
            this.gridAddresses.Size = new System.Drawing.Size(595, 120);
            this.gridAddresses.TabIndex = 7;
            // 
            // gridPhones
            // 
            this.gridPhones.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPhones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPhoneId,
            this.colPhoneType,
            this.colAreaCode,
            this.colPhoneNumber});
            this.gridPhones.Location = new System.Drawing.Point(558, 274);
            this.gridPhones.Name = "gridPhones";
            this.gridPhones.Size = new System.Drawing.Size(294, 119);
            this.gridPhones.TabIndex = 7;
            // 
            // gridDates
            // 
            this.gridDates.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDateId,
            this.colDateType,
            this.colDate});
            this.gridDates.Location = new System.Drawing.Point(270, 274);
            this.gridDates.Name = "gridDates";
            this.gridDates.Size = new System.Drawing.Size(266, 119);
            this.gridDates.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(671, 423);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(790, 423);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(548, 423);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dateTableAdapter
            // 
            this.dateTableAdapter.ClearBeforeFill = true;
            // 
            // colContactId
            // 
            this.colContactId.Width = 0;
            // 
            // colDateId
            // 
            this.colDateId.FillWeight = 10F;
            this.colDateId.Frozen = true;
            this.colDateId.HeaderText = "Date Id";
            this.colDateId.Name = "colDateId";
            this.colDateId.ReadOnly = true;
            this.colDateId.Visible = false;
            this.colDateId.Width = 10;
            // 
            // colDateType
            // 
            this.colDateType.HeaderText = "Date Type";
            this.colDateType.Items.AddRange(new object[] {
            "1",
            "2"});
            this.colDateType.Name = "colDateType";
            this.colDateType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDateType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colDate
            // 
            this.colDate.FillWeight = 120F;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Width = 120;
            // 
            // colAddressId
            // 
            this.colAddressId.FillWeight = 10F;
            this.colAddressId.Frozen = true;
            this.colAddressId.HeaderText = "Address Id";
            this.colAddressId.Name = "colAddressId";
            this.colAddressId.ReadOnly = true;
            this.colAddressId.Visible = false;
            this.colAddressId.Width = 10;
            // 
            // colAddressType
            // 
            this.colAddressType.Frozen = true;
            this.colAddressType.HeaderText = "Address Type";
            this.colAddressType.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.colAddressType.Name = "colAddressType";
            this.colAddressType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colStreetApt
            // 
            this.colStreetApt.FillWeight = 200F;
            this.colStreetApt.Frozen = true;
            this.colStreetApt.HeaderText = "Street Apt";
            this.colStreetApt.Name = "colStreetApt";
            this.colStreetApt.Width = 200;
            // 
            // colCityName
            // 
            this.colCityName.FillWeight = 80F;
            this.colCityName.HeaderText = "City";
            this.colCityName.Name = "colCityName";
            this.colCityName.Width = 80;
            // 
            // colStateName
            // 
            this.colStateName.FillWeight = 70F;
            this.colStateName.HeaderText = "State";
            this.colStateName.Name = "colStateName";
            this.colStateName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStateName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colStateName.Width = 70;
            // 
            // colZipCode
            // 
            this.colZipCode.HeaderText = "Zip Code";
            this.colZipCode.Name = "colZipCode";
            this.colZipCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colZipCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPhoneId
            // 
            this.colPhoneId.FillWeight = 10F;
            this.colPhoneId.Frozen = true;
            this.colPhoneId.HeaderText = "Phone Id";
            this.colPhoneId.Name = "colPhoneId";
            this.colPhoneId.ReadOnly = true;
            this.colPhoneId.Visible = false;
            this.colPhoneId.Width = 10;
            // 
            // colPhoneType
            // 
            this.colPhoneType.Frozen = true;
            this.colPhoneType.HeaderText = "Phone Type";
            this.colPhoneType.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.colPhoneType.MaxDropDownItems = 3;
            this.colPhoneType.Name = "colPhoneType";
            this.colPhoneType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colAreaCode
            // 
            this.colAreaCode.FillWeight = 80F;
            this.colAreaCode.Frozen = true;
            this.colAreaCode.HeaderText = "Area Code";
            this.colAreaCode.Name = "colAreaCode";
            this.colAreaCode.Visible = false;
            this.colAreaCode.Width = 80;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.FillWeight = 150F;
            this.colPhoneNumber.Frozen = true;
            this.colPhoneNumber.HeaderText = "Phone Number";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 482);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gridDates);
            this.Controls.Add(this.gridPhones);
            this.Controls.Add(this.gridAddresses);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lstSearchResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource contactdbDataSetBindingSource;
        private contactdbDataSet contactdbDataSet;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.BindingSource phoneBindingSource;
        private System.Windows.Forms.BindingSource dateBindingSource;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lstSearchResults;
        private System.Windows.Forms.ColumnHeader colContacts;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DataGridView gridAddresses;
        private System.Windows.Forms.DataGridView gridPhones;
        private System.Windows.Forms.DataGridView gridDates;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private contactdbDataSetTableAdapters.DateTableAdapter dateTableAdapter;
        private System.Windows.Forms.ColumnHeader colContactId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddressId;
        private System.Windows.Forms.DataGridViewComboBoxColumn colAddressType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStreetApt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateId;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDateType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneId;
        private System.Windows.Forms.DataGridViewComboBoxColumn colPhoneType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAreaCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
    }
}

