using Microsoft.VisualBasic;
using SomerenDAL;
using System;
using System.Collections.Generic;

namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfActivitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinksSuppliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vatCalculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblVatSelectYear = new System.Windows.Forms.Label();
            this.lblVatSelectQuarter = new System.Windows.Forms.Label();
            this.lblVatQuarterRuns = new System.Windows.Forms.Label();
            this.lblVatTotalVATLow = new System.Windows.Forms.Label();
            this.lblVatTotalVATHigh = new System.Windows.Forms.Label();
            this.lblVatTotalVAT = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtActivityName = new System.Windows.Forms.TextBox();
            this.txtActivityId = new System.Windows.Forms.TextBox();
            this.btnUpdateActivity = new System.Windows.Forms.Button();
            this.btnDeleteActivity = new System.Windows.Forms.Button();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.btnDeleteDrink = new System.Windows.Forms.Button();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.pnlVat = new System.Windows.Forms.Panel();
            this.cbSelectYear = new System.Windows.Forms.ComboBox();
            this.cbSelectQuarter = new System.Windows.Forms.ComboBox();
            this.btnCalculateVat = new System.Windows.Forms.Button();
            this.pnlDrinks = new System.Windows.Forms.Panel();
            this.listViewDrinks = new System.Windows.Forms.ListView();
            this.tbDrinkId = new System.Windows.Forms.TextBox();
            this.tbDrinkName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbIsAlcohol = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.btnUpdateDrink = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTeachers = new System.Windows.Forms.Panel();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.pnlActivities = new System.Windows.Forms.Panel();
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.listViewStudentSimple = new System.Windows.Forms.ListView();
            this.listViewDrinksSimple = new System.Windows.Forms.ListView();
            this.pnlRooms = new System.Windows.Forms.Panel();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.pnlCashRegister = new System.Windows.Forms.Panel();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlVat.SuspendLayout();
            this.pnlDrinks.SuspendLayout();
            this.pnlTeachers.SuspendLayout();
            this.pnlActivities.SuspendLayout();
            this.pnlRooms.SuspendLayout();
            this.pnlCashRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.drinksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1374, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(202, 34);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.lecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfActivitiesToolStripMenuItem});
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // listOfActivitiesToolStripMenuItem
            // 
            this.listOfActivitiesToolStripMenuItem.Name = "listOfActivitiesToolStripMenuItem";
            this.listOfActivitiesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.listOfActivitiesToolStripMenuItem.Text = " List of Activities";
            this.listOfActivitiesToolStripMenuItem.Click += new System.EventHandler(this.listOfActivitiesToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // drinksToolStripMenuItem
            // 
            this.drinksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drinksSuppliesToolStripMenuItem,
            this.cashRegisterToolStripMenuItem,
            this.revenueReportToolStripMenuItem,
            this.vatCalculationToolStripMenuItem});
            this.drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            this.drinksToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.drinksToolStripMenuItem.Text = "Drinks";
            // 
            // drinksSuppliesToolStripMenuItem
            // 
            this.drinksSuppliesToolStripMenuItem.Name = "drinksSuppliesToolStripMenuItem";
            this.drinksSuppliesToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.drinksSuppliesToolStripMenuItem.Text = "Drinks Supplies";
            this.drinksSuppliesToolStripMenuItem.Click += new System.EventHandler(this.drinksSuppliesToolStripMenuItem_Click);
            // 
            // cashRegisterToolStripMenuItem
            // 
            this.cashRegisterToolStripMenuItem.Name = "cashRegisterToolStripMenuItem";
            this.cashRegisterToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.cashRegisterToolStripMenuItem.Text = "Cash Register";
            this.cashRegisterToolStripMenuItem.Click += new System.EventHandler(this.cashRegisterToolStripMenuItem_Click);
            // 
            // revenueReportToolStripMenuItem
            // 
            this.revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            this.revenueReportToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.revenueReportToolStripMenuItem.Text = "Revenue Report";
            // 
            // vatCalculationToolStripMenuItem
            // 
            this.vatCalculationToolStripMenuItem.Name = "vatCalculationToolStripMenuItem";
            this.vatCalculationToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.vatCalculationToolStripMenuItem.Text = "VAT Calculation";
            this.vatCalculationToolStripMenuItem.Click += new System.EventHandler(this.vatCalculationToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lblDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(18, 45);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1340, 778);
            this.pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Location = new System.Drawing.Point(19, 100);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(313, 25);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // lblVatSelectYear
            // 
            this.lblVatSelectYear.AutoSize = true;
            this.lblVatSelectYear.Location = new System.Drawing.Point(19, 100);
            this.lblVatSelectYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVatSelectYear.Name = "lblVatSelectYear";
            this.lblVatSelectYear.Size = new System.Drawing.Size(104, 25);
            this.lblVatSelectYear.TabIndex = 6;
            this.lblVatSelectYear.Text = "Select Year: ";
            // 
            // lblVatSelectQuarter
            // 
            this.lblVatSelectQuarter.AutoSize = true;
            this.lblVatSelectQuarter.Location = new System.Drawing.Point(19, 138);
            this.lblVatSelectQuarter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVatSelectQuarter.Name = "lblVatSelectQuarter";
            this.lblVatSelectQuarter.Size = new System.Drawing.Size(265, 25);
            this.lblVatSelectQuarter.TabIndex = 6;
            this.lblVatSelectQuarter.Text = "Select Quarter (Q1, Q2, Q3, Q4):";
            // 
            // lblVatQuarterRuns
            // 
            this.lblVatQuarterRuns.AutoSize = true;
            this.lblVatQuarterRuns.Location = new System.Drawing.Point(19, 175);
            this.lblVatQuarterRuns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVatQuarterRuns.Name = "lblVatQuarterRuns";
            this.lblVatQuarterRuns.Size = new System.Drawing.Size(159, 25);
            this.lblVatQuarterRuns.TabIndex = 6;
            this.lblVatQuarterRuns.Text = "Quarter runs from:";
            // 
            // lblVatTotalVATLow
            // 
            this.lblVatTotalVATLow.AutoSize = true;
            this.lblVatTotalVATLow.Location = new System.Drawing.Point(19, 212);
            this.lblVatTotalVATLow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVatTotalVATLow.Name = "lblVatTotalVATLow";
            this.lblVatTotalVATLow.Size = new System.Drawing.Size(336, 25);
            this.lblVatTotalVATLow.TabIndex = 6;
            this.lblVatTotalVATLow.Text = "Total VAT(low tariff, 6%) amount payable:";
            // 
            // lblVatTotalVATHigh
            // 
            this.lblVatTotalVATHigh.AutoSize = true;
            this.lblVatTotalVATHigh.Location = new System.Drawing.Point(19, 250);
            this.lblVatTotalVATHigh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVatTotalVATHigh.Name = "lblVatTotalVATHigh";
            this.lblVatTotalVATHigh.Size = new System.Drawing.Size(353, 25);
            this.lblVatTotalVATHigh.TabIndex = 6;
            this.lblVatTotalVATHigh.Text = "Total VAT(high tariff, 21%) amount payable:";
            // 
            // lblVatTotalVAT
            // 
            this.lblVatTotalVAT.AutoSize = true;
            this.lblVatTotalVAT.Location = new System.Drawing.Point(19, 288);
            this.lblVatTotalVAT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVatTotalVAT.Name = "lblVatTotalVAT";
            this.lblVatTotalVAT.Size = new System.Drawing.Size(151, 25);
            this.lblVatTotalVAT.TabIndex = 6;
            this.lblVatTotalVAT.Text = "Total VAT amount";
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.pictureBox1);
            this.pnlStudents.Controls.Add(this.listViewStudents);
            this.pnlStudents.Location = new System.Drawing.Point(18, 45);
            this.pnlStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(1340, 778);
            this.pnlStudents.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.Location = new System.Drawing.Point(1150, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 205);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Location = new System.Drawing.Point(19, 52);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(1093, 509);
            this.listViewStudents.TabIndex = 1;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(920, 665);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(150, 31);
            this.txtEndTime.TabIndex = 10;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(727, 665);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(150, 31);
            this.txtStartTime.TabIndex = 9;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(529, 664);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(150, 31);
            this.txtDate.TabIndex = 8;
            // 
            // txtActivityName
            // 
            this.txtActivityName.Location = new System.Drawing.Point(328, 664);
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.Size = new System.Drawing.Size(150, 31);
            this.txtActivityName.TabIndex = 7;
            // 
            // txtActivityId
            // 
            this.txtActivityId.Location = new System.Drawing.Point(120, 664);
            this.txtActivityId.Name = "txtActivityId";
            this.txtActivityId.Size = new System.Drawing.Size(150, 31);
            this.txtActivityId.TabIndex = 6;
            // 
            // btnUpdateActivity
            // 
            this.btnUpdateActivity.Location = new System.Drawing.Point(920, 723);
            this.btnUpdateActivity.Name = "btnUpdateActivity";
            this.btnUpdateActivity.Size = new System.Drawing.Size(112, 34);
            this.btnUpdateActivity.TabIndex = 5;
            this.btnUpdateActivity.Text = "Update";
            this.btnUpdateActivity.UseVisualStyleBackColor = true;
            this.btnUpdateActivity.Click += btnUpdateActivity_Click;
            // 
            // btnDeleteActivity
            // 
            this.btnDeleteActivity.Location = new System.Drawing.Point(532, 723);
            this.btnDeleteActivity.Name = "btnDeleteActivity";
            this.btnDeleteActivity.Size = new System.Drawing.Size(112, 34);
            this.btnDeleteActivity.TabIndex = 8;
            this.btnDeleteActivity.Text = "Delete Activity";
            this.btnDeleteActivity.UseVisualStyleBackColor = true;
            this.btnDeleteActivity.Click += btnDeleteActivity_Click;
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Location = new System.Drawing.Point(120, 723);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(112, 34);
            this.btnAddActivity.TabIndex = 3;
            this.btnAddActivity.Text = "Add Activity";
            this.btnAddActivity.UseVisualStyleBackColor = true;
            this.btnAddActivity.Click += btnAddActivity_Click;
            // 
            // btnDeleteDrink
            // 
            this.btnDeleteDrink.Location = new System.Drawing.Point(220, 646);
            this.btnDeleteDrink.Name = "btnDeleteDrink";
            this.btnDeleteDrink.Size = new System.Drawing.Size(112, 34);
            this.btnDeleteDrink.TabIndex = 9;
            this.btnDeleteDrink.Text = "Delete Drink";
            this.btnDeleteDrink.UseVisualStyleBackColor = true;
            this.btnDeleteDrink.Click += BtnDeleteDrink_Click;
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Location = new System.Drawing.Point(64, 646);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(112, 34);
            this.btnAddDrink.TabIndex = 8;
            this.btnAddDrink.Text = "Add Drink";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            this.btnAddDrink.Click += BtnAddDrink_Click;
            // 
            // pnlVat
            // 
            this.pnlVat.Controls.Add(this.lblVatSelectYear);
            this.pnlVat.Controls.Add(this.cbSelectYear);
            this.pnlVat.Controls.Add(this.lblVatSelectQuarter);
            this.pnlVat.Controls.Add(this.cbSelectQuarter);
            this.pnlVat.Controls.Add(this.lblVatQuarterRuns);
            this.pnlVat.Controls.Add(this.btnCalculateVat);
            this.pnlVat.Controls.Add(this.lblVatTotalVATLow);
            this.pnlVat.Controls.Add(this.lblVatTotalVATHigh);
            this.pnlVat.Controls.Add(this.lblVatTotalVAT);
            this.pnlVat.Location = new System.Drawing.Point(18, 45);
            this.pnlVat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlVat.Name = "pnlVat";
            this.pnlVat.Size = new System.Drawing.Size(1340, 778);
            this.pnlVat.TabIndex = 6;
            // 
            // cbSelectYear
            // 
            this.cbSelectYear.FormattingEnabled = true;
            this.cbSelectYear.Location = new System.Drawing.Point(583, 100);
            this.cbSelectYear.Name = "cbSelectYear";
            this.cbSelectYear.Size = new System.Drawing.Size(182, 33);
            this.cbSelectYear.TabIndex = 1;
            // 
            // cbSelectQuarter
            // 
            this.cbSelectQuarter.FormattingEnabled = true;
            this.cbSelectQuarter.Items.AddRange(new object[] {
            "Q1",
            "Q2",
            "Q3",
            "Q4"});
            this.cbSelectQuarter.Location = new System.Drawing.Point(583, 130);
            this.cbSelectQuarter.Name = "cbSelectQuarter";
            this.cbSelectQuarter.Size = new System.Drawing.Size(182, 33);
            this.cbSelectQuarter.TabIndex = 4;
            // 
            // btnCalculateVat
            // 
            this.btnCalculateVat.Location = new System.Drawing.Point(577, 662);
            this.btnCalculateVat.Name = "btnCalculateVat";
            this.btnCalculateVat.Size = new System.Drawing.Size(112, 34);
            this.btnCalculateVat.TabIndex = 3;
            this.btnCalculateVat.Text = "Calculate Vat";
            this.btnCalculateVat.UseVisualStyleBackColor = true;
            this.btnCalculateVat.Click += BtnCalculateVat_Click;
            // 
            // pnlDrinks
            // 
            this.pnlDrinks.Controls.Add(this.listViewDrinks);
            this.pnlDrinks.Controls.Add(this.tbDrinkId);
            this.pnlDrinks.Controls.Add(this.tbDrinkName);
            this.pnlDrinks.Controls.Add(this.tbPrice);
            this.pnlDrinks.Controls.Add(this.tbIsAlcohol);
            this.pnlDrinks.Controls.Add(this.tbStock);
            this.pnlDrinks.Controls.Add(this.btnAddDrink);
            this.pnlDrinks.Controls.Add(this.btnDeleteDrink);
            this.pnlDrinks.Controls.Add(this.btnUpdateDrink);
            this.pnlDrinks.Location = new System.Drawing.Point(18, 45);
            this.pnlDrinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDrinks.Name = "pnlDrinks";
            this.pnlDrinks.Size = new System.Drawing.Size(1340, 778);
            this.pnlDrinks.TabIndex = 7;
            // 
            // listViewDrinks
            // 
            this.listViewDrinks.FullRowSelect = true;
            this.listViewDrinks.GridLines = true;
            this.listViewDrinks.Location = new System.Drawing.Point(19, 52);
            this.listViewDrinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewDrinks.Name = "listViewDrinks";
            this.listViewDrinks.Size = new System.Drawing.Size(1093, 509);
            this.listViewDrinks.TabIndex = 7;
            this.listViewDrinks.UseCompatibleStateImageBehavior = false;
            this.listViewDrinks.Click += listViewDrinks_Click;
            // 
            // tbDrinkId
            // 
            this.tbDrinkId.Location = new System.Drawing.Point(32, 579);
            this.tbDrinkId.Name = "tbDrinkId";
            this.tbDrinkId.PlaceholderText = "ID(e.g. 50)";
            this.tbDrinkId.Size = new System.Drawing.Size(150, 31);
            this.tbDrinkId.TabIndex = 3;
            // 
            // tbDrinkName
            // 
            this.tbDrinkName.Location = new System.Drawing.Point(205, 579);
            this.tbDrinkName.Name = "tbDrinkName";
            this.tbDrinkName.PlaceholderText = "Drink Name(Coca Cola)";
            this.tbDrinkName.Size = new System.Drawing.Size(150, 31);
            this.tbDrinkName.TabIndex = 4;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(377, 579);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PlaceholderText = "Price(e.g. 50)";
            this.tbPrice.Size = new System.Drawing.Size(150, 31);
            this.tbPrice.TabIndex = 5;
            // 
            // tbIsAlcohol
            // 
            this.tbIsAlcohol.Location = new System.Drawing.Point(551, 579);
            this.tbIsAlcohol.Name = "tbIsAlcohol";
            this.tbIsAlcohol.PlaceholderText = "Is Alcoholic(e.g. 1)";
            this.tbIsAlcohol.Size = new System.Drawing.Size(150, 31);
            this.tbIsAlcohol.TabIndex = 6;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(727, 579);
            this.tbStock.Name = "tbStock";
            this.tbStock.PlaceholderText = "Stock(e.g. 50)";
            this.tbStock.Size = new System.Drawing.Size(150, 31);
            this.tbStock.TabIndex = 6;
            // 
            // btnUpdateDrink
            // 
            this.btnUpdateDrink.Location = new System.Drawing.Point(650, 650);
            this.btnUpdateDrink.Name = "btnUpdateDrink";
            this.btnUpdateDrink.Size = new System.Drawing.Size(112, 34);
            this.btnUpdateDrink.TabIndex = 10;
            this.btnUpdateDrink.Text = "Update Drink";
            this.btnUpdateDrink.UseVisualStyleBackColor = true;
            this.btnUpdateDrink.Click += btnUpdateDrink_Click;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students";
            // 
            // pnlTeachers
            // 
            this.pnlTeachers.Controls.Add(this.listViewTeachers);
            this.pnlTeachers.Location = new System.Drawing.Point(18, 45);
            this.pnlTeachers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTeachers.Name = "pnlTeachers";
            this.pnlTeachers.Size = new System.Drawing.Size(1340, 778);
            this.pnlTeachers.TabIndex = 3;
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.Location = new System.Drawing.Point(19, 52);
            this.listViewTeachers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(1093, 509);
            this.listViewTeachers.TabIndex = 3;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            // 
            // pnlActivities
            // 
            this.pnlActivities.Controls.Add(this.listViewActivities);
            this.pnlActivities.Controls.Add(this.txtActivityId);
            this.pnlActivities.Controls.Add(this.txtActivityName);
            this.pnlActivities.Controls.Add(this.txtStartTime);
            this.pnlActivities.Controls.Add(this.txtEndTime);
            this.pnlActivities.Controls.Add(this.txtDate);
            this.pnlActivities.Controls.Add(this.btnAddActivity);
            this.pnlActivities.Controls.Add(this.btnDeleteActivity);
            this.pnlActivities.Controls.Add(this.btnUpdateActivity);
            this.pnlActivities.Controls.Add(this.label1);
            this.pnlActivities.Location = new System.Drawing.Point(18, 45);
            this.pnlActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlActivities.Name = "pnlActivities";
            this.pnlActivities.Size = new System.Drawing.Size(1340, 778);
            this.pnlActivities.TabIndex = 4;
            // 
            // listViewActivities
            // 
            this.listViewActivities.FullRowSelect = true;
            this.listViewActivities.GridLines = true;
            this.listViewActivities.Location = new System.Drawing.Point(19, 52);
            this.listViewActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(1093, 509);
            this.listViewActivities.TabIndex = 7;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.Click += listViewActivities_Click;
            // 
            // listViewStudentSimple
            // 
            this.listViewStudentSimple.FullRowSelect = true;
            this.listViewStudentSimple.Location = new System.Drawing.Point(19, 52);
            this.listViewStudentSimple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewStudentSimple.Name = "listViewStudentSimple";
            this.listViewStudentSimple.Size = new System.Drawing.Size(1093, 250);
            this.listViewStudentSimple.TabIndex = 4;
            this.listViewStudentSimple.UseCompatibleStateImageBehavior = false;
            this.listViewStudentSimple.Click += ListViewStudentSimple_Click;
            // 
            // listViewDrinksSimple
            // 
            this.listViewDrinksSimple.FullRowSelect = true;
            this.listViewDrinksSimple.Location = new System.Drawing.Point(19, 300);
            this.listViewDrinksSimple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewDrinksSimple.Name = "listViewDrinksSimple";
            this.listViewDrinksSimple.Size = new System.Drawing.Size(1093, 250);
            this.listViewDrinksSimple.TabIndex = 4;
            this.listViewDrinksSimple.UseCompatibleStateImageBehavior = false;
            this.listViewDrinksSimple.Click += ListViewDrinksSimple_Click;
            // 
            // pnlRooms
            // 
            this.pnlRooms.Controls.Add(this.listViewRooms);
            this.pnlRooms.Location = new System.Drawing.Point(18, 45);
            this.pnlRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlRooms.Name = "pnlRooms";
            this.pnlRooms.Size = new System.Drawing.Size(1340, 778);
            this.pnlRooms.TabIndex = 5;
            // 
            // listViewRooms
            // 
            this.listViewRooms.Location = new System.Drawing.Point(19, 52);
            this.listViewRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(1093, 509);
            this.listViewRooms.TabIndex = 5;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            // 
            // pnlCashRegister
            // 
            this.pnlCashRegister.Controls.Add(this.listViewStudentSimple);
            this.pnlCashRegister.Controls.Add(this.listViewDrinksSimple);
            this.pnlCashRegister.Controls.Add(this.lblAmountToPay);
            this.pnlCashRegister.Controls.Add(this.btnCheckOut);
            this.pnlCashRegister.Location = new System.Drawing.Point(18, 45);
            this.pnlCashRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCashRegister.Name = "pnlCashRegister";
            this.pnlCashRegister.Size = new System.Drawing.Size(1340, 778);
            this.pnlCashRegister.TabIndex = 5;
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Location = new System.Drawing.Point(145, 636);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(173, 25);
            this.lblAmountToPay.TabIndex = 4;
            this.lblAmountToPay.Text = "Amount to be paid: ";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(456, 579);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(112, 34);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Checkout";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += BtnCheckOut_Click;
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 842);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlTeachers);
            this.Controls.Add(this.pnlActivities);
            this.Controls.Add(this.pnlRooms);
            this.Controls.Add(this.pnlDrinks);
            this.Controls.Add(this.pnlVat);
            this.Controls.Add(this.pnlCashRegister);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SomerenUI";
            this.Text = "SomerenApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlVat.ResumeLayout(false);
            this.pnlVat.PerformLayout();
            this.pnlDrinks.ResumeLayout(false);
            this.pnlDrinks.PerformLayout();
            this.pnlTeachers.ResumeLayout(false);
            this.pnlActivities.ResumeLayout(false);
            this.pnlActivities.PerformLayout();
            this.pnlRooms.ResumeLayout(false);
            this.pnlCashRegister.ResumeLayout(false);
            this.pnlCashRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblVatSelectYear;
        private System.Windows.Forms.Label lblVatSelectQuarter;
        private System.Windows.Forms.Label lblVatQuarterRuns;
        private System.Windows.Forms.Label lblVatTotalVATLow;
        private System.Windows.Forms.Label lblVatTotalVATHigh;
        private System.Windows.Forms.Label lblVatTotalVAT;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Panel pnlVat;
        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.Panel pnlActivities;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.Panel pnlCashRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.ListView listViewStudentSimple;
        private System.Windows.Forms.ListView listViewDrinksSimple;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem drinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinksSuppliesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vatCalculationToolStripMenuItem;
        private System.Windows.Forms.Button btnDeleteDrink;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbIsAlcohol;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbDrinkName;
        private System.Windows.Forms.TextBox tbDrinkId;
        private System.Windows.Forms.Button btnUpdateDrink;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.ComboBox cbSelectYear;
        private System.Windows.Forms.ComboBox cbSelectQuarter;
        private System.Windows.Forms.Button btnCalculateVat;
        private System.Windows.Forms.ToolStripMenuItem listOfActivitiesToolStripMenuItem;
        private System.Windows.Forms.Button btnUpdateActivity;
        private System.Windows.Forms.Button btnDeleteActivity;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtActivityName;
        private System.Windows.Forms.TextBox txtActivityId;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.TextBox txtStartTime;
    }
}