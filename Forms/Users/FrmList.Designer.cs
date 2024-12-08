﻿namespace POSSystem.Forms.Users
{
    partial class FrmList
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
            components = new System.ComponentModel.Container();
            dsUsers = new DS.DsUsers();
            tblUsersTableAdapter = new DS.DsUsersTableAdapters.TblUsersTableAdapter();
            bdUser = new BindingSource(components);
            dGVUser = new DataGridView();
            btnClose = new Button();
            btnRefresh = new Button();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            activeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dsUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bdUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGVUser).BeginInit();
            SuspendLayout();
            // 
            // dsUsers
            // 
            dsUsers.DataSetName = "DsUsers";
            dsUsers.Namespace = "http://tempuri.org/DsUsers.xsd";
            dsUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersTableAdapter
            // 
            tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // bdUser
            // 
            bdUser.DataMember = "TblUsers";
            bdUser.DataSource = dsUsers;
            // 
            // dGVUser
            // 
            dGVUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dGVUser.AutoGenerateColumns = false;
            dGVUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVUser.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, activeDataGridViewTextBoxColumn, userIDDataGridViewTextBoxColumn, createdAtDataGridViewTextBoxColumn, updatedAtDataGridViewTextBoxColumn, Edit, Delete });
            dGVUser.DataSource = bdUser;
            dGVUser.EditMode = DataGridViewEditMode.EditProgrammatically;
            dGVUser.Location = new Point(12, 73);
            dGVUser.MultiSelect = false;
            dGVUser.Name = "dGVUser";
            dGVUser.RightToLeft = RightToLeft.No;
            dGVUser.RowHeadersWidth = 62;
            dGVUser.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dGVUser.Size = new Size(1395, 529);
            dGVUser.TabIndex = 0;
            dGVUser.VirtualMode = true;
            dGVUser.CellClick += dGVUser_CellClick;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Image = Properties.Resources._90686782;
            btnClose.Location = new Point(1330, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(66, 66);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Image = Properties.Resources.refresh;
            btnRefresh.Location = new Point(1258, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(66, 66);
            btnRefresh.TabIndex = 1;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.MinimumWidth = 8;
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.Width = 150;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // activeDataGridViewTextBoxColumn
            // 
            activeDataGridViewTextBoxColumn.DataPropertyName = "Active";
            activeDataGridViewTextBoxColumn.HeaderText = "Active";
            activeDataGridViewTextBoxColumn.MinimumWidth = 8;
            activeDataGridViewTextBoxColumn.Name = "activeDataGridViewTextBoxColumn";
            activeDataGridViewTextBoxColumn.Width = 150;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            userIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            userIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            createdAtDataGridViewTextBoxColumn.MinimumWidth = 8;
            createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            createdAtDataGridViewTextBoxColumn.Width = 150;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            updatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt";
            updatedAtDataGridViewTextBoxColumn.HeaderText = "UpdatedAt";
            updatedAtDataGridViewTextBoxColumn.MinimumWidth = 8;
            updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            updatedAtDataGridViewTextBoxColumn.Width = 150;
            // 
            // Edit
            // 
            Edit.Description = "Edit";
            Edit.HeaderText = "Edit";
            Edit.Image = Properties.Resources.edit;
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.Width = 70;
            // 
            // Delete
            // 
            Delete.Description = "Delete";
            Delete.FillWeight = 50F;
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.delete1;
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.Width = 70;
            // 
            // FrmList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 614);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(dGVUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmList";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += FrmList_Load;
            ((System.ComponentModel.ISupportInitialize)dsUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)bdUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGVUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DS.DsUsers dsUsers;
        private DS.DsUsersTableAdapters.TblUsersTableAdapter tblUsersTableAdapter;
        private BindingSource bdUser;
        private DataGridView dGVUser;
        private Button btnClose;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn activeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}