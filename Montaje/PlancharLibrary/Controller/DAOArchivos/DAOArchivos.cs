using ConnectorLibrary.Constantes;
using ConnectorLibrary.Sql;
using PlancharLibrary.Model.Archivo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlancharLibrary.Controller.DAOArchivos
{
    public class DAOArchivos
    {
        private static readonly object _mutex = new object();
        private static DAOArchivos _Instance;
        public static DAOArchivos Instance
        {
            get
            {
                lock (_mutex)
                {
                    if (_Instance == null)
                    {
                        _Instance = new DAOArchivos();
                    }
                }
                return _Instance;
            }
        }

        public  List<ArchivoExcel> CargarArchivosSeleccionables()
        {
            try
            {

                ObjetosSQL _SQL = new ObjetosSQL();

                DataTable dt = _SQL.EjecutaDataAdapter(Stords.Montaje_Get_ArchivosSeleccionables);

                List<ArchivoExcel> listaProyectos = new List<ArchivoExcel>();
                if (dt.Rows.Count > 0)
                    listaProyectos.Add(new ArchivoExcel());

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listaProyectos.Add(new ArchivoExcel
                    {
                        ID = int.Parse(dt.Rows[i][0].ToString()),
                        Nombre = dt.Rows[i][1].ToString(),
                        NumHojaLeer = int.Parse(dt.Rows[i][2].ToString()),
                        FilaInicioLeer= int.Parse(dt.Rows[i][3].ToString()),
                        RequiereValidar = bool.Parse(dt.Rows[i][4].ToString())
                        
                    });
                }

                return listaProyectos;

            }
            catch (Exception ex)
            {
                return new List<ArchivoExcel>();
            }
        }

    }
}
