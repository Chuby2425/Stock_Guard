namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_login = new System.Windows.Forms.Label();
            this.png_login = new System.Windows.Forms.PictureBox();
            this.panel_Validation = new System.Windows.Forms.Panel();
            this.bt_cancelar = new FontAwesome.Sharp.IconButton();
            this.bt_Ingresar = new FontAwesome.Sharp.IconButton();
            this.lb_pasword = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.txt_pasword = new System.Windows.Forms.TextBox();
            this.txtb_id = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.png_login)).BeginInit();
            this.panel_Validation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lb_login);
            this.panel1.Controls.Add(this.png_login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_login.Location = new System.Drawing.Point(96, 284);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(130, 49);
            this.lb_login.TabIndex = 1;
            this.lb_login.Text = "Login";
            // 
            // png_login
            // 
            this.png_login.Image = ((System.Drawing.Image)(resources.GetObject("png_login.Image")));
            this.png_login.Location = new System.Drawing.Point(59, 49);
            this.png_login.Name = "png_login";
            this.png_login.Size = new System.Drawing.Size(211, 198);
            this.png_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.png_login.TabIndex = 0;
            this.png_login.TabStop = false;
            // 
            // panel_Validation
            // 
            this.panel_Validation.BackColor = System.Drawing.Color.White;
            this.panel_Validation.Controls.Add(this.bt_cancelar);
            this.panel_Validation.Controls.Add(this.bt_Ingresar);
            this.panel_Validation.Controls.Add(this.lb_pasword);
            this.panel_Validation.Controls.Add(this.lb_id);
            this.panel_Validation.Controls.Add(this.txt_pasword);
            this.panel_Validation.Controls.Add(this.txtb_id);
            this.panel_Validation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Validation.Location = new System.Drawing.Point(347, 0);
            this.panel_Validation.Name = "panel_Validation";
            this.panel_Validation.Size = new System.Drawing.Size(505, 450);
            this.panel_Validation.TabIndex = 1;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Red;
            this.bt_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_cancelar.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.bt_cancelar.IconColor = System.Drawing.Color.Black;
            this.bt_cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_cancelar.Location = new System.Drawing.Point(255, 300);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(199, 62);
            this.bt_cancelar.TabIndex = 10;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_Ingresar
            // 
            this.bt_Ingresar.BackColor = System.Drawing.Color.Teal;
            this.bt_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Ingresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_Ingresar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Ingresar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_Ingresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.bt_Ingresar.IconColor = System.Drawing.Color.Black;
            this.bt_Ingresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_Ingresar.Location = new System.Drawing.Point(51, 300);
            this.bt_Ingresar.Name = "bt_Ingresar";
            this.bt_Ingresar.Size = new System.Drawing.Size(198, 62);
            this.bt_Ingresar.TabIndex = 9;
            this.bt_Ingresar.Text = "Ingresar";
            this.bt_Ingresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Ingresar.UseVisualStyleBackColor = false;
            this.bt_Ingresar.Click += new System.EventHandler(this.bt_Ingresar_Click);
            // 
            // lb_pasword
            // 
            this.lb_pasword.AutoSize = true;
            this.lb_pasword.Location = new System.Drawing.Point(50, 191);
            this.lb_pasword.Name = "lb_pasword";
            this.lb_pasword.Size = new System.Drawing.Size(76, 16);
            this.lb_pasword.TabIndex = 8;
            this.lb_pasword.Text = "Contraseña";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(50, 84);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(140, 16);
            this.lb_id.TabIndex = 7;
            this.lb_id.Text = "Nunero de documento";
            // 
            // txt_pasword
            // 
            this.txt_pasword.Location = new System.Drawing.Point(51, 210);
            this.txt_pasword.Name = "txt_pasword";
            this.txt_pasword.PasswordChar = '*';
            this.txt_pasword.Size = new System.Drawing.Size(403, 22);
            this.txt_pasword.TabIndex = 6;
            this.txt_pasword.TextChanged += new System.EventHandler(this.txtb_pasword_TextChanged);
            // 
            // txtb_id
            // 
            this.txtb_id.Location = new System.Drawing.Point(51, 103);
            this.txtb_id.Name = "txtb_id";
            this.txtb_id.Size = new System.Drawing.Size(403, 22);
            this.txtb_id.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.panel_Validation);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.png_login)).EndInit();
            this.panel_Validation.ResumeLayout(false);
            this.panel_Validation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox png_login;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Panel panel_Validation;
        private System.Windows.Forms.Label lb_pasword;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox txt_pasword;
        private System.Windows.Forms.TextBox txtb_id;
        private FontAwesome.Sharp.IconButton bt_cancelar;
        private FontAwesome.Sharp.IconButton bt_Ingresar;
    }
}