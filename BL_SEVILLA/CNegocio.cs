using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO_SEVILLA;
using System.Collections;

namespace BL_SEVILLA
{
    public class CNegocio
    {
        //CONEXION BD SUNAT FACTURACION ELECTRONICA
        private CDatos cone = new CDatos();

        #region Logica de Negocio conexion con servidores
        public string TraerServidorSGI()
        {
            return cone.TraerServidorSGI();
        }

        public string TraerServidorSUNATFE()
        {
            return cone.TraerServidorSunatFE();
        }

        public string TraerServidorTesoreria()
        {
            return cone.TraerServidorTesoreria();
        }

        public string TraerServidorSevilla()
        {
            return cone.TraerServidorSevilla();
        }
        #endregion

        public DataSet TraerDataset(string ProcedimientoAlmacenado,string BD, params object[] Argumentos)
        {
            try
            {
                return cone.TraerDataset(ProcedimientoAlmacenado,BD, Argumentos);
            }
            catch (Exception ex) { throw ex; }
        }

        public DataSet TraerDataset(string ProcedimientoAlmacenado, string BD)
        {
            try
            {
                return cone.TraerDataset(ProcedimientoAlmacenado, BD);
            }
            catch (Exception ex) { throw ex; }
        }

        public int EjecutarSP(string ProcedimientoAlmacenado,string BD, params object[] Argumentos)
        {
            try
            {
                return cone.EjecutarSP(ProcedimientoAlmacenado,BD, Argumentos);
            }
            catch (Exception ex) { throw ex; }
        }

        public DataSet EjecutarSqlDTS(string SQL,string BD)
        {
            try
            {
                return cone.EjecutarSqlDTS(SQL,BD);
            }
            catch (Exception) { throw; }
        }

        public int EjecutarUD(string SQL, string BD)
        {
            try
            {
                return cone.EjecutarUD(SQL, BD);
            }
            catch (Exception) { throw; }
        }

        public int EjecutarTransaccionDoble(string ProcedimientoAlmacenado1, string ProcedimientoAlmacenado2,string BD, params Object[] Argumentos)
        {
            try
            {
                return cone.EjecutarTransaccionDoble(ProcedimientoAlmacenado1,ProcedimientoAlmacenado2,BD,Argumentos);
            }
            catch (Exception) { throw; }
        }       

        public DataSet IngresaRecibo(string ProcedimientoAlmacenado, bool estado, DataTable dtCabecera,DataTable dtCabeceraDetalle,string BD)
        {
            try
            {
                return cone.IngresaRecibo(ProcedimientoAlmacenado, estado, dtCabecera, dtCabeceraDetalle,BD);
            }
            catch (Exception) { throw; }
        }

        public IEnumerable ExecuteQuery(string commandtext, string BD, params Object[] args)
        {
            try
            {
                return cone.ExecuteQuery(commandtext, BD,args);
            }
            catch (Exception) { throw; }
        }
        public DataSet ObtenerComprobantesParaEnvio(string ProcedimientoAlmacenado,DataTable lstId_Comprobante, string BD)
        {
            try
            {
                return cone.ObtenerComprobantesParaEnvio(ProcedimientoAlmacenado, lstId_Comprobante, BD);
            }
            catch (Exception) { throw; }
        }
        public DataSet VerificarComprobanteParaBaja(string ProcedimientoAlmacenado,DateTime fecha,  DataTable lstId_Comprobante, string BD)
        {
            try
            {
                return cone.VerificarComprobanteParaBaja(ProcedimientoAlmacenado,fecha, lstId_Comprobante, BD);
            }
            catch (Exception) { throw; }
        }
      
        public DataSet IngresarResumenBoletas(string ProcedimientoAlmacenado, DateTime Fecha_Resumen, string Identificador,
            DateTime Fecha_Validacion, string Ticket, string Codigo_SUNAT, string Observacion_Mensaje_SUNAT, string sRutaXML_DLL,
            string sRutaXML_SUNAT, string Estado_WS_ITS, string usuario, string pc, DataTable Lista_Id_Comprobante, string conexion)
        {
            try
            {
                return cone.IngresarResumenBoletas(ProcedimientoAlmacenado, Fecha_Resumen, Identificador,
            Fecha_Validacion, Ticket, Codigo_SUNAT, Observacion_Mensaje_SUNAT, sRutaXML_DLL,
            sRutaXML_SUNAT, Estado_WS_ITS, usuario, pc, Lista_Id_Comprobante, conexion);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet IngresarBajaDocumento(string ProcedimientoAlmacenado, DateTime Fecha_Resumen, string Identificador,
            DateTime Fecha_Validacion, string Ticket, string Codigo_SUNAT, string Observacion_Mensaje_SUNAT, string sRutaXML_DLL,
            string sRutaXML_SUNAT, string Estado_WS_ITS, DataTable Lista_Id_Comprobante,string usuario,string host,Boolean genera, string conexion)
        {
            try
            {
                return cone.IngresarBajaDocumento(ProcedimientoAlmacenado, Fecha_Resumen, Identificador,
            Fecha_Validacion, Ticket, Codigo_SUNAT, Observacion_Mensaje_SUNAT, sRutaXML_DLL,
            sRutaXML_SUNAT, Estado_WS_ITS, Lista_Id_Comprobante,usuario,host, genera,conexion);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
