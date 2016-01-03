﻿namespace Shares
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
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader columnHeader3;
            System.Windows.Forms.ColumnHeader columnHeader4;
            System.Windows.Forms.ColumnHeader columnHeader5;
            System.Windows.Forms.ColumnHeader columnHeader6;
            System.Windows.Forms.ColumnHeader columnHeader7;
            System.Windows.Forms.ColumnHeader columnHeader8;
            System.Windows.Forms.ColumnHeader columnHeader9;
            System.Windows.Forms.ColumnHeader columnHeader11;
            System.Windows.Forms.ColumnHeader columnHeader12;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbSimpleSearchSymbol = new System.Windows.Forms.ComboBox();
            this.lvSimpleSearchResults = new System.Windows.Forms.ListView();
            this.btnSimpleSearchGentics = new System.Windows.Forms.Button();
            this.btSaveSimpleSearchSettings = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbRepeats = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRateChange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFallSearchPeriod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRiseSearchPeriod = new System.Windows.Forms.TextBox();
            this.lbRiseSearchPeriod = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gcSplits = new ZedGraph.ZedGraphControl();
            this.cbSelectSymbol = new System.Windows.Forms.ComboBox();
            this.lbPercentageDiffForSplit = new System.Windows.Forms.Label();
            this.lvSplits = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAllSharesGo = new System.Windows.Forms.Button();
            this.lvAllShares = new System.Windows.Forms.ListView();
            this.btnAllSharesGenetics = new System.Windows.Forms.Button();
            this.btnAllSharesSave = new System.Windows.Forms.Button();
            this.tbAllSharesRepeats = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAllSharesRateChange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAllSharesFallSearchPeriod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAllSharesRiseSearchPeriod = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Date";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Previous Day Close";
            columnHeader2.Width = 192;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Next Day Open";
            columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Normalised";
            columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "First Buy Date";
            columnHeader5.Width = 38;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Last Buy Date";
            columnHeader6.Width = 37;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Number of Sells";
            columnHeader7.Width = 45;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Failed";
            columnHeader8.Width = 53;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Symbol";
            columnHeader9.Width = 89;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Number of Ok Sells";
            columnHeader11.Width = 133;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Number of Fails";
            columnHeader12.Width = 119;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(8, 12);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(44, 13);
            label12.TabIndex = 9;
            label12.Text = "Symbol:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(9, 8);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(44, 13);
            label13.TabIndex = 14;
            label13.Text = "Symbol:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbSimpleSearchSymbol);
            this.splitContainer1.Panel1.Controls.Add(label13);
            this.splitContainer1.Panel1.Controls.Add(this.lvSimpleSearchResults);
            this.splitContainer1.Panel1.Controls.Add(this.btnSimpleSearchGentics);
            this.splitContainer1.Panel1.Controls.Add(this.btSaveSimpleSearchSettings);
            this.splitContainer1.Panel1.Controls.Add(this.btnGo);
            this.splitContainer1.Panel1.Controls.Add(this.tbRepeats);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.tbRateChange);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.tbFallSearchPeriod);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tbRiseSearchPeriod);
            this.splitContainer1.Panel1.Controls.Add(this.lbRiseSearchPeriod);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.zedGraphControl1);
            this.splitContainer1.Size = new System.Drawing.Size(660, 417);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbSimpleSearchSymbol
            // 
            this.cbSimpleSearchSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSimpleSearchSymbol.FormattingEnabled = true;
            this.cbSimpleSearchSymbol.Location = new System.Drawing.Point(54, 5);
            this.cbSimpleSearchSymbol.Name = "cbSimpleSearchSymbol";
            this.cbSimpleSearchSymbol.Size = new System.Drawing.Size(121, 21);
            this.cbSimpleSearchSymbol.TabIndex = 15;
            this.cbSimpleSearchSymbol.SelectedIndexChanged += new System.EventHandler(this.cbSimpleSearchSymbol_SelectedIndexChanged);
            // 
            // lvSimpleSearchResults
            // 
            this.lvSimpleSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSimpleSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader5,
            columnHeader6,
            columnHeader7,
            columnHeader8});
            this.lvSimpleSearchResults.Location = new System.Drawing.Point(13, 188);
            this.lvSimpleSearchResults.Name = "lvSimpleSearchResults";
            this.lvSimpleSearchResults.Size = new System.Drawing.Size(191, 224);
            this.lvSimpleSearchResults.TabIndex = 13;
            this.lvSimpleSearchResults.UseCompatibleStateImageBehavior = false;
            this.lvSimpleSearchResults.View = System.Windows.Forms.View.Details;
            // 
            // btnSimpleSearchGentics
            // 
            this.btnSimpleSearchGentics.Location = new System.Drawing.Point(129, 133);
            this.btnSimpleSearchGentics.Name = "btnSimpleSearchGentics";
            this.btnSimpleSearchGentics.Size = new System.Drawing.Size(75, 23);
            this.btnSimpleSearchGentics.TabIndex = 12;
            this.btnSimpleSearchGentics.Text = "Genetics";
            this.btnSimpleSearchGentics.UseVisualStyleBackColor = true;
            this.btnSimpleSearchGentics.Click += new System.EventHandler(this.btnSimpleSearchGentics_Click);
            // 
            // btSaveSimpleSearchSettings
            // 
            this.btSaveSimpleSearchSettings.Location = new System.Drawing.Point(13, 159);
            this.btSaveSimpleSearchSettings.Name = "btSaveSimpleSearchSettings";
            this.btSaveSimpleSearchSettings.Size = new System.Drawing.Size(75, 23);
            this.btSaveSimpleSearchSettings.TabIndex = 11;
            this.btSaveSimpleSearchSettings.Text = "Save";
            this.btSaveSimpleSearchSettings.UseVisualStyleBackColor = true;
            this.btSaveSimpleSearchSettings.Click += new System.EventHandler(this.btSaveSimpleSearchSettings_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(13, 133);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 10;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbRepeats
            // 
            this.tbRepeats.Location = new System.Drawing.Point(115, 105);
            this.tbRepeats.Name = "tbRepeats";
            this.tbRepeats.Size = new System.Drawing.Size(43, 20);
            this.tbRepeats.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Repeats";
            // 
            // tbRateChange
            // 
            this.tbRateChange.Location = new System.Drawing.Point(115, 81);
            this.tbRateChange.Name = "tbRateChange";
            this.tbRateChange.Size = new System.Drawing.Size(43, 20);
            this.tbRateChange.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rate Change:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "days";
            // 
            // tbFallSearchPeriod
            // 
            this.tbFallSearchPeriod.Location = new System.Drawing.Point(115, 55);
            this.tbFallSearchPeriod.Name = "tbFallSearchPeriod";
            this.tbFallSearchPeriod.Size = new System.Drawing.Size(43, 20);
            this.tbFallSearchPeriod.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fall Search Period:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "days";
            // 
            // tbRiseSearchPeriod
            // 
            this.tbRiseSearchPeriod.Location = new System.Drawing.Point(115, 29);
            this.tbRiseSearchPeriod.Name = "tbRiseSearchPeriod";
            this.tbRiseSearchPeriod.Size = new System.Drawing.Size(43, 20);
            this.tbRiseSearchPeriod.TabIndex = 1;
            // 
            // lbRiseSearchPeriod
            // 
            this.lbRiseSearchPeriod.AutoSize = true;
            this.lbRiseSearchPeriod.Location = new System.Drawing.Point(10, 32);
            this.lbRiseSearchPeriod.Name = "lbRiseSearchPeriod";
            this.lbRiseSearchPeriod.Size = new System.Drawing.Size(101, 13);
            this.lbRiseSearchPeriod.TabIndex = 0;
            this.lbRiseSearchPeriod.Text = "Rise Search Period:";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(438, 417);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gcSplits);
            this.tabPage2.Controls.Add(this.cbSelectSymbol);
            this.tabPage2.Controls.Add(label12);
            this.tabPage2.Controls.Add(this.lbPercentageDiffForSplit);
            this.tabPage2.Controls.Add(this.lvSplits);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Split";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gcSplits
            // 
            this.gcSplits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSplits.Location = new System.Drawing.Point(0, 183);
            this.gcSplits.Name = "gcSplits";
            this.gcSplits.ScrollGrace = 0D;
            this.gcSplits.ScrollMaxX = 0D;
            this.gcSplits.ScrollMaxY = 0D;
            this.gcSplits.ScrollMaxY2 = 0D;
            this.gcSplits.ScrollMinX = 0D;
            this.gcSplits.ScrollMinY = 0D;
            this.gcSplits.ScrollMinY2 = 0D;
            this.gcSplits.Size = new System.Drawing.Size(663, 240);
            this.gcSplits.TabIndex = 11;
            // 
            // cbSelectSymbol
            // 
            this.cbSelectSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectSymbol.FormattingEnabled = true;
            this.cbSelectSymbol.Location = new System.Drawing.Point(53, 9);
            this.cbSelectSymbol.Name = "cbSelectSymbol";
            this.cbSelectSymbol.Size = new System.Drawing.Size(121, 21);
            this.cbSelectSymbol.TabIndex = 10;
            this.cbSelectSymbol.SelectedIndexChanged += new System.EventHandler(this.cbSelectSymbol_SelectedIndexChanged);
            // 
            // lbPercentageDiffForSplit
            // 
            this.lbPercentageDiffForSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPercentageDiffForSplit.Location = new System.Drawing.Point(558, 14);
            this.lbPercentageDiffForSplit.Name = "lbPercentageDiffForSplit";
            this.lbPercentageDiffForSplit.Size = new System.Drawing.Size(100, 23);
            this.lbPercentageDiffForSplit.TabIndex = 7;
            this.lbPercentageDiffForSplit.Text = "0";
            this.lbPercentageDiffForSplit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lvSplits
            // 
            this.lvSplits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSplits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3,
            columnHeader4});
            this.lvSplits.Location = new System.Drawing.Point(8, 40);
            this.lvSplits.Name = "lvSplits";
            this.lvSplits.Size = new System.Drawing.Size(649, 137);
            this.lvSplits.TabIndex = 6;
            this.lvSplits.UseCompatibleStateImageBehavior = false;
            this.lvSplits.View = System.Windows.Forms.View.Details;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAllSharesGo);
            this.tabPage3.Controls.Add(this.lvAllShares);
            this.tabPage3.Controls.Add(this.btnAllSharesGenetics);
            this.tabPage3.Controls.Add(this.btnAllSharesSave);
            this.tabPage3.Controls.Add(this.tbAllSharesRepeats);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tbAllSharesRateChange);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.tbAllSharesFallSearchPeriod);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.tbAllSharesRiseSearchPeriod);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(666, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAllSharesGo
            // 
            this.btnAllSharesGo.Location = new System.Drawing.Point(11, 130);
            this.btnAllSharesGo.Name = "btnAllSharesGo";
            this.btnAllSharesGo.Size = new System.Drawing.Size(75, 23);
            this.btnAllSharesGo.TabIndex = 27;
            this.btnAllSharesGo.Text = "Go";
            this.btnAllSharesGo.UseVisualStyleBackColor = true;
            this.btnAllSharesGo.Click += new System.EventHandler(this.btnAllSharesGo_Click);
            // 
            // lvAllShares
            // 
            this.lvAllShares.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAllShares.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader9,
            columnHeader11,
            columnHeader12});
            this.lvAllShares.Location = new System.Drawing.Point(225, 6);
            this.lvAllShares.Name = "lvAllShares";
            this.lvAllShares.Size = new System.Drawing.Size(433, 409);
            this.lvAllShares.TabIndex = 26;
            this.lvAllShares.UseCompatibleStateImageBehavior = false;
            this.lvAllShares.View = System.Windows.Forms.View.Details;
            // 
            // btnAllSharesGenetics
            // 
            this.btnAllSharesGenetics.Location = new System.Drawing.Point(127, 130);
            this.btnAllSharesGenetics.Name = "btnAllSharesGenetics";
            this.btnAllSharesGenetics.Size = new System.Drawing.Size(75, 23);
            this.btnAllSharesGenetics.TabIndex = 25;
            this.btnAllSharesGenetics.Text = "Genetics";
            this.btnAllSharesGenetics.UseVisualStyleBackColor = true;
            // 
            // btnAllSharesSave
            // 
            this.btnAllSharesSave.Location = new System.Drawing.Point(11, 159);
            this.btnAllSharesSave.Name = "btnAllSharesSave";
            this.btnAllSharesSave.Size = new System.Drawing.Size(75, 23);
            this.btnAllSharesSave.TabIndex = 24;
            this.btnAllSharesSave.Text = "Save";
            this.btnAllSharesSave.UseVisualStyleBackColor = true;
            // 
            // tbAllSharesRepeats
            // 
            this.tbAllSharesRepeats.Location = new System.Drawing.Point(113, 90);
            this.tbAllSharesRepeats.Name = "tbAllSharesRepeats";
            this.tbAllSharesRepeats.Size = new System.Drawing.Size(43, 20);
            this.tbAllSharesRepeats.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Repeats";
            // 
            // tbAllSharesRateChange
            // 
            this.tbAllSharesRateChange.Location = new System.Drawing.Point(113, 61);
            this.tbAllSharesRateChange.Name = "tbAllSharesRateChange";
            this.tbAllSharesRateChange.Size = new System.Drawing.Size(43, 20);
            this.tbAllSharesRateChange.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Rate Change:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "days";
            // 
            // tbAllSharesFallSearchPeriod
            // 
            this.tbAllSharesFallSearchPeriod.Location = new System.Drawing.Point(113, 35);
            this.tbAllSharesFallSearchPeriod.Name = "tbAllSharesFallSearchPeriod";
            this.tbAllSharesFallSearchPeriod.Size = new System.Drawing.Size(43, 20);
            this.tbAllSharesFallSearchPeriod.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fall Search Period:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "days";
            // 
            // tbAllSharesRiseSearchPeriod
            // 
            this.tbAllSharesRiseSearchPeriod.Location = new System.Drawing.Point(113, 9);
            this.tbAllSharesRiseSearchPeriod.Name = "tbAllSharesRiseSearchPeriod";
            this.tbAllSharesRiseSearchPeriod.Size = new System.Drawing.Size(43, 20);
            this.tbAllSharesRiseSearchPeriod.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Rise Search Period:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 449);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRiseSearchPeriod;
        private System.Windows.Forms.Label lbRiseSearchPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFallSearchPeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRateChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbRepeats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvSplits;
        private System.Windows.Forms.Label lbPercentageDiffForSplit;
        private System.Windows.Forms.Button btSaveSimpleSearchSettings;
        private System.Windows.Forms.Button btnSimpleSearchGentics;
        private System.Windows.Forms.ListView lvSimpleSearchResults;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAllSharesGo;
        private System.Windows.Forms.ListView lvAllShares;
        private System.Windows.Forms.Button btnAllSharesGenetics;
        private System.Windows.Forms.Button btnAllSharesSave;
        private System.Windows.Forms.TextBox tbAllSharesRepeats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAllSharesRateChange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAllSharesFallSearchPeriod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAllSharesRiseSearchPeriod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbSelectSymbol;
        private System.Windows.Forms.ComboBox cbSimpleSearchSymbol;
        private ZedGraph.ZedGraphControl gcSplits;
    }
}

