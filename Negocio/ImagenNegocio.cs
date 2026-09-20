using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> ListarPorArticulo(int idArticulo)
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo = @idArticulo");
                datos.SetearParametros("@idArticulo", idArticulo);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.id = (int)datos.Lector["Id"];
                    aux.idarticulo = (int)datos.Lector["IdArticulo"];
                    aux.urlimagen = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void Agregar(Imagen nueva)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(
                    "INSERT INTO IMAGENES (IdArticulo, ImagenUrl) " +
                    "VALUES (@IdArticulo, @ImagenUrl)"
                );

                datos.SetearParametros("@IdArticulo", nueva.idarticulo);
                datos.SetearParametros("@ImagenUrl", nueva.urlimagen);

                datos.EjecutarConsulta();
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void Eliminar(int idImagen)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("DELETE FROM IMAGENES WHERE Id = @Id");
                datos.SetearParametros("@Id", idImagen);
                datos.EjecutarConsulta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void Modificar(Imagen imagen)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("UPDATE IMAGENES SET ImagenUrl = @ImagenUrl WHERE Id = @Id");
                datos.SetearParametros("@ImagenUrl", imagen.urlimagen);
                datos.SetearParametros("@Id", imagen.id);

                datos.EjecutarConsulta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }




    }
}
