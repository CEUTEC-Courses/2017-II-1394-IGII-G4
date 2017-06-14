using TCS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCS.MenuFlota.Unidad
{
    public class CRUDUnidad
    {
        public void CrearUnidad(UnidadModelo unidad)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                var nuevaunidad = new unidad()
                {
                    Placa = unidad.Placa,
                    Marca = unidad.Marca,
                    Modelo = unidad.Modelo,
                    Estado = unidad.Estado,
                    Anio = unidad.Anio
                };

                conexion.unidad.Add(nuevaunidad);
                conexion.SaveChanges();
            }
        }

        public void MostrarListaUnidades(ref ListView listaDeUnidades)
        {
            listaDeUnidades.Items.Clear();
            using (TCS_Entities conexion = new TCS_Entities())
            {
                var queryListaUnidades = from unidad in conexion.unidad
                                         select new
                                         {
                                             Id = unidad.UnidadID,
                                             Placa = unidad.Placa,
                                             Marca = unidad.Marca,
                                             Modelo = unidad.Modelo,
                                             Estado = unidad.Estado,
                                             Año = unidad.Anio.Value.Year
                                         };

                foreach (var item in queryListaUnidades)
                {
                    ListViewItem lista = listaDeUnidades.Items.Add(item.Id.ToString());
                    lista.SubItems.Add(item.Placa.ToString());
                    lista.SubItems.Add(item.Marca.ToString());
                    lista.SubItems.Add(item.Modelo.ToString());
                    lista.SubItems.Add(item.Estado.ToString());
                    lista.SubItems.Add(item.Año.ToString());
                }
            }

        }

        public void ActualizarUnidad(UnidadModelo unidad)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {

                var unidadActualizada = (from Unidad in conexion.unidad
                                         where Unidad.UnidadID == unidad.UnidadID
                                         select Unidad).FirstOrDefault();
                unidadActualizada.Placa = unidad.Placa;
                unidadActualizada.Marca = unidad.Marca;
                unidadActualizada.Modelo = unidad.Modelo;
                unidadActualizada.Estado = unidad.Estado;
                unidadActualizada.Anio = unidad.Anio;       
                conexion.SaveChanges();
            }
        }
        public void EliminarUnidad(int id)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                var UnidadAEliminar = (from unidad in conexion.unidad
                                       where unidad.UnidadID == id
                                       select unidad).FirstOrDefault();
                conexion.unidad.Remove(UnidadAEliminar);
                conexion.SaveChanges();
            }

        }
    }
}
