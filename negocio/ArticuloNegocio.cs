using System;
using System.Collections.Generic;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {

                datos.setearConsulta("SELECT Id, Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria FROM ARTICULOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Marca = marcaNegocio.buscarPorId( (int) datos.Lector["IdMarca"] );
                    aux.Categoria = categoriaNegocio.buscarPorId( (int)datos.Lector["IdCategoria"] );
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
                datos.cerrarConexion();
            }
        }

        public void guardar(Articulo articulo) {
            AccesoDatos datos = new AccesoDatos();

            try {
                datos.setearConsulta($"INSERT INTO ARTICULOS VALUES ('{articulo.Codigo}', '{articulo.Nombre}', '{articulo.Descripcion}', {articulo.Marca.Id}, {articulo.Categoria.Id}, {articulo.Precio.ToString().Replace(",", ".")})");
                datos.ejecutarAccion();

            } catch (Exception) {
                throw;

            } finally {
                datos.cerrarConexion();
            }
        }


        public int obtenerIdArticuloPorCodigo(Articulo articulo) {
            AccesoDatos datos = new AccesoDatos();

            try {
                datos.setearConsulta($"SELECT Id FROM ARTICULOS WHERE Codigo = '{articulo.Codigo}'");
                datos.ejecutarLectura();

                if (datos.Lector.Read()) {
                    return (int)datos.Lector["Id"];

                } else return 0;

            } catch (Exception ex) {
                throw ex;

            } finally {
                datos.cerrarConexion();
            }
        }


        public void actualizarArticulo(Articulo articulo) {
            AccesoDatos datos = new AccesoDatos();

            try {
                datos.setearConsulta($"UPDATE ARTICULOS SET Codigo='{articulo.Codigo}', Nombre='{articulo.Nombre}', Descripcion='{articulo.Descripcion}', IdMarca={articulo.Marca.Id}, IdCategoria={articulo.Categoria.Id}, Precio={articulo.Precio.ToString().Replace(",", ".")} WHERE ID={articulo.Id}");
                datos.ejecutarAccion();


            } catch (Exception ex) {
                throw ex;

            } finally {
                datos.cerrarConexion();
            }



        }
    }
}