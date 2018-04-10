namespace QuizApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.btnAddStu = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataStudent = new System.Windows.Forms.TextBox();
            this.txtDataTask = new System.Windows.Forms.TextBox();
            this.txtQuiz = new System.Windows.Forms.TextBox();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name:";
            // 
            // txtStuName
            // 
            this.txtStuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuName.Location = new System.Drawing.Point(210, 12);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(160, 26);
            this.txtStuName.TabIndex = 1;
            // 
            // btnAddStu
            // 
            this.btnAddStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStu.Location = new System.Drawing.Point(272, 65);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(98, 35);
            this.btnAddStu.TabIndex = 2;
            this.btnAddStu.Text = "Add Student";
            this.btnAddStu.UseVisualStyleBackColor = true;
            this.btnAddStu.Click += new System.EventHandler(this.btnAddStu_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(711, 65);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(98, 35);
            this.btnAddTask.TabIndex = 5;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // txtTask
            // 
            this.txtTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTask.Location = new System.Drawing.Point(649, 12);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(160, 26);
            this.txtTask.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(541, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task Name:";
            // 
            // txtDataStudent
            // 
            this.txtDataStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataStudent.Location = new System.Drawing.Point(15, 117);
            this.txtDataStudent.Multiline = true;
            this.txtDataStudent.Name = "txtDataStudent";
            this.txtDataStudent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataStudent.Size = new System.Drawing.Size(355, 82);
            this.txtDataStudent.TabIndex = 6;
            // 
            // txtDataTask
            // 
            this.txtDataTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataTask.Location = new System.Drawing.Point(454, 117);
            this.txtDataTask.Multiline = true;
            this.txtDataTask.Name = "txtDataTask";
            this.txtDataTask.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataTask.Size = new System.Drawing.Size(355, 82);
            this.txtDataTask.TabIndex = 7;
            // 
            // txtQuiz
            // 
            this.txtQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuiz.Location = new System.Drawing.Point(15, 283);
            this.txtQuiz.Multiline = true;
            this.txtQuiz.Name = "txtQuiz";
            this.txtQuiz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuiz.Size = new System.Drawing.Size(794, 182);
            this.txtQuiz.TabIndex = 8;
            // 
            // btnQuiz
            // 
            this.btnQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz.Location = new System.Drawing.Point(711, 242);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(98, 35);
            this.btnQuiz.TabIndex = 9;
            this.btnQuiz.Text = "Quiz";
            this.btnQuiz.UseVisualStyleBackColor = true;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 477);
            this.Controls.Add(this.btnQuiz);
            this.Controls.Add(this.txtQuiz);
            this.Controls.Add(this.txtDataTask);
            this.Controls.Add(this.txtDataStudent);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddStu);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.Button btnAddStu;
        private System.Windows.Forms.Button btnAddTask;
        public System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDataStudent;
        public System.Windows.Forms.TextBox txtDataTask;
        public System.Windows.Forms.TextBox txtQuiz;
        private System.Windows.Forms.Button btnQuiz;
    }
}

