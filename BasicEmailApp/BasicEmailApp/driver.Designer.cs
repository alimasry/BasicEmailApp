﻿namespace BasicEmailApp
{
    partial class Driver
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
            this.tab_control = new System.Windows.Forms.TabControl();
            this.inbox_tab = new System.Windows.Forms.TabPage();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.LinkLabel();
            this.add_to_folder_button = new System.Windows.Forms.LinkLabel();
            this.label16 = new System.Windows.Forms.Label();
            this.forward_button = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.reply_button = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.archive_button = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.view_button = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.LinkLabel();
            this.inboxDataView = new System.Windows.Forms.DataGridView();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailing_list_tab = new System.Windows.Forms.TabPage();
            this.searchBar2 = new System.Windows.Forms.TextBox();
            this.search2 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mailinglistDataView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.folders_tab = new System.Windows.Forms.TabPage();
            this.searchBar3 = new System.Windows.Forms.TextBox();
            this.search3 = new System.Windows.Forms.LinkLabel();
            this.label15 = new System.Windows.Forms.Label();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.delete_selected_folder_button = new System.Windows.Forms.LinkLabel();
            this.add_folder_button = new System.Windows.Forms.LinkLabel();
            this.folderDataView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archive_tab = new System.Windows.Forms.TabPage();
            this.searchBar4 = new System.Windows.Forms.TextBox();
            this.search4 = new System.Windows.Forms.LinkLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.archiveDataView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.view_archived = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.delete_archived = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.Sent_tab = new System.Windows.Forms.TabPage();
            this.searchBar5 = new System.Windows.Forms.TextBox();
            this.search5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.label18 = new System.Windows.Forms.Label();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.sentDataView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refresh_button = new System.Windows.Forms.LinkLabel();
            this.sep3 = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.LinkLabel();
            this.edit_button = new System.Windows.Forms.LinkLabel();
            this.sep4 = new System.Windows.Forms.Label();
            this.loggedInAs = new System.Windows.Forms.Label();
            this.sep1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.generateR = new System.Windows.Forms.LinkLabel();
            this.tab_control.SuspendLayout();
            this.inbox_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inboxDataView)).BeginInit();
            this.mailing_list_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailinglistDataView)).BeginInit();
            this.folders_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderDataView)).BeginInit();
            this.archive_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataView)).BeginInit();
            this.Sent_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sentDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_control
            // 
            this.tab_control.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tab_control.Controls.Add(this.inbox_tab);
            this.tab_control.Controls.Add(this.mailing_list_tab);
            this.tab_control.Controls.Add(this.folders_tab);
            this.tab_control.Controls.Add(this.archive_tab);
            this.tab_control.Controls.Add(this.Sent_tab);
            this.tab_control.HotTrack = true;
            this.tab_control.Location = new System.Drawing.Point(2, 49);
            this.tab_control.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_control.Multiline = true;
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(1382, 878);
            this.tab_control.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_control.TabIndex = 0;
            // 
            // inbox_tab
            // 
            this.inbox_tab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inbox_tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.inbox_tab.Controls.Add(this.searchBar);
            this.inbox_tab.Controls.Add(this.search);
            this.inbox_tab.Controls.Add(this.add_to_folder_button);
            this.inbox_tab.Controls.Add(this.label16);
            this.inbox_tab.Controls.Add(this.forward_button);
            this.inbox_tab.Controls.Add(this.label7);
            this.inbox_tab.Controls.Add(this.reply_button);
            this.inbox_tab.Controls.Add(this.label6);
            this.inbox_tab.Controls.Add(this.archive_button);
            this.inbox_tab.Controls.Add(this.label5);
            this.inbox_tab.Controls.Add(this.view_button);
            this.inbox_tab.Controls.Add(this.label4);
            this.inbox_tab.Controls.Add(this.delete_button);
            this.inbox_tab.Controls.Add(this.inboxDataView);
            this.inbox_tab.Location = new System.Drawing.Point(4, 4);
            this.inbox_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inbox_tab.Name = "inbox_tab";
            this.inbox_tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inbox_tab.Size = new System.Drawing.Size(1374, 845);
            this.inbox_tab.TabIndex = 0;
            this.inbox_tab.Text = "Inbox";
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(1095, 0);
            this.searchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(259, 26);
            this.searchBar.TabIndex = 27;
            // 
            // search
            // 
            this.search.ActiveLinkColor = System.Drawing.Color.Red;
            this.search.AutoSize = true;
            this.search.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.search.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.search.Location = new System.Drawing.Point(1028, 3);
            this.search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(57, 20);
            this.search.TabIndex = 26;
            this.search.TabStop = true;
            this.search.Text = "search";
            this.search.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.search.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.search_LinkClicked);
            // 
            // add_to_folder_button
            // 
            this.add_to_folder_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.add_to_folder_button.AutoSize = true;
            this.add_to_folder_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.add_to_folder_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add_to_folder_button.Location = new System.Drawing.Point(758, 3);
            this.add_to_folder_button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_to_folder_button.Name = "add_to_folder_button";
            this.add_to_folder_button.Size = new System.Drawing.Size(98, 20);
            this.add_to_folder_button.TabIndex = 24;
            this.add_to_folder_button.TabStop = true;
            this.add_to_folder_button.Text = "add to folder";
            this.add_to_folder_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add_to_folder_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel9_LinkClicked);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(736, 3);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = "|";
            // 
            // forward_button
            // 
            this.forward_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.forward_button.AutoSize = true;
            this.forward_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.forward_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.forward_button.Location = new System.Drawing.Point(602, 3);
            this.forward_button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forward_button.Name = "forward_button";
            this.forward_button.Size = new System.Drawing.Size(126, 20);
            this.forward_button.TabIndex = 22;
            this.forward_button.TabStop = true;
            this.forward_button.Text = "forward selected";
            this.forward_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.forward_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forward_button_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(579, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "|";
            // 
            // reply_button
            // 
            this.reply_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.reply_button.AutoSize = true;
            this.reply_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.reply_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reply_button.Location = new System.Drawing.Point(446, 3);
            this.reply_button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reply_button.Name = "reply_button";
            this.reply_button.Size = new System.Drawing.Size(124, 20);
            this.reply_button.TabIndex = 20;
            this.reply_button.TabStop = true;
            this.reply_button.Text = "reply to selected";
            this.reply_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reply_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reply_button_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "|";
            // 
            // archive_button
            // 
            this.archive_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.archive_button.AutoSize = true;
            this.archive_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.archive_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.archive_button.Location = new System.Drawing.Point(291, 3);
            this.archive_button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.archive_button.Name = "archive_button";
            this.archive_button.Size = new System.Drawing.Size(123, 20);
            this.archive_button.TabIndex = 18;
            this.archive_button.TabStop = true;
            this.archive_button.Text = "archive selected";
            this.archive_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.archive_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.archive_button_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "|";
            // 
            // view_button
            // 
            this.view_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.view_button.AutoSize = true;
            this.view_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.view_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.view_button.Location = new System.Drawing.Point(154, 3);
            this.view_button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(103, 20);
            this.view_button.TabIndex = 16;
            this.view_button.TabStop = true;
            this.view_button.Text = "view selected";
            this.view_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.view_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.view_button_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "|";
            // 
            // delete_button
            // 
            this.delete_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.delete_button.AutoSize = true;
            this.delete_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.delete_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_button.Location = new System.Drawing.Point(4, 3);
            this.delete_button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(117, 20);
            this.delete_button.TabIndex = 12;
            this.delete_button.TabStop = true;
            this.delete_button.Text = "delete selected";
            this.delete_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // inboxDataView
            // 
            this.inboxDataView.AllowUserToAddRows = false;
            this.inboxDataView.AllowUserToResizeColumns = false;
            this.inboxDataView.AllowUserToResizeRows = false;
            this.inboxDataView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.inboxDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.inboxDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sender,
            this.Subject,
            this.DATE});
            this.inboxDataView.Location = new System.Drawing.Point(0, 28);
            this.inboxDataView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inboxDataView.Name = "inboxDataView";
            this.inboxDataView.ReadOnly = true;
            this.inboxDataView.RowHeadersWidth = 20;
            this.inboxDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.inboxDataView.Size = new System.Drawing.Size(1370, 811);
            this.inboxDataView.TabIndex = 0;
            this.inboxDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inbox_data_view_CellClick);
            // 
            // Sender
            // 
            this.Sender.DataPropertyName = "Sent by";
            this.Sender.HeaderText = "Sent by";
            this.Sender.Name = "Sender";
            this.Sender.ReadOnly = true;
            this.Sender.Width = 120;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 650;
            // 
            // DATE
            // 
            this.DATE.DataPropertyName = "DATE";
            this.DATE.HeaderText = "Date";
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            this.DATE.Width = 104;
            // 
            // mailing_list_tab
            // 
            this.mailing_list_tab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mailing_list_tab.Controls.Add(this.searchBar2);
            this.mailing_list_tab.Controls.Add(this.search2);
            this.mailing_list_tab.Controls.Add(this.label12);
            this.mailing_list_tab.Controls.Add(this.label1);
            this.mailing_list_tab.Controls.Add(this.mailinglistDataView);
            this.mailing_list_tab.Controls.Add(this.linkLabel6);
            this.mailing_list_tab.Controls.Add(this.linkLabel5);
            this.mailing_list_tab.Controls.Add(this.linkLabel4);
            this.mailing_list_tab.Location = new System.Drawing.Point(4, 4);
            this.mailing_list_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mailing_list_tab.Name = "mailing_list_tab";
            this.mailing_list_tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mailing_list_tab.Size = new System.Drawing.Size(1374, 845);
            this.mailing_list_tab.TabIndex = 1;
            this.mailing_list_tab.Text = "Mailing List";
            // 
            // searchBar2
            // 
            this.searchBar2.Location = new System.Drawing.Point(1094, 0);
            this.searchBar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBar2.Name = "searchBar2";
            this.searchBar2.Size = new System.Drawing.Size(259, 26);
            this.searchBar2.TabIndex = 29;
            // 
            // search2
            // 
            this.search2.ActiveLinkColor = System.Drawing.Color.Red;
            this.search2.AutoSize = true;
            this.search2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.search2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.search2.Location = new System.Drawing.Point(1026, 3);
            this.search2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(57, 20);
            this.search2.TabIndex = 28;
            this.search2.TabStop = true;
            this.search2.Text = "search";
            this.search2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.search2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.search2_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "|";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "|";
            // 
            // mailinglistDataView
            // 
            this.mailinglistDataView.AllowUserToAddRows = false;
            this.mailinglistDataView.AllowUserToResizeColumns = false;
            this.mailinglistDataView.AllowUserToResizeRows = false;
            this.mailinglistDataView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.mailinglistDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mailinglistDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.mailinglistDataView.Location = new System.Drawing.Point(0, 29);
            this.mailinglistDataView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mailinglistDataView.Name = "mailinglistDataView";
            this.mailinglistDataView.ReadOnly = true;
            this.mailinglistDataView.RowHeadersWidth = 20;
            this.mailinglistDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mailinglistDataView.Size = new System.Drawing.Size(1370, 811);
            this.mailinglistDataView.TabIndex = 3;
            this.mailinglistDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mailinglist_data_view_CellClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 890;
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel6.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel6.Location = new System.Drawing.Point(177, 5);
            this.linkLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(35, 20);
            this.linkLabel6.TabIndex = 2;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "edit";
            this.linkLabel6.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel5.Location = new System.Drawing.Point(90, 5);
            this.linkLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(54, 20);
            this.linkLabel5.TabIndex = 1;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "create";
            this.linkLabel5.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel4.Location = new System.Drawing.Point(4, 5);
            this.linkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(53, 20);
            this.linkLabel4.TabIndex = 0;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "delete";
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // folders_tab
            // 
            this.folders_tab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.folders_tab.Controls.Add(this.searchBar3);
            this.folders_tab.Controls.Add(this.search3);
            this.folders_tab.Controls.Add(this.label15);
            this.folders_tab.Controls.Add(this.linkLabel8);
            this.folders_tab.Controls.Add(this.label14);
            this.folders_tab.Controls.Add(this.delete_selected_folder_button);
            this.folders_tab.Controls.Add(this.add_folder_button);
            this.folders_tab.Controls.Add(this.folderDataView);
            this.folders_tab.Location = new System.Drawing.Point(4, 4);
            this.folders_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.folders_tab.Name = "folders_tab";
            this.folders_tab.Size = new System.Drawing.Size(1374, 845);
            this.folders_tab.TabIndex = 2;
            this.folders_tab.Text = "Folders";
            // 
            // searchBar3
            // 
            this.searchBar3.Location = new System.Drawing.Point(1094, 5);
            this.searchBar3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBar3.Name = "searchBar3";
            this.searchBar3.Size = new System.Drawing.Size(259, 26);
            this.searchBar3.TabIndex = 31;
            // 
            // search3
            // 
            this.search3.ActiveLinkColor = System.Drawing.Color.Red;
            this.search3.AutoSize = true;
            this.search3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.search3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.search3.Location = new System.Drawing.Point(1026, 8);
            this.search3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.search3.Name = "search3";
            this.search3.Size = new System.Drawing.Size(57, 20);
            this.search3.TabIndex = 30;
            this.search3.TabStop = true;
            this.search3.Text = "search";
            this.search3.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.search3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.search3_LinkClicked);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(242, 9);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "|";
            // 
            // linkLabel8
            // 
            this.linkLabel8.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel8.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel8.Location = new System.Drawing.Point(264, 9);
            this.linkLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(83, 20);
            this.linkLabel8.TabIndex = 20;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "view folder";
            this.linkLabel8.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked_2);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(94, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "|";
            // 
            // delete_selected_folder_button
            // 
            this.delete_selected_folder_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.delete_selected_folder_button.AutoSize = true;
            this.delete_selected_folder_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.delete_selected_folder_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_selected_folder_button.Location = new System.Drawing.Point(117, 9);
            this.delete_selected_folder_button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delete_selected_folder_button.Name = "delete_selected_folder_button";
            this.delete_selected_folder_button.Size = new System.Drawing.Size(117, 20);
            this.delete_selected_folder_button.TabIndex = 18;
            this.delete_selected_folder_button.TabStop = true;
            this.delete_selected_folder_button.Text = "delete selected";
            this.delete_selected_folder_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_selected_folder_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked_1);
            // 
            // add_folder_button
            // 
            this.add_folder_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.add_folder_button.AutoSize = true;
            this.add_folder_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.add_folder_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add_folder_button.Location = new System.Drawing.Point(8, 9);
            this.add_folder_button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_folder_button.Name = "add_folder_button";
            this.add_folder_button.Size = new System.Drawing.Size(80, 20);
            this.add_folder_button.TabIndex = 17;
            this.add_folder_button.TabStop = true;
            this.add_folder_button.Text = "add folder";
            this.add_folder_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add_folder_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // folderDataView
            // 
            this.folderDataView.AllowUserToAddRows = false;
            this.folderDataView.AllowUserToResizeColumns = false;
            this.folderDataView.AllowUserToResizeRows = false;
            this.folderDataView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.folderDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.folderDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7});
            this.folderDataView.Location = new System.Drawing.Point(4, 34);
            this.folderDataView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.folderDataView.Name = "folderDataView";
            this.folderDataView.ReadOnly = true;
            this.folderDataView.RowHeadersWidth = 20;
            this.folderDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.folderDataView.Size = new System.Drawing.Size(1370, 811);
            this.folderDataView.TabIndex = 16;
            this.folderDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.folder_data_view_CellClick_1);
            this.folderDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.folder_data_view_CellContentClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Folder name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Folder name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // archive_tab
            // 
            this.archive_tab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.archive_tab.Controls.Add(this.searchBar4);
            this.archive_tab.Controls.Add(this.search4);
            this.archive_tab.Controls.Add(this.label17);
            this.archive_tab.Controls.Add(this.linkLabel9);
            this.archive_tab.Controls.Add(this.linkLabel1);
            this.archive_tab.Controls.Add(this.archiveDataView);
            this.archive_tab.Controls.Add(this.label8);
            this.archive_tab.Controls.Add(this.view_archived);
            this.archive_tab.Controls.Add(this.linkLabel2);
            this.archive_tab.Controls.Add(this.delete_archived);
            this.archive_tab.Controls.Add(this.label9);
            this.archive_tab.Controls.Add(this.label11);
            this.archive_tab.Controls.Add(this.linkLabel3);
            this.archive_tab.Controls.Add(this.label10);
            this.archive_tab.Location = new System.Drawing.Point(4, 4);
            this.archive_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.archive_tab.Name = "archive_tab";
            this.archive_tab.Size = new System.Drawing.Size(1374, 845);
            this.archive_tab.TabIndex = 3;
            this.archive_tab.Text = "Archive";
            // 
            // searchBar4
            // 
            this.searchBar4.Location = new System.Drawing.Point(1094, 0);
            this.searchBar4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBar4.Name = "searchBar4";
            this.searchBar4.Size = new System.Drawing.Size(259, 26);
            this.searchBar4.TabIndex = 35;
            // 
            // search4
            // 
            this.search4.ActiveLinkColor = System.Drawing.Color.Red;
            this.search4.AutoSize = true;
            this.search4.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.search4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.search4.Location = new System.Drawing.Point(1026, 3);
            this.search4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.search4.Name = "search4";
            this.search4.Size = new System.Drawing.Size(57, 20);
            this.search4.TabIndex = 34;
            this.search4.TabStop = true;
            this.search4.Text = "search";
            this.search4.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.search4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.search4_LinkClicked);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(736, 3);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "|";
            // 
            // linkLabel9
            // 
            this.linkLabel9.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel9.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel9.Location = new System.Drawing.Point(758, 3);
            this.linkLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(98, 20);
            this.linkLabel9.TabIndex = 32;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "add to folder";
            this.linkLabel9.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel9.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel9_LinkClicked_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(602, 3);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(126, 20);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "forward selected";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_2);
            // 
            // archiveDataView
            // 
            this.archiveDataView.AllowUserToAddRows = false;
            this.archiveDataView.AllowUserToResizeColumns = false;
            this.archiveDataView.AllowUserToResizeRows = false;
            this.archiveDataView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.archiveDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.archiveDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.archiveDataView.Location = new System.Drawing.Point(0, 28);
            this.archiveDataView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.archiveDataView.Name = "archiveDataView";
            this.archiveDataView.ReadOnly = true;
            this.archiveDataView.RowHeadersWidth = 20;
            this.archiveDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.archiveDataView.Size = new System.Drawing.Size(1370, 811);
            this.archiveDataView.TabIndex = 15;
            this.archiveDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.archive_data_view_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Sent by";
            this.dataGridViewTextBoxColumn1.HeaderText = "Sent by";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn2.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 650;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(579, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "|";
            // 
            // view_archived
            // 
            this.view_archived.ActiveLinkColor = System.Drawing.Color.Red;
            this.view_archived.AutoSize = true;
            this.view_archived.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.view_archived.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.view_archived.Location = new System.Drawing.Point(154, 3);
            this.view_archived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.view_archived.Name = "view_archived";
            this.view_archived.Size = new System.Drawing.Size(103, 20);
            this.view_archived.TabIndex = 25;
            this.view_archived.TabStop = true;
            this.view_archived.Text = "view selected";
            this.view_archived.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.view_archived.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.view_archived_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel2.Location = new System.Drawing.Point(446, 3);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(124, 20);
            this.linkLabel2.TabIndex = 29;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "reply to selected";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
            // 
            // delete_archived
            // 
            this.delete_archived.ActiveLinkColor = System.Drawing.Color.Red;
            this.delete_archived.AutoSize = true;
            this.delete_archived.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.delete_archived.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_archived.Location = new System.Drawing.Point(4, 3);
            this.delete_archived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delete_archived.Name = "delete_archived";
            this.delete_archived.Size = new System.Drawing.Size(117, 20);
            this.delete_archived.TabIndex = 23;
            this.delete_archived.TabStop = true;
            this.delete_archived.Text = "delete selected";
            this.delete_archived.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_archived.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.delete_archived_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "|";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "|";
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel3.Location = new System.Drawing.Point(280, 3);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(141, 20);
            this.linkLabel3.TabIndex = 27;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "unarchive selected";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(268, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "|";
            // 
            // Sent_tab
            // 
            this.Sent_tab.Controls.Add(this.searchBar5);
            this.Sent_tab.Controls.Add(this.search5);
            this.Sent_tab.Controls.Add(this.linkLabel11);
            this.Sent_tab.Controls.Add(this.label18);
            this.Sent_tab.Controls.Add(this.linkLabel10);
            this.Sent_tab.Controls.Add(this.sentDataView);
            this.Sent_tab.Location = new System.Drawing.Point(4, 4);
            this.Sent_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sent_tab.Name = "Sent_tab";
            this.Sent_tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sent_tab.Size = new System.Drawing.Size(1374, 845);
            this.Sent_tab.TabIndex = 4;
            this.Sent_tab.Text = "Sent";
            this.Sent_tab.UseVisualStyleBackColor = true;
            this.Sent_tab.Click += new System.EventHandler(this.sent_data_view_Click);
            // 
            // searchBar5
            // 
            this.searchBar5.Location = new System.Drawing.Point(1077, 9);
            this.searchBar5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBar5.Name = "searchBar5";
            this.searchBar5.Size = new System.Drawing.Size(259, 26);
            this.searchBar5.TabIndex = 29;
            // 
            // search5
            // 
            this.search5.ActiveLinkColor = System.Drawing.Color.Red;
            this.search5.AutoSize = true;
            this.search5.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.search5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.search5.Location = new System.Drawing.Point(1010, 12);
            this.search5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.search5.Name = "search5";
            this.search5.Size = new System.Drawing.Size(57, 20);
            this.search5.TabIndex = 28;
            this.search5.TabStop = true;
            this.search5.Text = "search";
            this.search5.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.search5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.search5_LinkClicked);
            // 
            // linkLabel11
            // 
            this.linkLabel11.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel11.AutoSize = true;
            this.linkLabel11.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel11.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel11.Location = new System.Drawing.Point(159, 15);
            this.linkLabel11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.Size = new System.Drawing.Size(126, 20);
            this.linkLabel11.TabIndex = 33;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "forward selected";
            this.linkLabel11.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel11.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel11_LinkClicked);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(133, 14);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 20);
            this.label18.TabIndex = 32;
            this.label18.Text = "|";
            // 
            // linkLabel10
            // 
            this.linkLabel10.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel10.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel10.Location = new System.Drawing.Point(18, 14);
            this.linkLabel10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(103, 20);
            this.linkLabel10.TabIndex = 28;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "view selected";
            this.linkLabel10.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel10_LinkClicked);
            // 
            // sentDataView
            // 
            this.sentDataView.AllowUserToAddRows = false;
            this.sentDataView.AllowUserToResizeColumns = false;
            this.sentDataView.AllowUserToResizeRows = false;
            this.sentDataView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.sentDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sentDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.sentDataView.Location = new System.Drawing.Point(0, 52);
            this.sentDataView.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.sentDataView.Name = "sentDataView";
            this.sentDataView.ReadOnly = true;
            this.sentDataView.RowHeadersWidth = 20;
            this.sentDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.sentDataView.Size = new System.Drawing.Size(1364, 793);
            this.sentDataView.TabIndex = 16;
            this.sentDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sent_data_view_CellClick);
            this.sentDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sent_data_view_CellContentClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sent to";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sent to";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn6.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 650;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 104;
            // 
            // refresh_button
            // 
            this.refresh_button.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.refresh_button.AutoSize = true;
            this.refresh_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.refresh_button.LinkColor = System.Drawing.Color.Green;
            this.refresh_button.Location = new System.Drawing.Point(386, 14);
            this.refresh_button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(100, 20);
            this.refresh_button.TabIndex = 2;
            this.refresh_button.TabStop = true;
            this.refresh_button.Text = "refresh inbox";
            this.refresh_button.VisitedLinkColor = System.Drawing.Color.Green;
            this.refresh_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // sep3
            // 
            this.sep3.AutoSize = true;
            this.sep3.Location = new System.Drawing.Point(490, 14);
            this.sep3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(14, 20);
            this.sep3.TabIndex = 6;
            this.sep3.Text = "|";
            // 
            // send_button
            // 
            this.send_button.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.send_button.AutoSize = true;
            this.send_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.send_button.LinkColor = System.Drawing.Color.Green;
            this.send_button.Location = new System.Drawing.Point(520, 14);
            this.send_button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(90, 20);
            this.send_button.TabIndex = 7;
            this.send_button.TabStop = true;
            this.send_button.Text = "send e-mail";
            this.send_button.VisitedLinkColor = System.Drawing.Color.Green;
            this.send_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.send_button_LinkClicked);
            // 
            // edit_button
            // 
            this.edit_button.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.edit_button.AutoSize = true;
            this.edit_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.edit_button.LinkColor = System.Drawing.Color.Green;
            this.edit_button.Location = new System.Drawing.Point(657, 14);
            this.edit_button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(96, 20);
            this.edit_button.TabIndex = 8;
            this.edit_button.TabStop = true;
            this.edit_button.Text = "edit account";
            this.edit_button.VisitedLinkColor = System.Drawing.Color.Green;
            this.edit_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // sep4
            // 
            this.sep4.AutoSize = true;
            this.sep4.Location = new System.Drawing.Point(620, 14);
            this.sep4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sep4.Name = "sep4";
            this.sep4.Size = new System.Drawing.Size(14, 20);
            this.sep4.TabIndex = 9;
            this.sep4.Text = "|";
            // 
            // loggedInAs
            // 
            this.loggedInAs.AutoSize = true;
            this.loggedInAs.Location = new System.Drawing.Point(18, 14);
            this.loggedInAs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loggedInAs.Name = "loggedInAs";
            this.loggedInAs.Size = new System.Drawing.Size(13, 20);
            this.loggedInAs.TabIndex = 10;
            this.loggedInAs.Text = ".";
            // 
            // sep1
            // 
            this.sep1.AutoSize = true;
            this.sep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sep1.Location = new System.Drawing.Point(356, 14);
            this.sep1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(14, 20);
            this.sep1.TabIndex = 11;
            this.sep1.Text = "|";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(932, 14);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 20);
            this.statusLabel.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(765, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(878, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "status:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(855, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "|";
            // 
            // linkLabel7
            // 
            this.linkLabel7.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel7.LinkColor = System.Drawing.Color.Green;
            this.linkLabel7.Location = new System.Drawing.Point(788, 14);
            this.linkLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(57, 20);
            this.linkLabel7.TabIndex = 16;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "log out";
            this.linkLabel7.VisitedLinkColor = System.Drawing.Color.Green;
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // generateR
            // 
            this.generateR.AutoSize = true;
            this.generateR.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.generateR.Location = new System.Drawing.Point(1224, 14);
            this.generateR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.generateR.Name = "generateR";
            this.generateR.Size = new System.Drawing.Size(123, 20);
            this.generateR.TabIndex = 18;
            this.generateR.TabStop = true;
            this.generateR.Text = "Generate report";
            this.generateR.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.generateR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.generateR_LinkClicked);
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1364, 929);
            this.Controls.Add(this.generateR);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.sep1);
            this.Controls.Add(this.loggedInAs);
            this.Controls.Add(this.sep4);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.sep3);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.tab_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Driver";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.driver_FormClosed);
            this.Load += new System.EventHandler(this.driver_Load);
            this.tab_control.ResumeLayout(false);
            this.inbox_tab.ResumeLayout(false);
            this.inbox_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inboxDataView)).EndInit();
            this.mailing_list_tab.ResumeLayout(false);
            this.mailing_list_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailinglistDataView)).EndInit();
            this.folders_tab.ResumeLayout(false);
            this.folders_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderDataView)).EndInit();
            this.archive_tab.ResumeLayout(false);
            this.archive_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataView)).EndInit();
            this.Sent_tab.ResumeLayout(false);
            this.Sent_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sentDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage inbox_tab;
        private System.Windows.Forms.TabPage mailing_list_tab;
        private System.Windows.Forms.DataGridView inboxDataView;
        private System.Windows.Forms.LinkLabel refresh_button;
        private System.Windows.Forms.TabPage folders_tab;
        private System.Windows.Forms.Label sep3;
        private System.Windows.Forms.LinkLabel send_button;
        private System.Windows.Forms.LinkLabel edit_button;
        private System.Windows.Forms.Label sep4;
        private System.Windows.Forms.Label loggedInAs;
        private System.Windows.Forms.Label sep1;
        private System.Windows.Forms.LinkLabel delete_button;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage archive_tab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel forward_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel reply_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel archive_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel view_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView archiveDataView;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel view_archived;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel delete_archived;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.DataGridView mailinglistDataView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.DataGridView folderDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.LinkLabel add_folder_button;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.LinkLabel delete_selected_folder_button;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel add_to_folder_button;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.LinkLabel search;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox searchBar2;
        private System.Windows.Forms.LinkLabel search2;
        private System.Windows.Forms.TextBox searchBar3;
        private System.Windows.Forms.LinkLabel search3;
        private System.Windows.Forms.TextBox searchBar4;
        private System.Windows.Forms.LinkLabel search4;
        private System.Windows.Forms.TabPage Sent_tab;
        private System.Windows.Forms.DataGridView sentDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.LinkLabel linkLabel11;
        private System.Windows.Forms.TextBox searchBar5;
        private System.Windows.Forms.LinkLabel search5;
        private System.Windows.Forms.LinkLabel generateR;
    }
}