using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_SEVILLA;
using DAO_SEVILLA;

namespace GUI_SEVILLA
{
    public partial class frmAperturaAnioEscolar : MetroFramework.Forms.MetroForm
    {
        CNegocio cn = new CNegocio();

        public frmAperturaAnioEscolar()
        {
            InitializeComponent();
        }

        private void frmAperturaAnioEscolar_Load(object sender, EventArgs e)
        {
            CargarAnio();
            CargarFase();
        }

        private void CargarAnio()
        {
            try
            {
                cboAnio.DataSource = cn.EjecutarSqlDTS("select IDANIO,ANIO from ANIOESCOLAR order by ANIO desc", conectar.conexionbdSevilla).Tables[0];
                cboAnio.DisplayMember = "ANIO";
                cboAnio.ValueMember = "IDANIO";
            }
            catch (Exception)
            {

            }

        }

        private void CargarFase()
        {
            try
            {
                cboFase.DataSource = cn.EjecutarSqlDTS("select IDFASE,DESCRIPCIONFASE from FASE", conectar.conexionbdSevilla).Tables[0];
                cboFase.DisplayMember = "DESCRIPCIONFASE";
                cboFase.ValueMember = "IDFASE";
            }
            catch (Exception)
            {

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataTable dtBusquedaApertura = new DataTable();
            bool resultado;
            try
            {
                resultado = true;

                dtBusquedaApertura = cn.EjecutarSqlDTS("select A.IDANIO,A.ESTADO,B.ANIO,A.IDFASE from APERTURAANIOESCOLAR A INNER JOIN ANIOESCOLAR B ON A.IDANIO=B.IDANIO ORDER BY B.ANIO DESC", conectar.conexionbdSevilla).Tables[0];

                if (dtBusquedaApertura.Rows.Count > 0)
                {
                    foreach (DataRow item in dtBusquedaApertura.Rows)
                    {
                        if (Convert.ToInt32(item["ANIO"]) <= Convert.ToInt32(cboAnio.Text))
                        {
                            if((item["ANIO"].ToString()  + item["IDFASE"].ToString())!= cboAnio.Text.ToString() + cboFase.SelectedValue.ToString())
                            {
                                if (Convert.ToBoolean(item["ESTADO"]))
                                {
                                    string message = "Se procederá a cerrar el año escolar "+ item["ANIO"].ToString() + " - "+ item["IDFASE"].ToString() + " . ¿Esta seguro?";
                                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                    DialogResult result;

                                    result = MessageBox.Show(message, VariablesGlobales.NombreMensajes, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                                    if (result == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        cn.EjecutarUD("update APERTURAANIOESCOLAR set estado=0", conectar.conexionbdSevilla);
                                        resultado = true;
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("El año "+cboAnio.Text+" con fase " + cboFase.Text + " ya se encuentra aperturado.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                resultado = false;
                                break;
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("No se puede ingresar un año menor a los ya registrado en aperturas anteriores.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            resultado = false;
                            break;
                        }
                    }
                }
                if (!resultado) return;
                if (!Validar()) return;

                if (cn.TraerDataset("USP_ANIOESCOLARApertura", conectar.conexionbdSevilla, cboAnio.SelectedValue,txtObservaciones.Text, 
                    cboFase.SelectedValue, cboInicioMes.Text.Substring(0, 2).Trim(), 
                    cboFinMes.Text.Substring(0, 2).Trim(),VariablesGlobales.NombreUsuario,VariablesGlobales.UserHostIp).Tables[0].Rows[0][0].ToString()!="0")
                {
                    MessageBox.Show("El año escolar " + cboAnio.Text + "-" + cboFase.Text + " ha sido aperturado correctamente. Se procedera a cerrar el sistema.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error en la apertura, intente de nuevo.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //if (cn.EjecutarUD("insert into APERTURAANIOESCOLAR(IDANIO,OBSERVACIONES,ESTADO,IDFASE,DESDE,HASTA) values ("+
                //    cboAnio.SelectedValue+",'"+txtObservaciones.Text.Trim()+"',"+(chkAperturar.Checked ==true ? 1 : 0)+","+cboFase.SelectedValue+","+cboInicioMes.Text.Substring(3,15).Trim()+","+ cboFinMes.Text.Substring(3, 15).Trim() + ")", conectar.conexionbdSevilla)>0)
                //{
                //    MessageBox.Show("El año escolar "+ cboAnio.Text+"-" + cboFase.Text+ " ha sido aperturado correctamente.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show("Ha ocurrido un error en la apertura, intente de nuevo.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            catch (Exception ex)
            {
               
            }          
        }
        private bool Validar()
        {
            bool rspta;

            if (cboInicioMes.SelectedIndex>-1 && cboFinMes.SelectedIndex>-1)
            {
                if (Convert.ToInt32(cboFinMes.Text.Substring(0, 2).Trim()) >= Convert.ToInt32(cboInicioMes.Text.Substring(0, 2).Trim()))
                {
                    rspta = true;
                }
                else
                {
                    MessageBox.Show("El mes final no puede ser menor al inicial.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    rspta = false;
                }
            }
            else
            {
                MessageBox.Show("Seleccione correctamente el rango de inicio y fin del año escolar.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                rspta = false;
            }
            return rspta;
        }
    }
}
