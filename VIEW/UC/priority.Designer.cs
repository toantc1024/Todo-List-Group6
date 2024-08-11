namespace todolist.VIEW.UC
{
    partial class priority
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLowest = new System.Windows.Forms.Button();
            this.btnHighest = new System.Windows.Forms.Button();
            this.lvwPriority = new System.Windows.Forms.ListView();
            this.prior = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reminderpr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpPriority = new System.Windows.Forms.DateTimePicker();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLowest
            // 
            this.btnLowest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnLowest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowest.Location = new System.Drawing.Point(937, 306);
            this.btnLowest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLowest.Name = "btnLowest";
            this.btnLowest.Size = new System.Drawing.Size(113, 80);
            this.btnLowest.TabIndex = 46;
            this.btnLowest.Text = "Lowest priority";
            this.btnLowest.UseVisualStyleBackColor = false;
            this.btnLowest.Click += new System.EventHandler(this.btnLowest_Click);
            // 
            // btnHighest
            // 
            this.btnHighest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnHighest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighest.Location = new System.Drawing.Point(937, 154);
            this.btnHighest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHighest.Name = "btnHighest";
            this.btnHighest.Size = new System.Drawing.Size(113, 76);
            this.btnHighest.TabIndex = 45;
            this.btnHighest.Text = "Highest Priority";
            this.btnHighest.UseVisualStyleBackColor = false;
            this.btnHighest.Click += new System.EventHandler(this.btnHighest_Click);
            // 
            // lvwPriority
            // 
            this.lvwPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.lvwPriority.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwPriority.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prior,
            this.StartTime,
            this.EndTime,
            this.Title,
            this.reminderpr});
            this.lvwPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPriority.GridLines = true;
            this.lvwPriority.HideSelection = false;
            this.lvwPriority.LabelEdit = true;
            this.lvwPriority.Location = new System.Drawing.Point(65, 79);
            this.lvwPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwPriority.Name = "lvwPriority";
            this.lvwPriority.Size = new System.Drawing.Size(840, 414);
            this.lvwPriority.TabIndex = 44;
            this.lvwPriority.UseCompatibleStateImageBehavior = false;
            this.lvwPriority.View = System.Windows.Forms.View.Details;
            // 
            // prior
            // 
            this.prior.Text = "Priority";
            this.prior.Width = 50;
            // 
            // StartTime
            // 
            this.StartTime.Text = "StartTime";
            this.StartTime.Width = 160;
            // 
            // EndTime
            // 
            this.EndTime.Text = "EndTime";
            this.EndTime.Width = 160;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 100;
            // 
            // reminderpr
            // 
            this.reminderpr.Text = "Description";
            this.reminderpr.Width = 400;
            // 
            // dtpPriority
            // 
            this.dtpPriority.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dtpPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPriority.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPriority.Location = new System.Drawing.Point(920, 31);
            this.dtpPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPriority.Name = "dtpPriority";
            this.dtpPriority.Size = new System.Drawing.Size(129, 23);
            this.dtpPriority.TabIndex = 43;
            this.dtpPriority.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::todolist.Properties.Resources.wt___Copy7;
            this.pictureBox16.Location = new System.Drawing.Point(293, 16);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(47, 39);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 42;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::todolist.Properties.Resources.wt___Copy5;
            this.pictureBox15.Location = new System.Drawing.Point(240, 16);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(47, 39);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 41;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::todolist.Properties.Resources.wt___Copy4;
            this.pictureBox14.Location = new System.Drawing.Point(188, 16);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(47, 39);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 40;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::todolist.Properties.Resources.wt___Copy;
            this.pictureBox13.Location = new System.Drawing.Point(345, 16);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(44, 37);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 39;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::todolist.Properties.Resources.wt___Copy2;
            this.pictureBox12.Location = new System.Drawing.Point(125, 12);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(57, 52);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 38;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::todolist.Properties.Resources.wt___Copy3;
            this.pictureBox11.Location = new System.Drawing.Point(80, 16);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(47, 39);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 37;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::todolist.Properties.Resources.wt___Copy1;
            this.pictureBox10.Location = new System.Drawing.Point(28, 16);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(47, 39);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 36;
            this.pictureBox10.TabStop = false;
            // 
            // priority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnLowest);
            this.Controls.Add(this.btnHighest);
            this.Controls.Add(this.lvwPriority);
            this.Controls.Add(this.dtpPriority);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "priority";
            this.Size = new System.Drawing.Size(1079, 526);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLowest;
        private System.Windows.Forms.Button btnHighest;
        private System.Windows.Forms.ListView lvwPriority;
        private System.Windows.Forms.ColumnHeader prior;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.ColumnHeader reminderpr;
        private System.Windows.Forms.DateTimePicker dtpPriority;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.ColumnHeader EndTime;
        private System.Windows.Forms.ColumnHeader Title;
    }
}
