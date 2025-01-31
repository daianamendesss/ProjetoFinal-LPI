namespace AgendaMedica
{
	partial class formPrincipal
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.painelMenu = new System.Windows.Forms.Panel();
            this.btnConfig = new FontAwesome.Sharp.IconButton();
            this.btn_Listar = new FontAwesome.Sharp.IconButton();
            this.btn_Cadastrar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Icone = new FontAwesome.Sharp.IconPictureBox();
            this.painelTitulo = new System.Windows.Forms.Panel();
            this.btnFechar = new FontAwesome.Sharp.IconButton();
            this.Titulo = new System.Windows.Forms.Label();
            this.painelPrincipal = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.txtdatahora = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmaCadastro = new FontAwesome.Sharp.IconButton();
            this.txtmotivo = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddPaciente = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.btnAddMedicos = new FontAwesome.Sharp.IconButton();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabListar = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBuscaMedico = new System.Windows.Forms.TextBox();
            this.btnAlterar = new FontAwesome.Sharp.IconButton();
            this.btnExcluir = new FontAwesome.Sharp.IconButton();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgConsultas = new System.Windows.Forms.DataGridView();
            this.tabAlterar = new System.Windows.Forms.TabPage();
            this.txtalteradata = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmaAlteracao = new FontAwesome.Sharp.IconButton();
            this.txtalteramotivo = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbAlterapaciente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAlteramedico = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCadastrarUser = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnovasenha = new System.Windows.Forms.TextBox();
            this.txtnovouser = new System.Windows.Forms.TextBox();
            this.lblmsgerro = new System.Windows.Forms.Label();
            this.painelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Icone)).BeginInit();
            this.painelTitulo.SuspendLayout();
            this.painelPrincipal.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.tabListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).BeginInit();
            this.tabAlterar.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelMenu
            // 
            this.painelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(58)))));
            this.painelMenu.Controls.Add(this.btnConfig);
            this.painelMenu.Controls.Add(this.btn_Listar);
            this.painelMenu.Controls.Add(this.btn_Cadastrar);
            this.painelMenu.Controls.Add(this.panel2);
            this.painelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelMenu.Location = new System.Drawing.Point(0, 0);
            this.painelMenu.Name = "painelMenu";
            this.painelMenu.Size = new System.Drawing.Size(220, 592);
            this.painelMenu.TabIndex = 0;
            // 
            // btnConfig
            // 
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnConfig.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnConfig.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 532);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(220, 60);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "Configuração";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btn_Listar
            // 
            this.btn_Listar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Listar.FlatAppearance.BorderSize = 0;
            this.btn_Listar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Listar.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Listar.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btn_Listar.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Listar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Listar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Listar.Location = new System.Drawing.Point(0, 200);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(220, 60);
            this.btn_Listar.TabIndex = 2;
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Listar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Cadastrar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_Cadastrar.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Cadastrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cadastrar.Location = new System.Drawing.Point(0, 140);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(220, 60);
            this.btn_Cadastrar.TabIndex = 1;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_Icone);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 140);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(40, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "AGENDA MÉDICA";
            // 
            // btn_Icone
            // 
            this.btn_Icone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(58)))));
            this.btn_Icone.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Icone.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.btn_Icone.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Icone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Icone.IconSize = 99;
            this.btn_Icone.Location = new System.Drawing.Point(3, 3);
            this.btn_Icone.Name = "btn_Icone";
            this.btn_Icone.Size = new System.Drawing.Size(217, 99);
            this.btn_Icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Icone.TabIndex = 1;
            this.btn_Icone.TabStop = false;
            this.btn_Icone.Click += new System.EventHandler(this.btn_Icone_Click);
            // 
            // painelTitulo
            // 
            this.painelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.painelTitulo.Controls.Add(this.btnFechar);
            this.painelTitulo.Controls.Add(this.Titulo);
            this.painelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelTitulo.Location = new System.Drawing.Point(220, 0);
            this.painelTitulo.Name = "painelTitulo";
            this.painelTitulo.Size = new System.Drawing.Size(753, 75);
            this.painelTitulo.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnFechar.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.btnFechar.IconColor = System.Drawing.Color.White;
            this.btnFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFechar.Location = new System.Drawing.Point(702, 9);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(39, 37);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Titulo.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.Titulo.Location = new System.Drawing.Point(228, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(295, 37);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Registro de Consultas";
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.Controls.Add(this.tabHome);
            this.painelPrincipal.Controls.Add(this.tabCadastrar);
            this.painelPrincipal.Controls.Add(this.tabListar);
            this.painelPrincipal.Controls.Add(this.tabAlterar);
            this.painelPrincipal.Controls.Add(this.tabConfig);
            this.painelPrincipal.Location = new System.Drawing.Point(220, 143);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.SelectedIndex = 0;
            this.painelPrincipal.Size = new System.Drawing.Size(753, 449);
            this.painelPrincipal.TabIndex = 2;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.tabHome.BackgroundImage = global::AgendaMedica.Properties.Resources.kisspng_pharmacy_health_care_computer_icons_medicine_medical_snake_5b3054836b1fb4_0388120215298940194388;
            this.tabHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabHome.Location = new System.Drawing.Point(4, 24);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(745, 421);
            this.tabHome.TabIndex = 3;
            this.tabHome.Text = "Home";
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.tabCadastrar.Controls.Add(this.txtdatahora);
            this.tabCadastrar.Controls.Add(this.btnConfirmaCadastro);
            this.tabCadastrar.Controls.Add(this.txtmotivo);
            this.tabCadastrar.Controls.Add(this.label5);
            this.tabCadastrar.Controls.Add(this.btnAddPaciente);
            this.tabCadastrar.Controls.Add(this.label4);
            this.tabCadastrar.Controls.Add(this.cbPaciente);
            this.tabCadastrar.Controls.Add(this.btnAddMedicos);
            this.tabCadastrar.Controls.Add(this.cbMedico);
            this.tabCadastrar.Controls.Add(this.label3);
            this.tabCadastrar.Controls.Add(this.label2);
            this.tabCadastrar.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.tabCadastrar.Location = new System.Drawing.Point(4, 24);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrar.Size = new System.Drawing.Size(745, 421);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Cadastrar";
            // 
            // txtdatahora
            // 
            this.txtdatahora.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.txtdatahora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdatahora.Location = new System.Drawing.Point(177, 41);
            this.txtdatahora.Name = "txtdatahora";
            this.txtdatahora.Size = new System.Drawing.Size(426, 23);
            this.txtdatahora.TabIndex = 12;
            this.txtdatahora.Value = new System.DateTime(2022, 12, 1, 20, 3, 0, 0);
            this.txtdatahora.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnConfirmaCadastro
            // 
            this.btnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaCadastro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmaCadastro.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnConfirmaCadastro.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnConfirmaCadastro.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnConfirmaCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirmaCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaCadastro.Location = new System.Drawing.Point(293, 331);
            this.btnConfirmaCadastro.Name = "btnConfirmaCadastro";
            this.btnConfirmaCadastro.Size = new System.Drawing.Size(153, 56);
            this.btnConfirmaCadastro.TabIndex = 11;
            this.btnConfirmaCadastro.Text = "Cadastrar";
            this.btnConfirmaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmaCadastro.UseVisualStyleBackColor = true;
            this.btnConfirmaCadastro.Click += new System.EventHandler(this.btnConfirmaCadastro_Click);
            // 
            // txtmotivo
            // 
            this.txtmotivo.Location = new System.Drawing.Point(177, 182);
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(493, 82);
            this.txtmotivo.TabIndex = 10;
            this.txtmotivo.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(57, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Motivo:";
            // 
            // btnAddPaciente
            // 
            this.btnAddPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnAddPaciente.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddPaciente.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAddPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPaciente.Location = new System.Drawing.Point(631, 132);
            this.btnAddPaciente.Name = "btnAddPaciente";
            this.btnAddPaciente.Size = new System.Drawing.Size(39, 35);
            this.btnAddPaciente.TabIndex = 8;
            this.btnAddPaciente.UseVisualStyleBackColor = true;
            this.btnAddPaciente.Click += new System.EventHandler(this.btnAddPaciente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(57, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Paciente:";
            // 
            // cbPaciente
            // 
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(177, 140);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(426, 23);
            this.cbPaciente.TabIndex = 6;
            // 
            // btnAddMedicos
            // 
            this.btnAddMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnAddMedicos.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddMedicos.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAddMedicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddMedicos.Location = new System.Drawing.Point(631, 82);
            this.btnAddMedicos.Name = "btnAddMedicos";
            this.btnAddMedicos.Size = new System.Drawing.Size(39, 35);
            this.btnAddMedicos.TabIndex = 5;
            this.btnAddMedicos.UseVisualStyleBackColor = true;
            this.btnAddMedicos.Click += new System.EventHandler(this.btnAddMedicos_Click);
            // 
            // cbMedico
            // 
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Location = new System.Drawing.Point(177, 89);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(426, 23);
            this.cbMedico.TabIndex = 4;
            this.cbMedico.SelectedIndexChanged += new System.EventHandler(this.cbMedico_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(57, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Médico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data e Hora:";
            // 
            // tabListar
            // 
            this.tabListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.tabListar.Controls.Add(this.label11);
            this.tabListar.Controls.Add(this.txtBuscaMedico);
            this.tabListar.Controls.Add(this.btnAlterar);
            this.tabListar.Controls.Add(this.btnExcluir);
            this.tabListar.Controls.Add(this.txtBuscarCliente);
            this.tabListar.Controls.Add(this.label6);
            this.tabListar.Controls.Add(this.dgConsultas);
            this.tabListar.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.tabListar.Location = new System.Drawing.Point(4, 24);
            this.tabListar.Name = "tabListar";
            this.tabListar.Padding = new System.Windows.Forms.Padding(3);
            this.tabListar.Size = new System.Drawing.Size(745, 421);
            this.tabListar.TabIndex = 1;
            this.tabListar.Text = "Listar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(34, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 19);
            this.label11.TabIndex = 7;
            this.label11.Text = "Médico:";
            // 
            // txtBuscaMedico
            // 
            this.txtBuscaMedico.Location = new System.Drawing.Point(92, 56);
            this.txtBuscaMedico.Name = "txtBuscaMedico";
            this.txtBuscaMedico.Size = new System.Drawing.Size(292, 23);
            this.txtBuscaMedico.TabIndex = 6;
            this.txtBuscaMedico.TextChanged += new System.EventHandler(this.txtBuscaMedico_TextChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAlterar.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnAlterar.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAlterar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(574, 13);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(114, 65);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnExcluir.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.btnExcluir.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(424, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(114, 65);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(92, 17);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(292, 23);
            this.txtBuscarCliente.TabIndex = 3;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(34, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cliente:";
            // 
            // dgConsultas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.dgConsultas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgConsultas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.dgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgConsultas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgConsultas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.dgConsultas.Location = new System.Drawing.Point(6, 108);
            this.dgConsultas.Name = "dgConsultas";
            this.dgConsultas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgConsultas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgConsultas.RowTemplate.Height = 25;
            this.dgConsultas.Size = new System.Drawing.Size(733, 245);
            this.dgConsultas.TabIndex = 0;
            // 
            // tabAlterar
            // 
            this.tabAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.tabAlterar.Controls.Add(this.txtalteradata);
            this.tabAlterar.Controls.Add(this.btnConfirmaAlteracao);
            this.tabAlterar.Controls.Add(this.txtalteramotivo);
            this.tabAlterar.Controls.Add(this.label10);
            this.tabAlterar.Controls.Add(this.cbAlterapaciente);
            this.tabAlterar.Controls.Add(this.label9);
            this.tabAlterar.Controls.Add(this.cbAlteramedico);
            this.tabAlterar.Controls.Add(this.label8);
            this.tabAlterar.Controls.Add(this.label7);
            this.tabAlterar.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.tabAlterar.Location = new System.Drawing.Point(4, 24);
            this.tabAlterar.Name = "tabAlterar";
            this.tabAlterar.Size = new System.Drawing.Size(745, 421);
            this.tabAlterar.TabIndex = 2;
            this.tabAlterar.Text = "Alterar";
            this.tabAlterar.Click += new System.EventHandler(this.tabAlterar_Click);
            // 
            // txtalteradata
            // 
            this.txtalteradata.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.txtalteradata.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtalteradata.Location = new System.Drawing.Point(177, 41);
            this.txtalteradata.Name = "txtalteradata";
            this.txtalteradata.Size = new System.Drawing.Size(426, 23);
            this.txtalteradata.TabIndex = 13;
            // 
            // btnConfirmaAlteracao
            // 
            this.btnConfirmaAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaAlteracao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmaAlteracao.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnConfirmaAlteracao.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnConfirmaAlteracao.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnConfirmaAlteracao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirmaAlteracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.Location = new System.Drawing.Point(293, 331);
            this.btnConfirmaAlteracao.Name = "btnConfirmaAlteracao";
            this.btnConfirmaAlteracao.Size = new System.Drawing.Size(153, 56);
            this.btnConfirmaAlteracao.TabIndex = 12;
            this.btnConfirmaAlteracao.Text = "Alterar";
            this.btnConfirmaAlteracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmaAlteracao.UseVisualStyleBackColor = true;
            this.btnConfirmaAlteracao.Click += new System.EventHandler(this.btnConfirmaAlteracao_Click);
            // 
            // txtalteramotivo
            // 
            this.txtalteramotivo.Location = new System.Drawing.Point(177, 182);
            this.txtalteramotivo.Name = "txtalteramotivo";
            this.txtalteramotivo.Size = new System.Drawing.Size(493, 82);
            this.txtalteramotivo.TabIndex = 11;
            this.txtalteramotivo.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(57, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Motivo:";
            // 
            // cbAlterapaciente
            // 
            this.cbAlterapaciente.FormattingEnabled = true;
            this.cbAlterapaciente.Location = new System.Drawing.Point(177, 140);
            this.cbAlterapaciente.Name = "cbAlterapaciente";
            this.cbAlterapaciente.Size = new System.Drawing.Size(426, 23);
            this.cbAlterapaciente.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(57, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Paciente:";
            // 
            // cbAlteramedico
            // 
            this.cbAlteramedico.FormattingEnabled = true;
            this.cbAlteramedico.Location = new System.Drawing.Point(177, 89);
            this.cbAlteramedico.Name = "cbAlteramedico";
            this.cbAlteramedico.Size = new System.Drawing.Size(426, 23);
            this.cbAlteramedico.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(57, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Médico:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(57, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Data e Hora:";
            // 
            // tabConfig
            // 
            this.tabConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.tabConfig.Controls.Add(this.label14);
            this.tabConfig.Controls.Add(this.label13);
            this.tabConfig.Controls.Add(this.btnCadastrarUser);
            this.tabConfig.Controls.Add(this.label12);
            this.tabConfig.Controls.Add(this.txtnovasenha);
            this.tabConfig.Controls.Add(this.txtnovouser);
            this.tabConfig.Location = new System.Drawing.Point(4, 24);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Size = new System.Drawing.Size(745, 421);
            this.tabConfig.TabIndex = 4;
            this.tabConfig.Text = "Config";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label14.Location = new System.Drawing.Point(85, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 21);
            this.label14.TabIndex = 14;
            this.label14.Text = "Senha:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label13.Location = new System.Drawing.Point(85, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 21);
            this.label13.TabIndex = 13;
            this.label13.Text = "Nome de Usuário:";
            // 
            // btnCadastrarUser
            // 
            this.btnCadastrarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarUser.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCadastrarUser.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCadastrarUser.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCadastrarUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarUser.Location = new System.Drawing.Point(284, 314);
            this.btnCadastrarUser.Name = "btnCadastrarUser";
            this.btnCadastrarUser.Size = new System.Drawing.Size(153, 56);
            this.btnCadastrarUser.TabIndex = 12;
            this.btnCadastrarUser.Text = "Cadastrar";
            this.btnCadastrarUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarUser.UseVisualStyleBackColor = true;
            this.btnCadastrarUser.Click += new System.EventHandler(this.btnCadastrarUser_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label12.Location = new System.Drawing.Point(257, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(220, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Cadastrar novo usuário";
            // 
            // txtnovasenha
            // 
            this.txtnovasenha.Location = new System.Drawing.Point(224, 147);
            this.txtnovasenha.Name = "txtnovasenha";
            this.txtnovasenha.Size = new System.Drawing.Size(292, 23);
            this.txtnovasenha.TabIndex = 5;
            // 
            // txtnovouser
            // 
            this.txtnovouser.Location = new System.Drawing.Point(224, 70);
            this.txtnovouser.Name = "txtnovouser";
            this.txtnovouser.Size = new System.Drawing.Size(295, 23);
            this.txtnovouser.TabIndex = 4;
            // 
            // lblmsgerro
            // 
            this.lblmsgerro.AutoSize = true;
            this.lblmsgerro.ForeColor = System.Drawing.Color.White;
            this.lblmsgerro.Location = new System.Drawing.Point(272, 87);
            this.lblmsgerro.Name = "lblmsgerro";
            this.lblmsgerro.Size = new System.Drawing.Size(38, 15);
            this.lblmsgerro.TabIndex = 3;
            this.lblmsgerro.Text = "label7";
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(973, 592);
            this.Controls.Add(this.lblmsgerro);
            this.Controls.Add(this.painelPrincipal);
            this.Controls.Add(this.painelTitulo);
            this.Controls.Add(this.painelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Médica";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.painelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Icone)).EndInit();
            this.painelTitulo.ResumeLayout(false);
            this.painelTitulo.PerformLayout();
            this.painelPrincipal.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.tabListar.ResumeLayout(false);
            this.tabListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).EndInit();
            this.tabAlterar.ResumeLayout(false);
            this.tabAlterar.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Panel painelMenu;
		private FontAwesome.Sharp.IconButton btn_Listar;
		private FontAwesome.Sharp.IconButton btn_Cadastrar;
		private Panel panel2;
		private FontAwesome.Sharp.IconPictureBox btn_Icone;
		private Panel painelTitulo;
        private Label label1;
        private TabControl painelPrincipal;
        private TabPage tabCadastrar;
        private TabPage tabListar;
        private TabPage tabAlterar;
        private Label Titulo;
        private Label label2;
        private ComboBox cbPaciente;
        private FontAwesome.Sharp.IconButton btnAddMedicos;
        private ComboBox cbMedico;
        private Label label3;
        private Label label4;
        private RichTextBox txtmotivo;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnAddPaciente;
        private FontAwesome.Sharp.IconButton btnConfirmaCadastro;
        private FontAwesome.Sharp.IconButton btnAlterar;
        private FontAwesome.Sharp.IconButton btnExcluir;
        private TextBox txtBuscarCliente;
        private Label label6;
        private DataGridView dgConsultas;
		private Label lblmsgerro;
		private FontAwesome.Sharp.IconButton btnConfirmaAlteracao;
		private RichTextBox txtalteramotivo;
		private Label label10;
		private ComboBox cbAlterapaciente;
		private Label label9;
		private ComboBox cbAlteramedico;
		private Label label8;
		private Label label7;
        private DateTimePicker txtdatahora;
        private DateTimePicker txtalteradata;
        private TabPage tabHome;
        private FontAwesome.Sharp.IconButton btnFechar;
        private Label label11;
        private TextBox txtBuscaMedico;
        private FontAwesome.Sharp.IconButton btnConfig;
        private TabPage tabConfig;
        private Label label14;
        private Label label13;
        private FontAwesome.Sharp.IconButton btnCadastrarUser;
        private Label label12;
        private TextBox txtnovasenha;
        private TextBox txtnovouser;
    }
}
