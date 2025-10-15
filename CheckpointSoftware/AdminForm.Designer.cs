namespace CheckpointSoftware
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.Label();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new CheckpointSoftware.masterDataSet();
            this.productoTableAdapter = new CheckpointSoftware.masterDataSetTableAdapters.ProductoTableAdapter();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAlertas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido/a";
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(578, 63);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(105, 38);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "@user";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(154, 157);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(284, 83);
            this.btnProductos.TabIndex = 6;
            this.btnProductos.Text = "Gestionar Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(154, 292);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(284, 92);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "Gestionar Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 83);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gestionar Sedes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlertas
            // 
            this.btnAlertas.Location = new System.Drawing.Point(601, 292);
            this.btnAlertas.Name = "btnAlertas";
            this.btnAlertas.Size = new System.Drawing.Size(237, 92);
            this.btnAlertas.TabIndex = 9;
            this.btnAlertas.Text = "Ver Alertas";
            this.btnAlertas.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 508);
            this.Controls.Add(this.btnAlertas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUser;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private masterDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAlertas;
    }
}