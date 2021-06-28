using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crudEF.Entities;

namespace crudEF
{
    public partial class Products : Form
    {
        private Db_Context db = new Db_Context();
        public Products()
        {
            InitializeComponent();
        }

        private void Poductos_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = db.Productos.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvProductos.Rows[e.RowIndex].Cells[0].Value;
            var p = db.Productos.Find(id);
            txtProductoId.Text = p.Id.ToString();
            txtProductoNombre.Text = p.Nombre.ToString();
            txtProductoDesc.Text = p.Descripcion.ToString();
            nupPrecio.Value = new decimal((double)p.Precio);
            nupStock.Value = p.Stock;
            if (p.Path != null)
            {
                pbProducto.Image = Image.FromFile(p.Path);
                pbProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pbProducto.Image = null;
            }
            btnEliminarProd.Enabled = true;
            btnActProducto.Enabled = true;
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Productos p = new Productos();
                p.Nombre = txtProductoNombre.Text;
                p.Descripcion = txtProductoDesc.Text;
                p.Precio = (decimal)nupPrecio.Value;
                p.Stock = (int)nupStock.Value;
                p.Path = pbProducto.ImageLocation;
                db.Productos.Add(p);
                db.SaveChanges();
                dgvProductos.DataSource = db.Productos.ToList();
                MessageBox.Show("Producto guardado");
            }
            catch
            {
                MessageBox.Show("El producto no se ha podido guardar");
            }
            

        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            
            try
            {
                var result = MessageBox.Show("Esta seguro de eliminar?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) 
                {
                    int id = Convert.ToInt32(txtProductoId.Text);
                    var p = db.Productos.Find(id);
                    db.Productos.Remove(p);
                    db.SaveChanges();
                    dgvProductos.DataSource = db.Productos.ToList();
                    MessageBox.Show("Eliminacion Exitosa");
                    btnLimpiar_Click(null, null);
                }
                
            }
            catch
            {
                MessageBox.Show("No se ha podido eliminar");
            }
        }

        private void btnActProducto_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtProductoId.Text);
                Productos p = db.Productos.Find(id);
                p.Descripcion = txtProductoNombre.Text.ToString();
                p.Nombre = txtProductoNombre.Text.ToString();
                p.Precio = nupPrecio.Value;
                p.Stock = (int)nupStock.Value;
                p.Path = pbProducto.ImageLocation;

                db.SaveChanges();
                MessageBox.Show("Actualizacion exitosa");
                dgvProductos.DataSource = db.Productos.ToList();
                 
            }
            catch
            {
                MessageBox.Show("No se ha podido actualizar");

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtProductoId.Text = "";
            txtProductoNombre.Text = "";
            txtProductoDesc.Text = "";
            nupPrecio.Value = 0;
            nupStock.Value = 0;
            btnActProducto.Enabled = false;
            btnEliminarProd.Enabled = false;
            pbProducto.Image = null;
        }

        private void btnAddImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                pbProducto.Image = Image.FromFile(fo.FileName);
                pbProducto.ImageLocation = fo.FileName;
                pbProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
