
using System;
using System.Windows.Forms;

namespace crudEF
{
    partial class Products
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductoId = new System.Windows.Forms.TextBox();
            this.txtProductoNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductoDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nupStock = new System.Windows.Forms.NumericUpDown();
            this.nupPrecio = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.btnActProducto = new System.Windows.Forms.Button();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pbProducto = new System.Windows.Forms.PictureBox();
            this.btnAddImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 51);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(446, 344);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto Id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProductoId
            // 
            this.txtProductoId.Enabled = false;
            this.txtProductoId.Location = new System.Drawing.Point(511, 98);
            this.txtProductoId.Name = "txtProductoId";
            this.txtProductoId.Size = new System.Drawing.Size(286, 23);
            this.txtProductoId.TabIndex = 2;
            // 
            // txtProductoNombre
            // 
            this.txtProductoNombre.Location = new System.Drawing.Point(511, 157);
            this.txtProductoNombre.Name = "txtProductoNombre";
            this.txtProductoNombre.Size = new System.Drawing.Size(286, 23);
            this.txtProductoNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Producto:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion:";
            // 
            // txtProductoDesc
            // 
            this.txtProductoDesc.Location = new System.Drawing.Point(511, 216);
            this.txtProductoDesc.Multiline = true;
            this.txtProductoDesc.Name = "txtProductoDesc";
            this.txtProductoDesc.Size = new System.Drawing.Size(286, 85);
            this.txtProductoDesc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stock:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nupStock
            // 
            this.nupStock.Location = new System.Drawing.Point(556, 333);
            this.nupStock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupStock.Name = "nupStock";
            this.nupStock.Size = new System.Drawing.Size(83, 23);
            this.nupStock.TabIndex = 8;
            // 
            // nupPrecio
            // 
            this.nupPrecio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nupPrecio.Location = new System.Drawing.Point(710, 333);
            this.nupPrecio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupPrecio.Name = "nupPrecio";
            this.nupPrecio.Size = new System.Drawing.Size(83, 23);
            this.nupPrecio.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio:";
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(564, 372);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarProducto.TabIndex = 11;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // btnActProducto
            // 
            this.btnActProducto.Enabled = false;
            this.btnActProducto.Location = new System.Drawing.Point(710, 372);
            this.btnActProducto.Name = "btnActProducto";
            this.btnActProducto.Size = new System.Drawing.Size(75, 23);
            this.btnActProducto.TabIndex = 12;
            this.btnActProducto.Text = "Actualizar";
            this.btnActProducto.UseVisualStyleBackColor = true;
            this.btnActProducto.Click += new System.EventHandler(this.btnActProducto_Click);
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.Enabled = false;
            this.btnEliminarProd.Location = new System.Drawing.Point(852, 372);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProd.TabIndex = 13;
            this.btnEliminarProd.Text = "Eliminar";
            this.btnEliminarProd.UseVisualStyleBackColor = true;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(910, 51);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pbProducto
            // 
            this.pbProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProducto.Location = new System.Drawing.Point(821, 98);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(164, 217);
            this.pbProducto.TabIndex = 15;
            this.pbProducto.TabStop = false;
            // 
            // btnAddImagen
            // 
            this.btnAddImagen.Location = new System.Drawing.Point(821, 321);
            this.btnAddImagen.Name = "btnAddImagen";
            this.btnAddImagen.Size = new System.Drawing.Size(164, 29);
            this.btnAddImagen.TabIndex = 16;
            this.btnAddImagen.Text = "Agregar Imagen";
            this.btnAddImagen.UseVisualStyleBackColor = true;
            this.btnAddImagen.Click += new System.EventHandler(this.btnAddImagen_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 423);
            this.Controls.Add(this.btnAddImagen);
            this.Controls.Add(this.pbProducto);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminarProd);
            this.Controls.Add(this.btnActProducto);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.nupPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nupStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductoDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductoId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductos);
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Poductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductoId;
        private System.Windows.Forms.TextBox txtProductoNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductoDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupStock;
        private System.Windows.Forms.NumericUpDown nupPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.Button btnActProducto;
        private System.Windows.Forms.Button btnEliminarProd;
        private Button btnLimpiar;
        private PictureBox pbProducto;
        private Button btnAddImagen;
    }
}

