
namespace todolist.VIEW.US
{
    partial class myplan
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
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.DayTodolist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YourTodoList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DaySchedule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yourSchedule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DayGoals = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YourGoals = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DayNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YourNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font(".VnVogueH", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 42);
            this.label8.TabIndex = 24;
            this.label8.Text = "My TODOList: \r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(".VnVogueH", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 42);
            this.label1.TabIndex = 25;
            this.label1.Text = "My schedule:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font(".VnVogueH", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 42);
            this.label2.TabIndex = 26;
            this.label2.Text = "My goals:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font(".VnVogueH", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 42);
            this.label3.TabIndex = 27;
            this.label3.Text = "My notes: \r\n";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DayTodolist,
            this.YourTodoList});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(252, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(617, 111);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(204)))));
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DaySchedule,
            this.yourSchedule});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(252, 138);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(617, 111);
            this.listView2.TabIndex = 29;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DayGoals,
            this.YourGoals});
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(252, 274);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(617, 111);
            this.listView3.TabIndex = 30;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // listView4
            // 
            this.listView4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.listView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DayNote,
            this.YourNotes});
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(252, 403);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(617, 111);
            this.listView4.TabIndex = 31;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // DayTodolist
            // 
            this.DayTodolist.Text = "Day: ";
            this.DayTodolist.Width = 200;
            // 
            // YourTodoList
            // 
            this.YourTodoList.Text = "Your TODO List:";
            this.YourTodoList.Width = 474;
            // 
            // DaySchedule
            // 
            this.DaySchedule.Text = "Day:";
            this.DaySchedule.Width = 200;
            // 
            // yourSchedule
            // 
            this.yourSchedule.Text = "Your Schedule";
            this.yourSchedule.Width = 472;
            // 
            // DayGoals
            // 
            this.DayGoals.Text = "Day:";
            this.DayGoals.Width = 200;
            // 
            // YourGoals
            // 
            this.YourGoals.Text = "Your Goals:";
            this.YourGoals.Width = 468;
            // 
            // DayNote
            // 
            this.DayNote.Text = "Day:";
            this.DayNote.Width = 203;
            // 
            // YourNotes
            // 
            this.YourNotes.Text = "Your Notes:";
            this.YourNotes.Width = 457;
            // 
            // myplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "myplan";
            this.Size = new System.Drawing.Size(981, 537);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader DayTodolist;
        private System.Windows.Forms.ColumnHeader YourTodoList;
        private System.Windows.Forms.ColumnHeader DaySchedule;
        private System.Windows.Forms.ColumnHeader yourSchedule;
        private System.Windows.Forms.ColumnHeader DayGoals;
        private System.Windows.Forms.ColumnHeader YourGoals;
        private System.Windows.Forms.ColumnHeader DayNote;
        private System.Windows.Forms.ColumnHeader YourNotes;
    }
}
