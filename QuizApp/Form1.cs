using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : Form
    {
        public List<string> students = new List<string>();
        public List<string> tasks = new List<string>();
        public Random random = new Random();
        int count = 1;
        public Form1()
        {
            InitializeComponent();  
        }

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            string name = txtStuName.Text;
            students.Add(name);
            Read();
            CLeaner();
        }

        public void CLeaner()
        {
            txtStuName.Clear();
            txtTask.Clear();
        }

        public void Read()
        {
            txtDataStudent.Text = "";
            txtDataTask.Text = "";
            int stuCount = 1;
            int taskCount = 1;
            foreach (string student in students)
            {
                txtDataStudent.Text += stuCount + " - "+ student + "\r\n";
                stuCount++;
            }
            foreach (string task in tasks)
            {
                txtDataTask.Text += taskCount + " - " + task + "\r\n";
                taskCount++;
            }

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string task = txtTask.Text;
            tasks.Add(task);
            Read();
            CLeaner();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            int stu_index;
            int task_index;
            do
            {
                if (students.Count == 1)
                {
                    stu_index = 0;
                    task_index = 0;
                    btnQuiz.Enabled = false;
                    break;
                }
                stu_index = random.Next(students.Count);
                task_index = random.Next(tasks.Count); 
            } while (stu_index == task_index); 
            txtQuiz.Text += count + " Student: " + students[stu_index] + " Task: " + tasks[task_index] + "\r\n";
            students.RemoveAt(stu_index); 
            tasks.RemoveAt(task_index);
            Read();
            count++;
        }
    }
}
