using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProjectUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Resize += MainForm_Resize;
            this.FormClosing += MainForm_FormClosing;
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Check if the form is being minimized
                if (this.WindowState == FormWindowState.Minimized)
                {
                    // Cancel the event to prevent the form from being minimized
                    e.Cancel = true;
                    // Optionally, you can restore the form to its normal state
                    this.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           /* // Add a Panel control for the header section
            Panel headerPanel = new Panel();
            headerPanel.Location = new Point(0, 0);
            headerPanel.Size = new Size(800, 80);
            headerPanel.BackColor = Color.DodgerBlue;
            this.Controls.Add(headerPanel);*/

            // Add a Label control for the title in the header section
           /* Label titleLabel = new Label();
            titleLabel.Location = new Point(20, 20);
            titleLabel.Size = new Size(200, 40);
            titleLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Text = "Final Year Projects";
            headerPanel.Controls.Add(titleLabel);*/

            // Add a PictureBox control for the logo in the header section
           /* PictureBox logoPictureBox = new PictureBox();
            logoPictureBox.Location = new Point(600, 10);
            logoPictureBox.Size = new Size(150, 60);
           // logoPictureBox.Image = Image.FromFile("logo.png");
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            headerPanel.Controls.Add(logoPictureBox);
*/
            // Add a Panel control for the menu section
            /*Panel menuPanel = new Panel();
            menuPanel.Location = new Point(0, 80);
            menuPanel.Size = new Size(200, 520);
            menuPanel.BackColor = Color.LightGray;
            this.Controls.Add(menuPanel);

            // Add a Button control for the "Manage Students" menu item
            Button manageStudentsButton = new Button();
            manageStudentsButton.Location = new Point(20, 20);
            manageStudentsButton.Size = new Size(160, 40);
            manageStudentsButton.Text = "Manage Students";
            menuPanel.Controls.Add(manageStudentsButton);*/
            // Add an event handler for the Click event of the manageStudentsButton
           /* manageStudentsButton.Click += ManageStudentsButton_Click;


            // Add a Button control for the "Manage Advisors" menu item
            Button manageAdvisorsButton = new Button();
            manageAdvisorsButton.Location = new Point(20, 80);
            manageAdvisorsButton.Size = new Size(160, 40);
            manageAdvisorsButton.Text = "Manage Advisors";
            menuPanel.Controls.Add(manageAdvisorsButton);
            // Add an event handler for the Click event of the manageStudentsButton
            manageAdvisorsButton.Click += ManageAdvisorsButton_Click;

            // Add a Button control for the "Manage Projects" menu item
            Button manageProjectsButton = new Button();
            manageProjectsButton.Location = new Point(20, 140);
            manageProjectsButton.Size = new Size(160, 40);
            manageProjectsButton.Text = "Manage Projects";
            menuPanel.Controls.Add(manageProjectsButton);

            // Add a Button control for the "Formation of Student Group" menu item
            Button formationButton = new Button();
            formationButton.Location = new Point(20, 200);
            formationButton.Size = new Size(160, 40);
            formationButton.Text = "Formation of Student Group";
            menuPanel.Controls.Add(formationButton);*/
        }



       

        private void guna2Button2_Click(object sender, EventArgs e)
        {
       
        }

        private void groupFormationBtn_Click(object sender, EventArgs e)
        {
         
        }

        private void report_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void guna2CirclePictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            Group evaluation = new Group();

            evaluation.Show();
            this.Hide();
        }

        private void guna2CirclePictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
                
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // Create an instance of the ManageStudentsForm
            ManageStudentForm manageStudentsForm = new ManageStudentForm();

            // Show the ManageStudentsForm
            manageStudentsForm.Show();
            this.Hide();
        }

        private void groupFormationBtn_Click_1(object sender, EventArgs e)
        {
            ManageGroup evaluation = new ManageGroup();

            evaluation.Show();
            this.Hide();
           
           
        }

        private void manageAdvisorBtn_Click_1(object sender, EventArgs e)
        {
            AdvisorForm advisorForm = new AdvisorForm();

            advisorForm.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Group evaluation = new Group();

            evaluation.Show();
            this.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            ManageProject project = new ManageProject();

            project.Show();
            this.Hide();
           
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            ProjectAdvisor advisorForm = new ProjectAdvisor();

            advisorForm.Show();
            this.Hide();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            GroupEvaluation evaluation = new GroupEvaluation();

            evaluation.Show();
            this.Hide();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            ManageEvaluation evaluation = new ManageEvaluation();
            evaluation.Show();
            this.Hide();
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Hide();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            PDFs evaluation = new PDFs();

            evaluation.Show();
            this.Hide();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            AssignProject project = new AssignProject();

            project.Show();
            this.Hide();
        }
    }
}
