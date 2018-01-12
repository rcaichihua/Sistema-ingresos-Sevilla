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
    public partial class frmUsuarioListado : MetroFramework.Forms.MetroForm
    {
        public frmUsuarioListado()
        {
            InitializeComponent();
        }
        CNegocio cn = new CNegocio();

        private void frmUsuarioListado_Load(object sender, EventArgs e)
        {
            this.dgvUsuarios.AutoGenerateColumns = false;
            LlenarGrillaUsuarios();
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.CellMouseEnter += (sa, ea) =>
            {
                if (ea.ColumnIndex != -1 && ea.RowIndex != -1)
                    dgvUsuarios.CurrentCell = dgvUsuarios.Rows[ea.RowIndex].Cells[ea.ColumnIndex];
            };
            contextMenuStrip1.Click += (sa, ea) =>
            {
                //if (this.dgvUsuarios.CurrentCell != null)
                //    this.dgvUsuarios.Columns.RemoveAt(this.dgvUsuarios.CurrentCell.ColumnIndex);
                if (this.dgvUsuarios.CurrentCell == null)
                    dgvUsuarios.ContextMenuStrip = null;
            };
        }

        private void LlenarGrillaUsuarios()
        {
            dgvUsuarios.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvUsuarios.DataSource = cn.TraerDataset("USP_USUARIOSelectAll", conectar.conexionbdSevilla).Tables[0];
            dgvUsuarios.Refresh();
        }

        private void dgvUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex>=0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (this.dgvUsuarios.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.ColumnHeader)
                    {
                        contextMenuStrip1.Show(MousePosition);//
                    }
                    //this.dgvUsuarios.CurrentCell = this.dgvUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //this.contextMenuStrip1.Show(this.dgvUsuarios, new Point(e.RowIndex, e.ColumnIndex));
                }
            }
        }

        private void dgvUsuarios_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (this.dgvUsuarios.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.ColumnHeader)
                    {
                        contextMenuStrip1.Show(MousePosition);//this.dgvUsuarios, e.Location)
                    }
                    //this.dgvUsuarios.CurrentCell = this.dgvUsuarios.Rows[e.RowIndex].Cells[3];//e.ColumnIndex
                    //this.contextMenuStrip1.Show(this.dgvUsuarios, new Point(e.RowIndex, e.ColumnIndex));
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deshabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("¿Esta seguro de deshabilitar al usuario " + this.dgvUsuarios.Rows[this.dgvUsuarios.CurrentCell.RowIndex].Cells[3].Value.ToString() +
              "", VariablesGlobales.NombreMensajes, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        cn.EjecutarUD("UPDATE USUARIO SET DESACTIVAR=1 WHERE NOMBREUSUARIO='" + this.dgvUsuarios.Rows[this.dgvUsuarios.CurrentCell.RowIndex].Cells[3].Value + "'", conectar.conexionbdSevilla);
                        LlenarGrillaUsuarios();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void restablecerContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarioContrasenia WinUsuContra = new frmUsuarioContrasenia();
            WinUsuContra.NombreUSuario = this.dgvUsuarios.Rows[this.dgvUsuarios.CurrentCell.RowIndex].Cells[3].Value.ToString();
            WinUsuContra.Flag = true;
            WinUsuContra.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Esta seguro de eliminar al usuario " + this.dgvUsuarios.Rows[this.dgvUsuarios.CurrentCell.RowIndex].Cells[3].Value.ToString() + 
                "",VariablesGlobales.NombreMensajes, MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes))
            {
                try
                {
                    if (VariablesGlobales.NombreUsuario== this.dgvUsuarios.Rows[this.dgvUsuarios.CurrentCell.RowIndex].Cells[3].Value.ToString())
                    {
                        MessageBox.Show("El usuario que desea eliminar se encuentra con la sesión iniciada en este computador.", VariablesGlobales.NombreMensajes, MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                        return;
                    }
                    cn.EjecutarUD("DELETE FROM USUARIO WHERE NOMBREUSUARIO='" + this.dgvUsuarios.Rows[this.dgvUsuarios.CurrentCell.RowIndex].Cells[3].Value + "'", conectar.conexionbdSevilla);
                    LlenarGrillaUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El usuario tiene acciones realizadas en el sistema y no se puede eliminar. Posible error -> "+ ex.Message);
                }
            }
        }

        private void propiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int indexUsuarioMod = dgvUsuarios.CurrentRow.Index;
            frmUsuario winUsuario = new frmUsuario();
            winUsuario.mantenimiento = true;
            winUsuario.NombresCompletos = dgvUsuarios.Rows[indexUsuarioMod].Cells[1].Value.ToString();
            winUsuario.NroDoc = dgvUsuarios.Rows[indexUsuarioMod].Cells[2].Value.ToString();
            winUsuario.NombreUsuario = dgvUsuarios.Rows[indexUsuarioMod].Cells[3].Value.ToString();
            winUsuario.Contrasenia = VariablesGlobales.llave_publica;
            winUsuario.UsuDebeCambiarContrasenia= Convert.ToBoolean(dgvUsuarios.Rows[indexUsuarioMod].Cells[4].Value);
            winUsuario.UsuNocamnbiaContrasenia = Convert.ToBoolean(dgvUsuarios.Rows[indexUsuarioMod].Cells[5].Value);
            winUsuario.UsuNuncaCaduca = Convert.ToBoolean(dgvUsuarios.Rows[indexUsuarioMod].Cells[6].Value);
            winUsuario.UsuUsuDeshabilita = Convert.ToBoolean(dgvUsuarios.Rows[indexUsuarioMod].Cells[7].Value);
            winUsuario.Admin= Convert.ToBoolean(dgvUsuarios.Rows[indexUsuarioMod].Cells[8].Value);
            winUsuario.ShowDialog();
            LlenarGrillaUsuarios();
        }

        private void dgvUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvUsuarios.Columns[e.ColumnIndex].Name == "usu" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvUsuarios.Rows[e.RowIndex].Cells["usu"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory +"\\ICOS\\"+ @"edit.ico");

                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvUsuarios.Rows[e.RowIndex].Height = icoAtomico.Height + 6;
                this.dgvUsuarios.Columns[e.ColumnIndex].Width = icoAtomico.Width + 6;

                e.Handled = true;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.txtPorcentaje.Text == string.Empty)
            //{
            //    MessageBox.Show("Introducir valor para el porcentaje");
            //    this.txtPorcentaje.Focus();
            //}

                if (this.dgvUsuarios.Columns[e.ColumnIndex].Name == "usu")
                {
                    //decimal nListPrice = (decimal)this.dataGridView1.Rows[e.RowIndex].Cells["ListPrice"].Value;
                    //int nPorcentaje = int.Parse(this.txtPorcentaje.Text);
                    //decimal nDescuento = (nListPrice * nPorcentaje) / 100;

                    MessageBox.Show(this.dgvUsuarios.Rows[e.RowIndex].Cells["IDUSUARIO"].Value.ToString(), "Descuento aplicable");
                }
        }
    }
}

