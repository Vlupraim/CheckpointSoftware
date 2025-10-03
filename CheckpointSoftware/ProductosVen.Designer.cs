namespace CheckpointSoftware
{
    partial class ProductosVen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masterDataSet = new CheckpointSoftware.masterDataSet();
            this.masterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosProductos = new CheckpointSoftware.DatosProductos();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new CheckpointSoftware.DatosProductosTableAdapters.ProductoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidaUtilDiasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtVida = new System.Windows.Forms.TextBox();
            this.txtTempMin = new System.Windows.Forms.TextBox();
            this.txtTempMax = new System.Windows.Forms.TextBox();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSku = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Productos";
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
            this.dataGridView1.Location = new System.Drawing.Point(55, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1417, 127);
            this.dataGridView1.TabIndex = 1;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterDataSetBindingSource
            // 
            this.masterDataSetBindingSource.DataSource = this.masterDataSet;
            this.masterDataSetBindingSource.Position = 0;
            // 
            // datosProductos
            // 
            this.datosProductos.DataSetName = "DatosProductos";
            this.datosProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.datosProductos;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agregar Productos";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(176, 405);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(69, 20);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(269, 399);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(282, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vida util:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Temperatura Minima:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 558);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Temperatura Maxima:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 604);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Stock Minimo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 651);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Activo:";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(269, 439);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(282, 26);
            this.txtUnidad.TabIndex = 11;
            // 
            // txtVida
            // 
            this.txtVida.Location = new System.Drawing.Point(269, 478);
            this.txtVida.Name = "txtVida";
            this.txtVida.Size = new System.Drawing.Size(282, 26);
            this.txtVida.TabIndex = 12;
            // 
            // txtTempMin
            // 
            this.txtTempMin.Location = new System.Drawing.Point(269, 511);
            this.txtTempMin.Name = "txtTempMin";
            this.txtTempMin.Size = new System.Drawing.Size(282, 26);
            this.txtTempMin.TabIndex = 13;
            // 
            // txtTempMax
            // 
            this.txtTempMax.Location = new System.Drawing.Point(269, 550);
            this.txtTempMax.Name = "txtTempMax";
            this.txtTempMax.Size = new System.Drawing.Size(282, 26);
            this.txtTempMax.TabIndex = 14;
            // 
            // txtStockMin
            // 
            this.txtStockMin.Location = new System.Drawing.Point(269, 601);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(282, 26);
            this.txtStockMin.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(169, 686);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(287, 44);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(269, 646);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(109, 24);
            this.chkActivo.TabIndex = 18;
            this.chkActivo.Text = "Disponible";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Sku:";
            // 
            // txtSku
            // 
            this.txtSku.Location = new System.Drawing.Point(269, 358);
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(282, 26);
            this.txtSku.TabIndex = 20;
            // 
            // ProductosVen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 794);
            this.Controls.Add(this.txtSku);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtStockMin);
            this.Controls.Add(this.txtTempMax);
            this.Controls.Add(this.txtTempMin);
            this.Controls.Add(this.txtVida);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ProductosVen";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ProductosVen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource masterDataSetBindingSource;
        private masterDataSet masterDataSet;
        private DatosProductos datosProductos;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DatosProductosTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidaUtilDiasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtVida;
        private System.Windows.Forms.TextBox txtTempMin;
        private System.Windows.Forms.TextBox txtTempMax;
        private System.Windows.Forms.TextBox txtStockMin;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSku;
    }
}