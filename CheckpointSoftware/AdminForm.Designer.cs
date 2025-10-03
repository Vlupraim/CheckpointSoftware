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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidaUtilDiasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new CheckpointSoftware.masterDataSet();
            this.productoTableAdapter = new CheckpointSoftware.masterDataSetTableAdapters.ProductoTableAdapter();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAlertas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 100);
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
            this.txtUser.Location = new System.Drawing.Point(414, 103);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(105, 38);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "@user";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.skuDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.unidadDataGridViewTextBoxColumn,
            this.vidaUtilDiasDataGridViewTextBoxColumn,
            this.tempMinDataGridViewTextBoxColumn,
            this.tempMaxDataGridViewTextBoxColumn,
            this.stockMinimoDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(330, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(668, 159);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // skuDataGridViewTextBoxColumn
            // 
            this.skuDataGridViewTextBoxColumn.DataPropertyName = "Sku";
            this.skuDataGridViewTextBoxColumn.HeaderText = "Sku";
            this.skuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            this.skuDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // unidadDataGridViewTextBoxColumn
            // 
            this.unidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad";
            this.unidadDataGridViewTextBoxColumn.HeaderText = "Unidad";
            this.unidadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unidadDataGridViewTextBoxColumn.Name = "unidadDataGridViewTextBoxColumn";
            this.unidadDataGridViewTextBoxColumn.Width = 150;
            // 
            // vidaUtilDiasDataGridViewTextBoxColumn
            // 
            this.vidaUtilDiasDataGridViewTextBoxColumn.DataPropertyName = "VidaUtilDias";
            this.vidaUtilDiasDataGridViewTextBoxColumn.HeaderText = "VidaUtilDias";
            this.vidaUtilDiasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vidaUtilDiasDataGridViewTextBoxColumn.Name = "vidaUtilDiasDataGridViewTextBoxColumn";
            this.vidaUtilDiasDataGridViewTextBoxColumn.Width = 150;
            // 
            // tempMinDataGridViewTextBoxColumn
            // 
            this.tempMinDataGridViewTextBoxColumn.DataPropertyName = "TempMin";
            this.tempMinDataGridViewTextBoxColumn.HeaderText = "TempMin";
            this.tempMinDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tempMinDataGridViewTextBoxColumn.Name = "tempMinDataGridViewTextBoxColumn";
            this.tempMinDataGridViewTextBoxColumn.Width = 150;
            // 
            // tempMaxDataGridViewTextBoxColumn
            // 
            this.tempMaxDataGridViewTextBoxColumn.DataPropertyName = "TempMax";
            this.tempMaxDataGridViewTextBoxColumn.HeaderText = "TempMax";
            this.tempMaxDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tempMaxDataGridViewTextBoxColumn.Name = "tempMaxDataGridViewTextBoxColumn";
            this.tempMaxDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockMinimoDataGridViewTextBoxColumn
            // 
            this.stockMinimoDataGridViewTextBoxColumn.DataPropertyName = "StockMinimo";
            this.stockMinimoDataGridViewTextBoxColumn.HeaderText = "StockMinimo";
            this.stockMinimoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockMinimoDataGridViewTextBoxColumn.Name = "stockMinimoDataGridViewTextBoxColumn";
            this.stockMinimoDataGridViewTextBoxColumn.Width = 150;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.Width = 150;
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
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(92, 563);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(164, 51);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(379, 563);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(221, 51);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar Stock";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(737, 563);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(187, 51);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar base de datos (es mentira)";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(60, 170);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(213, 38);
            this.btnProductos.TabIndex = 6;
            this.btnProductos.Text = "Gestionar Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(60, 246);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(213, 40);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "Gestionar Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gestionar Sedes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAlertas
            // 
            this.btnAlertas.Location = new System.Drawing.Point(60, 417);
            this.btnAlertas.Name = "btnAlertas";
            this.btnAlertas.Size = new System.Drawing.Size(213, 41);
            this.btnAlertas.TabIndex = 9;
            this.btnAlertas.Text = "Ver Alertas";
            this.btnAlertas.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 931);
            this.Controls.Add(this.btnAlertas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private masterDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidaUtilDiasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAlertas;
    }
}