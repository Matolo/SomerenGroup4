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
            pnlDrinks = new System.Windows.Forms.Panel();
            listViewDrinks = new System.Windows.Forms.ListView();
            tbDrinkId = new System.Windows.Forms.TextBox();
            tbDrinkName = new System.Windows.Forms.TextBox();
            tbPrice = new System.Windows.Forms.TextBox();
            tbIsAlcohol = new System.Windows.Forms.TextBox();
            tbStock = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            pnlTeachers = new System.Windows.Forms.Panel();
            listViewTeachers = new System.Windows.Forms.ListView();
            pnlActivities = new System.Windows.Forms.Panel();
            listViewActivities = new System.Windows.Forms.ListView();
            pnlRooms = new System.Windows.Forms.Panel();
            listViewRooms = new System.Windows.Forms.ListView();
            btnUpdateDrink = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlVat.SuspendLayout();
            pnlDrinks.SuspendLayout();
            pnlTeachers.SuspendLayout();
            pnlActivities.SuspendLayout();
            pnlRooms.SuspendLayout();
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
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
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
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
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
            pnlStudents.TabIndex = 2;
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
            pnlVat.Controls.Add(lblVatSelectQuarter);
            pnlVat.Controls.Add(lblVatQuarterRuns);
            pnlVat.Controls.Add(lblVatTotalVATLow);
            pnlVat.Controls.Add(lblVatTotalVATHigh);
            pnlVat.Controls.Add(lblVatTotalVAT);
            pnlVat.Location = new System.Drawing.Point(18, 45);
            pnlVat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlVat.Name = "pnlVat";
            pnlVat.Size = new System.Drawing.Size(1340, 778);
            pnlVat.TabIndex = 6;
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
            pnlActivities.Controls.Add(label1);
            pnlActivities.Location = new System.Drawing.Point(18, 45);
            pnlActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new System.Drawing.Size(1340, 778);
            pnlActivities.TabIndex = 4;
            // 
            // listViewActivities
            // 
            listViewActivities.Location = new System.Drawing.Point(19, 52);
            listViewActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewActivities.Name = "listViewActivities";
            listViewActivities.Size = new System.Drawing.Size(1093, 509);
            listViewActivities.TabIndex = 4;
            listViewActivities.UseCompatibleStateImageBehavior = false;
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
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1374, 842);
            Controls.Add(menuStrip1);
            Controls.Add(pnlStudents);
            Controls.Add(pnlVat);
            Controls.Add(pnlDrinks);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlTeachers);
            Controls.Add(pnlActivities);
            Controls.Add(pnlRooms);
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
            pnlTeachers.ResumeLayout(false);
            pnlActivities.ResumeLayout(false);
            pnlActivities.PerformLayout();
            pnlRooms.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ListView listViewActivities;
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
    }
}