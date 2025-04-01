namespace WindowsFormsApp1
{
    partial class frmProducto
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
            this.txt_Indice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Clear = new FontAwesome.Sharp.IconButton();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.Combo_Search = new System.Windows.Forms.ComboBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Limpiar = new FontAwesome.Sharp.IconButton();
            this.btn_ = new FontAwesome.Sharp.IconButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btn_Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Tittle = new System.Windows.Forms.Label();
            this.Combo_State = new System.Windows.Forms.ComboBox();
            this.lbl_State = new System.Windows.Forms.Label();
            this.Combo_Categoria = new System.Windows.Forms.ComboBox();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.cont_Left = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_download = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Indice
            // 
            this.txt_Indice.Location = new System.Drawing.Point(204, 57);
            this.txt_Indice.Name = "txt_Indice";
            this.txt_Indice.Size = new System.Drawing.Size(33, 22);
            this.txt_Indice.TabIndex = 60;
            this.txt_Indice.Text = "0";
            this.txt_Indice.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1161, -260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(974, 59);
            this.label3.TabIndex = 59;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btn_Clear.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.btn_Clear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Clear.IconSize = 25;
            this.btn_Clear.Location = new System.Drawing.Point(1243, 50);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(53, 29);
            this.btn_Clear.TabIndex = 58;
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btn_Search.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.btn_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Search.IconSize = 25;
            this.btn_Search.Location = new System.Drawing.Point(1184, 50);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(53, 29);
            this.btn_Search.TabIndex = 57;
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.txt_Search.Location = new System.Drawing.Point(1038, 53);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(127, 22);
            this.txt_Search.TabIndex = 56;
            // 
            // Combo_Search
            // 
            this.Combo_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.Combo_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Search.FormattingEnabled = true;
            this.Combo_Search.Location = new System.Drawing.Point(881, 53);
            this.Combo_Search.Name = "Combo_Search";
            this.Combo_Search.Size = new System.Drawing.Size(151, 24);
            this.Combo_Search.TabIndex = 55;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.lbl_Search.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.lbl_Search.Location = new System.Drawing.Point(776, 56);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(99, 21);
            this.lbl_Search.TabIndex = 54;
            this.lbl_Search.Text = "Buscar por:";
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
            this.btn_Delete.Location = new System.Drawing.Point(29, 506);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(241, 29);
            this.btn_Delete.TabIndex = 49;
            this.btn_Delete.Text = "Eliminar";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(243, 57);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(33, 22);
            this.txt_Id.TabIndex = 53;
            this.txt_Id.Text = "0";
            this.txt_Id.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(349, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(6, 6, 0, 0);
            this.label2.Size = new System.Drawing.Size(966, 92);
            this.label2.TabIndex = 52;
            this.label2.Text = "Lista de Productos:";
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
            this.btn_Limpiar.Location = new System.Drawing.Point(29, 471);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(241, 29);
            this.btn_Limpiar.TabIndex = 48;
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
            this.btn_.Location = new System.Drawing.Point(29, 436);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(241, 29);
            this.btn_.TabIndex = 47;
            this.btn_.Text = "Guardar";
            this.btn_.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_.UseVisualStyleBackColor = false;
            this.btn_.Click += new System.EventHandler(this.btn__Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
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
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.IdCategoria,
            this.Categoria,
            this.Stock,
            this.EstadoValor,
            this.EstadoUsuario});
            this.dgvData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvData.Location = new System.Drawing.Point(349, 138);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(966, 479);
            this.dgvData.TabIndex = 51;
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
            this.Id.HeaderText = "ID ";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre ";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 180;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "ID Categoria";
            this.IdCategoria.MinimumWidth = 6;
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Visible = false;
            this.IdCategoria.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 125;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 125;
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
            // lbl_Tittle
            // 
            this.lbl_Tittle.AutoSize = true;
            this.lbl_Tittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.lbl_Tittle.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.lbl_Tittle.Location = new System.Drawing.Point(29, 13);
            this.lbl_Tittle.Name = "lbl_Tittle";
            this.lbl_Tittle.Size = new System.Drawing.Size(217, 32);
            this.lbl_Tittle.TabIndex = 50;
            this.lbl_Tittle.Text = "Detalle Producto:";
            this.lbl_Tittle.Click += new System.EventHandler(this.lbl_Tittle_Click);
            // 
            // Combo_State
            // 
            this.Combo_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_State.FormattingEnabled = true;
            this.Combo_State.Location = new System.Drawing.Point(32, 353);
            this.Combo_State.Name = "Combo_State";
            this.Combo_State.Size = new System.Drawing.Size(241, 24);
            this.Combo_State.TabIndex = 46;
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.lbl_State.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_State.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.lbl_State.Location = new System.Drawing.Point(31, 329);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(67, 21);
            this.lbl_State.TabIndex = 45;
            this.lbl_State.Text = "Estado:";
            // 
            // Combo_Categoria
            // 
            this.Combo_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Categoria.FormattingEnabled = true;
            this.Combo_Categoria.Location = new System.Drawing.Point(32, 286);
            this.Combo_Categoria.Name = "Combo_Categoria";
            this.Combo_Categoria.Size = new System.Drawing.Size(241, 24);
            this.Combo_Categoria.TabIndex = 44;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.lbl_Categoria.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.lbl_Categoria.Location = new System.Drawing.Point(31, 262);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(89, 21);
            this.lbl_Categoria.TabIndex = 42;
            this.lbl_Categoria.Text = "Categoria:";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(32, 226);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(241, 22);
            this.txt_Descripcion.TabIndex = 40;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.lbl_Descripcion.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.lbl_Descripcion.Location = new System.Drawing.Point(31, 203);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(99, 21);
            this.lbl_Descripcion.TabIndex = 39;
            this.lbl_Descripcion.Text = "Descripcion";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(35, 163);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(241, 22);
            this.txt_Nombre.TabIndex = 38;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.lbl_Nombre.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.lbl_Nombre.Location = new System.Drawing.Point(34, 138);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(71, 21);
            this.lbl_Nombre.TabIndex = 37;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(35, 100);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(241, 22);
            this.txt_Codigo.TabIndex = 36;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.lbl_Name.Location = new System.Drawing.Point(34, 75);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(63, 21);
            this.lbl_Name.TabIndex = 35;
            this.lbl_Name.Text = "Codigo";
            // 
            // cont_Left
            // 
            this.cont_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(140)))));
            this.cont_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cont_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.cont_Left.Location = new System.Drawing.Point(0, 0);
            this.cont_Left.Name = "cont_Left";
            this.cont_Left.Size = new System.Drawing.Size(317, 628);
            this.cont_Left.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 33;
            // 
            // btn_download
            // 
            this.btn_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.btn_download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_download.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_download.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_download.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.btn_download.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btn_download.IconColor = System.Drawing.Color.LimeGreen;
            this.btn_download.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_download.IconSize = 25;
            this.btn_download.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_download.Location = new System.Drawing.Point(364, 75);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(150, 29);
            this.btn_download.TabIndex = 61;
            this.btn_download.Text = "Descargar Excel";
            this.btn_download.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_download.UseVisualStyleBackColor = false;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 628);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.txt_Indice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.Combo_Search);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lbl_Tittle);
            this.Controls.Add(this.Combo_State);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.Combo_Categoria);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.cont_Left);
            this.Controls.Add(this.label1);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Indice;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btn_Clear;
        private FontAwesome.Sharp.IconButton btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox Combo_Search;
        private System.Windows.Forms.Label lbl_Search;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btn_Limpiar;
        private FontAwesome.Sharp.IconButton btn_;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lbl_Tittle;
        private System.Windows.Forms.ComboBox Combo_State;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.ComboBox Combo_Categoria;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label cont_Left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoUsuario;
        private FontAwesome.Sharp.IconButton btn_download;
    }
}