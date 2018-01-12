using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Transactions;

namespace DAO_SEVILLA
{
    public class CDatos
    {
        public string TraerServidorSGI()
        {
            return conectar.conexionSisinmueble = ConfigurationManager.ConnectionStrings["sisinmueble"].ConnectionString;
        }
        public string TraerServidorSunatFE()
        {
            return conectar.conexionSUNATFE = ConfigurationManager.ConnectionStrings["SUNATFE"].ConnectionString;
        }
        public string TraerServidorTesoreria()
        {
            return conectar.conexionbdtesoreria = ConfigurationManager.ConnectionStrings["bdtesoreria"].ConnectionString;
        }
        public string TraerServidorSevilla()
        {
            return conectar.conexionbdSevilla = ConfigurationManager.ConnectionStrings["BDSEVILLA"].ConnectionString;
        }

        protected IDbCommand Comando(string ProcedimientoAlmacenado,string conexion)
        {
            try
            {
                var cn = new SqlConnection(conexion);
                var mComando = new SqlCommand(ProcedimientoAlmacenado, cn);

                cn.Open();
                mComando.Connection = cn;
                mComando.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(mComando);
                cn.Close();
                return mComando;
            }
            catch (Exception ex) { throw ex; }
        }

        protected void CargarParametros(IDbCommand Comando, params object[] Args)
        {
            int i;
            for (i = 0; (i <= Args.GetUpperBound(0)); i++)
            {
                try
                {
                    if (Args.GetValue(i) == null)
                    {
                        Args[i] = DBNull.Value;
                    }
                    ((SqlParameter)(Comando.Parameters[(i+1)])).Value = Args.GetValue(i);
                }
                catch (Exception Qex)
                {
                    throw Qex;
                }
            }
        }

        public DataSet TraerDataset(string ProcedimientoAlmacenado, string conexion,params object[] Args)
        {
            var mDataset = new DataSet();
            try
            {
                using (var cn = new SqlConnection(conexion))
                {
                    using (var mComando = new SqlCommand(ProcedimientoAlmacenado, cn))
                    {
                        cn.Open();
                        mComando.CommandTimeout = 2700;
                        mComando.Connection = cn;
                        mComando.CommandType = CommandType.StoredProcedure;

                        SqlCommandBuilder.DeriveParameters(mComando);
                        
                        if ((Args != null))
                        {
                            CargarParametros(mComando, Args);
                        }
                        new SqlDataAdapter(mComando).Fill(mDataset);

                        return mDataset;
                    }
                }
            }
            catch (Exception ex) { throw ex; }

        }

        public DataSet TraerDataset(string ProcedimientoAlmacenado,string conexion)
        {
            var mDataset = new DataSet();
            try
            {
                using (var cn = new SqlConnection(conexion))
                {
                    using (var mComando = new SqlCommand(ProcedimientoAlmacenado, cn))
                    {
                        cn.Open();
                        mComando.CommandTimeout = 2700;
                        mComando.Connection = cn;
                        mComando.CommandType = CommandType.StoredProcedure;

                        new SqlDataAdapter(mComando).Fill(mDataset);

                        return mDataset;
                    }
                }
            }
            catch (Exception ex) { throw ex; }

        }

