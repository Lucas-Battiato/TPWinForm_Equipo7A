using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio {
    public class CategoriaNegocio {

        public List<Categoria> listar() {
            List<Categoria> listaCategorias = new List<Categoria>();
            AccesoDatos conector = new AccesoDatos();

            try {
                conector.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                conector.ejecutarLectura();

                while (conector.Lector.Read()) {
                    Categoria categoriaAux = new Categoria();
                    categoriaAux.Id = (int)conector.Lector["Id"];
                    categoriaAux.Descripcion = (string)conector.Lector["Descripcion"];

                    listaCategorias.Add(categoriaAux);
                }

                return listaCategorias;

            } catch (Exception e) {
                throw e;

            } finally {
                conector.cerrarConexion();

            }
        }


        public Categoria buscarPorId(int id) {
            AccesoDatos conector = new AccesoDatos();

            try {
                conector.setearConsulta($"SELECT Id, Descripcion FROM CATEGORIAS WHERE Id = {id}");
                conector.ejecutarLectura();

                Categoria categoriaAux = new Categoria();
                if (conector.Lector.Read()) {
                    categoriaAux.Id = (int)conector.Lector["Id"];
                    categoriaAux.Descripcion = (string)conector.Lector["Descripcion"];

                } else {
                    categoriaAux.Id = -1;
                    categoriaAux.Descripcion = "N/A";
                }

                return categoriaAux;

            } catch (Exception e) {
                throw e;

            } finally {
                conector.cerrarConexion();

            }
        }
    }
}
