
namespace CapaPresentacao.Formulários.JanelasInicio
{
    partial class FrmLogin
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
            this.txtUsuario = new ControlesPersonalizados.CMControles.CMTextBox();
            this.txtSenha = new ControlesPersonalizados.CMControles.CMTextBox();
            this.btnEntrar = new ControlesPersonalizados.CMControles.CMButton();
            this.lblErro = new System.Windows.Forms.Label();
            this.tbVerSenha = new ControlesPersonalizados.CMControles.CMToggleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvisivel = new ControlesPersonalizados.CMControles.CMTextBox();
            this.btnMinimizar = new ControlesPersonalizados.CMControles.CMButton();
            this.btnFechar = new ControlesPersonalizados.CMControles.CMButton();
            this.pbErro = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(250, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Controle de Acesso";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtUsuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUsuario.BorderFocusColor = System.Drawing.Color.MediumVioletRed;
            this.txtUsuario.BorderRadius = 0;
            this.txtUsuario.BorderSize = 2;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuario.Location = new System.Drawing.Point(231, 78);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceholderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUsuario.PlaceholderText = "Usuário";
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.Size = new System.Drawing.Size(268, 34);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.Texts = "";
            this.txtUsuario.UnderlinedStyle = true;
            this.txtUsuario.Enter += new System.EventHandler(this.txtSenha_Enter);
            // 
            // txtSenha
            // 
            this.txtSenha.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtSenha.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSenha.BorderFocusColor = System.Drawing.Color.MediumVioletRed;
            this.txtSenha.BorderRadius = 0;
            this.txtSenha.BorderSize = 2;
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSenha.Location = new System.Drawing.Point(231, 144);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSenha.PasswordChar = true;
            this.txtSenha.PlaceholderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSenha.PlaceholderText = "Senha";
            this.txtSenha.ReadOnly = false;
            this.txtSenha.Size = new System.Drawing.Size(268, 34);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.Texts = "";
            this.txtSenha.UnderlinedStyle = true;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnEntrar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnEntrar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEntrar.BorderRadius = 76;
            this.btnEntrar.BorderSize = 1;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(312, 258);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 76);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.TextColor = System.Drawing.Color.White;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblErro
            // 
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.lblErro.Location = new System.Drawing.Point(262, 213);
            this.lblErro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(266, 37);
            this.lblErro.TabIndex = 11;
            this.lblErro.Text = "Lamentamos! o Usuário ou a Senha esta errada, verifica e tente novamente\r\n";
            this.lblErro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErro.Visible = false;
            // 
            // tbVerSenha
            // 
            this.tbVerSenha.AutoSize = true;
            this.tbVerSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.tbVerSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbVerSenha.Location = new System.Drawing.Point(231, 188);
            this.tbVerSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbVerSenha.MinimumSize = new System.Drawing.Size(34, 18);
            this.tbVerSenha.Name = "tbVerSenha";
            this.tbVerSenha.OffBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbVerSenha.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbVerSenha.OnBackColor = System.Drawing.Color.MediumVioletRed;
            this.tbVerSenha.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbVerSenha.Size = new System.Drawing.Size(34, 18);
            this.tbVerSenha.SolidStyle = false;
            this.tbVerSenha.TabIndex = 4;
            this.tbVerSenha.UseVisualStyleBackColor = true;
            this.tbVerSenha.CheckedChanged += new System.EventHandler(this.tbVerSenha_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(268, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ver Senha";
            // 
            // txtInvisivel
            // 
            this.txtInvisivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtInvisivel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtInvisivel.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtInvisivel.BorderRadius = 0;
            this.txtInvisivel.BorderSize = 2;
            this.txtInvisivel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtInvisivel.Font = new System.Drawing.Font("Century Gothic", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvisivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtInvisivel.Location = new System.Drawing.Point(98, 272);
            this.txtInvisivel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtInvisivel.MaxLength = 32767;
            this.txtInvisivel.Multiline = false;
            this.txtInvisivel.Name = "txtInvisivel";
            this.txtInvisivel.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtInvisivel.PasswordChar = false;
            this.txtInvisivel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtInvisivel.PlaceholderText = "";
            this.txtInvisivel.ReadOnly = false;
            this.txtInvisivel.Size = new System.Drawing.Size(1, 15);
            this.txtInvisivel.TabIndex = 0;
            this.txtInvisivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtInvisivel.Texts = "";
            this.txtInvisivel.UnderlinedStyle = true;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnMinimizar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnMinimizar.BackgroundImage = global::CapaPresentacao.Properties.Resources.icons8_subtract_16px;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMinimizar.BorderRadius = 31;
            this.btnMinimizar.BorderSize = 1;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(470, 8);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 31);
            this.btnMinimizar.TabIndex = 15;
            this.btnMinimizar.TextColor = System.Drawing.Color.White;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnFechar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnFechar.BackgroundImage = global::CapaPresentacao.Properties.Resources.icons8_multiply_16px;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.btnFechar.BorderRadius = 31;
            this.btnFechar.BorderSize = 1;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(506, 8);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 31);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.TextColor = System.Drawing.Color.White;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pbErro
            // 
            this.pbErro.Image = global::CapaPresentacao.Properties.Resources.icons8_error_120px;
            this.pbErro.Location = new System.Drawing.Point(231, 219);
            this.pbErro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbErro.Name = "pbErro";
            this.pbErro.Size = new System.Drawing.Size(26, 29);
            this.pbErro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbErro.TabIndex = 10;
            this.pbErro.TabStop = false;
            this.pbErro.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacao.Properties.Resources.icons8_password_1_120px;
            this.pictureBox1.Location = new System.Drawing.Point(9, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(546, 361);
            this.Controls.Add(this.txtInvisivel);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVerSenha);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.pbErro);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ControlesPersonalizados.CMControles.CMTextBox txtUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ControlesPersonalizados.CMControles.CMTextBox txtSenha;
        private ControlesPersonalizados.CMControles.CMButton btnEntrar;
        private System.Windows.Forms.PictureBox pbErro;
        private System.Windows.Forms.Label lblErro;
        private ControlesPersonalizados.CMControles.CMToggleButton tbVerSenha;
        private System.Windows.Forms.Label label2;
        private ControlesPersonalizados.CMControles.CMButton btnMinimizar;
        private ControlesPersonalizados.CMControles.CMButton btnFechar;
        private ControlesPersonalizados.CMControles.CMTextBox txtInvisivel;
    }
}