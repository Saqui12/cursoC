using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.CodeDom;

namespace datos
{
    public class DiscoDatos
    {
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS;database=DISCOS_DB; integrated security= true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Titulo,CantidadCanciones,UrlImagenTapa,E.Descripcion Estilo,T.Descripcion Tipos, IdEstilo, IdTipoEdicion,DISCOS.Id from DISCOS  ,ESTILOS E, TIPOSEDICION T WHERE E.Id = DISCOS.IdESTILO AND T.Id=DISCOS.IdTipoEdicion";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)lector["Titulo"];
                    aux.CantidadCanciones = (Int32)lector["CantidadCanciones"];
                    aux.Id = (int)lector["Id"];
                    // aux.FechaLanzamiento = (string)lector["FechaLanzamiento"];
                    if(!(lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];

                    aux.Estilo = new Estilos();
                    aux.Estilo.Id = (int)lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)lector["Estilo"];
                    aux.Edicion = new Edicion();
                    aux.Edicion.Id = (int)lector["IdTipoEdicion"];
                    aux.Edicion.Descripcion = (string)lector["Tipos"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void agregar(Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into DISCOS (Titulo, CantidadCanciones, UrlImagenTapa,IdEstilo,IdTipoEdicion)values('" + nuevo.Titulo + "', " + nuevo.CantidadCanciones + ", '" + nuevo.UrlImagenTapa + "',@IdEstilo,@IdTipoEdicion)");
                datos.setearParametro("@IdEstilo", nuevo.Estilo.Id);
                datos.setearParametro("@IdTipoEdicion", nuevo.Edicion.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificar(Disco modificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update DISCOS set Titulo = @titulo, CantidadCanciones = @canciones, UrlImagenTapa = @img, IdEstilo = @idEstilo, IdTipoEdicion = @idTipoEdicion Where Id = @id");
                datos.setearParametro("@titulo",modificado.Titulo);
                datos.setearParametro("@canciones", modificado.CantidadCanciones);
                datos.setearParametro("@img",modificado.UrlImagenTapa);
                datos.setearParametro("@IdEstilo",modificado.Estilo.Id);
                datos.setearParametro("@IdTipoEdicion", modificado.Edicion.Id);
                datos.setearParametro("@id", modificado.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from discos where Id = @Id");
                datos.setearParametro("Id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
