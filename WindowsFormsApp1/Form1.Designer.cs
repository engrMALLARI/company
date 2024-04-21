namespace WindowsFormsApp1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProjects = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProjectID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProjectDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnProjectUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnProjectAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txtProjectName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTaskID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTaskDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaskUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaskAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txtTaskStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTaskDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTaskProjectID = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTeamMemberID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTeamMemberDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnTeamMemberUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnTeamMemberAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txtTeamMemberRole = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTeamMemberName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvTask = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvTeamMember = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamMember)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvProjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProjects.ColumnHeadersHeight = 4;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjects.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProjects.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProjects.Location = new System.Drawing.Point(403, 15);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.ReadOnly = true;
            this.dgvProjects.RowHeadersVisible = false;
            this.dgvProjects.RowHeadersWidth = 62;
            this.dgvProjects.RowTemplate.Height = 28;
            this.dgvProjects.Size = new System.Drawing.Size(820, 263);
            this.dgvProjects.TabIndex = 0;
            this.dgvProjects.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProjects.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProjects.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProjects.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProjects.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProjects.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProjects.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProjects.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProjects.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProjects.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProjects.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProjects.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProjects.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvProjects.ThemeStyle.ReadOnly = true;
            this.dgvProjects.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProjects.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProjects.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProjects.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProjects.ThemeStyle.RowsStyle.Height = 28;
            this.dgvProjects.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProjects.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblProjectID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnProjectDelete);
            this.panel1.Controls.Add(this.btnProjectUpdate);
            this.panel1.Controls.Add(this.btnProjectAdd);
            this.panel1.Controls.Add(this.txtProjectName);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 263);
            this.panel1.TabIndex = 1;
            // 
            // lblProjectID
            // 
            this.lblProjectID.AutoSize = true;
            this.lblProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectID.Location = new System.Drawing.Point(323, 27);
            this.lblProjectID.Name = "lblProjectID";
            this.lblProjectID.Size = new System.Drawing.Size(33, 26);
            this.lblProjectID.TabIndex = 11;
            this.lblProjectID.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // btnProjectDelete
            // 
            this.btnProjectDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProjectDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProjectDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProjectDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProjectDelete.FillColor = System.Drawing.Color.Maroon;
            this.btnProjectDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProjectDelete.ForeColor = System.Drawing.Color.White;
            this.btnProjectDelete.Location = new System.Drawing.Point(47, 207);
            this.btnProjectDelete.Name = "btnProjectDelete";
            this.btnProjectDelete.Size = new System.Drawing.Size(277, 44);
            this.btnProjectDelete.TabIndex = 10;
            this.btnProjectDelete.Text = "DELETE";
            this.btnProjectDelete.Click += new System.EventHandler(this.btnProjectDelete_Click);
            // 
            // btnProjectUpdate
            // 
            this.btnProjectUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProjectUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProjectUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProjectUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProjectUpdate.FillColor = System.Drawing.Color.Green;
            this.btnProjectUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProjectUpdate.ForeColor = System.Drawing.Color.White;
            this.btnProjectUpdate.Location = new System.Drawing.Point(195, 147);
            this.btnProjectUpdate.Name = "btnProjectUpdate";
            this.btnProjectUpdate.Size = new System.Drawing.Size(172, 54);
            this.btnProjectUpdate.TabIndex = 7;
            this.btnProjectUpdate.Text = "UPDATE";
            this.btnProjectUpdate.Click += new System.EventHandler(this.btnProjectUpdate_Click);
            // 
            // btnProjectAdd
            // 
            this.btnProjectAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProjectAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProjectAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProjectAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProjectAdd.FillColor = System.Drawing.Color.Teal;
            this.btnProjectAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProjectAdd.ForeColor = System.Drawing.Color.White;
            this.btnProjectAdd.Location = new System.Drawing.Point(14, 147);
            this.btnProjectAdd.Name = "btnProjectAdd";
            this.btnProjectAdd.Size = new System.Drawing.Size(172, 54);
            this.btnProjectAdd.TabIndex = 6;
            this.btnProjectAdd.Text = "ADD";
            this.btnProjectAdd.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProjectName.DefaultText = "";
            this.txtProjectName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProjectName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProjectName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProjectName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProjectName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProjectName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProjectName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProjectName.Location = new System.Drawing.Point(26, 81);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.PasswordChar = '\0';
            this.txtProjectName.PlaceholderText = "Name";
            this.txtProjectName.SelectedText = "";
            this.txtProjectName.Size = new System.Drawing.Size(330, 47);
            this.txtProjectName.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTaskID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnTaskDelete);
            this.panel2.Controls.Add(this.btnTaskUpdate);
            this.panel2.Controls.Add(this.btnTaskAdd);
            this.panel2.Controls.Add(this.txtTaskStatus);
            this.panel2.Controls.Add(this.txtTaskDescription);
            this.panel2.Controls.Add(this.txtTaskProjectID);
            this.panel2.Location = new System.Drawing.Point(12, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 350);
            this.panel2.TabIndex = 3;
            // 
            // lblTaskID
            // 
            this.lblTaskID.AutoSize = true;
            this.lblTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskID.Location = new System.Drawing.Point(316, 16);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(33, 26);
            this.lblTaskID.TabIndex = 12;
            this.lblTaskID.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID:";
            // 
            // btnTaskDelete
            // 
            this.btnTaskDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaskDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaskDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaskDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaskDelete.FillColor = System.Drawing.Color.Maroon;
            this.btnTaskDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTaskDelete.ForeColor = System.Drawing.Color.White;
            this.btnTaskDelete.Location = new System.Drawing.Point(44, 297);
            this.btnTaskDelete.Name = "btnTaskDelete";
            this.btnTaskDelete.Size = new System.Drawing.Size(277, 44);
            this.btnTaskDelete.TabIndex = 10;
            this.btnTaskDelete.Text = "DELETE";
            this.btnTaskDelete.Click += new System.EventHandler(this.btnTaskDelete_Click);
            // 
            // btnTaskUpdate
            // 
            this.btnTaskUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaskUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaskUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaskUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaskUpdate.FillColor = System.Drawing.Color.Green;
            this.btnTaskUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTaskUpdate.ForeColor = System.Drawing.Color.White;
            this.btnTaskUpdate.Location = new System.Drawing.Point(195, 237);
            this.btnTaskUpdate.Name = "btnTaskUpdate";
            this.btnTaskUpdate.Size = new System.Drawing.Size(172, 54);
            this.btnTaskUpdate.TabIndex = 8;
            this.btnTaskUpdate.Text = "UPDATE";
            this.btnTaskUpdate.Click += new System.EventHandler(this.btnTaskUpdate_Click);
            // 
            // btnTaskAdd
            // 
            this.btnTaskAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaskAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaskAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaskAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaskAdd.FillColor = System.Drawing.Color.Teal;
            this.btnTaskAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTaskAdd.ForeColor = System.Drawing.Color.White;
            this.btnTaskAdd.Location = new System.Drawing.Point(14, 237);
            this.btnTaskAdd.Name = "btnTaskAdd";
            this.btnTaskAdd.Size = new System.Drawing.Size(172, 54);
            this.btnTaskAdd.TabIndex = 7;
            this.btnTaskAdd.Text = "ADD";
            this.btnTaskAdd.Click += new System.EventHandler(this.btnTaskAdd_Click);
            // 
            // txtTaskStatus
            // 
            this.txtTaskStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaskStatus.DefaultText = "";
            this.txtTaskStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaskStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaskStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTaskStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskStatus.Location = new System.Drawing.Point(27, 175);
            this.txtTaskStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaskStatus.Name = "txtTaskStatus";
            this.txtTaskStatus.PasswordChar = '\0';
            this.txtTaskStatus.PlaceholderText = "Status";
            this.txtTaskStatus.SelectedText = "";
            this.txtTaskStatus.Size = new System.Drawing.Size(330, 47);
            this.txtTaskStatus.TabIndex = 4;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaskDescription.DefaultText = "";
            this.txtTaskDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaskDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaskDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTaskDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskDescription.Location = new System.Drawing.Point(27, 118);
            this.txtTaskDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.PasswordChar = '\0';
            this.txtTaskDescription.PlaceholderText = "Description";
            this.txtTaskDescription.SelectedText = "";
            this.txtTaskDescription.Size = new System.Drawing.Size(330, 47);
            this.txtTaskDescription.TabIndex = 3;
            // 
            // txtTaskProjectID
            // 
            this.txtTaskProjectID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaskProjectID.DefaultText = "";
            this.txtTaskProjectID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaskProjectID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaskProjectID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskProjectID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskProjectID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskProjectID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTaskProjectID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskProjectID.Location = new System.Drawing.Point(27, 61);
            this.txtTaskProjectID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaskProjectID.Name = "txtTaskProjectID";
            this.txtTaskProjectID.PasswordChar = '\0';
            this.txtTaskProjectID.PlaceholderText = "ProjectID";
            this.txtTaskProjectID.SelectedText = "";
            this.txtTaskProjectID.Size = new System.Drawing.Size(330, 47);
            this.txtTaskProjectID.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTeamMemberID);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnTeamMemberDelete);
            this.panel3.Controls.Add(this.btnTeamMemberUpdate);
            this.panel3.Controls.Add(this.btnTeamMemberAdd);
            this.panel3.Controls.Add(this.txtTeamMemberRole);
            this.panel3.Controls.Add(this.txtTeamMemberName);
            this.panel3.Location = new System.Drawing.Point(12, 640);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 306);
            this.panel3.TabIndex = 3;
            // 
            // lblTeamMemberID
            // 
            this.lblTeamMemberID.AutoSize = true;
            this.lblTeamMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamMemberID.Location = new System.Drawing.Point(316, 15);
            this.lblTeamMemberID.Name = "lblTeamMemberID";
            this.lblTeamMemberID.Size = new System.Drawing.Size(33, 26);
            this.lblTeamMemberID.TabIndex = 11;
            this.lblTeamMemberID.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID:";
            // 
            // btnTeamMemberDelete
            // 
            this.btnTeamMemberDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTeamMemberDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTeamMemberDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTeamMemberDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTeamMemberDelete.FillColor = System.Drawing.Color.Maroon;
            this.btnTeamMemberDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTeamMemberDelete.ForeColor = System.Drawing.Color.White;
            this.btnTeamMemberDelete.Location = new System.Drawing.Point(47, 249);
            this.btnTeamMemberDelete.Name = "btnTeamMemberDelete";
            this.btnTeamMemberDelete.Size = new System.Drawing.Size(277, 44);
            this.btnTeamMemberDelete.TabIndex = 9;
            this.btnTeamMemberDelete.Text = "DELETE";
            this.btnTeamMemberDelete.Click += new System.EventHandler(this.btnTeamMemberDelete_Click);
            // 
            // btnTeamMemberUpdate
            // 
            this.btnTeamMemberUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTeamMemberUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTeamMemberUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTeamMemberUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTeamMemberUpdate.FillColor = System.Drawing.Color.Green;
            this.btnTeamMemberUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTeamMemberUpdate.ForeColor = System.Drawing.Color.White;
            this.btnTeamMemberUpdate.Location = new System.Drawing.Point(195, 189);
            this.btnTeamMemberUpdate.Name = "btnTeamMemberUpdate";
            this.btnTeamMemberUpdate.Size = new System.Drawing.Size(172, 54);
            this.btnTeamMemberUpdate.TabIndex = 8;
            this.btnTeamMemberUpdate.Text = "UPDATE";
            this.btnTeamMemberUpdate.Click += new System.EventHandler(this.btnTeamMemberUpdate_Click);
            // 
            // btnTeamMemberAdd
            // 
            this.btnTeamMemberAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTeamMemberAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTeamMemberAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTeamMemberAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTeamMemberAdd.FillColor = System.Drawing.Color.Teal;
            this.btnTeamMemberAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTeamMemberAdd.ForeColor = System.Drawing.Color.White;
            this.btnTeamMemberAdd.Location = new System.Drawing.Point(14, 189);
            this.btnTeamMemberAdd.Name = "btnTeamMemberAdd";
            this.btnTeamMemberAdd.Size = new System.Drawing.Size(172, 54);
            this.btnTeamMemberAdd.TabIndex = 7;
            this.btnTeamMemberAdd.Text = "ADD";
            this.btnTeamMemberAdd.Click += new System.EventHandler(this.btnTeamMemberAdd_Click);
            // 
            // txtTeamMemberRole
            // 
            this.txtTeamMemberRole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTeamMemberRole.DefaultText = "";
            this.txtTeamMemberRole.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTeamMemberRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTeamMemberRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTeamMemberRole.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTeamMemberRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTeamMemberRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTeamMemberRole.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTeamMemberRole.Location = new System.Drawing.Point(26, 118);
            this.txtTeamMemberRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTeamMemberRole.Name = "txtTeamMemberRole";
            this.txtTeamMemberRole.PasswordChar = '\0';
            this.txtTeamMemberRole.PlaceholderText = "Role";
            this.txtTeamMemberRole.SelectedText = "";
            this.txtTeamMemberRole.Size = new System.Drawing.Size(330, 47);
            this.txtTeamMemberRole.TabIndex = 3;
            // 
            // txtTeamMemberName
            // 
            this.txtTeamMemberName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTeamMemberName.DefaultText = "";
            this.txtTeamMemberName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTeamMemberName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTeamMemberName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTeamMemberName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTeamMemberName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTeamMemberName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTeamMemberName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTeamMemberName.Location = new System.Drawing.Point(27, 60);
            this.txtTeamMemberName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTeamMemberName.Name = "txtTeamMemberName";
            this.txtTeamMemberName.PasswordChar = '\0';
            this.txtTeamMemberName.PlaceholderText = "Name";
            this.txtTeamMemberName.SelectedText = "";
            this.txtTeamMemberName.Size = new System.Drawing.Size(330, 47);
            this.txtTeamMemberName.TabIndex = 2;
            // 
            // dgvTask
            // 
            this.dgvTask.AllowUserToAddRows = false;
            this.dgvTask.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvTask.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTask.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvTask.ColumnHeadersHeight = 4;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTask.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTask.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTask.Location = new System.Drawing.Point(403, 284);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.ReadOnly = true;
            this.dgvTask.RowHeadersVisible = false;
            this.dgvTask.RowHeadersWidth = 62;
            this.dgvTask.RowTemplate.Height = 28;
            this.dgvTask.Size = new System.Drawing.Size(820, 350);
            this.dgvTask.TabIndex = 4;
            this.dgvTask.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTask.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTask.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTask.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTask.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTask.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTask.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTask.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTask.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTask.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTask.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTask.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTask.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvTask.ThemeStyle.ReadOnly = true;
            this.dgvTask.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTask.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTask.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTask.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTask.ThemeStyle.RowsStyle.Height = 28;
            this.dgvTask.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTask.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTask.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTask_CellClick);
            // 
            // dgvTeamMember
            // 
            this.dgvTeamMember.AllowUserToAddRows = false;
            this.dgvTeamMember.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvTeamMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeamMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvTeamMember.ColumnHeadersHeight = 4;
            this.dgvTeamMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTeamMember.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvTeamMember.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTeamMember.Location = new System.Drawing.Point(403, 640);
            this.dgvTeamMember.Name = "dgvTeamMember";
            this.dgvTeamMember.ReadOnly = true;
            this.dgvTeamMember.RowHeadersVisible = false;
            this.dgvTeamMember.RowHeadersWidth = 62;
            this.dgvTeamMember.RowTemplate.Height = 28;
            this.dgvTeamMember.Size = new System.Drawing.Size(820, 306);
            this.dgvTeamMember.TabIndex = 5;
            this.dgvTeamMember.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTeamMember.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTeamMember.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTeamMember.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTeamMember.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTeamMember.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTeamMember.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTeamMember.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTeamMember.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTeamMember.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTeamMember.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTeamMember.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTeamMember.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvTeamMember.ThemeStyle.ReadOnly = true;
            this.dgvTeamMember.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTeamMember.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTeamMember.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTeamMember.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTeamMember.ThemeStyle.RowsStyle.Height = 28;
            this.dgvTeamMember.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTeamMember.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTeamMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeamMember_CellClick);
            this.dgvTeamMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView2_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 954);
            this.Controls.Add(this.dgvTeamMember);
            this.Controls.Add(this.dgvTask);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProjects);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvProjects;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtProjectName;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtTaskProjectID;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtTeamMemberName;
        private Guna.UI2.WinForms.Guna2TextBox txtTaskStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtTaskDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtTeamMemberRole;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTask;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTeamMember;
        private Guna.UI2.WinForms.Guna2Button btnProjectUpdate;
        private Guna.UI2.WinForms.Guna2Button btnProjectAdd;
        private Guna.UI2.WinForms.Guna2Button btnTeamMemberUpdate;
        private Guna.UI2.WinForms.Guna2Button btnTeamMemberAdd;
        private Guna.UI2.WinForms.Guna2Button btnTaskUpdate;
        private Guna.UI2.WinForms.Guna2Button btnTaskAdd;
        private Guna.UI2.WinForms.Guna2Button btnTeamMemberDelete;
        private Guna.UI2.WinForms.Guna2Button btnProjectDelete;
        private Guna.UI2.WinForms.Guna2Button btnTaskDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProjectID;
        private System.Windows.Forms.Label lblTaskID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTeamMemberID;
        private System.Windows.Forms.Label label3;
    }
}

