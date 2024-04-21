using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string connString = "datasource=localhost; username=root; password=;database=company";
        
        void clearData()
        {
            lblProjectID.Text = null;
            txtProjectName.Text = null;
            lblTaskID.Text = null;
            txtTaskProjectID.Text = null;
            txtTaskDescription.Text = null;
            txtTaskStatus.Text = null;
            txtTeamMemberName.Text = null;
            txtTeamMemberRole.Text = null;
        }
        public void loadProjectsData()
        {
           MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                String query = "SELECT * FROM projects";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvProjects.DataSource = dt;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadTaskData()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                String query = "SELECT * FROM task";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvTask.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadTeamMemberData()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                String query = "SELECT * FROM TeamMember";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvTeamMember.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Form1()
        {
            InitializeComponent();
            loadProjectsData();
            loadTaskData();
            loadTeamMemberData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void dgvProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                DataGridViewCell id = dgvProjects.Rows[e.RowIndex].Cells[e.ColumnIndex];
                lblProjectID.Text = id.Value.ToString();

                DataGridViewCell ProjectName = dgvProjects.Rows[e.RowIndex].Cells[e.ColumnIndex + 1];
                txtProjectName.Text = ProjectName.Value.ToString();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                String query = "INSERT INTO projects (NAME) VALUES ('"+txtProjectName.Text+"')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
               MySqlDataReader reader = cmd.ExecuteReader();
                loadProjectsData();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProjectUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                String query = "UPDATE projects SET NAME = '"+txtProjectName.Text+"' WHERE id = '"+lblProjectID.Text+"'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                loadProjectsData();
                MessageBox.Show("UPDATED PROJECT NAME SUCCESSFULLY!");
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProjectDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                string query = "DELETE FROM projects WHERE id = '"+lblProjectID.Text+"'";
                MySqlCommand cmd = new MySqlCommand(query,conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("SUCCESSFULLY DELETED!");
                loadProjectsData();
                clearData();
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                DataGridViewCell id = dgvTask.Rows[e.RowIndex].Cells[e.ColumnIndex];
                lblTaskID.Text = id.Value.ToString();

                DataGridViewCell TaskProjectID = dgvTask.Rows[e.RowIndex].Cells[e.ColumnIndex + 1];
                txtTaskProjectID.Text = TaskProjectID.Value.ToString();

                DataGridViewCell TaskDescription = dgvTask.Rows[e.RowIndex].Cells[e.ColumnIndex + 2];
                txtTaskDescription.Text = TaskDescription.Value.ToString();

                DataGridViewCell TaskStatus = dgvTask.Rows[e.RowIndex].Cells[e.ColumnIndex + 3];
                txtTaskStatus.Text = TaskStatus.Value.ToString();
            }
        }

        private void btnTaskAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                string query = "INSERT INTO task (PROJECTID, DESCRIPTION, STATUS) VALUES ('"+txtTaskProjectID.Text+"', '"+txtTaskDescription.Text+"', '"+txtTaskStatus.Text+"')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                loadTaskData();
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTaskUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                string query = "UPDATE task SET STATUS = '"+txtTaskStatus.Text+"' WHERE id = '"+lblTaskID.Text+"'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                loadTaskData();
                MessageBox.Show("UPDATED STATUS SUCCESSFULLY!");
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }

        private void btnTaskDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                string query = "DELETE FROM task WHERE id = '"+lblTaskID.Text+"'";
                MySqlCommand cmd = new MySqlCommand (query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                loadTaskData();
                MessageBox.Show("SUCCESSFULLY DELETED!");
                clearData();
                conn.Close ();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTeamMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                DataGridViewCell id = dgvTeamMember.Rows[e.RowIndex].Cells[e.ColumnIndex];
                lblTeamMemberID.Text = id.Value.ToString();

                DataGridViewCell TeamMemberName = dgvTeamMember.Rows[e.RowIndex].Cells[e.ColumnIndex + 1];
                txtTeamMemberName.Text = TeamMemberName.Value.ToString();

                DataGridViewCell TeamMemberRole = dgvTeamMember.Rows[e.RowIndex].Cells[e.ColumnIndex + 2];
                txtTeamMemberRole.Text = TeamMemberRole.Value.ToString();

            }
        }

        private void btnTeamMemberAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                string query = "INSERT INTO teammember (NAME, ROLE) VALUES ('" + txtTeamMemberName.Text + "', '" + txtTeamMemberRole.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                loadTeamMemberData();
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTeamMemberUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                string query = "UPDATE teammember SET NAME = '"+txtTeamMemberName.Text+ "', ROLE = '"+txtTeamMemberRole.Text+"' WHERE id = '" + lblTeamMemberID.Text+"'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                loadTeamMemberData();
                MessageBox.Show("UPDATED NAME SUCCESSFULLY!");
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTeamMemberDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                string query = "DELETE FROM teammember WHERE id = '"+lblTeamMemberID+"'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                loadTeamMemberData();
                clearData();
                MessageBox.Show("SUCCESSFULLY DELETED!");
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
