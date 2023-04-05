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
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitySupervisorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlVat.SuspendLayout();
            pnlDrinks.SuspendLayout();
            pnlTeachers.SuspendLayout();
            pnlActivities.SuspendLayout();
            pnlRooms.SuspendLayout();
            pnlCashRegister.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, activitiesToolStripMenuItem, lecturersToolStripMenuItem, roomsToolStripMenuItem, drinksToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1099, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { activitySupervisorsToolStripMenuItem });
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // activitySupervisorsToolStripMenuItem
            // 
            activitySupervisorsToolStripMenuItem.Name = "activitySupervisorsToolStripMenuItem";
            activitySupervisorsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            activitySupervisorsToolStripMenuItem.Text = "Activity Supervisor";
            activitySupervisorsToolStripMenuItem.Click += activitySupervisorsToolStripMenuItem_Click_1;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // drinksToolStripMenuItem
            // 
            drinksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { drinksSuppliesToolStripMenuItem, cashRegisterToolStripMenuItem, revenueReportToolStripMenuItem, vatCalculationToolStripMenuItem });
            drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            drinksToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            drinksToolStripMenuItem.Text = "Drinks";
            // 
            // drinksSuppliesToolStripMenuItem
            // 
            drinksSuppliesToolStripMenuItem.Name = "drinksSuppliesToolStripMenuItem";
            drinksSuppliesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            drinksSuppliesToolStripMenuItem.Text = "Drinks Supplies";
            drinksSuppliesToolStripMenuItem.Click += drinksSuppliesToolStripMenuItem_Click;
            // 
            // cashRegisterToolStripMenuItem
            // 
            cashRegisterToolStripMenuItem.Name = "cashRegisterToolStripMenuItem";
            cashRegisterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            cashRegisterToolStripMenuItem.Text = "Cash Register";
            cashRegisterToolStripMenuItem.Click += cashRegisterToolStripMenuItem_Click;
            // 
            // revenueReportToolStripMenuItem
            // 
            revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            revenueReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            revenueReportToolStripMenuItem.Text = "Revenue Report";
            revenueReportToolStripMenuItem.Click += revenueReportToolStripMenuItem_Click;
            // 
            // vatCalculationToolStripMenuItem
            // 
            vatCalculationToolStripMenuItem.Name = "vatCalculationToolStripMenuItem";
            vatCalculationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            vatCalculationToolStripMenuItem.Text = "VAT Calculation";
            vatCalculationToolStripMenuItem.Click += vatCalculationToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(14, 36);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1072, 622);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(15, 80);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(262, 20);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // lblVatSelectYear
            // 
            lblVatSelectYear.AutoSize = true;
            lblVatSelectYear.Location = new System.Drawing.Point(15, 80);
            lblVatSelectYear.Name = "lblVatSelectYear";
            lblVatSelectYear.Size = new System.Drawing.Size(88, 20);
            lblVatSelectYear.TabIndex = 6;
            lblVatSelectYear.Text = "Select Year: ";
            // 
            // lblVatSelectQuarter
            // 
            lblVatSelectQuarter.AutoSize = true;
            lblVatSelectQuarter.Location = new System.Drawing.Point(15, 110);
            lblVatSelectQuarter.Name = "lblVatSelectQuarter";
            lblVatSelectQuarter.Size = new System.Drawing.Size(217, 20);
            lblVatSelectQuarter.TabIndex = 6;
            lblVatSelectQuarter.Text = "Select Quarter (Q1, Q2, Q3, Q4):";
            // 
            // lblVatQuarterRuns
            // 
            lblVatQuarterRuns.AutoSize = true;
            lblVatQuarterRuns.Location = new System.Drawing.Point(15, 140);
            lblVatQuarterRuns.Name = "lblVatQuarterRuns";
            lblVatQuarterRuns.Size = new System.Drawing.Size(129, 20);
            lblVatQuarterRuns.TabIndex = 6;
            lblVatQuarterRuns.Text = "Quarter runs from:";
            // 
            // lblVatTotalVATLow
            // 
            lblVatTotalVATLow.AutoSize = true;
            lblVatTotalVATLow.Location = new System.Drawing.Point(15, 170);
            lblVatTotalVATLow.Name = "lblVatTotalVATLow";
            lblVatTotalVATLow.Size = new System.Drawing.Size(283, 20);
            lblVatTotalVATLow.TabIndex = 6;
            lblVatTotalVATLow.Text = "Total VAT(low tariff, 6%) amount payable:";
            // 
            // lblVatTotalVATHigh
            // 
            lblVatTotalVATHigh.AutoSize = true;
            lblVatTotalVATHigh.Location = new System.Drawing.Point(15, 200);
            lblVatTotalVATHigh.Name = "lblVatTotalVATHigh";
            lblVatTotalVATHigh.Size = new System.Drawing.Size(296, 20);
            lblVatTotalVATHigh.TabIndex = 6;
            lblVatTotalVATHigh.Text = "Total VAT(high tariff, 21%) amount payable:";
            // 
            // lblVatTotalVAT
            // 
            lblVatTotalVAT.AutoSize = true;
            lblVatTotalVAT.Location = new System.Drawing.Point(15, 230);
            lblVatTotalVAT.Name = "lblVatTotalVAT";
            lblVatTotalVAT.Size = new System.Drawing.Size(126, 20);
            lblVatTotalVAT.TabIndex = 6;
            lblVatTotalVAT.Text = "Total VAT amount";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Location = new System.Drawing.Point(14, 36);
            pnlStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1072, 622);
            pnlStudents.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.someren;
            pictureBox1.Location = new System.Drawing.Point(920, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(149, 164);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new System.Drawing.Point(15, 42);
            listViewStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(875, 408);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // btnDeleteDrink
            // 
            btnDeleteDrink.Location = new System.Drawing.Point(176, 517);
            btnDeleteDrink.Margin = new System.Windows.Forms.Padding(2);
            btnDeleteDrink.Name = "btnDeleteDrink";
            btnDeleteDrink.Size = new System.Drawing.Size(90, 27);
            btnDeleteDrink.TabIndex = 9;
            btnDeleteDrink.Text = "Delete Drink";
            btnDeleteDrink.UseVisualStyleBackColor = true;
            btnDeleteDrink.Click += BtnDeleteDrink_Click;
            // 
            // btnAddDrink
            // 
            btnAddDrink.Location = new System.Drawing.Point(51, 517);
            btnAddDrink.Margin = new System.Windows.Forms.Padding(2);
            btnAddDrink.Name = "btnAddDrink";
            btnAddDrink.Size = new System.Drawing.Size(90, 27);
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
            pnlVat.Location = new System.Drawing.Point(14, 36);
            pnlVat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlVat.Name = "pnlVat";
            pnlVat.Size = new System.Drawing.Size(1072, 622);
            pnlVat.TabIndex = 6;
            // 
            // cbSelectYear
            // 
            cbSelectYear.FormattingEnabled = true;
            cbSelectYear.Location = new System.Drawing.Point(466, 80);
            cbSelectYear.Margin = new System.Windows.Forms.Padding(2);
            cbSelectYear.Name = "cbSelectYear";
            cbSelectYear.Size = new System.Drawing.Size(146, 28);
            cbSelectYear.TabIndex = 3;
            // 
            // cbSelectQuarter
            // 
            cbSelectQuarter.FormattingEnabled = true;
            cbSelectQuarter.Items.AddRange(new object[] { "Q1", "Q2", "Q3", "Q4" });
            cbSelectQuarter.Location = new System.Drawing.Point(466, 104);
            cbSelectQuarter.Margin = new System.Windows.Forms.Padding(2);
            cbSelectQuarter.Name = "cbSelectQuarter";
            cbSelectQuarter.Size = new System.Drawing.Size(146, 28);
            cbSelectQuarter.TabIndex = 4;
            // 
            // btnCalculateVat
            // 
            btnCalculateVat.Location = new System.Drawing.Point(462, 530);
            btnCalculateVat.Margin = new System.Windows.Forms.Padding(2);
            btnCalculateVat.Name = "btnCalculateVat";
            btnCalculateVat.Size = new System.Drawing.Size(90, 27);
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
            pnlDrinks.Location = new System.Drawing.Point(14, 36);
            pnlDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDrinks.Name = "pnlDrinks";
            pnlDrinks.Size = new System.Drawing.Size(1072, 622);
            pnlDrinks.TabIndex = 7;
            // 
            // listViewDrinks
            // 
            listViewDrinks.FullRowSelect = true;
            listViewDrinks.GridLines = true;
            listViewDrinks.Location = new System.Drawing.Point(15, 42);
            listViewDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewDrinks.Name = "listViewDrinks";
            listViewDrinks.Size = new System.Drawing.Size(875, 408);
            listViewDrinks.TabIndex = 7;
            listViewDrinks.UseCompatibleStateImageBehavior = false;
            listViewDrinks.Click += listViewDrinks_Click;
            // 
            // tbDrinkId
            // 
            tbDrinkId.Location = new System.Drawing.Point(26, 463);
            tbDrinkId.Margin = new System.Windows.Forms.Padding(2);
            tbDrinkId.Name = "tbDrinkId";
            tbDrinkId.PlaceholderText = "ID(e.g. 50)";
            tbDrinkId.Size = new System.Drawing.Size(121, 27);
            tbDrinkId.TabIndex = 3;
            // 
            // tbDrinkName
            // 
            tbDrinkName.Location = new System.Drawing.Point(164, 463);
            tbDrinkName.Margin = new System.Windows.Forms.Padding(2);
            tbDrinkName.Name = "tbDrinkName";
            tbDrinkName.PlaceholderText = "Drink Name(Coca Cola)";
            tbDrinkName.Size = new System.Drawing.Size(121, 27);
            tbDrinkName.TabIndex = 4;
            // 
            // tbPrice
            // 
            tbPrice.Location = new System.Drawing.Point(302, 463);
            tbPrice.Margin = new System.Windows.Forms.Padding(2);
            tbPrice.Name = "tbPrice";
            tbPrice.PlaceholderText = "Price(e.g. 50)";
            tbPrice.Size = new System.Drawing.Size(121, 27);
            tbPrice.TabIndex = 5;
            // 
            // tbIsAlcohol
            // 
            tbIsAlcohol.Location = new System.Drawing.Point(441, 463);
            tbIsAlcohol.Margin = new System.Windows.Forms.Padding(2);
            tbIsAlcohol.Name = "tbIsAlcohol";
            tbIsAlcohol.PlaceholderText = "Is Alcoholic(e.g. 1)";
            tbIsAlcohol.Size = new System.Drawing.Size(121, 27);
            tbIsAlcohol.TabIndex = 6;
            // 
            // tbStock
            // 
            tbStock.Location = new System.Drawing.Point(582, 463);
            tbStock.Margin = new System.Windows.Forms.Padding(2);
            tbStock.Name = "tbStock";
            tbStock.PlaceholderText = "Stock(e.g. 50)";
            tbStock.Size = new System.Drawing.Size(121, 27);
            tbStock.TabIndex = 6;
            // 
            // btnUpdateDrink
            // 
            btnUpdateDrink.Location = new System.Drawing.Point(520, 520);
            btnUpdateDrink.Margin = new System.Windows.Forms.Padding(2);
            btnUpdateDrink.Name = "btnUpdateDrink";
            btnUpdateDrink.Size = new System.Drawing.Size(90, 27);
            btnUpdateDrink.TabIndex = 10;
            btnUpdateDrink.Text = "Update Drink";
            btnUpdateDrink.UseVisualStyleBackColor = true;
            btnUpdateDrink.Click += btnUpdateDrink_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(15, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 41);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlTeachers
            // 
            pnlTeachers.Controls.Add(listViewTeachers);
            pnlTeachers.Location = new System.Drawing.Point(14, 36);
            pnlTeachers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlTeachers.Name = "pnlTeachers";
            pnlTeachers.Size = new System.Drawing.Size(1072, 622);
            pnlTeachers.TabIndex = 3;
            // 
            // listViewTeachers
            // 
            listViewTeachers.Location = new System.Drawing.Point(15, 42);
            listViewTeachers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewTeachers.Name = "listViewTeachers";
            listViewTeachers.Size = new System.Drawing.Size(875, 408);
            listViewTeachers.TabIndex = 3;
            listViewTeachers.UseCompatibleStateImageBehavior = false;
            // 
            // pnlActivities
            // 
            pnlActivities.Controls.Add(listViewActivities);
            pnlActivities.Controls.Add(label1);
            pnlActivities.Location = new System.Drawing.Point(14, 36);
            pnlActivities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new System.Drawing.Size(1072, 622);
            pnlActivities.TabIndex = 4;
            // 
            // listViewActivities
            // 
            listViewActivities.Location = new System.Drawing.Point(15, 42);
            listViewActivities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewActivities.Name = "listViewActivities";
            listViewActivities.Size = new System.Drawing.Size(875, 408);
            listViewActivities.TabIndex = 4;
            listViewActivities.UseCompatibleStateImageBehavior = false;
            // 
            // listViewStudentSimple
            // 
            listViewStudentSimple.FullRowSelect = true;
            listViewStudentSimple.Location = new System.Drawing.Point(15, 42);
            listViewStudentSimple.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewStudentSimple.Name = "listViewStudentSimple";
            listViewStudentSimple.Size = new System.Drawing.Size(875, 201);
            listViewStudentSimple.TabIndex = 4;
            listViewStudentSimple.UseCompatibleStateImageBehavior = false;
            listViewStudentSimple.Click += ListViewStudentSimple_Click;
            // 
            // listViewDrinksSimple
            // 
            listViewDrinksSimple.FullRowSelect = true;
            listViewDrinksSimple.Location = new System.Drawing.Point(15, 240);
            listViewDrinksSimple.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewDrinksSimple.Name = "listViewDrinksSimple";
            listViewDrinksSimple.Size = new System.Drawing.Size(875, 201);
            listViewDrinksSimple.TabIndex = 4;
            listViewDrinksSimple.UseCompatibleStateImageBehavior = false;
            listViewDrinksSimple.Click += ListViewDrinksSimple_Click;
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Location = new System.Drawing.Point(14, 36);
            pnlRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1072, 622);
            pnlRooms.TabIndex = 5;
            // 
            // listViewRooms
            // 
            listViewRooms.Location = new System.Drawing.Point(15, 42);
            listViewRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(875, 408);
            listViewRooms.TabIndex = 5;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            // 
            // pnlCashRegister
            // 
            pnlCashRegister.Controls.Add(listViewStudentSimple);
            pnlCashRegister.Controls.Add(listViewDrinksSimple);
            pnlCashRegister.Controls.Add(lblAmountToPay);
            pnlCashRegister.Controls.Add(btnCheckOut);
            pnlCashRegister.Location = new System.Drawing.Point(14, 36);
            pnlCashRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlCashRegister.Name = "pnlCashRegister";
            pnlCashRegister.Size = new System.Drawing.Size(1072, 622);
            pnlCashRegister.TabIndex = 5;
            // 
            // lblAmountToPay
            // 
            lblAmountToPay.AutoSize = true;
            lblAmountToPay.Location = new System.Drawing.Point(116, 509);
            lblAmountToPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAmountToPay.Name = "lblAmountToPay";
            lblAmountToPay.Size = new System.Drawing.Size(142, 20);
            lblAmountToPay.TabIndex = 4;
            lblAmountToPay.Text = "Amount to be paid: ";
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new System.Drawing.Point(365, 463);
            btnCheckOut.Margin = new System.Windows.Forms.Padding(2);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new System.Drawing.Size(90, 27);
            btnCheckOut.TabIndex = 3;
            btnCheckOut.Text = "Checkout";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += BtnCheckOut_Click;
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1099, 674);
            Controls.Add(menuStrip1);
            Controls.Add(pnlStudents);
            Controls.Add(pnlVat);
            Controls.Add(pnlDrinks);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlTeachers);
            Controls.Add(pnlActivities);
            Controls.Add(pnlRooms);
            Controls.Add(pnlCashRegister);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.Panel pnlActivities;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.Panel pnlCashRegister;
        private System.Windows.Forms.Panel pnlSupervisors;
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
        private System.Windows.Forms.ToolStripMenuItem activitySupervisorsToolStripMenuItem;
    }
}