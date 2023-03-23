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
            vatStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            lblVatSelectYear = new System.Windows.Forms.Label();
            lblVatSelectQuarter = new System.Windows.Forms.Label();
            lblVatQuarterRuns = new System.Windows.Forms.Label();
            lblVatTotalVATLow = new System.Windows.Forms.Label();
            lblVatTotalVATHigh = new System.Windows.Forms.Label();
            lblVatTotalVAT = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            pnlVat = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            label1 = new System.Windows.Forms.Label();
            pnlTeachers = new System.Windows.Forms.Panel();
            listViewTeachers = new System.Windows.Forms.ListView();
            pnlActivities = new System.Windows.Forms.Panel();
            listViewActivities = new System.Windows.Forms.ListView();
            pnlRooms = new System.Windows.Forms.Panel();
            listViewRooms = new System.Windows.Forms.ListView();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            pnlVat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTeachers.SuspendLayout();
            pnlActivities.SuspendLayout();
            pnlRooms.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, vatStripMenuItem });
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
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
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
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // vatStripMenuItem
            // 
            vatStripMenuItem.Name = "vatStripMenuItem";
            vatStripMenuItem.Size = new System.Drawing.Size(48, 24);
            vatStripMenuItem.Text = "VAT";
            vatStripMenuItem.Click += vatStripMenuItem_Click;
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
            lblVatSelectYear.Size = new System.Drawing.Size(262, 20);
            lblVatSelectYear.TabIndex = 6;
            lblVatSelectYear.Text = "Select Year: ";
            // 
            // lblVatSelectQuarter
            // 
            lblVatSelectQuarter.AutoSize = true;
            lblVatSelectQuarter.Location = new System.Drawing.Point(15, 110);
            lblVatSelectQuarter.Name = "lblVatSelectQuarter";
            lblVatSelectQuarter.Size = new System.Drawing.Size(262, 20);
            lblVatSelectQuarter.TabIndex = 6;
            lblVatSelectQuarter.Text = "Select Quarter (Q1, Q2, Q3, Q4):";
            // 
            // lblVatQuarterRuns
            // 
            lblVatQuarterRuns.AutoSize = true;
            lblVatQuarterRuns.Location = new System.Drawing.Point(15, 140);
            lblVatQuarterRuns.Name = "lblVatQuarterRuns";
            lblVatQuarterRuns.Size = new System.Drawing.Size(262, 20);
            lblVatQuarterRuns.TabIndex = 6;
            lblVatQuarterRuns.Text = "Quarter runs from:";
            // 
            // lblVatTotalVATLow
            // 
            lblVatTotalVATLow.AutoSize = true;
            lblVatTotalVATLow.Location = new System.Drawing.Point(15, 170);
            lblVatTotalVATLow.Name = "lblVatTotalVATLow";
            lblVatTotalVATLow.Size = new System.Drawing.Size(262, 20);
            lblVatTotalVATLow.TabIndex = 6;
            lblVatTotalVATLow.Text = "Total VAT(low tariff, 6%) amount payable:";
            // 
            // lblVatTotalVATHigh
            // 
            lblVatTotalVATHigh.AutoSize = true;
            lblVatTotalVATHigh.Location = new System.Drawing.Point(15, 200);
            lblVatTotalVATHigh.Name = "lblVatSelectYear";
            lblVatTotalVATHigh.Size = new System.Drawing.Size(262, 20);
            lblVatTotalVATHigh.TabIndex = 6;
            lblVatTotalVATHigh.Text = "Total VAT(high tariff, 21%) amount payable:";
            // 
            // lblVatTotalVAT
            // 
            lblVatTotalVAT.AutoSize = true;
            lblVatTotalVAT.Location = new System.Drawing.Point(15, 230);
            lblVatTotalVAT.Name = "lblVatTotalVAT";
            lblVatTotalVAT.Size = new System.Drawing.Size(262, 20);
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
            // pnlVat
            // 
            pnlVat.Controls.Add(lblVatSelectYear);
            pnlVat.Controls.Add(lblVatSelectQuarter);
            pnlVat.Controls.Add(lblVatQuarterRuns);
            pnlVat.Controls.Add(lblVatTotalVATLow);
            pnlVat.Controls.Add(lblVatTotalVATHigh);
            pnlVat.Controls.Add(lblVatTotalVAT);
            pnlVat.Location = new System.Drawing.Point(14, 36);
            pnlVat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlVat.Name = "pnlVat";
            pnlVat.Size = new System.Drawing.Size(1072, 622);
            pnlVat.TabIndex = 6;
            //
            // pictureBox1
            // 
            pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
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
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1099, 674);
            Controls.Add(menuStrip1);
            Controls.Add(pnlStudents);
            Controls.Add(pnlVat);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlTeachers);
            Controls.Add(pnlActivities);
            Controls.Add(pnlRooms);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlVat.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.Panel pnlActivities;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem vatStripMenuItem;
    }
}