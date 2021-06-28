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

namespace crudEF.Forms
{
    public partial class Proveedor : Form
    {
        private Db_Context db = new Db_Context();
        public Proveedor()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = db.Proveedores.ToList();
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvProveedores.Rows[e.RowIndex].Cells[0].Value;
            var p = db.Proveedores.Find(id);
            txtProveedorId.Text = p.Id.ToString();
            txtProveedorNombre.Text = p.Nombre.ToString();
            txtProveedorDirec.Text = p.Direccion.ToString();
            txtProvCorreo.Text = p.Correo.ToString();
            txtTelefono.Text = p.Telefono.ToString();
            if (p.Path != null)
            {
                pbProveedor.Image = Image.FromFile(p.Path);
                pbProveedor.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pbProveedor.Image = null;
            }
            btnEliminarProv.Enabled = true;
            btnActProveedor.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtProveedorId.Text = "";
            txtProveedorNombre.Text = "";
            txtProveedorDirec.Text = "";
            txtProvCorreo.Text = "";
            txtTelefono.Text = "";
            btnActProveedor.Enabled = false;
            btnEliminarProv.Enabled = false;
            pbProveedor.Image = null;
        }

        private void btnActProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtProveedorId.Text);
                Proveedores p = db.Proveedores.Find(id);
                p.Nombre = txtProveedorNombre.Text.ToString();
                p.Direccion = txtProveedorDirec.Text.ToString();
                p.Correo = txtProvCorreo.Text.ToString();
                p.Telefono = txtTelefono.Text.ToString();
                p.Path = pbProveedor.ImageLocation;

                db.SaveChanges();
                MessageBox.Show("Actualizacion exitosa");
                dgvProveedores.DataSource = db.Proveedores.ToList();

            }
            catch
            {
                MessageBox.Show("No se ha podido actualizar");

            }
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedores p = new Proveedores();
                p.Nombre = txtProveedorNombre.Text;
                p.Direccion = txtProveedorDirec.Text;
                p.Correo = txtProvCorreo.Text;
                p.Telefono = txtTelefono.Text;
                p.Path = pbProveedor.ImageLocation;
                db.Proveedores.Add(p);
                db.SaveChanges();
                dgvProveedores.DataSource = db.Proveedores.ToList();
                MessageBox.Show("Proveedor guardado");
            }
            catch
            {
                MessageBox.Show("El proveedor no se ha podido guardar");
            }

        }

        private void btnEliminarProv_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Esta seguro de eliminar?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtProveedorId.Text);
                    var p = db.Proveedores.Find(id);
                    db.Proveedores.Remove(p);
                    db.SaveChanges();
                    dgvProveedores.DataSource = db.Proveedores .ToList();
                    MessageBox.Show("Eliminacion Exitosa");
                    btnLimpiar_Click(null, null);
                }

            }
            catch
            {
                MessageBox.Show("No se ha podido eliminar");
            }
        }

        private void btnAddImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                pbProveedor.Image = Image.FromFile(fo.FileName);
                pbProveedor.ImageLocation = fo.FileName;
                pbProveedor.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
    
}
