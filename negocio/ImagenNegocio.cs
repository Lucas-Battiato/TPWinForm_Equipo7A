using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio {
    public class ImagenNegocio {

        public List<Imagen> listar() {
            List<Imagen> listaImagenes = new List<Imagen>();
            AccesoDatos conector = new AccesoDatos();

            try {
                conector.setearConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES");
                conector.ejecutarLectura();

                while (conector.Lector.Read()) {
                    Imagen imagenAux = new Imagen();
                    imagenAux.Id = (int)conector.Lector["Id"];
                    imagenAux.IdArticulo = (int)conector.Lector["IdArticulo"];
                    imagenAux.ImagenUrl = (string)conector.Lector["ImagenUrl"];

                    listaImagenes.Add(imagenAux);
                }

                return listaImagenes;

            } catch (Exception e) {
                throw e;

            } finally {
                conector.cerrarConexion();

            }
        }

        public void guardar(Imagen imagen) {
            AccesoDatos datos = new AccesoDatos();

            try {
                datos.setearConsulta($"INSERT INTO IMAGENES VALUES ('{imagen.IdArticulo}', '{imagen.ImagenUrl}')");
                datos.ejecutarAccion();

            } catch (Exception) {
                throw;

            } finally {
                datos.cerrarConexion();
            }
        }
    }
}
