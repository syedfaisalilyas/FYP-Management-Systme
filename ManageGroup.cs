using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProjectUI
{
    public partial class ManageGroup : Form
    {
        public ManageGroup()
        {
           
            InitializeComponent();
            this.Resize += ManageForm_Resize;
            DisplayGroups();
            AddEditButtonColumn();
            
        }
    
   
        private void AddEditButtonColumn()
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Name = "EditButtonColumn";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            GroupDataGrid.Columns.Add(editButtonColumn);

        }
        private void createGroupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Group](Created_On) VALUES(@date); SELECT Id FROM [Group] ORDER BY Id Desc", con);
                cmd.Parameters.AddWithValue("@date", DateTime.Today);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    id = int.Parse(reader["Id"].ToString());
                }
                reader.Close();
                MessageBox.Show("Group G-" + id + " Created Successfully");
                StudentGroup EditGroup = new StudentGroup(id);
                /* Menu menuForm = (Menu)this.ParentForm;
                 menuForm.OpenChildForm(EditGroup, sender);*/
                EditGroup.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DisplayGroups();
        }
        public void DisplayGroups()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT CONCAT('G-',G.Id) AS GroupId,P.Id AS ProjectId,P.Title,COUNT(GS.StudentId) AS GStudent,(SELECT FORMAT(G.Created_On, 'dd-MM-yyyy')) AS Created_On FROM [Group] AS G LEFT JOIN GroupProject AS GP ON G.Id=GP.GroupId LEFT JOIN GroupStudent AS GS ON GS.GroupId=G.Id LEFT JOIN Project AS P ON GP.ProjectId=P.Id WHERE GS.Status=3 GROUP BY G.Id,P.Id,P.Title,G.Created_On", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                GroupDataGrid.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GroupDataGrid0_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GroupDataGrid.Columns["EditButtonColumn"].Index && e.RowIndex >= 0)
            {
                string groupIdString = GroupDataGrid.Rows[e.RowIndex].Cells["GroupId"].Value.ToString();
                // Extract numeric part of the group ID
                int groupId;
                if (int.TryParse(groupIdString.Replace("G-", ""), out groupId))
                {
                    string projectTitle = GroupDataGrid.Rows[e.RowIndex].Cells["Title"].Value.ToString();

                    StudentGroup editGroupForm = new StudentGroup(groupId, projectTitle);

                    /* Menu menuForm = (Menu)this.ParentForm;
                     menuForm.OpenChildForm(editGroupForm, sender);*/
                    editGroupForm.Show();

                    //editGroupForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid group ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ManageForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void ManageGroup_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
