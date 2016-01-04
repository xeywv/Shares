namespace Shares
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
            System.Windows.Forms.Label label13;
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader columnHeader3;
            System.Windows.Forms.ColumnHeader columnHeader4;
            System.Windows.Forms.ColumnHeader columnHeader9;
            System.Windows.Forms.ColumnHeader columnHeader11;
            System.Windows.Forms.ColumnHeader columnHeader12;
            System.Windows.Forms.ColumnHeader columnHeader5;
            System.Windows.Forms.ColumnHeader columnHeader6;
            System.Windows.Forms.ColumnHeader columnHeader7;
            System.Windows.Forms.ColumnHeader columnHeader8;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.TabControl tabControl1;
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.cbGraphDisplay = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbSplitsShowOnGraph = new System.Windows.Forms.CheckBox();
            this.lbPercentageDiffForSplit = new System.Windows.Forms.Label();
            this.lvSplits = new System.Windows.Forms.ListView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.cbSelectSymbol = new System.Windows.Forms.ComboBox();
            label13 = new System.Windows.Forms.Label();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            label12 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            tabControl1 = new System.Windows.Forms.TabControl();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(13, 6);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(44, 13);
            label13.TabIndex = 19;
            label13.Text = "Symbol:";
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(185, 6);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(39, 13);
            label12.TabIndex = 21;
            label12.Text = "Graph:";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 199);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(673, 250);
            this.zedGraphControl1.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            panel1.Controls.Add(this.cbGraphDisplay);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(this.cbSelectSymbol);
            panel1.Controls.Add(label13);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(673, 200);
            panel1.TabIndex = 19;
            // 
            // cbGraphDisplay
            // 
            this.cbGraphDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGraphDisplay.FormattingEnabled = true;
            this.cbGraphDisplay.Items.AddRange(new object[] {
            "Normalised",
            "Raw",
            "Raw +Normalised"});
            this.cbGraphDisplay.Location = new System.Drawing.Point(230, 3);
            this.cbGraphDisplay.Name = "cbGraphDisplay";
            this.cbGraphDisplay.Size = new System.Drawing.Size(121, 21);
            this.cbGraphDisplay.TabIndex = 22;
            this.cbGraphDisplay.SelectedIndexChanged += new System.EventHandler(this.CbGraphDisplay_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tabControl1.Controls.Add(this.tabPage2);
            tabControl1.Controls.Add(this.tabPage1);
            tabControl1.Controls.Add(this.tabPage3);
            tabControl1.Location = new System.Drawing.Point(0, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(674, 167);
            tabControl1.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbSplitsShowOnGraph);
            this.tabPage2.Controls.Add(this.lbPercentageDiffForSplit);
            this.tabPage2.Controls.Add(this.lvSplits);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 141);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Splits";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbSplitsShowOnGraph
            // 
            this.cbSplitsShowOnGraph.AutoSize = true;
            this.cbSplitsShowOnGraph.Location = new System.Drawing.Point(0, 127);
            this.cbSplitsShowOnGraph.Name = "cbSplitsShowOnGraph";
            this.cbSplitsShowOnGraph.Size = new System.Drawing.Size(102, 17);
            this.cbSplitsShowOnGraph.TabIndex = 9;
            this.cbSplitsShowOnGraph.Text = "Show On Graph";
            this.cbSplitsShowOnGraph.UseVisualStyleBackColor = true;
            this.cbSplitsShowOnGraph.Click += new System.EventHandler(this.cbSplitsShowOnGraph_Click);
            // 
            // lbPercentageDiffForSplit
            // 
            this.lbPercentageDiffForSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPercentageDiffForSplit.Location = new System.Drawing.Point(563, 115);
            this.lbPercentageDiffForSplit.Name = "lbPercentageDiffForSplit";
            this.lbPercentageDiffForSplit.Size = new System.Drawing.Size(100, 23);
            this.lbPercentageDiffForSplit.TabIndex = 8;
            this.lbPercentageDiffForSplit.Text = "0";
            this.lbPercentageDiffForSplit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lvSplits
            // 
            this.lvSplits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSplits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSplits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3,
            columnHeader4});
            this.lvSplits.Location = new System.Drawing.Point(3, 3);
            this.lvSplits.Name = "lvSplits";
            this.lvSplits.Size = new System.Drawing.Size(660, 135);
            this.lvSplits.TabIndex = 6;
            this.lvSplits.UseCompatibleStateImageBehavior = false;
            this.lvSplits.View = System.Windows.Forms.View.Details;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvSimpleSearchResults);
            this.tabPage1.Controls.Add(this.btnSimpleSearchGentics);
            this.tabPage1.Controls.Add(this.btSaveSimpleSearchSettings);
            this.tabPage1.Controls.Add(this.btnGo);
            this.tabPage1.Controls.Add(this.tbRepeats);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbRateChange);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbFallSearchPeriod);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbRiseSearchPeriod);
            this.tabPage1.Controls.Add(this.lbRiseSearchPeriod);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.lvSimpleSearchResults.Location = new System.Drawing.Point(235, 41);
            this.lvSimpleSearchResults.Name = "lvSimpleSearchResults";
            this.lvSimpleSearchResults.Size = new System.Drawing.Size(423, 94);
            this.lvSimpleSearchResults.TabIndex = 27;
            this.lvSimpleSearchResults.UseCompatibleStateImageBehavior = false;
            this.lvSimpleSearchResults.View = System.Windows.Forms.View.Details;
            // 
            // btnSimpleSearchGentics
            // 
            this.btnSimpleSearchGentics.Location = new System.Drawing.Point(128, 113);
            this.btnSimpleSearchGentics.Name = "btnSimpleSearchGentics";
            this.btnSimpleSearchGentics.Size = new System.Drawing.Size(75, 23);
            this.btnSimpleSearchGentics.TabIndex = 26;
            this.btnSimpleSearchGentics.Text = "Genetics";
            this.btnSimpleSearchGentics.UseVisualStyleBackColor = true;
            // 
            // btSaveSimpleSearchSettings
            // 
            this.btSaveSimpleSearchSettings.Location = new System.Drawing.Point(235, 12);
            this.btSaveSimpleSearchSettings.Name = "btSaveSimpleSearchSettings";
            this.btSaveSimpleSearchSettings.Size = new System.Drawing.Size(75, 23);
            this.btSaveSimpleSearchSettings.TabIndex = 25;
            this.btSaveSimpleSearchSettings.Text = "Save";
            this.btSaveSimpleSearchSettings.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(12, 113);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 24;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // tbRepeats
            // 
            this.tbRepeats.Location = new System.Drawing.Point(114, 85);
            this.tbRepeats.Name = "tbRepeats";
            this.tbRepeats.Size = new System.Drawing.Size(43, 20);
            this.tbRepeats.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Repeats";
            // 
            // tbRateChange
            // 
            this.tbRateChange.Location = new System.Drawing.Point(114, 61);
            this.tbRateChange.Name = "tbRateChange";
            this.tbRateChange.Size = new System.Drawing.Size(43, 20);
            this.tbRateChange.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Rate Change:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "days";
            // 
            // tbFallSearchPeriod
            // 
            this.tbFallSearchPeriod.Location = new System.Drawing.Point(114, 35);
            this.tbFallSearchPeriod.Name = "tbFallSearchPeriod";
            this.tbFallSearchPeriod.Size = new System.Drawing.Size(43, 20);
            this.tbFallSearchPeriod.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fall Search Period:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "days";
            // 
            // tbRiseSearchPeriod
            // 
            this.tbRiseSearchPeriod.Location = new System.Drawing.Point(114, 9);
            this.tbRiseSearchPeriod.Name = "tbRiseSearchPeriod";
            this.tbRiseSearchPeriod.Size = new System.Drawing.Size(43, 20);
            this.tbRiseSearchPeriod.TabIndex = 15;
            // 
            // lbRiseSearchPeriod
            // 
            this.lbRiseSearchPeriod.AutoSize = true;
            this.lbRiseSearchPeriod.Location = new System.Drawing.Point(9, 12);
            this.lbRiseSearchPeriod.Name = "lbRiseSearchPeriod";
            this.lbRiseSearchPeriod.Size = new System.Drawing.Size(101, 13);
            this.lbRiseSearchPeriod.TabIndex = 14;
            this.lbRiseSearchPeriod.Text = "Rise Search Period:";
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
            this.tabPage3.Size = new System.Drawing.Size(666, 141);
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
            this.lvAllShares.Size = new System.Drawing.Size(433, 127);
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
            // cbSelectSymbol
            // 
            this.cbSelectSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectSymbol.FormattingEnabled = true;
            this.cbSelectSymbol.Location = new System.Drawing.Point(58, 3);
            this.cbSelectSymbol.Name = "cbSelectSymbol";
            this.cbSelectSymbol.Size = new System.Drawing.Size(121, 21);
            this.cbSelectSymbol.TabIndex = 20;
            this.cbSelectSymbol.SelectedIndexChanged += new System.EventHandler(this.cbSelectSymbol_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 449);
            this.Controls.Add(panel1);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvSplits;
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
        private System.Windows.Forms.Label lbPercentageDiffForSplit;
        private System.Windows.Forms.ListView lvSimpleSearchResults;
        private System.Windows.Forms.Button btnSimpleSearchGentics;
        private System.Windows.Forms.Button btSaveSimpleSearchSettings;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbRepeats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRateChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFallSearchPeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRiseSearchPeriod;
        private System.Windows.Forms.Label lbRiseSearchPeriod;
        private System.Windows.Forms.ComboBox cbGraphDisplay;
        private System.Windows.Forms.CheckBox cbSplitsShowOnGraph;
    }
}

