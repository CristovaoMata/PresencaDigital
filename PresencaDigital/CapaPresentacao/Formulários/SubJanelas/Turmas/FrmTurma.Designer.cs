
namespace CapaPresentacao.Formulários.SubJanelas.Turmas
{
    partial class FrmTurma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnFechar = new ControlesPersonalizados.CMControles.CMButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBuscaClasse = new ControlesPersonalizados.CMControles.CMTextBox();
            this.txtBuscaTurma = new ControlesPersonalizados.CMControles.CMTextBox();
            this.txtBuscaCurso = new ControlesPersonalizados.CMControles.CMTextBox();
            this.txtBuscaPeriodo = new ControlesPersonalizados.CMControles.CMTextBox();
            this.txtBuscaSala = new ControlesPersonalizados.CMControles.CMTextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnVerMais = new ControlesPersonalizados.CMControles.CMButton();
            this.btnEliminar = new ControlesPersonalizados.CMControles.CMButton();
            this.btnEditar = new ControlesPersonalizados.CMControles.CMButton();
            this.btnNovo = new ControlesPersonalizados.CMControles.CMButton();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.cmbCurso = new ControlesPersonalizados.CMControles.CMComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPeriodo = new ControlesPersonalizados.CMControles.CMComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTurma = new ControlesPersonalizados.CMControles.CMTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClasse = new ControlesPersonalizados.CMControles.CMTextBox();
            this.btnGuardar = new ControlesPersonalizados.CMControles.CMButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSala = new ControlesPersonalizados.CMControles.CMTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.btnFechar);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(980, 62);
            this.panelTitulo.TabIndex = 10;
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
            this.btnFechar.Location = new System.Drawing.Point(925, 9);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(33, 35);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.TextColor = System.Drawing.Color.White;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.lblTitulo.Location = new System.Drawing.Point(25, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(873, 50);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Lista de Todos os Cursos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.txtBuscaClasse);
            this.flowLayoutPanel1.Controls.Add(this.txtBuscaTurma);
            this.flowLayoutPanel1.Controls.Add(this.txtBuscaCurso);
            this.flowLayoutPanel1.Controls.Add(this.txtBuscaPeriodo);
            this.flowLayoutPanel1.Controls.Add(this.txtBuscaSala);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(980, 95);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // txtBuscaClasse
            // 
            this.txtBuscaClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtBuscaClasse.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBuscaClasse.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBuscaClasse.BorderRadius = 20;
            this.txtBuscaClasse.BorderSize = 2;
            this.txtBuscaClasse.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscaClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaClasse.ForeColor = System.Drawing.Color.White;
            this.txtBuscaClasse.Location = new System.Drawing.Point(13, 4);
            this.txtBuscaClasse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscaClasse.MaxLength = 32767;
            this.txtBuscaClasse.Multiline = false;
            this.txtBuscaClasse.Name = "txtBuscaClasse";
            this.txtBuscaClasse.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscaClasse.PasswordChar = false;
            this.txtBuscaClasse.PlaceholderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBuscaClasse.PlaceholderText = "Buscar por Classe..";
            this.txtBuscaClasse.ReadOnly = false;
            this.txtBuscaClasse.Size = new System.Drawing.Size(250, 35);
            this.txtBuscaClasse.TabIndex = 0;
            this.txtBuscaClasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscaClasse.Texts = "";
            this.txtBuscaClasse.UnderlinedStyle = false;
            this.txtBuscaClasse._textChaged += new System.EventHandler(this.txtBuscaClasse__textChaged);
            // 
            // txtBuscaTurma
            // 
            this.txtBuscaTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtBuscaTurma.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBuscaTurma.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBuscaTurma.BorderRadius = 20;
            this.txtBuscaTurma.BorderSize = 2;
            this.txtBuscaTurma.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscaTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaTurma.ForeColor = System.Drawing.Color.White;
            this.txtBuscaTurma.Location = new System.Drawing.Point(269, 4);
            this.txtBuscaTurma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscaTurma.MaxLength = 32767;
            this.txtBuscaTurma.Multiline = false;
            this.txtBuscaTurma.Name = "txtBuscaTurma";
            this.txtBuscaTurma.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscaTurma.PasswordChar = false;
            this.txtBuscaTurma.PlaceholderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBuscaTurma.PlaceholderText = "Buscar por Turma...";
            this.txtBuscaTurma.ReadOnly = false;
            this.txtBuscaTurma.Size = new System.Drawing.Size(250, 35);
            this.txtBuscaTurma.TabIndex = 3;
            this.txtBuscaTurma.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscaTurma.Texts = "";
            this.txtBuscaTurma.UnderlinedStyle = false;
            this.txtBuscaTurma._textChaged += new System.EventHandler(this.txtBuscaTurma__textChaged);
            // 
            // txtBuscaCurso
            // 
            this.txtBuscaCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtBuscaCurso.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBuscaCurso.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBuscaCurso.BorderRadius = 20;
            this.txtBuscaCurso.BorderSize = 2;
            this.txtBuscaCurso.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscaCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaCurso.ForeColor = System.Drawing.Color.White;
            this.txtBuscaCurso.Location = new System.Drawing.Point(525, 4);
            this.txtBuscaCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscaCurso.MaxLength = 32767;
            this.txtBuscaCurso.Multiline = false;
            this.txtBuscaCurso.Name = "txtBuscaCurso";
            this.txtBuscaCurso.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscaCurso.PasswordChar = false;
            this.txtBuscaCurso.PlaceholderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBuscaCurso.PlaceholderText = "Buscar por Curso...";
            this.txtBuscaCurso.ReadOnly = false;
            this.txtBuscaCurso.Size = new System.Drawing.Size(250, 35);
            this.txtBuscaCurso.TabIndex = 1;
            this.txtBuscaCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscaCurso.Texts = "";
            this.txtBuscaCurso.UnderlinedStyle = false;
            this.txtBuscaCurso._textChaged += new System.EventHandler(this.txtBuscaCurso__textChaged);
            // 
            // txtBuscaPeriodo
            // 
            this.txtBuscaPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtBuscaPeriodo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBuscaPeriodo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBuscaPeriodo.BorderRadius = 20;
            this.txtBuscaPeriodo.BorderSize = 2;
            this.txtBuscaPeriodo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscaPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaPeriodo.ForeColor = System.Drawing.Color.White;
            this.txtBuscaPeriodo.Location = new System.Drawing.Point(13, 47);
            this.txtBuscaPeriodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscaPeriodo.MaxLength = 32767;
            this.txtBuscaPeriodo.Multiline = false;
            this.txtBuscaPeriodo.Name = "txtBuscaPeriodo";
            this.txtBuscaPeriodo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscaPeriodo.PasswordChar = false;
            this.txtBuscaPeriodo.PlaceholderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBuscaPeriodo.PlaceholderText = "Buscar por Período...";
            this.txtBuscaPeriodo.ReadOnly = false;
            this.txtBuscaPeriodo.Size = new System.Drawing.Size(250, 35);
            this.txtBuscaPeriodo.TabIndex = 4;
            this.txtBuscaPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscaPeriodo.Texts = "";
            this.txtBuscaPeriodo.UnderlinedStyle = false;
            this.txtBuscaPeriodo._textChaged += new System.EventHandler(this.txtBuscaPeriodo__textChaged);
            // 
            // txtBuscaSala
            // 
            this.txtBuscaSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtBuscaSala.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBuscaSala.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBuscaSala.BorderRadius = 20;
            this.txtBuscaSala.BorderSize = 2;
            this.txtBuscaSala.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscaSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaSala.ForeColor = System.Drawing.Color.White;
            this.txtBuscaSala.Location = new System.Drawing.Point(269, 47);
            this.txtBuscaSala.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscaSala.MaxLength = 32767;
            this.txtBuscaSala.Multiline = false;
            this.txtBuscaSala.Name = "txtBuscaSala";
            this.txtBuscaSala.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscaSala.PasswordChar = false;
            this.txtBuscaSala.PlaceholderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBuscaSala.PlaceholderText = "Buscar por Sala...";
            this.txtBuscaSala.ReadOnly = false;
            this.txtBuscaSala.Size = new System.Drawing.Size(250, 35);
            this.txtBuscaSala.TabIndex = 5;
            this.txtBuscaSala.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscaSala.Texts = "";
            this.txtBuscaSala.UnderlinedStyle = false;
            this.txtBuscaSala._textChaged += new System.EventHandler(this.txtBuscaSala__textChaged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.dgv.Location = new System.Drawing.Point(32, 158);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 30;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(622, 420);
            this.dgv.TabIndex = 12;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // btnVerMais
            // 
            this.btnVerMais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVerMais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnVerMais.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnVerMais.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnVerMais.BorderRadius = 20;
            this.btnVerMais.BorderSize = 2;
            this.btnVerMais.FlatAppearance.BorderSize = 0;
            this.btnVerMais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVerMais.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnVerMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMais.ForeColor = System.Drawing.Color.White;
            this.btnVerMais.Image = global::CapaPresentacao.Properties.Resources.icons8_study_32px;
            this.btnVerMais.Location = new System.Drawing.Point(31, 623);
            this.btnVerMais.Name = "btnVerMais";
            this.btnVerMais.Size = new System.Drawing.Size(150, 48);
            this.btnVerMais.TabIndex = 18;
            this.btnVerMais.Text = "Ver  Mais";
            this.btnVerMais.TextColor = System.Drawing.Color.White;
            this.btnVerMais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerMais.UseVisualStyleBackColor = false;
            this.btnVerMais.Click += new System.EventHandler(this.btnVerMais_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnEliminar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.BorderSize = 2;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::CapaPresentacao.Properties.Resources.icons8_multiply_32px;
            this.btnEliminar.Location = new System.Drawing.Point(802, 623);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 48);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnEditar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnEditar.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditar.BorderRadius = 20;
            this.btnEditar.BorderSize = 2;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::CapaPresentacao.Properties.Resources.icons8_edit_32px;
            this.btnEditar.Location = new System.Drawing.Point(642, 623);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 48);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnNovo.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnNovo.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnNovo.BorderRadius = 20;
            this.btnNovo.BorderSize = 2;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Image = global::CapaPresentacao.Properties.Resources.icons8_plus_math_32px;
            this.btnNovo.Location = new System.Drawing.Point(483, 623);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(150, 48);
            this.btnNovo.TabIndex = 15;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextColor = System.Drawing.Color.White;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panelCampos
            // 
            this.panelCampos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCampos.AutoScroll = true;
            this.panelCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.panelCampos.Controls.Add(this.cmbCurso);
            this.panelCampos.Controls.Add(this.label5);
            this.panelCampos.Controls.Add(this.cmbPeriodo);
            this.panelCampos.Controls.Add(this.label4);
            this.panelCampos.Controls.Add(this.txtTurma);
            this.panelCampos.Controls.Add(this.label3);
            this.panelCampos.Controls.Add(this.txtClasse);
            this.panelCampos.Controls.Add(this.btnGuardar);
            this.panelCampos.Controls.Add(this.label1);
            this.panelCampos.Controls.Add(this.txtSala);
            this.panelCampos.Controls.Add(this.label2);
            this.panelCampos.Location = new System.Drawing.Point(660, 158);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(319, 420);
            this.panelCampos.TabIndex = 19;
            // 
            // cmbCurso
            // 
            this.cmbCurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCurso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCurso.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbCurso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cmbCurso.BorderSize = 0;
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbCurso.ForeColor = System.Drawing.Color.White;
            this.cmbCurso.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.cmbCurso.Items.AddRange(new object[] {
            "Manhã ",
            "Tarde",
            "Noite"});
            this.cmbCurso.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.cmbCurso.ListFont = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCurso.ListTextColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbCurso.Location = new System.Drawing.Point(16, 219);
            this.cmbCurso.MinimumSize = new System.Drawing.Size(100, 30);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(282, 38);
            this.cmbCurso.TabIndex = 28;
            this.cmbCurso.Texts = "";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(11, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Curso";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbPeriodo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cmbPeriodo.BorderSize = 0;
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbPeriodo.ForeColor = System.Drawing.Color.White;
            this.cmbPeriodo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.cmbPeriodo.Items.AddRange(new object[] {
            "Manhã ",
            "Tarde",
            "Noite"});
            this.cmbPeriodo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.cmbPeriodo.ListFont = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPeriodo.ListTextColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbPeriodo.Location = new System.Drawing.Point(16, 128);
            this.cmbPeriodo.MinimumSize = new System.Drawing.Size(100, 30);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(143, 38);
            this.cmbPeriodo.TabIndex = 26;
            this.cmbPeriodo.Texts = "";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(11, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Período";
            // 
            // txtTurma
            // 
            this.txtTurma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.txtTurma.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTurma.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTurma.BorderRadius = 1;
            this.txtTurma.BorderSize = 2;
            this.txtTurma.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurma.ForeColor = System.Drawing.Color.White;
            this.txtTurma.Location = new System.Drawing.Point(198, 42);
            this.txtTurma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTurma.MaxLength = 32767;
            this.txtTurma.Multiline = false;
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTurma.PasswordChar = false;
            this.txtTurma.PlaceholderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTurma.PlaceholderText = "";
            this.txtTurma.ReadOnly = false;
            this.txtTurma.Size = new System.Drawing.Size(101, 35);
            this.txtTurma.TabIndex = 21;
            this.txtTurma.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTurma.Texts = "";
            this.txtTurma.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(193, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Turma";
            // 
            // txtClasse
            // 
            this.txtClasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClasse.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.txtClasse.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtClasse.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtClasse.BorderRadius = 1;
            this.txtClasse.BorderSize = 2;
            this.txtClasse.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClasse.ForeColor = System.Drawing.Color.White;
            this.txtClasse.Location = new System.Drawing.Point(15, 42);
            this.txtClasse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClasse.MaxLength = 32767;
            this.txtClasse.Multiline = false;
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtClasse.PasswordChar = false;
            this.txtClasse.PlaceholderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtClasse.PlaceholderText = "";
            this.txtClasse.ReadOnly = false;
            this.txtClasse.Size = new System.Drawing.Size(144, 35);
            this.txtClasse.TabIndex = 19;
            this.txtClasse.Tag = "[0-9]";
            this.txtClasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClasse.Texts = "";
            this.txtClasse.UnderlinedStyle = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnGuardar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.BorderSize = 2;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::CapaPresentacao.Properties.Resources.icons8_save_32px;
            this.btnGuardar.Location = new System.Drawing.Point(89, 346);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 48);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Classe";
            // 
            // txtSala
            // 
            this.txtSala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.txtSala.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSala.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSala.BorderRadius = 1;
            this.txtSala.BorderSize = 2;
            this.txtSala.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSala.ForeColor = System.Drawing.Color.White;
            this.txtSala.Location = new System.Drawing.Point(198, 128);
            this.txtSala.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSala.MaxLength = 32767;
            this.txtSala.Multiline = false;
            this.txtSala.Name = "txtSala";
            this.txtSala.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSala.PasswordChar = false;
            this.txtSala.PlaceholderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSala.PlaceholderText = "";
            this.txtSala.ReadOnly = false;
            this.txtSala.Size = new System.Drawing.Size(100, 35);
            this.txtSala.TabIndex = 16;
            this.txtSala.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSala.Texts = "";
            this.txtSala.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(193, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Sala";
            // 
            // FrmTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(980, 700);
            this.Controls.Add(this.panelCampos);
            this.Controls.Add(this.btnVerMais);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTurma";
            this.Load += new System.EventHandler(this.FrmTurma_Load);
            this.panelTitulo.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private ControlesPersonalizados.CMControles.CMButton btnFechar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ControlesPersonalizados.CMControles.CMTextBox txtBuscaClasse;
        private ControlesPersonalizados.CMControles.CMTextBox txtBuscaTurma;
        private ControlesPersonalizados.CMControles.CMTextBox txtBuscaCurso;
        private ControlesPersonalizados.CMControles.CMTextBox txtBuscaPeriodo;
        private ControlesPersonalizados.CMControles.CMTextBox txtBuscaSala;
        private System.Windows.Forms.DataGridView dgv;
        private ControlesPersonalizados.CMControles.CMButton btnVerMais;
        private ControlesPersonalizados.CMControles.CMButton btnEliminar;
        private ControlesPersonalizados.CMControles.CMButton btnEditar;
        private ControlesPersonalizados.CMControles.CMButton btnNovo;
        private System.Windows.Forms.Panel panelCampos;
        private ControlesPersonalizados.CMControles.CMButton btnGuardar;
        private System.Windows.Forms.Label label1;
        private ControlesPersonalizados.CMControles.CMTextBox txtSala;
        private System.Windows.Forms.Label label2;
        private ControlesPersonalizados.CMControles.CMTextBox txtTurma;
        private System.Windows.Forms.Label label3;
        private ControlesPersonalizados.CMControles.CMTextBox txtClasse;
        private System.Windows.Forms.Label label4;
        public ControlesPersonalizados.CMControles.CMComboBox cmbPeriodo;
        private System.Windows.Forms.Label label5;
        public ControlesPersonalizados.CMControles.CMComboBox cmbCurso;
    }
}