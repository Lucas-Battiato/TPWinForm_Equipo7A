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

            } catch (Exception e) {
                throw e;

            } finally {
                conector.cerrarConexion();

            }
        }
    }
}