        public int EjecutarSP(string ProcedimientoAlmacenado, string conexion, params Object[] Argumentos)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    using (SqlCommand mCom = (SqlCommand)Comando(ProcedimientoAlmacenado,conexion))
                    {
                        int Resp = 0;
                        cn.Open();
                        mCom.Connection = cn;
                        mCom.CommandType = CommandType.StoredProcedure;
                        CargarParametros(mCom, Argumentos);
                        Resp = mCom.ExecuteNonQuery();
                        return Resp;
                    }
                }
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }

        public DataSet EjecutarSqlDTS(string SQL,string conexion)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    SqlDataAdapter da = new SqlDataAdapter(SQL, cn);
                    DataSet dtx = new DataSet();
                    da.Fill(dtx);

                    return dtx;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public int EjecutarUD(string SQL,string conexion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conexion))
                {
                    using (SqlCommand command = new SqlCommand(SQL, connection))
                    {
                        connection.Open();
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }

        public int EjecutarTransaccionDoble(string ProcedimientoAlmacenado1, string ProcedimientoAlmacenado2, string conexion, params Object[] Argumentos)
        {
            var txOption = new System.Transactions.TransactionOptions();
            txOption.IsolationLevel = System.Transactions.IsolationLevel.Serializable;

            using (TransactionScope trans = new TransactionScope())
            {
                try
                {
                    EjecutarSP(ProcedimientoAlmacenado1, conexion, Argumentos[0]);
                    EjecutarSP(ProcedimientoAlmacenado2, conexion, Argumentos);
                    trans.Complete();
                    return 1;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    trans.Dispose();
                }
            }
        }

        public int EjecutarTransaccionSimple(string ProcedimientoAlmacenado1, string conexion, params Object[] Argumentos)
        {
            var txOption = new System.Transactions.TransactionOptions();
            txOption.IsolationLevel = System.Transactions.IsolationLevel.Serializable;

            using (TransactionScope trans = new TransactionScope())
            {
                try
                {
                    EjecutarSP(ProcedimientoAlmacenado1, conexion, Argumentos[0]);

                    trans.Complete();
                    return 1;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    trans.Dispose();
                }
            }
        }

        public DataSet ObtenerComprobantesParaEnvio(string ProcedimientoAlmacenado, DataTable dtListaComprobantesEnvio, string conexion)
        {
            using (var cn = new SqlConnection(conexion))
            {
                using (var mComando = new SqlCommand(ProcedimientoAlmacenado, cn))
                {
                    var mDataset = new DataSet();
                    cn.Open();
                    mComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter tvpParam1 = mComando.Parameters.AddWithValue("@TablaLista_Id_ComprobanteTmp", dtListaComprobantesEnvio);
                    tvpParam1.SqlDbType = SqlDbType.Structured;

                    new SqlDataAdapter(mComando).Fill(mDataset);

                    return mDataset;
                }
            }
        }

        public DataSet VerificarComprobanteParaBaja(string ProcedimientoAlmacenado,DateTime fecha, DataTable dtListaComprobantesEnvio, string conexion)
        {
            using (var cn = new SqlConnection(conexion))
            {
                using (var mComando = new SqlCommand(ProcedimientoAlmacenado, cn))
                {
                    var mDataset = new DataSet();
                    cn.Open();
                    mComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter tvpParam1 = mComando.Parameters.AddWithValue("@FECHA", fecha);
                    SqlParameter tvpParam2 = mComando.Parameters.AddWithValue("@TablaLista_Id_ComprobanteTmp", dtListaComprobantesEnvio);
                    tvpParam2.SqlDbType = SqlDbType.Structured;

                    new SqlDataAdapter(mComando).Fill(mDataset);

                    return mDataset;
                }
            }
        }
        
        public DataSet IngresaRecibo(string ProcedimientoAlmacenado, bool estado, DataTable dtCabecera, DataTable dtCabeceraDetalle,string conexion)
        {
            using (var cn = new SqlConnection(conexion))
            {
                using (var mComando = new SqlCommand(ProcedimientoAlmacenado, cn))
                {
                    var mDataset = new DataSet();
                    cn.Open();
                    mComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter tvpParam2 = mComando.Parameters.AddWithValue("@estadoMov", estado);

                    SqlParameter tvpParam1 = mComando.Parameters.AddWithValue("@TablaCabeceraTmp", dtCabecera);
                    tvpParam1.SqlDbType = SqlDbType.Structured;

                    SqlParameter tvpParam3 = mComando.Parameters.AddWithValue("@TablaCabeceraDetalleTmp", dtCabeceraDetalle);
                    tvpParam3.SqlDbType = SqlDbType.Structured;

                    new SqlDataAdapter(mComando).Fill(mDataset);

                    return mDataset;
                }
            }
        }

        static SqlParameter ToConvertSqlParams(SqlCommand command, string name, object value)
        {
            var p = command.CreateParameter();
            p.ParameterName = name;
            p.Value = value;
            return p;
        }

        public IEnumerable ExecuteQuery(string commandtext,string conexion, params Object[] args)
        {          

                SqlConnection cnPubs = new SqlConnection(conexion);
                using (var connection = cnPubs)
                {
                    using (var command = new SqlCommand(commandtext, connection))
                    {
                        //use index,values to convert parameters passed  to sqlparameters         
                        var Parameters = args.Select((value, index) => ToConvertSqlParams(command, index.ToString(), value));

                        command.Parameters.AddRange(Parameters.ToArray());
                        connection.Open();
                        //Execute the query 
                        using (var reader = command.ExecuteReader())
                        {
                            foreach (IDataRecord record in reader)
                                yield return record;
                        }
                        connection.Close();
                    }
                }
        }

        public DataSet IngresarResumenBoletas(string ProcedimientoAlmacenado, DateTime Fecha_Resumen, string Identificador,
            DateTime Fecha_Validacion,string Ticket,string Codigo_SUNAT, string Observacion_Mensaje_SUNAT,string sRutaXML_DLL,
            string sRutaXML_SUNAT,string Estado_WS_ITS, string usuario, string pc, DataTable Lista_Id_Comprobante,string conexion)
        {
            using (var cn = new SqlConnection(conexion))
            {
                using (var mComando = new SqlCommand(ProcedimientoAlmacenado, cn))
                {
                    var mDataset = new DataSet();
                    cn.Open();
                    mComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter tvpParam1 = mComando.Parameters.AddWithValue("@Fecha_Resumen", Fecha_Resumen);
                    SqlParameter tvpParam2 = mComando.Parameters.AddWithValue("@Identificador", Identificador);
                    SqlParameter tvpParam3 = mComando.Parameters.AddWithValue("@Fecha_Validacion", Fecha_Validacion);
                    SqlParameter tvpParam4 = mComando.Parameters.AddWithValue("@Ticket", Ticket);
                    SqlParameter tvpParam5 = mComando.Parameters.AddWithValue("@Codigo_SUNAT", Codigo_SUNAT);
                    SqlParameter tvpParam6 = mComando.Parameters.AddWithValue("@Observacion_Mensaje_SUNAT", Observacion_Mensaje_SUNAT);
                    SqlParameter tvpParam7 = mComando.Parameters.AddWithValue("@sRutaXML_DLL", sRutaXML_DLL);
                    SqlParameter tvpParam8 = mComando.Parameters.AddWithValue("@sRutaXML_SUNAT", sRutaXML_SUNAT);
                    SqlParameter tvpParam9 = mComando.Parameters.AddWithValue("@Estado_WS_ITS", Estado_WS_ITS);

                    SqlParameter tvpParam10 = mComando.Parameters.AddWithValue("@usuario", usuario);
                    SqlParameter tvpParam11 = mComando.Parameters.AddWithValue("@pc", pc);

                    SqlParameter tvpParam12 = mComando.Parameters.AddWithValue("@TablaLista_Id_ComprobanteTmp", Lista_Id_Comprobante);
                    tvpParam12.SqlDbType = SqlDbType.Structured;

                    new SqlDataAdapter(mComando).Fill(mDataset);

                    return mDataset;
                }
            }
        }

        public DataSet IngresarBajaDocumento(string ProcedimientoAlmacenado, DateTime Fecha_Resumen, string Identificador,
            DateTime Fecha_Validacion, string Ticket, string Codigo_SUNAT, string Observacion_Mensaje_SUNAT, string sRutaXML_DLL,
            string sRutaXML_SUNAT, string Estado_WS_ITS, DataTable Lista_Id_Comprobante,string usuario,string host,Boolean genera, string conexion)
        {
            using (var cn = new SqlConnection(conexion))
            {
                using (var mComando = new SqlCommand(ProcedimientoAlmacenado, cn))
                {
                    var mDataset = new DataSet();
                    cn.Open();
                    mComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter tvpParam1 = mComando.Parameters.AddWithValue("@Fecha_Genera_Ticke_Baja", Fecha_Resumen);
                    SqlParameter tvpParam2 = mComando.Parameters.AddWithValue("@Identificador", Identificador);
                    SqlParameter tvpParam3 = mComando.Parameters.AddWithValue("@Fecha_Validacion", Fecha_Validacion);
                    SqlParameter tvpParam4 = mComando.Parameters.AddWithValue("@Ticket", Ticket);
                    SqlParameter tvpParam5 = mComando.Parameters.AddWithValue("@Codigo_SUNAT", Codigo_SUNAT);
                    SqlParameter tvpParam6 = mComando.Parameters.AddWithValue("@Observacion_Mensaje_SUNAT", Observacion_Mensaje_SUNAT);
                    SqlParameter tvpParam7 = mComando.Parameters.AddWithValue("@sRutaXML_DLL", sRutaXML_DLL);
                    SqlParameter tvpParam8 = mComando.Parameters.AddWithValue("@sRutaXML_SUNAT", sRutaXML_SUNAT);                 
                    SqlParameter tvpParam9 = mComando.Parameters.AddWithValue("@Estado_WS_ITS", Estado_WS_ITS);

                    SqlParameter tvpParam10 = mComando.Parameters.AddWithValue("@Usuario", usuario);
                    SqlParameter tvpParam11 = mComando.Parameters.AddWithValue("@host", host);
                    SqlParameter tvpParam12 = mComando.Parameters.AddWithValue("@genera", genera);

                    SqlParameter tvpParam13 = mComando.Parameters.AddWithValue("@TablaLista_Id_ComprobanteTmp", Lista_Id_Comprobante);

                    tvpParam13.SqlDbType = SqlDbType.Structured;

                    new SqlDataAdapter(mComando).Fill(mDataset);

                    return mDataset;
                }
            }
        }
    }
}

