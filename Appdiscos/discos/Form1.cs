using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using datos;

namespace discos
{
    public partial class Form1: Form
    {
        private List<Disco> ListaDiscos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            DiscoDatos Datos = new DiscoDatos();
            ListaDiscos = Datos.listar();
            dgbDiscos.DataSource = ListaDiscos;
            ocultarColumnas();
            cargarImagen(ListaDiscos[0].UrlImagenTapa);

        }
        private void ocultarColumnas()
        {
            dgbDiscos.Columns["UrlImagenTapa"].Visible = false;
            dgbDiscos.Columns["Id"].Visible = false;
        }

        private void dgbDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgbDiscos.CurrentRow != null)
            {
                Disco seleccionado = (Disco)dgbDiscos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagenTapa);
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDisco.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxDisco.Load("https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.FgSHy4RMgjNNcLv1UqLDdgHaH_%26pid%3DApi&f=1&ipt=05598e45a51bb7a60ddc8376d02e6c543b53f1b3d9d7ae27bd7991f88c3b9a2e&ipo=images");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco alta = new frmAltaDisco();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado;
            seleccionado = (Disco)dgbDiscos.CurrentRow.DataBoundItem;

            frmAltaDisco alta = new frmAltaDisco(seleccionado);
            alta.ShowDialog();
            cargar();

        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            DiscoDatos datos = new DiscoDatos();
            Disco seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Disco)dgbDiscos.CurrentRow.DataBoundItem;
                    datos.eliminar(seleccionado.Id);
                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Disco> listaFiltrada;
            string filtro = txtFiltro.Text;
            if (filtro != "") 
            {
                listaFiltrada = ListaDiscos.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) || x.Estilo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = ListaDiscos;
            }
            dgbDiscos.DataSource = null;
            dgbDiscos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
    }
}
