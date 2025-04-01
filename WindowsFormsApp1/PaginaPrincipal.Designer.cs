namespace WindowsFormsApp1
{
    partial class PaginaPrincipal
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
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.LeftBar_Button = new System.Windows.Forms.MenuStrip();
            this.btn_Usuario = new FontAwesome.Sharp.IconMenuItem();
            this.menuMantenimientos = new FontAwesome.Sharp.IconMenuItem();
            this.btn_Categoria = new FontAwesome.Sharp.IconMenuItem();
            this.btn_Producto = new FontAwesome.Sharp.IconMenuItem();
            this.MenuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.btn_RCompras = new FontAwesome.Sharp.IconMenuItem();
            this.btn_Detcompras = new FontAwesome.Sharp.IconMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.btn_RVentas = new FontAwesome.Sharp.IconMenuItem();
            this.btn_DetVentas = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.reporteDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Info = new FontAwesome.Sharp.IconMenuItem();
            this.TopBar_title = new System.Windows.Forms.MenuStrip();
            this.iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem9 = new FontAwesome.Sharp.IconMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.LeftBar_Button.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem2.Text = "iconMenuItem2";
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem3.Text = "iconMenuItem3";
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem4.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem4.Text = "iconMenuItem4";
            // 
            // LeftBar_Button
            // 
            this.LeftBar_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.LeftBar_Button.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBar_Button.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.LeftBar_Button.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Usuario,
            this.menuMantenimientos,
            this.MenuCompras,
            this.menuVentas,
            this.menuReportes,
            this.btn_Info});
            this.LeftBar_Button.Location = new System.Drawing.Point(0, 81);
            this.LeftBar_Button.Name = "LeftBar_Button";
            this.LeftBar_Button.Size = new System.Drawing.Size(197, 636);
            this.LeftBar_Button.TabIndex = 0;
            this.LeftBar_Button.Text = "menuStrip1";
            // 
            // btn_Usuario
            // 
            this.btn_Usuario.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.btn_Usuario.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.btn_Usuario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btn_Usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Usuario.IconSize = 1000;
            this.btn_Usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Usuario.Name = "btn_Usuario";
            this.btn_Usuario.Size = new System.Drawing.Size(184, 30);
            this.btn_Usuario.Text = "Usuario";
            this.btn_Usuario.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Usuario.Click += new System.EventHandler(this.iconMenuItem6_Click);
            // 
            // menuMantenimientos
            // 
            this.menuMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Categoria,
            this.btn_Producto});
            this.menuMantenimientos.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMantenimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.menuMantenimientos.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.menuMantenimientos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.menuMantenimientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMantenimientos.IconSize = 100;
            this.menuMantenimientos.Name = "menuMantenimientos";
            this.menuMantenimientos.Size = new System.Drawing.Size(184, 30);
            this.menuMantenimientos.Text = "Productos        ";
            this.menuMantenimientos.Click += new System.EventHandler(this.btn_Mantenimiento_Click);
            // 
            // btn_Categoria
            // 
            this.btn_Categoria.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Categoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Categoria.IconColor = System.Drawing.Color.Black;
            this.btn_Categoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Categoria.Name = "btn_Categoria";
            this.btn_Categoria.Size = new System.Drawing.Size(166, 26);
            this.btn_Categoria.Text = "Categoria";
            this.btn_Categoria.Click += new System.EventHandler(this.btn_Categoria_Click);
            // 
            // btn_Producto
            // 
            this.btn_Producto.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Producto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Producto.IconColor = System.Drawing.Color.Black;
            this.btn_Producto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Producto.Name = "btn_Producto";
            this.btn_Producto.Size = new System.Drawing.Size(166, 26);
            this.btn_Producto.Text = "Producto ";
            this.btn_Producto.Click += new System.EventHandler(this.btn_Producto_Click);
            // 
            // MenuCompras
            // 
            this.MenuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_RCompras,
            this.btn_Detcompras});
            this.MenuCompras.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.MenuCompras.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.MenuCompras.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.MenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuCompras.IconSize = 100;
            this.MenuCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuCompras.Name = "MenuCompras";
            this.MenuCompras.Size = new System.Drawing.Size(184, 30);
            this.MenuCompras.Text = "Entradas";
            // 
            // btn_RCompras
            // 
            this.btn_RCompras.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_RCompras.IconColor = System.Drawing.Color.Black;
            this.btn_RCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_RCompras.Name = "btn_RCompras";
            this.btn_RCompras.Size = new System.Drawing.Size(244, 26);
            this.btn_RCompras.Text = "Registro de Entradas";
            this.btn_RCompras.Click += new System.EventHandler(this.btn_RCompras_Click);
            // 
            // btn_Detcompras
            // 
            this.btn_Detcompras.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detcompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Detcompras.IconColor = System.Drawing.Color.Black;
            this.btn_Detcompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Detcompras.Name = "btn_Detcompras";
            this.btn_Detcompras.Size = new System.Drawing.Size(244, 26);
            this.btn_Detcompras.Text = "Detalle de Entradas";
            this.btn_Detcompras.Click += new System.EventHandler(this.btn_Detcompras_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_RVentas,
            this.btn_DetVentas});
            this.menuVentas.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.menuVentas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.IconSize = 100;
            this.menuVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(184, 30);
            this.menuVentas.Text = "Salidas";
            this.menuVentas.Click += new System.EventHandler(this.MenuVentas_Click);
            // 
            // btn_RVentas
            // 
            this.btn_RVentas.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_RVentas.IconColor = System.Drawing.Color.Black;
            this.btn_RVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_RVentas.Name = "btn_RVentas";
            this.btn_RVentas.Size = new System.Drawing.Size(222, 26);
            this.btn_RVentas.Text = "Registrar Salidas";
            this.btn_RVentas.Click += new System.EventHandler(this.btn_RVentas_Click);
            // 
            // btn_DetVentas
            // 
            this.btn_DetVentas.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DetVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_DetVentas.IconColor = System.Drawing.Color.Black;
            this.btn_DetVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DetVentas.Name = "btn_DetVentas";
            this.btn_DetVentas.Size = new System.Drawing.Size(222, 26);
            this.btn_DetVentas.Text = "Detalle de Salidas";
            this.btn_DetVentas.Click += new System.EventHandler(this.btn_DetVentas_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeComprasToolStripMenuItem,
            this.reporteDeVentasToolStripMenuItem});
            this.menuReportes.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.menuReportes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.IconSize = 100;
            this.menuReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(184, 30);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.Click += new System.EventHandler(this.menuReportes_Click);
            // 
            // reporteDeComprasToolStripMenuItem
            // 
            this.reporteDeComprasToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporteDeComprasToolStripMenuItem.Name = "reporteDeComprasToolStripMenuItem";
            this.reporteDeComprasToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.reporteDeComprasToolStripMenuItem.Text = "Reporte de Entradas";
            this.reporteDeComprasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeComprasToolStripMenuItem_Click);
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de Salidas";
            this.reporteDeVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasToolStripMenuItem_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.btn_Info.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btn_Info.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btn_Info.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_Info.IconSize = 100;
            this.btn_Info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(184, 30);
            this.btn_Info.Text = "Info";
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // TopBar_title
            // 
            this.TopBar_title.AutoSize = false;
            this.TopBar_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.TopBar_title.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TopBar_title.Location = new System.Drawing.Point(0, 0);
            this.TopBar_title.Name = "TopBar_title";
            this.TopBar_title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TopBar_title.Size = new System.Drawing.Size(1304, 81);
            this.TopBar_title.TabIndex = 1;
            this.TopBar_title.Text = "menuStrip2";
            // 
            // iconMenuItem5
            // 
            this.iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem5.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem5.Name = "iconMenuItem5";
            this.iconMenuItem5.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem5.Text = "iconMenuItem5";
            // 
            // iconMenuItem9
            // 
            this.iconMenuItem9.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem9.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem9.Name = "iconMenuItem9";
            this.iconMenuItem9.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem9.Text = "iconMenuItem9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "STOCK GUARD";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contenedor.Location = new System.Drawing.Point(197, 81);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1107, 636);
            this.Contenedor.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.lblName.Location = new System.Drawing.Point(938, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 26);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.lblUsuario.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.lblUsuario.Location = new System.Drawing.Point(1030, 29);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(114, 26);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1206, 18);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 47);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1304, 717);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeftBar_Button);
            this.Controls.Add(this.TopBar_title);
            this.Name = "PaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PaginaPrincipal";
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            this.LeftBar_Button.ResumeLayout(false);
            this.LeftBar_Button.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private System.Windows.Forms.MenuStrip LeftBar_Button;
        private FontAwesome.Sharp.IconMenuItem btn_Usuario;
        private System.Windows.Forms.MenuStrip TopBar_title;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem9;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuMantenimientos;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuCompras;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem btn_Info;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconMenuItem btn_Categoria;
        private FontAwesome.Sharp.IconMenuItem btn_Producto;
        private FontAwesome.Sharp.IconMenuItem btn_RVentas;
        private FontAwesome.Sharp.IconMenuItem btn_DetVentas;
        private FontAwesome.Sharp.IconMenuItem btn_RCompras;
        private FontAwesome.Sharp.IconMenuItem btn_Detcompras;
        private System.Windows.Forms.ToolStripMenuItem reporteDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}