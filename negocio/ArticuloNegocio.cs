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
        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {

                string consulta = "Select A.Id, Codigo, Nombre, A.Descripcion, Precio, A.IdMarca, A.IdCategoria, M.Descripcion Marca, C.Descripcion Categoria From ARTICULOS A, MARCAS M, CATEGORIAS C Where A.IdMarca = M.Id And A.IdCategoria = C.Id And ";

                if (campo == "Id")
                {
                    switch (criterio)
                    {
                        case "Mayor a": consulta += "A.Id > " + filtro; break;
                        case "Menor a": consulta += "A.Id < " + filtro; break;
                        default: consulta += "A.Id = " + filtro; break;
                    }
                }

                else if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a": consulta += "Precio > " + filtro; break;
                        case "Menor a": consulta += "Precio < " + filtro; break;
                        default: consulta += "Precio = " + filtro; break;
                    }
                }

                else if (campo == "Código" || campo == "Codigo")
                {
                    switch (criterio)
                    {
                        case "Comienza con": consulta += "Codigo like '" + filtro + "%' "; break;
                        case "Termina con": consulta += "Codigo like '%" + filtro + "'"; break;
                        default: consulta += "Codigo like '%" + filtro + "%'"; break;
                    }
                }

                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con": consulta += "Nombre like '" + filtro + "%' "; break;
                        case "Termina con": consulta += "Nombre like '%" + filtro + "'"; break;
                        default: consulta += "Nombre like '%" + filtro + "%'"; break;
                    }
                }

                else if (campo == "Marca")
                {
                    switch (criterio)
                    {
                        case "Comienza con": consulta += "M.Descripcion like '" + filtro + "%' "; break;
                        case "Termina con": consulta += "M.Descripcion like '%" + filtro + "'"; break;
                        default: consulta += "M.Descripcion like '%" + filtro + "%'"; break;
                    }
                }

                else if (campo == "Categoría" || campo == "Categoria")
                {
                    switch (criterio)
                    {
                        case "Comienza con": consulta += "C.Descripcion like '" + filtro + "%' "; break;
                        case "Termina con": consulta += "C.Descripcion like '%" + filtro + "'"; break;
                        default: consulta += "C.Descripcion like '%" + filtro + "%'"; break;
                    }
                }

                else
                {
                    switch (criterio)
                    {
                        case "Comienza con": consulta += "A.Descripcion like '" + filtro + "%' "; break;
                        case "Termina con": consulta += "A.Descripcion like '%" + filtro + "'"; break;
                        default: consulta += "A.Descripcion like '%" + filtro + "%'"; break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

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
    }
}