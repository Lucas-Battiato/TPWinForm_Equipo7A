using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio {
    public class MarcaNegocio {

        public List<Marca> listar() {
            List<Marca> listaMarcas = new List<Marca>();
            AccesoDatos conector = new AccesoDatos();

            try {
                conector.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                conector.ejecutarLectura();

                while (conector.Lector.Read()) {
                    Marca marcaAux = new Marca();
                    marcaAux.Id = (int)conector.Lector["Id"];
                    marcaAux.Descripcion = (string)conector.Lector["Descripcion"];

                    listaMarcas.Add(marcaAux);
                }

                return listaMarcas;

            } catch {
                throw;

            } finally {
                conector.cerrarConexion();

            }
        }


        public void guardar(string descripcion) {
            AccesoDatos datos = new AccesoDatos();
            try {
                datos.setearConsulta($"INSERT INTO MARCAS (Descripcion) VALUES ('{descripcion}')");
                datos.ejecutarAccion();
            } catch { throw; } finally { datos.cerrarConexion(); }
        }

        public int contarProductosRelacionados(int id) {
            AccesoDatos datos = new AccesoDatos();
            try {
                datos.setearConsulta($"SELECT COUNT(*) FROM ARTICULOS WHERE IdMarca = {id}");
                datos.ejecutarLectura();
                if (datos.Lector.Read()) {
                    return (int)datos.Lector[0];
                }
                return 0;
            } catch { throw; } finally { datos.cerrarConexion(); }
        }

        public void eliminar(int id) {
            AccesoDatos datos = new AccesoDatos();
            try {
                datos.setearConsulta($"DELETE FROM MARCAS WHERE Id = {id}");
                datos.ejecutarAccion();
            } catch { throw; } finally { datos.cerrarConexion(); }
        }

        public Marca buscarPorId(int id) {
            AccesoDatos conector = new AccesoDatos();

            try {
                conector.setearConsulta($"SELECT Id, Descripcion FROM MARCAS WHERE Id = {id}");
                conector.ejecutarLectura();

                Marca marcaAux = new Marca();
                if (conector.Lector.Read()) {
                    marcaAux.Id = (int)conector.Lector["Id"];
                    marcaAux.Descripcion = (string)conector.Lector["Descripcion"];

                } else {
                    marcaAux.Id = -1;
                    marcaAux.Descripcion = "N/A";
                }

                return marcaAux;

            } catch {
                throw;

            } finally {
                conector.cerrarConexion();

            }
        }
    }
}

