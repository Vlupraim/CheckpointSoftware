namespace CheckpointSoftware
{
    partial class UsuariosVen
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordHashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosUsuarios = new CheckpointSoftware.DatosUsuarios();
            this.usuarioTableAdapter = new CheckpointSoftware.DatosUsuariosTableAdapters.UsuarioTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnAgregarUser = new System.Windows.Forms.Button();
            this.Activo = new System.Windows.Forms.Label();
            this.cbxActivo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordHashDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.usuarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(816, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordHashDataGridViewTextBoxColumn
            // 
            this.passwordHashDataGridViewTextBoxColumn.DataPropertyName = "PasswordHash";
            this.passwordHashDataGridViewTextBoxColumn.HeaderText = "PasswordHash";
            this.passwordHashDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordHashDataGridViewTextBoxColumn.Name = "passwordHashDataGridViewTextBoxColumn";
            this.passwordHashDataGridViewTextBoxColumn.Width = 150;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.Width = 150;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.datosUsuarios;
            // 
            // datosUsuarios
            // 
            this.datosUsuarios.DataSetName = "DatosUsuarios";
            this.datosUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestión de Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agregar Usuarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(272, 355);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(278, 26);
            this.txtID.TabIndex = 8;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(272, 395);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(278, 26);
            this.txtUsuario.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(272, 436);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(278, 26);
            this.txtEmail.TabIndex = 10;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(272, 469);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(278, 26);
            this.txtClave.TabIndex = 11;
            // 
            // btnAgregarUser
            // 
            this.btnAgregarUser.Location = new System.Drawing.Point(218, 536);
            this.btnAgregarUser.Name = "btnAgregarUser";
            this.btnAgregarUser.Size = new System.Drawing.Size(200, 39);
            this.btnAgregarUser.TabIndex = 13;
            this.btnAgregarUser.Text = "Agregar Usuario";
            this.btnAgregarUser.UseVisualStyleBackColor = true;
            this.btnAgregarUser.Click += new System.EventHandler(this.btnAgregarUser_Click);
            // 
            // Activo
            // 
            this.Activo.AutoSize = true;
            this.Activo.Location = new System.Drawing.Point(156, 508);
            this.Activo.Name = "Activo";
            this.Activo.Size = new System.Drawing.Size(51, 20);
            this.Activo.TabIndex = 14;
            this.Activo.Text = "label7";
            // 
            // cbxActivo
            // 
            this.cbxActivo.AutoSize = true;
            this.cbxActivo.Location = new System.Drawing.Point(272, 506);
            this.cbxActivo.Name = "cbxActivo";
            this.cbxActivo.Size = new System.Drawing.Size(78, 24);
            this.cbxActivo.TabIndex = 15;
            this.cbxActivo.Text = "Activo";
            this.cbxActivo.UseVisualStyleBackColor = true;
            // 
            // UsuariosVen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 704);
            this.Controls.Add(this.cbxActivo);
            this.Controls.Add(this.Activo);
            this.Controls.Add(this.btnAgregarUser);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UsuariosVen";
            this.Text = "UsuariosVen";
            this.Load += new System.EventHandler(this.UsuariosVen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatosUsuarios datosUsuarios;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DatosUsuariosTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordHashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnAgregarUser;
        private System.Windows.Forms.Label Activo;
        private System.Windows.Forms.CheckBox cbxActivo;
    }
}