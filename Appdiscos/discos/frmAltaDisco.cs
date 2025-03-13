using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using datos;
using dominio;

namespace discos
{
    public partial class frmAltaDisco: Form
    {
        private Disco disco = null;
        public frmAltaDisco()
        {
            InitializeComponent();
        }
        public frmAltaDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            DiscoDatos Dato = new DiscoDatos();

            try
            {
                if (disco == null)
                    disco = new Disco();

                disco.Titulo = txtTitulo.Text;
                disco.CantidadCanciones = int.Parse(txtCanciones.Text);
                disco.UrlImagenTapa = txtImagen.Text;
                disco.Estilo = (Estilos)cbxEstilo.SelectedItem;
                disco.Edicion = (Edicion)cbxEdicion.SelectedItem;


                if (disco.Id != 0)
                {
                     Dato.modificar(disco);
                     MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    Dato.agregar(disco);
                    MessageBox.Show("Agregado exitosamente");

                }

                    Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void frmAltaDisco_Load(object sender, EventArgs e)
        {

            
            EdicionDatos edicionDatos = new EdicionDatos();
            EstiloDatos estiloDatos = new EstiloDatos();
            try
            {
                cbxEstilo.DataSource = estiloDatos.listar();
                cbxEstilo.ValueMember = "Id";
                cbxEstilo.DisplayMember = "Descripcion";
                cbxEdicion.DataSource = edicionDatos.listar();
                cbxEdicion.ValueMember = "Id";
                cbxEdicion.DisplayMember = "Descripcion";
                
                if (!(disco == null))
                {
                    txtTitulo.Text = disco.Titulo;
                    txtCanciones.Text= (disco.CantidadCanciones).ToString();
                    txtImagen.Text = disco.UrlImagenTapa;
                    cbxEstilo.SelectedValue = disco.Estilo.Id;
                    cbxEdicion.SelectedValue = disco.Edicion.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
