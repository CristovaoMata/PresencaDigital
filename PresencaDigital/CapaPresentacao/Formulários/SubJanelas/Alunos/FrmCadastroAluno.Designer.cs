
namespace CapaPresentacao.Formulários.SubJanelas.Alunos
{
    partial class FrmCadastroAluno
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
            this.txtNome = new ControlesPersonalizados.CMControles.CMTextBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new ControlesPersonalizados.CMControles.CMButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbMasculino = new ControlesPersonalizados.CMControles.CMRadioButton();
            this.rbFemenino = new ControlesPersonalizados.CMControles.CMRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroBI = new ControlesPersonalizados.CMControles.CMTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroTelefone = new ControlesPersonalizados.CMControles.CMTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndereco = new ControlesPersonalizados.CMControles.CMTextBox();
            this.pcbDataNascimento = new ControlesPersonalizados.CMControles.CMDatePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new ControlesPersonalizados.CMControles.CMButton();
            this.btnCancelar = new ControlesPersonalizados.CMControles.CMButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbActivo = new ControlesPersonalizados.CMControles.CMRadioButton();
            this.rbInativo = new ControlesPersonalizados.CMControles.CMRadioButton();
            this.cmbCurso = new ControlesPersonalizados.CMControles.CMComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTurma = new ControlesPersonalizados.CMControles.CMComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new ControlesPersonalizados.CMControles.CMTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmCircularPictureBox1 = new ControlesPersonalizados.CMControles.CMCircularPictureBox();
            this.cmbClasse = new ControlesPersonalizados.CMControles.CMComboBox();
            this.panelTitulo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtNome.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNome.BorderRadius = 1;
            this.txtNome.BorderSize = 2;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(91, 84);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtNome.PasswordChar = false;
            this.txtNome.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNome.PlaceholderText = "";
            this.txtNome.ReadOnly = false;
            this.txtNome.Size = new System.Drawing.Size(265, 34);
            this.txtNome.TabIndex = 10;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.Texts = "";
            this.txtNome.UnderlinedStyle = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Controls.Add(this.btnFechar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(646, 51);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            this.panelTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseMove);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitulo.Location = new System.Drawing.Point(9, 5);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(584, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastrar Aluno";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseMove);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackGroundColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::CapaPresentacao.Properties.Resources.icons8_multiply_26px_1;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFechar.BorderRadius = 0;
            this.btnFechar.BorderSize = 0;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(612, 10);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 28);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.TextColor = System.Drawing.Color.White;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // rbMasculino
            // 
            this.rbMasculino.Checked = true;
            this.rbMasculino.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbMasculino.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(13, 19);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(2);
            this.rbMasculino.MinimumSize = new System.Drawing.Size(100, 25);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(101, 25);
            this.rbMasculino.TabIndex = 4;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoEllipsis = true;
            this.rbFemenino.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbFemenino.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemenino.Location = new System.Drawing.Point(15, 50);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(2);
            this.rbFemenino.MinimumSize = new System.Drawing.Size(100, 25);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(101, 28);
            this.rbFemenino.TabIndex = 5;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Controls.Add(this.rbFemenino);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox1.Location = new System.Drawing.Point(20, 337);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(161, 86);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nº B.I:";
            // 
            // txtNumeroBI
            // 
            this.txtNumeroBI.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumeroBI.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtNumeroBI.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNumeroBI.BorderRadius = 1;
            this.txtNumeroBI.BorderSize = 2;
            this.txtNumeroBI.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumeroBI.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNumeroBI.ForeColor = System.Drawing.Color.Black;
            this.txtNumeroBI.Location = new System.Drawing.Point(91, 125);
            this.txtNumeroBI.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNumeroBI.MaxLength = 32767;
            this.txtNumeroBI.Multiline = false;
            this.txtNumeroBI.Name = "txtNumeroBI";
            this.txtNumeroBI.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtNumeroBI.PasswordChar = false;
            this.txtNumeroBI.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumeroBI.PlaceholderText = "";
            this.txtNumeroBI.ReadOnly = false;
            this.txtNumeroBI.Size = new System.Drawing.Size(265, 34);
            this.txtNumeroBI.TabIndex = 7;
            this.txtNumeroBI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumeroBI.Texts = "";
            this.txtNumeroBI.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nº Tel:";
            // 
            // txtNumeroTelefone
            // 
            this.txtNumeroTelefone.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumeroTelefone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtNumeroTelefone.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNumeroTelefone.BorderRadius = 1;
            this.txtNumeroTelefone.BorderSize = 2;
            this.txtNumeroTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumeroTelefone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNumeroTelefone.ForeColor = System.Drawing.Color.Black;
            this.txtNumeroTelefone.Location = new System.Drawing.Point(91, 167);
            this.txtNumeroTelefone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNumeroTelefone.MaxLength = 32767;
            this.txtNumeroTelefone.Multiline = false;
            this.txtNumeroTelefone.Name = "txtNumeroTelefone";
            this.txtNumeroTelefone.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtNumeroTelefone.PasswordChar = false;
            this.txtNumeroTelefone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumeroTelefone.PlaceholderText = "";
            this.txtNumeroTelefone.ReadOnly = false;
            this.txtNumeroTelefone.Size = new System.Drawing.Size(265, 34);
            this.txtNumeroTelefone.TabIndex = 9;
            this.txtNumeroTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumeroTelefone.Texts = "";
            this.txtNumeroTelefone.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndereco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtEndereco.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEndereco.BorderRadius = 1;
            this.txtEndereco.BorderSize = 2;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEndereco.ForeColor = System.Drawing.Color.Black;
            this.txtEndereco.Location = new System.Drawing.Point(91, 210);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEndereco.MaxLength = 32767;
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtEndereco.PasswordChar = false;
            this.txtEndereco.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEndereco.PlaceholderText = "";
            this.txtEndereco.ReadOnly = false;
            this.txtEndereco.Size = new System.Drawing.Size(265, 67);
            this.txtEndereco.TabIndex = 11;
            this.txtEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEndereco.Texts = "";
            this.txtEndereco.UnderlinedStyle = false;
            // 
            // pcbDataNascimento
            // 
            this.pcbDataNascimento.Border = 2;
            this.pcbDataNascimento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.pcbDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pcbDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pcbDataNascimento.Location = new System.Drawing.Point(216, 296);
            this.pcbDataNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.pcbDataNascimento.MinimumSize = new System.Drawing.Size(4, 35);
            this.pcbDataNascimento.Name = "pcbDataNascimento";
            this.pcbDataNascimento.Size = new System.Drawing.Size(140, 35);
            this.pcbDataNascimento.SkinColor = System.Drawing.Color.White;
            this.pcbDataNascimento.TabIndex = 13;
            this.pcbDataNascimento.TextColor = System.Drawing.Color.Black;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 296);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data de Nacimento:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnGuardar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(124, 448);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 32);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnCancelar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 0;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(6, 448);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 32);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbActivo);
            this.groupBox2.Controls.Add(this.rbInativo);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox2.Location = new System.Drawing.Point(194, 337);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(161, 86);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aluno";
            // 
            // rbActivo
            // 
            this.rbActivo.Checked = true;
            this.rbActivo.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbActivo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbActivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivo.Location = new System.Drawing.Point(10, 18);
            this.rbActivo.Margin = new System.Windows.Forms.Padding(2);
            this.rbActivo.MinimumSize = new System.Drawing.Size(100, 25);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(101, 25);
            this.rbActivo.TabIndex = 4;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // rbInativo
            // 
            this.rbInativo.AutoEllipsis = true;
            this.rbInativo.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbInativo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInativo.Location = new System.Drawing.Point(12, 50);
            this.rbInativo.Margin = new System.Windows.Forms.Padding(2);
            this.rbInativo.MinimumSize = new System.Drawing.Size(100, 25);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(101, 28);
            this.rbInativo.TabIndex = 5;
            this.rbInativo.Text = "Inactivo";
            this.rbInativo.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // cmbCurso
            // 
            this.cmbCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cmbCurso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cmbCurso.BorderSize = 0;
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbCurso.ForeColor = System.Drawing.Color.White;
            this.cmbCurso.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbCurso.ItemHeight = 17;
            this.cmbCurso.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cmbCurso.ListFont = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCurso.ListTextColor = System.Drawing.Color.White;
            this.cmbCurso.Location = new System.Drawing.Point(71, 501);
            this.cmbCurso.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCurso.MinimumSize = new System.Drawing.Size(150, 24);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(284, 31);
            this.cmbCurso.TabIndex = 19;
            this.cmbCurso.Texts = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 503);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Curso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 446);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Classe:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(190, 446);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "Turma:";
            // 
            // cmbTurma
            // 
            this.cmbTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cmbTurma.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cmbTurma.BorderSize = 0;
            this.cmbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurma.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbTurma.ForeColor = System.Drawing.Color.White;
            this.cmbTurma.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTurma.ItemHeight = 17;
            this.cmbTurma.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cmbTurma.ListFont = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTurma.ListTextColor = System.Drawing.Color.White;
            this.cmbTurma.Location = new System.Drawing.Point(248, 446);
            this.cmbTurma.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTurma.MinimumSize = new System.Drawing.Size(75, 24);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(107, 31);
            this.cmbTurma.TabIndex = 23;
            this.cmbTurma.Texts = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmCircularPictureBox1);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(405, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 510);
            this.panel1.TabIndex = 25;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtID.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txtID.BorderRadius = 1;
            this.txtID.BorderSize = 2;
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(99, 15);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtID.MaxLength = 32767;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtID.PasswordChar = false;
            this.txtID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtID.PlaceholderText = "";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(89, 34);
            this.txtID.TabIndex = 27;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.Texts = "";
            this.txtID.UnderlinedStyle = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 28);
            this.label9.TabIndex = 27;
            this.label9.Text = "ID:";
            // 
            // cmCircularPictureBox1
            // 
            this.cmCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.cmCircularPictureBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmCircularPictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cmCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.cmCircularPictureBox1.BorderSize = 0;
            this.cmCircularPictureBox1.GradientAngle = 50F;
            this.cmCircularPictureBox1.Image = global::CapaPresentacao.Properties.Resources.icons8_male_user_120px;
            this.cmCircularPictureBox1.Location = new System.Drawing.Point(32, 75);
            this.cmCircularPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.cmCircularPictureBox1.Name = "cmCircularPictureBox1";
            this.cmCircularPictureBox1.Size = new System.Drawing.Size(183, 183);
            this.cmCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmCircularPictureBox1.TabIndex = 3;
            this.cmCircularPictureBox1.TabStop = false;
            // 
            // cmbClasse
            // 
            this.cmbClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cmbClasse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cmbClasse.BorderSize = 0;
            this.cmbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasse.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbClasse.ForeColor = System.Drawing.Color.White;
            this.cmbClasse.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbClasse.ItemHeight = 17;
            this.cmbClasse.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cmbClasse.ListFont = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClasse.ListTextColor = System.Drawing.Color.White;
            this.cmbClasse.Location = new System.Drawing.Point(71, 446);
            this.cmbClasse.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClasse.MinimumSize = new System.Drawing.Size(75, 24);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(110, 31);
            this.cmbClasse.TabIndex = 26;
            this.cmbClasse.Texts = "";
            // 
            // FrmCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(646, 561);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTurma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pcbDataNascimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroBI);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadastroAluno";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroAluno";
            this.Load += new System.EventHandler(this.FrmCadastroAluno_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmCadastroAluno_Paint);
            this.panelTitulo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label1;
        private ControlesPersonalizados.CMControles.CMCircularPictureBox cmCircularPictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ControlesPersonalizados.CMControles.CMButton btnFechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public ControlesPersonalizados.CMControles.CMTextBox txtNumeroBI;
        public ControlesPersonalizados.CMControles.CMTextBox txtNumeroTelefone;
        public ControlesPersonalizados.CMControles.CMTextBox txtEndereco;
        public ControlesPersonalizados.CMControles.CMDatePicker pcbDataNascimento;
        private ControlesPersonalizados.CMControles.CMButton btnGuardar;
        private ControlesPersonalizados.CMControles.CMButton btnCancelar;
        public ControlesPersonalizados.CMControles.CMTextBox txtNome;
        public ControlesPersonalizados.CMControles.CMRadioButton rbMasculino;
        public ControlesPersonalizados.CMControles.CMRadioButton rbFemenino;
        private System.Windows.Forms.GroupBox groupBox2;
        public ControlesPersonalizados.CMControles.CMRadioButton rbActivo;
        public ControlesPersonalizados.CMControles.CMRadioButton rbInativo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        public ControlesPersonalizados.CMControles.CMComboBox cmbCurso;
        public ControlesPersonalizados.CMControles.CMComboBox cmbTurma;
        public System.Windows.Forms.Label lblTitulo;
        public ControlesPersonalizados.CMControles.CMComboBox cmbClasse;
        public ControlesPersonalizados.CMControles.CMTextBox txtID;
        private System.Windows.Forms.Label label9;
    }
}