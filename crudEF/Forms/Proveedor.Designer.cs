
namespace crudEF.Forms
{
    partial class Proveedor
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
            this.btnAddImagen = new System.Windows.Forms.Button();
            this.pbProveedor = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminarProv = new System.Windows.Forms.Button();
            this.btnActProveedor = new System.Windows.Forms.Button();
            this.btnGuardarProveedor = new System.Windows.Forms.Button();
            this.txtProveedorDirec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProveedorNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProveedorId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.txtProvCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddImagen
            // 
            this.btnAddImagen.Location = new System.Drawing.Point(826, 309);
            this.btnAddImagen.Name = "btnAddImagen";
            this.btnAddImagen.Size = new System.Drawing.Size(164, 29);
            this.btnAddImagen.TabIndex = 33;
            this.btnAddImagen.Text = "Agregar Imagen";
            this.btnAddImagen.UseVisualStyleBackColor = true;
            this.btnAddImagen.Click += new System.EventHandler(this.btnAddImagen_Click);
            // 
            // pbProveedor
            // 
            this.pbProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProveedor.Location = new System.Drawing.Point(826, 62);
            this.pbProveedor.Name = "pbProveedor";
            this.pbProveedor.Size = new System.Drawing.Size(164, 241);
            this.pbProveedor.TabIndex = 32;
            this.pbProveedor.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(915, 30);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 31;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminarProv
            // 
            this.btnEliminarProv.Enabled = false;
            this.btnEliminarProv.Location = new System.Drawing.Point(857, 360);
            this.btnEliminarProv.Name = "btnEliminarProv";
            this.btnEliminarProv.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProv.TabIndex = 30;
            this.btnEliminarProv.Text = "Eliminar";
            this.btnEliminarProv.UseVisualStyleBackColor = true;
            this.btnEliminarProv.Click += new System.EventHandler(this.btnEliminarProv_Click);
            // 
            // btnActProveedor
            // 
            this.btnActProveedor.Enabled = false;
            this.btnActProveedor.Location = new System.Drawing.Point(715, 360);
            this.btnActProveedor.Name = "btnActProveedor";
            this.btnActProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnActProveedor.TabIndex = 29;
            this.btnActProveedor.Text = "Actualizar";
            this.btnActProveedor.UseVisualStyleBackColor = true;
            this.btnActProveedor.Click += new System.EventHandler(this.btnActProveedor_Click);
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.Location = new System.Drawing.Point(569, 360);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarProveedor.TabIndex = 28;
            this.btnGuardarProveedor.Text = "Guardar";
            this.btnGuardarProveedor.UseVisualStyleBackColor = true;
            this.btnGuardarProveedor.Click += new System.EventHandler(this.btnGuardarProveedor_Click);
            // 
            // txtProveedorDirec
            // 
            this.txtProveedorDirec.Location = new System.Drawing.Point(516, 180);
            this.txtProveedorDirec.Multiline = true;
            this.txtProveedorDirec.Name = "txtProveedorDirec";
            this.txtProveedorDirec.Size = new System.Drawing.Size(286, 47);
            this.txtProveedorDirec.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Direccion:";
            // 
            // txtProveedorNombre
            // 
            this.txtProveedorNombre.Location = new System.Drawing.Point(516, 121);
            this.txtProveedorNombre.Name = "txtProveedorNombre";
            this.txtProveedorNombre.Size = new System.Drawing.Size(286, 23);
            this.txtProveedorNombre.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre:";
            // 
            // txtProveedorId
            // 
            this.txtProveedorId.Enabled = false;
            this.txtProveedorId.Location = new System.Drawing.Point(516, 62);
            this.txtProveedorId.Name = "txtProveedorId";
            this.txtProveedorId.Size = new System.Drawing.Size(286, 23);
            this.txtProveedorId.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Proveedor Id:";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(17, 39);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowTemplate.Height = 25;
            this.dgvProveedores.Size = new System.Drawing.Size(446, 344);
            this.dgvProveedores.TabIndex = 17;
            this.dgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellClick);
            // 
            // txtProvCorreo
            // 
            this.txtProvCorreo.Location = new System.Drawing.Point(516, 259);
            this.txtProvCorreo.Name = "txtProvCorreo";
            this.txtProvCorreo.Size = new System.Drawing.Size(286, 23);
            this.txtProvCorreo.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Correo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(516, 312);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(286, 23);
            this.txtTelefono.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Telefono:";
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 423);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProvCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddImagen);
            this.Controls.Add(this.pbProveedor);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminarProv);
            this.Controls.Add(this.btnActProveedor);
            this.Controls.Add(this.btnGuardarProveedor);
            this.Controls.Add(this.txtProveedorDirec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProveedorNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProveedorId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProveedores);
            this.Name = "Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();          

        }

        #endregion

        private System.Windows.Forms.Button btnAddImagen;
        private System.Windows.Forms.PictureBox pbProveedor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminarProv;
        private System.Windows.Forms.Button btnActProveedor;
        private System.Windows.Forms.Button btnGuardarProveedor;
        private System.Windows.Forms.TextBox txtProveedorDirec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProveedorNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProveedorId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.TextBox txtProvCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
    }
}