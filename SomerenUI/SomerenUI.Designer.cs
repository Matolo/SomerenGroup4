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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listOfActivitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitySupervisorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activityParticipantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            drinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            drinksSuppliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cashRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            revenueReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            vatCalculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            lblVatSelectYear = new System.Windows.Forms.Label();
            lblVatSelectQuarter = new System.Windows.Forms.Label();
            lblVatQuarterRuns = new System.Windows.Forms.Label();
            lblVatTotalVATLow = new System.Windows.Forms.Label();
            lblVatTotalVATHigh = new System.Windows.Forms.Label();
            lblVatTotalVAT = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            txtEndTime = new System.Windows.Forms.TextBox();
            txtStartTime = new System.Windows.Forms.TextBox();
            txtDate = new System.Windows.Forms.TextBox();
            txtActivityName = new System.Windows.Forms.TextBox();
            txtActivityId = new System.Windows.Forms.TextBox();
            btnUpdateActivity = new System.Windows.Forms.Button();
            btnDeleteActivity = new System.Windows.Forms.Button();
            btnAddActivity = new System.Windows.Forms.Button();
            btnDeleteDrink = new System.Windows.Forms.Button();
            btnAddDrink = new System.Windows.Forms.Button();
            pnlVat = new System.Windows.Forms.Panel();
            cbSelectYear = new System.Windows.Forms.ComboBox();
            cbSelectQuarter = new System.Windows.Forms.ComboBox();
            btnCalculateVat = new System.Windows.Forms.Button();
            pnlDrinks = new System.Windows.Forms.Panel();
            listViewDrinks = new System.Windows.Forms.ListView();
            tbDrinkId = new System.Windows.Forms.TextBox();
            tbDrinkName = new System.Windows.Forms.TextBox();
            tbPrice = new System.Windows.Forms.TextBox();
            tbIsAlcohol = new System.Windows.Forms.TextBox();
            tbStock = new System.Windows.Forms.TextBox();
            btnUpdateDrink = new System.Windows.Forms.Button();
            pnlActivitiesParticipants = new System.Windows.Forms.Panel();
            listViewActivitiesSimple = new System.Windows.Forms.ListView();
            label1 = new System.Windows.Forms.Label();
            pnlTeachers = new System.Windows.Forms.Panel();
            listViewTeachers = new System.Windows.Forms.ListView();
            pnlActivities = new System.Windows.Forms.Panel();
            listViewActivities = new System.Windows.Forms.ListView();
            listViewStudentSimple = new System.Windows.Forms.ListView();
            listViewDrinksSimple = new System.Windows.Forms.ListView();
            pnlRooms = new System.Windows.Forms.Panel();
            listViewRooms = new System.Windows.Forms.ListView();
            pnlCashRegister = new System.Windows.Forms.Panel();
            lblAmountToPay = new System.Windows.Forms.Label();
            btnCheckOut = new System.Windows.Forms.Button();
            listViewParticipants = new System.Windows.Forms.ListView();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlVat.SuspendLayout();
            pnlDrinks.SuspendLayout();
            pnlActivitiesParticipants.SuspendLayout();
            pnlTeachers.SuspendLayout();
            pnlActivities.SuspendLayout();
            pnlRooms.SuspendLayout();
            pnlCashRegister.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, drinksToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1374, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(202, 34);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { listOfActivitiesToolStripMenuItem, activitySupervisorsToolStripMenuItem, activityParticipantsToolStripMenuItem });
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            activitiesToolStripMenuItem.Text = "Activities";
            // 
            // listOfActivitiesToolStripMenuItem
            // 
            listOfActivitiesToolStripMenuItem.Name = "listOfActivitiesToolStripMenuItem";
            listOfActivitiesToolStripMenuItem.Size = new System.Drawing.Size(269, 34);
            listOfActivitiesToolStripMenuItem.Text = " List of Activities";
            listOfActivitiesToolStripMenuItem.Click += listOfActivitiesToolStripMenuItem_Click;
            // 
            // activitySupervisorsToolStripMenuItem
            // 
            activitySupervisorsToolStripMenuItem.Name = "activitySupervisorsToolStripMenuItem";
            activitySupervisorsToolStripMenuItem.Size = new System.Drawing.Size(269, 34);
            activitySupervisorsToolStripMenuItem.Text = "Activity Supervisors";
            // 
            // activityParticipantsToolStripMenuItem
            // 
            activityParticipantsToolStripMenuItem.Name = "activityParticipantsToolStripMenuItem";
            activityParticipantsToolStripMenuItem.Size = new System.Drawing.Size(269, 34);
            activityParticipantsToolStripMenuItem.Text = "Activity Participants";
            activityParticipantsToolStripMenuItem.Click += activityParticipantsToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // drinksToolStripMenuItem
            // 
            drinksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { drinksSuppliesToolStripMenuItem, cashRegisterToolStripMenuItem, revenueReportToolStripMenuItem, vatCalculationToolStripMenuItem });
            drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            drinksToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            drinksToolStripMenuItem.Text = "Drinks";
            // 
            // drinksSuppliesToolStripMenuItem
            // 
            drinksSuppliesToolStripMenuItem.Name = "drinksSuppliesToolStripMenuItem";
            drinksSuppliesToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            drinksSuppliesToolStripMenuItem.Text = "Drinks Supplies";
            drinksSuppliesToolStripMenuItem.Click += drinksSuppliesToolStripMenuItem_Click;
            // 
            // cashRegisterToolStripMenuItem
            // 
            cashRegisterToolStripMenuItem.Name = "cashRegisterToolStripMenuItem";
            cashRegisterToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            cashRegisterToolStripMenuItem.Text = "Cash Register";
            cashRegisterToolStripMenuItem.Click += cashRegisterToolStripMenuItem_Click;
            // 
            // revenueReportToolStripMenuItem
            // 
            revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            revenueReportToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            revenueReportToolStripMenuItem.Text = "Revenue Report";
            // 
            // vatCalculationToolStripMenuItem
            // 
            vatCalculationToolStripMenuItem.Name = "vatCalculationToolStripMenuItem";
            vatCalculationToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            vatCalculationToolStripMenuItem.Text = "VAT Calculation";
            vatCalculationToolStripMenuItem.Click += vatCalculationToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(18, 45);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1340, 778);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(19, 100);
            lblDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(313, 25);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // lblVatSelectYear
            // 
            lblVatSelectYear.AutoSize = true;
            lblVatSelectYear.Location = new System.Drawing.Point(19, 100);
            lblVatSelectYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVatSelectYear.Name = "lblVatSelectYear";
            lblVatSelectYear.Size = new System.Drawing.Size(104, 25);
            lblVatSelectYear.TabIndex = 6;
            lblVatSelectYear.Text = "Select Year: ";
            // 
            // lblVatSelectQuarter
            // 
            lblVatSelectQuarter.AutoSize = true;
            lblVatSelectQuarter.Location = new System.Drawing.Point(19, 138);
            lblVatSelectQuarter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVatSelectQuarter.Name = "lblVatSelectQuarter";
            lblVatSelectQuarter.Size = new System.Drawing.Size(265, 25);
            lblVatSelectQuarter.TabIndex = 6;
            lblVatSelectQuarter.Text = "Select Quarter (Q1, Q2, Q3, Q4):";
            // 
            // lblVatQuarterRuns
            // 
            lblVatQuarterRuns.AutoSize = true;
            lblVatQuarterRuns.Location = new System.Drawing.Point(19, 175);
            lblVatQuarterRuns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVatQuarterRuns.Name = "lblVatQuarterRuns";
            lblVatQuarterRuns.Size = new System.Drawing.Size(159, 25);
            lblVatQuarterRuns.TabIndex = 6;
            lblVatQuarterRuns.Text = "Quarter runs from:";
            // 
            // lblVatTotalVATLow
            // 
            lblVatTotalVATLow.AutoSize = true;
            lblVatTotalVATLow.Location = new System.Drawing.Point(19, 212);
            lblVatTotalVATLow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVatTotalVATLow.Name = "lblVatTotalVATLow";
            lblVatTotalVATLow.Size = new System.Drawing.Size(336, 25);
            lblVatTotalVATLow.TabIndex = 6;
            lblVatTotalVATLow.Text = "Total VAT(low tariff, 6%) amount payable:";
            // 
            // lblVatTotalVATHigh
            // 
            lblVatTotalVATHigh.AutoSize = true;
            lblVatTotalVATHigh.Location = new System.Drawing.Point(19, 250);
            lblVatTotalVATHigh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVatTotalVATHigh.Name = "lblVatTotalVATHigh";
            lblVatTotalVATHigh.Size = new System.Drawing.Size(353, 25);
            lblVatTotalVATHigh.TabIndex = 6;
            lblVatTotalVATHigh.Text = "Total VAT(high tariff, 21%) amount payable:";
            // 
            // lblVatTotalVAT
            // 
            lblVatTotalVAT.AutoSize = true;
            lblVatTotalVAT.Location = new System.Drawing.Point(19, 288);
            lblVatTotalVAT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVatTotalVAT.Name = "lblVatTotalVAT";
            lblVatTotalVAT.Size = new System.Drawing.Size(151, 25);
            lblVatTotalVAT.TabIndex = 6;
            lblVatTotalVAT.Text = "Total VAT amount";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Location = new System.Drawing.Point(18, 45);
            pnlStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1340, 778);
            pnlStudents.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.someren;
            pictureBox1.Location = new System.Drawing.Point(1150, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(186, 205);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new System.Drawing.Point(19, 52);
            listViewStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(1093, 509);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // txtEndTime
            // 
            txtEndTime.Location = new System.Drawing.Point(920, 665);
            txtEndTime.Name = "txtEndTime";
            txtEndTime.Size = new System.Drawing.Size(150, 31);
            txtEndTime.TabIndex = 10;
            // 
            // txtStartTime
            // 
            txtStartTime.Location = new System.Drawing.Point(727, 665);
            txtStartTime.Name = "txtStartTime";
            txtStartTime.Size = new System.Drawing.Size(150, 31);
            txtStartTime.TabIndex = 9;
            // 
            // txtDate
            // 
            txtDate.Location = new System.Drawing.Point(529, 664);
            txtDate.Name = "txtDate";
            txtDate.Size = new System.Drawing.Size(150, 31);
            txtDate.TabIndex = 8;
            // 
            // txtActivityName
            // 
            txtActivityName.Location = new System.Drawing.Point(328, 664);
            txtActivityName.Name = "txtActivityName";
            txtActivityName.Size = new System.Drawing.Size(150, 31);
            txtActivityName.TabIndex = 7;
            // 
            // txtActivityId
            // 
            txtActivityId.Location = new System.Drawing.Point(120, 664);
            txtActivityId.Name = "txtActivityId";
            txtActivityId.Size = new System.Drawing.Size(150, 31);
            txtActivityId.TabIndex = 6;
            // 
            // btnUpdateActivity
            // 
            btnUpdateActivity.Location = new System.Drawing.Point(920, 723);
            btnUpdateActivity.Name = "btnUpdateActivity";
            btnUpdateActivity.Size = new System.Drawing.Size(112, 34);
            btnUpdateActivity.TabIndex = 5;
            btnUpdateActivity.Text = "Update";
            btnUpdateActivity.UseVisualStyleBackColor = true;
            btnUpdateActivity.Click += btnUpdateActivity_Click;
            // 
            // btnDeleteActivity
            // 
            btnDeleteActivity.Location = new System.Drawing.Point(532, 723);
            btnDeleteActivity.Name = "btnDeleteActivity";
            btnDeleteActivity.Size = new System.Drawing.Size(112, 34);
            btnDeleteActivity.TabIndex = 8;
            btnDeleteActivity.Text = "Delete Activity";
            btnDeleteActivity.UseVisualStyleBackColor = true;
            btnDeleteActivity.Click += btnDeleteActivity_Click;
            // 
            // btnAddActivity
            // 
            btnAddActivity.Location = new System.Drawing.Point(120, 723);
            btnAddActivity.Name = "btnAddActivity";
            btnAddActivity.Size = new System.Drawing.Size(112, 34);
            btnAddActivity.TabIndex = 3;
            btnAddActivity.Text = "Add Activity";
            btnAddActivity.UseVisualStyleBackColor = true;
            btnAddActivity.Click += btnAddActivity_Click;
            // 
            // btnDeleteDrink
            // 
            btnDeleteDrink.Location = new System.Drawing.Point(220, 646);
            btnDeleteDrink.Name = "btnDeleteDrink";
            btnDeleteDrink.Size = new System.Drawing.Size(112, 34);
            btnDeleteDrink.TabIndex = 9;
            btnDeleteDrink.Text = "Delete Drink";
            btnDeleteDrink.UseVisualStyleBackColor = true;
            btnDeleteDrink.Click += BtnDeleteDrink_Click;
            // 
            // btnAddDrink
            // 
            btnAddDrink.Location = new System.Drawing.Point(64, 646);
            btnAddDrink.Name = "btnAddDrink";
            btnAddDrink.Size = new System.Drawing.Size(112, 34);
            btnAddDrink.TabIndex = 8;
            btnAddDrink.Text = "Add Drink";
            btnAddDrink.UseVisualStyleBackColor = true;
            btnAddDrink.Click += BtnAddDrink_Click;
            // 
            // pnlVat
            // 
            pnlVat.Controls.Add(lblVatSelectYear);
            pnlVat.Controls.Add(cbSelectYear);
            pnlVat.Controls.Add(lblVatSelectQuarter);
            pnlVat.Controls.Add(cbSelectQuarter);
            pnlVat.Controls.Add(lblVatQuarterRuns);
            pnlVat.Controls.Add(btnCalculateVat);
            pnlVat.Controls.Add(lblVatTotalVATLow);
            pnlVat.Controls.Add(lblVatTotalVATHigh);
            pnlVat.Controls.Add(lblVatTotalVAT);
            pnlVat.Location = new System.Drawing.Point(18, 45);
            pnlVat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlVat.Name = "pnlVat";
            pnlVat.Size = new System.Drawing.Size(1340, 778);
            pnlVat.TabIndex = 6;
            // 
            // cbSelectYear
            // 
            cbSelectYear.FormattingEnabled = true;
            cbSelectYear.Location = new System.Drawing.Point(583, 100);
            cbSelectYear.Name = "cbSelectYear";
            cbSelectYear.Size = new System.Drawing.Size(182, 33);
            cbSelectYear.TabIndex = 1;
            // 
            // cbSelectQuarter
            // 
            cbSelectQuarter.FormattingEnabled = true;
            cbSelectQuarter.Items.AddRange(new object[] { "Q1", "Q2", "Q3", "Q4" });
            cbSelectQuarter.Location = new System.Drawing.Point(583, 130);
            cbSelectQuarter.Name = "cbSelectQuarter";
            cbSelectQuarter.Size = new System.Drawing.Size(182, 33);
            cbSelectQuarter.TabIndex = 4;
            // 
            // btnCalculateVat
            // 
            btnCalculateVat.Location = new System.Drawing.Point(577, 662);
            btnCalculateVat.Name = "btnCalculateVat";
            btnCalculateVat.Size = new System.Drawing.Size(112, 34);
            btnCalculateVat.TabIndex = 3;
            btnCalculateVat.Text = "Calculate Vat";
            btnCalculateVat.UseVisualStyleBackColor = true;
            btnCalculateVat.Click += BtnCalculateVat_Click;
            // 
            // pnlDrinks
            // 
            pnlDrinks.Controls.Add(listViewDrinks);
            pnlDrinks.Controls.Add(tbDrinkId);
            pnlDrinks.Controls.Add(tbDrinkName);
            pnlDrinks.Controls.Add(tbPrice);
            pnlDrinks.Controls.Add(tbIsAlcohol);
            pnlDrinks.Controls.Add(tbStock);
            pnlDrinks.Controls.Add(btnAddDrink);
            pnlDrinks.Controls.Add(btnDeleteDrink);
            pnlDrinks.Controls.Add(btnUpdateDrink);
            pnlDrinks.Location = new System.Drawing.Point(18, 45);
            pnlDrinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlDrinks.Name = "pnlDrinks";
            pnlDrinks.Size = new System.Drawing.Size(1340, 778);
            pnlDrinks.TabIndex = 7;
            // 
            // listViewDrinks
            // 
            listViewDrinks.FullRowSelect = true;
            listViewDrinks.GridLines = true;
            listViewDrinks.Location = new System.Drawing.Point(19, 52);
            listViewDrinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewDrinks.Name = "listViewDrinks";
            listViewDrinks.Size = new System.Drawing.Size(1093, 509);
            listViewDrinks.TabIndex = 7;
            listViewDrinks.UseCompatibleStateImageBehavior = false;
            listViewDrinks.Click += listViewDrinks_Click;
            // 
            // tbDrinkId
            // 
            tbDrinkId.Location = new System.Drawing.Point(32, 579);
            tbDrinkId.Name = "tbDrinkId";
            tbDrinkId.PlaceholderText = "ID(e.g. 50)";
            tbDrinkId.Size = new System.Drawing.Size(150, 31);
            tbDrinkId.TabIndex = 3;
            // 
            // tbDrinkName
            // 
            tbDrinkName.Location = new System.Drawing.Point(205, 579);
            tbDrinkName.Name = "tbDrinkName";
            tbDrinkName.PlaceholderText = "Drink Name(Coca Cola)";
            tbDrinkName.Size = new System.Drawing.Size(150, 31);
            tbDrinkName.TabIndex = 4;
            // 
            // tbPrice
            // 
            tbPrice.Location = new System.Drawing.Point(377, 579);
            tbPrice.Name = "tbPrice";
            tbPrice.PlaceholderText = "Price(e.g. 50)";
            tbPrice.Size = new System.Drawing.Size(150, 31);
            tbPrice.TabIndex = 5;
            // 
            // tbIsAlcohol
            // 
            tbIsAlcohol.Location = new System.Drawing.Point(551, 579);
            tbIsAlcohol.Name = "tbIsAlcohol";
            tbIsAlcohol.PlaceholderText = "Is Alcoholic(e.g. 1)";
            tbIsAlcohol.Size = new System.Drawing.Size(150, 31);
            tbIsAlcohol.TabIndex = 6;
            // 
            // tbStock
            // 
            tbStock.Location = new System.Drawing.Point(727, 579);
            tbStock.Name = "tbStock";
            tbStock.PlaceholderText = "Stock(e.g. 50)";
            tbStock.Size = new System.Drawing.Size(150, 31);
            tbStock.TabIndex = 6;
            // 
            // btnUpdateDrink
            // 
            btnUpdateDrink.Location = new System.Drawing.Point(650, 650);
            btnUpdateDrink.Name = "btnUpdateDrink";
            btnUpdateDrink.Size = new System.Drawing.Size(112, 34);
            btnUpdateDrink.TabIndex = 10;
            btnUpdateDrink.Text = "Update Drink";
            btnUpdateDrink.UseVisualStyleBackColor = true;
            btnUpdateDrink.Click += btnUpdateDrink_Click;
            // 
            // pnlActivitiesParticipants
            // 
            pnlActivitiesParticipants.Controls.Add(listViewActivitiesSimple);
            pnlActivitiesParticipants.Controls.Add(listViewParticipants);
            pnlActivitiesParticipants.Location = new System.Drawing.Point(18, 45);
            pnlActivitiesParticipants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlActivitiesParticipants.Name = "pnlActivitiesParticipants";
            pnlActivitiesParticipants.Size = new System.Drawing.Size(1340, 778);
            pnlActivitiesParticipants.TabIndex = 5;
            pnlActivitiesParticipants.Click += PnlActivitiesParticipants_Click;
            // 
            // listViewActivitiesSimple
            // 
            listViewActivitiesSimple.FullRowSelect = true;
            listViewActivitiesSimple.GridLines = true;
            listViewActivitiesSimple.Location = new System.Drawing.Point(19, 52);
            listViewActivitiesSimple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewActivitiesSimple.Name = "listViewActivitiesSimple";
            listViewActivitiesSimple.Size = new System.Drawing.Size(1093, 250);
            listViewActivitiesSimple.TabIndex = 11;
            listViewActivitiesSimple.UseCompatibleStateImageBehavior = false;
            listViewActivitiesSimple.Click += ListViewActivitiesSimple_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(19, 12);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(157, 48);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlTeachers
            // 
            pnlTeachers.Controls.Add(listViewTeachers);
            pnlTeachers.Location = new System.Drawing.Point(18, 45);
            pnlTeachers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlTeachers.Name = "pnlTeachers";
            pnlTeachers.Size = new System.Drawing.Size(1340, 778);
            pnlTeachers.TabIndex = 3;
            // 
            // listViewTeachers
            // 
            listViewTeachers.Location = new System.Drawing.Point(19, 52);
            listViewTeachers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewTeachers.Name = "listViewTeachers";
            listViewTeachers.Size = new System.Drawing.Size(1093, 509);
            listViewTeachers.TabIndex = 3;
            listViewTeachers.UseCompatibleStateImageBehavior = false;
            // 
            // pnlActivities
            // 
            pnlActivities.Controls.Add(listViewActivities);
            pnlActivities.Controls.Add(txtActivityId);
            pnlActivities.Controls.Add(txtActivityName);
            pnlActivities.Controls.Add(txtStartTime);
            pnlActivities.Controls.Add(txtEndTime);
            pnlActivities.Controls.Add(txtDate);
            pnlActivities.Controls.Add(btnAddActivity);
            pnlActivities.Controls.Add(btnDeleteActivity);
            pnlActivities.Controls.Add(btnUpdateActivity);
            pnlActivities.Controls.Add(label1);
            pnlActivities.Location = new System.Drawing.Point(18, 45);
            pnlActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new System.Drawing.Size(1340, 778);
            pnlActivities.TabIndex = 4;
            // 
            // listViewActivities
            // 
            listViewActivities.FullRowSelect = true;
            listViewActivities.GridLines = true;
            listViewActivities.Location = new System.Drawing.Point(19, 52);
            listViewActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewActivities.Name = "listViewActivities";
            listViewActivities.Size = new System.Drawing.Size(1093, 509);
            listViewActivities.TabIndex = 7;
            listViewActivities.UseCompatibleStateImageBehavior = false;
            listViewActivities.Click += listViewActivities_Click;
            // 
            // listViewStudentSimple
            // 
            listViewStudentSimple.FullRowSelect = true;
            listViewStudentSimple.Location = new System.Drawing.Point(19, 52);
            listViewStudentSimple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewStudentSimple.Name = "listViewStudentSimple";
            listViewStudentSimple.Size = new System.Drawing.Size(1093, 250);
            listViewStudentSimple.TabIndex = 4;
            listViewStudentSimple.UseCompatibleStateImageBehavior = false;
            listViewStudentSimple.Click += ListViewStudentSimple_Click;
            // 
            // listViewDrinksSimple
            // 
            listViewDrinksSimple.FullRowSelect = true;
            listViewDrinksSimple.Location = new System.Drawing.Point(19, 300);
            listViewDrinksSimple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewDrinksSimple.Name = "listViewDrinksSimple";
            listViewDrinksSimple.Size = new System.Drawing.Size(1093, 250);
            listViewDrinksSimple.TabIndex = 4;
            listViewDrinksSimple.UseCompatibleStateImageBehavior = false;
            listViewDrinksSimple.Click += ListViewDrinksSimple_Click;
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Location = new System.Drawing.Point(18, 45);
            pnlRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1340, 778);
            pnlRooms.TabIndex = 5;
            // 
            // listViewRooms
            // 
            listViewRooms.Location = new System.Drawing.Point(19, 52);
            listViewRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(1093, 509);
            listViewRooms.TabIndex = 5;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            // 
            // pnlCashRegister
            // 
            pnlCashRegister.Controls.Add(listViewStudentSimple);
            pnlCashRegister.Controls.Add(listViewDrinksSimple);
            pnlCashRegister.Controls.Add(lblAmountToPay);
            pnlCashRegister.Controls.Add(btnCheckOut);
            pnlCashRegister.Location = new System.Drawing.Point(18, 45);
            pnlCashRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlCashRegister.Name = "pnlCashRegister";
            pnlCashRegister.Size = new System.Drawing.Size(1340, 778);
            pnlCashRegister.TabIndex = 5;
            // 
            // lblAmountToPay
            // 
            lblAmountToPay.AutoSize = true;
            lblAmountToPay.Location = new System.Drawing.Point(145, 636);
            lblAmountToPay.Name = "lblAmountToPay";
            lblAmountToPay.Size = new System.Drawing.Size(173, 25);
            lblAmountToPay.TabIndex = 4;
            lblAmountToPay.Text = "Amount to be paid: ";
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new System.Drawing.Point(456, 579);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new System.Drawing.Size(112, 34);
            btnCheckOut.TabIndex = 3;
            btnCheckOut.Text = "Checkout";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += BtnCheckOut_Click;
            // 
            // listViewParticipants
            // 
            listViewParticipants.FullRowSelect = true;
            listViewParticipants.GridLines = true;
            listViewParticipants.Location = new System.Drawing.Point(19, 300);
            listViewParticipants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewParticipants.Name = "listViewParticipants";
            listViewParticipants.Size = new System.Drawing.Size(1093, 250);
            listViewParticipants.TabIndex = 12;
            listViewParticipants.UseCompatibleStateImageBehavior = false;
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1374, 842);
            Controls.Add(pnlStudents);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlTeachers);
            Controls.Add(pnlActivities);
            Controls.Add(pnlRooms);
            Controls.Add(pnlDrinks);
            Controls.Add(pnlVat);
            Controls.Add(pnlCashRegister);
            Controls.Add(pnlActivitiesParticipants);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlVat.ResumeLayout(false);
            pnlVat.PerformLayout();
            pnlDrinks.ResumeLayout(false);
            pnlDrinks.PerformLayout();
            pnlActivitiesParticipants.ResumeLayout(false);
            pnlTeachers.ResumeLayout(false);
            pnlActivities.ResumeLayout(false);
            pnlActivities.PerformLayout();
            pnlRooms.ResumeLayout(false);
            pnlCashRegister.ResumeLayout(false);
            pnlCashRegister.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Panel pnlActivitiesParticipants;
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
        private System.Windows.Forms.ToolStripMenuItem activitySupervisorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityParticipantsToolStripMenuItem;
        private System.Windows.Forms.ListView listViewActivitiesSimple;
        private System.Windows.Forms.ListView listViewParticipants;
    }
}