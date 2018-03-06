using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Excel;
using System.IO;
using ConnectorLibrary.Sql;
using ConnectorLibrary.Constantes;

namespace PlancharLibrary.Controller.DAOExcel
{
    public class DAOExcel
    {
        private static readonly object _mutex = new object();
        private static DAOExcel _Instance;
        public static DAOExcel Instance
        {
            get
            {
                lock (_mutex)
                {
                    if (_Instance == null)
                    {
                        _Instance = new DAOExcel();
                    }
                }
                return _Instance;
            }
        }

        public DataTable LeerArchivoExcel(object itemSeleccionado, string archivo, Stream myStream, out string resultado)
        {
            resultado = "";
            Model.Archivo.ArchivoExcel archivoExcelSeleccionado = (Model.Archivo.ArchivoExcel)itemSeleccionado;
            DataTable dtHojaSeleccionada = new DataTable();
            #region CodigoExcel

            try
            {
                if (myStream != null)
                {

                    using (myStream)
                    {
                        if (archivo.Split('.')[archivo.Split('.').Length - 1].ToLower() == "xlsx")
                        {
                            // Insert code to read the stream here.
                            //IExcelDataReader excelReader =  Factory.CreateReader(myStream, ExcelFileType.Binary);
                            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(myStream);

                           

                            DataSet result = excelReader.AsDataSet();

                            for (int i = 0; i < result.Tables.Count; i++)
                            {
                                if (i == archivoExcelSeleccionado.NumHojaLeer)
                                    dtHojaSeleccionada = result.Tables[i];
                            }
                        }
                        if ( archivo.Split('.')[archivo.Split('.').Length - 1].ToLower() == "xls")
                        {
                          

                            //for excel 2003
                             IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(myStream);

                            DataSet result = excelReader.AsDataSet();

                            for (int i = 0; i < result.Tables.Count; i++)
                            {
                                if (i == archivoExcelSeleccionado.NumHojaLeer)
                                    dtHojaSeleccionada = result.Tables[i];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                resultado = "Error: No puede leer al archivo Original error: " + ex.Message;
            }
            #endregion
            return dtHojaSeleccionada;
        }

        public DataTable ValidarInformacion(object itemSeleccionado, DataTable dthoja, out string mensaje)
        {
            try
            {
                Model.Archivo.ArchivoExcel archivoExcelSeleccionado = (Model.Archivo.ArchivoExcel)itemSeleccionado;
                ObjetosSQL _SQL = new ObjetosSQL();




                string[,] parametro = { { "@ArchivoSeleccionado", archivoExcelSeleccionado.ID.ToString() } };

                DataTable dtNuevo = new DataTable();

                for (int i = 0; i < dthoja.Columns.Count; i++)
                {
                    dtNuevo.Columns.Add(new DataColumn(dthoja.Rows[archivoExcelSeleccionado.FilaInicioLeer - 1][i].ToString()));
                }

                for (int i = archivoExcelSeleccionado.FilaInicioLeer; i < dthoja.Rows.Count; i++)
                {
                    DataRow newRow = dtNuevo.NewRow();

                    for (int j = 0; j < dthoja.Columns.Count; j++)
                    {
                        newRow[j] = dthoja.Rows[i][j].ToString();
                    }
                    dtNuevo.Rows.Add(newRow);
                }


                int columna = 0;
                while (columna < dtNuevo.Columns.Count)
                {
                    if (archivoExcelSeleccionado.ID < 6)
                    {
                        if (dtNuevo.Columns[columna].ColumnName.ToUpper().Trim() != "Isometrico".ToUpper() && dtNuevo.Columns[columna].ColumnName.ToUpper().Trim() != "Isométrico".ToUpper() && dtNuevo.Columns[columna].ColumnName.ToUpper().Trim() != "Junta".ToUpper() && dtNuevo.Columns[columna].ColumnName.ToUpper().Trim() != "junta".ToUpper())
                            dtNuevo.Columns.RemoveAt(columna);
                        else
                            columna++;
                    }
                    else {
                        if (dtNuevo.Columns[columna].ColumnName.ToUpper().Trim() != "Dibujo".ToUpper() && dtNuevo.Columns[columna].ColumnName.ToUpper().Trim() != "Isometrico".ToUpper() &&  dtNuevo.Columns[columna].ColumnName.ToUpper().Trim() != "Isométrico".ToUpper())
                            dtNuevo.Columns.RemoveAt(columna);
                        else
                            columna++;
                    }
                }

                if (archivoExcelSeleccionado.RequiereValidar)
                {
                    DataTable tabla = new DataTable();
                    if (archivoExcelSeleccionado.ID<6)
                     tabla = _SQL.EjecutaDataAdapter(Stords.Montaje_Set_ValidarMontaje, dtNuevo, "@TablaMontaje", parametro);

                    else
                         tabla = _SQL.EjecutaDataAdapter(Stords.Montaje_Set_ValidarMontajeIsometrico, dtNuevo, "@TablaMontaje", parametro);
                    
                    if (tabla.Rows.Count == 0)
                        mensaje = "no se han encontrado datos repetidos, para continuar presione el boton Planchar informacion";
                    else
                        mensaje = "Se encontraron los siguientes datos repetidos para reemplazarlos favor de presionar el boton planchar información";

                    return tabla;

                }
                else
                {
                    mensaje = "No se requiere validar favor de presionar el boton planchar información";
                    return new DataTable();
                }


            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return new DataTable();
            }
        }

        public bool PlacharInserarInformacion(object itemSeleccionado, DataTable dthoja, out string mensaje)
        {
            try
            {
                Model.Archivo.ArchivoExcel archivoExcelSeleccionado = (Model.Archivo.ArchivoExcel)itemSeleccionado;
                ObjetosSQL _SQL = new ObjetosSQL();
                string[,] parametro = { { "@ArchivoSeleccionado", archivoExcelSeleccionado.ID.ToString() } };
                bool esCorrectoInsercion = false;

                DataTable dtNuevo = new DataTable();

                for (int i = 0; i < dthoja.Columns.Count; i++)
                {
                    dtNuevo.Columns.Add(new DataColumn(dthoja.Rows[archivoExcelSeleccionado.FilaInicioLeer - 1][i].ToString()));
                }

                for (int i = archivoExcelSeleccionado.FilaInicioLeer; i < dthoja.Rows.Count; i++)
                {
                    DataRow newRow = dtNuevo.NewRow();
                   // if (dthoja.Rows[i][0].ToString().Trim() != "")
                    //{
                        for (int j = 0; j < dthoja.Columns.Count; j++)
                        {
                            newRow[j] = dthoja.Rows[i][j].ToString();
                        }
                        dtNuevo.Rows.Add(newRow);
                    //}
                }

                if (archivoExcelSeleccionado.ID == 1)
                {
                    esCorrectoInsercion = _SQL.Ejecuta(Stords.Montaje_Set_GuardarMontajeBaseTrazabilidad, dtNuevo, "@TablaMontajeTrazabilidad", parametro);
                }
                else if (archivoExcelSeleccionado.ID == 2)
                {
                    esCorrectoInsercion = _SQL.Ejecuta(Stords.Montaje_Set_GuardarMontajeSeguimientoJuntas, dtNuevo, "@TablaMontajeSeguimientoJuntas", parametro);
                }
                else if (archivoExcelSeleccionado.ID == 4)
                {
                    esCorrectoInsercion = _SQL.Ejecuta(Stords.Montaje_Set_GuardarMontajeRT, dtNuevo, "@TablaMontajeRT", parametro);
                }
                else if (archivoExcelSeleccionado.ID == 5)
                {
                    esCorrectoInsercion = _SQL.Ejecuta(Stords.Montaje_Set_GuardarMontajePWHT, dtNuevo, "@TablaMontajePWHT", parametro);
                }
                else if (archivoExcelSeleccionado.ID == 6)
                {
                    esCorrectoInsercion = _SQL.Ejecuta(Stords.Montaje_Set_GuardarMontajePintura, dtNuevo, "@TablaMontaje", parametro);
                }
                else if (archivoExcelSeleccionado.ID == 7)
                {
                    esCorrectoInsercion = _SQL.Ejecuta(Stords.Montaje_Set_GuardarMontajeEncabezado, dtNuevo, "@TablaMontajeCabecera", parametro);
                }

                if (esCorrectoInsercion)
                {
                    mensaje = "Se realizo la insercion y/o actualizacion de manera satisfactoria";
                    return true;
                }

                mensaje = "existio un error al guardar/actualizar la información";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }



    }
}
