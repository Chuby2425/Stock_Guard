namespace WindowsFormsApp1
{
    partial class frmUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cont_Left = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Cpassword = new System.Windows.Forms.Label();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.txt_Cpassword = new System.Windows.Forms.TextBox();
            this.Combo_Rol = new System.Windows.Forms.ComboBox();
            this.lbl_State = new System.Windows.Forms.Label();
            this.Combo_State = new System.Windows.Forms.ComboBox();
            this.lbl_Tittle = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btn_Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContrasennaUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.Combo_Search = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Indice = new System.Windows.Forms.TextBox();
            this.btn_Clear = new FontAwesome.Sharp.IconButton();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.btn_Limpiar = new FontAwesome.Sharp.IconButton();
            this.btn_ = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 0;
            // 
            // cont_Left
            // 
            this.cont_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.cont_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cont_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.cont_Left.Location = new System.Drawing.Point(0, 0);
            this.cont_Left.Name = "cont_Left";
            this.cont_Left.Size = new System.Drawing.Size(317, 658);
            this.cont_Left.TabIndex = 1;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.lbl_Name.Location = new System.Drawing.Point(33, 92);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(154, 21);
            this.lbl_Name.TabIndex = 4;
            this.lbl_Name.Text = "Nombre Completo:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(34, 117);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(241, 22);
            this.txt_Name.TabIndex = 8;
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.lbl_Mail.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.lbl_Mail.Location = new System.Drawing.Point(33, 155);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(68, 21);
            this.lbl_Mail.TabIndex = 9;
            this.lbl_Mail.Text = "Correo:";
            this.lbl_Mail.Click += new System.EventHandler(this.lbl_Mail_Click);
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(34, 180);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(241, 22);
            this.txt_Mail.TabIndex = 10;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.lbl_Password.Location = new System.Drawing.Point(30, 220);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(102, 21);
            this.lbl_Password.TabIndex = 11;
            this.lbl_Password.Text = "Contraseña:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(31, 243);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(241, 22);
            this.txt_Password.TabIndex = 12;
            // 
            // lbl_Cpassword
            // 
            this.lbl_Cpassword.AutoSize = true;
            this.lbl_Cpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.lbl_Cpassword.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.lbl_Cpassword.Location = new System.Drawing.Point(33, 283);
            this.lbl_Cpassword.Name = "lbl_Cpassword";
            this.lbl_Cpassword.Size = new System.Drawing.Size(181, 21);
            this.lbl_Cpassword.TabIndex = 13;
            this.lbl_Cpassword.Text = "Confirmar Contraseña";
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.lbl_Rol.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.lbl_Rol.Location = new System.Drawing.Point(33, 343);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(42, 21);
            this.lbl_Rol.TabIndex = 14;
            this.lbl_Rol.Text = "Rol:";
            this.lbl_Rol.Click += new System.EventHandler(this.lbl_Rol_Click);
            // 
            // txt_Cpassword
            // 
            this.txt_Cpassword.Location = new System.Drawing.Point(34, 307);
            this.txt_Cpassword.Name = "txt_Cpassword";
            this.txt_Cpassword.PasswordChar = '*';
            this.txt_Cpassword.Size = new System.Drawing.Size(241, 22);
            this.txt_Cpassword.TabIndex = 15;
            // 
            // Combo_Rol
            // 
            this.Combo_Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Rol.FormattingEnabled = true;
            this.Combo_Rol.Location = new System.Drawing.Point(34, 367);
            this.Combo_Rol.Name = "Combo_Rol";
            this.Combo_Rol.Size = new System.Drawing.Size(241, 24);
            this.Combo_Rol.TabIndex = 16;
            this.Combo_Rol.SelectedIndexChanged += new System.EventHandler(this.Combo_Rol_SelectedIndexChanged);
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.lbl_State.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_State.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.lbl_State.Location = new System.Drawing.Point(33, 410);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(67, 21);
            this.lbl_State.TabIndex = 17;
            this.lbl_State.Text = "Estado:";
            // 
            // Combo_State
            // 
            this.Combo_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_State.FormattingEnabled = true;
            this.Combo_State.Location = new System.Drawing.Point(34, 434);
            this.Combo_State.Name = "Combo_State";
            this.Combo_State.Size = new System.Drawing.Size(241, 24);
            this.Combo_State.TabIndex = 18;
            // 
            // lbl_Tittle
            // 
            this.lbl_Tittle.AutoSize = true;
            this.lbl_Tittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.lbl_Tittle.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.lbl_Tittle.Location = new System.Drawing.Point(28, 30);
            this.lbl_Tittle.Name = "lbl_Tittle";
            this.lbl_Tittle.Size = new System.Drawing.Size(244, 32);
            this.lbl_Tittle.TabIndex = 22;
            this.lbl_Tittle.Text = "Detalles de usuario:";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_Select,
            this.Id,
            this.NombreUsuario,
            this.ContrasennaUsuario,
            this.CorreoUsuario,
            this.Id_Rol,
            this.EstadoRol,
            this.EstadoValor,
            this.EstadoUsuario});
            this.dgvData.Location = new System.Drawing.Point(350, 117);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(838, 479);
            this.dgvData.TabIndex = 23;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // btn_Select
            // 
            this.btn_Select.HeaderText = "";
            this.btn_Select.MinimumWidth = 6;
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.ReadOnly = true;
            this.btn_Select.Width = 30;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID Usuario";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "Nombre del Usuario";
            this.NombreUsuario.MinimumWidth = 6;
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            this.NombreUsuario.Width = 180;
            // 
            // ContrasennaUsuario
            // 
            this.ContrasennaUsuario.HeaderText = "Contraseña";
            this.ContrasennaUsuario.MinimumWidth = 6;
            this.ContrasennaUsuario.Name = "ContrasennaUsuario";
            this.ContrasennaUsuario.ReadOnly = true;
            this.ContrasennaUsuario.Visible = false;
            this.ContrasennaUsuario.Width = 125;
            // 
            // CorreoUsuario
            // 
            this.CorreoUsuario.HeaderText = "Correo";
            this.CorreoUsuario.MinimumWidth = 6;
            this.CorreoUsuario.Name = "CorreoUsuario";
            this.CorreoUsuario.ReadOnly = true;
            this.CorreoUsuario.Width = 200;
            // 
            // Id_Rol
            // 
            this.Id_Rol.HeaderText = "ID Rol";
            this.Id_Rol.MinimumWidth = 6;
            this.Id_Rol.Name = "Id_Rol";
            this.Id_Rol.ReadOnly = true;
            this.Id_Rol.Visible = false;
            this.Id_Rol.Width = 125;
            // 
            // EstadoRol
            // 
            this.EstadoRol.HeaderText = "Rol";
            this.EstadoRol.MinimumWidth = 6;
            this.EstadoRol.Name = "EstadoRol";
            this.EstadoRol.ReadOnly = true;
            this.EstadoRol.Width = 125;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "Estado Valor";
            this.EstadoValor.MinimumWidth = 6;
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            this.EstadoValor.Width = 125;
            // 
            // EstadoUsuario
            // 
            this.EstadoUsuario.HeaderText = "Estado";
            this.EstadoUsuario.MinimumWidth = 6;
            this.EstadoUsuario.Name = "EstadoUsuario";
            this.EstadoUsuario.ReadOnly = true;
            this.EstadoUsuario.Width = 125;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(838, 59);
            this.label2.TabIndex = 24;
            this.label2.Text = "lista de usuarios:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(242, 74);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(33, 22);
            this.txt_Id.TabIndex = 25;
            this.txt_Id.Text = "0";
            this.txt_Id.Visible = false;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.BackColor = System.Drawing.Color.White;
            this.lbl_Search.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.ForeColor = System.Drawing.Color.Black;
            this.lbl_Search.Location = new System.Drawing.Point(642, 63);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(99, 21);
            this.lbl_Search.TabIndex = 26;
            this.lbl_Search.Text = "Buscar por:";
            this.lbl_Search.Click += new System.EventHandler(this.label3_Click);
            // 
            // Combo_Search
            // 
            this.Combo_Search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Combo_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Search.FormattingEnabled = true;
            this.Combo_Search.Location = new System.Drawing.Point(747, 60);
            this.Combo_Search.Name = "Combo_Search";
            this.Combo_Search.Size = new System.Drawing.Size(151, 24);
            this.Combo_Search.TabIndex = 27;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(904, 60);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(127, 22);
            this.txt_Search.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1160, -243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(974, 59);
            this.label3.TabIndex = 31;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Indice
            // 
            this.txt_Indice.Location = new System.Drawing.Point(203, 74);
            this.txt_Indice.Name = "txt_Indice";
            this.txt_Indice.Size = new System.Drawing.Size(33, 22);
            this.txt_Indice.TabIndex = 32;
            this.txt_Indice.Text = "0";
            this.txt_Indice.Visible = false;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btn_Clear.IconColor = System.Drawing.Color.Black;
            this.btn_Clear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Clear.IconSize = 25;
            this.btn_Clear.Location = new System.Drawing.Point(1109, 57);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(53, 29);
            this.btn_Clear.TabIndex = 30;
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btn_Search.IconColor = System.Drawing.Color.Black;
            this.btn_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Search.IconSize = 25;
            this.btn_Search.Location = new System.Drawing.Point(1050, 57);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(53, 29);
            this.btn_Search.TabIndex = 29;
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_Delete.IconColor = System.Drawing.Color.White;
            this.btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Delete.IconSize = 25;
            this.btn_Delete.Location = new System.Drawing.Point(31, 587);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(241, 29);
            this.btn_Delete.TabIndex = 21;
            this.btn_Delete.Text = "Eliminar";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btn_Limpiar.IconColor = System.Drawing.Color.White;
            this.btn_Limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Limpiar.IconSize = 25;
            this.btn_Limpiar.Location = new System.Drawing.Point(31, 552);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(241, 29);
            this.btn_Limpiar.TabIndex = 20;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_
            // 
            this.btn_.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_.ForeColor = System.Drawing.Color.White;
            this.btn_.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btn_.IconColor = System.Drawing.Color.White;
            this.btn_.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_.IconSize = 25;
            this.btn_.Location = new System.Drawing.Point(31, 517);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(241, 29);
            this.btn_.TabIndex = 19;
            this.btn_.Text = "Guardar";
            this.btn_.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_.UseVisualStyleBackColor = false;
            this.btn_.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1382, 658);
            this.Controls.Add(this.txt_Indice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.Combo_Search);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lbl_Tittle);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.Combo_State);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.Combo_Rol);
            this.Controls.Add(this.txt_Cpassword);
            this.Controls.Add(this.lbl_Rol);
            this.Controls.Add(this.lbl_Cpassword);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.lbl_Mail);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.cont_Left);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cont_Left;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Cpassword;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.TextBox txt_Cpassword;
        private System.Windows.Forms.ComboBox Combo_Rol;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.ComboBox Combo_State;
        private FontAwesome.Sharp.IconButton btn_;
        private FontAwesome.Sharp.IconButton btn_Limpiar;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private System.Windows.Forms.Label lbl_Tittle;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.ComboBox Combo_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btn_Clear;
        private FontAwesome.Sharp.IconButton btn_Search;
        private System.Windows.Forms.TextBox txt_Indice;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContrasennaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoUsuario;
    }
}