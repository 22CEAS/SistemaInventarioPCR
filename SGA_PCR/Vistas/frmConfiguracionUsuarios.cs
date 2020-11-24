using AccesoDatos;
using DevComponents.DotNetBar.SuperGrid;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apolo
{
    public partial class frmConfiguracionUsuarios : Form
    {

        public enum TipoVista { Inicial, Nuevo, Modificar, Guardar, Vista, Limpiar, Duplicar, Anular , Cancelar}

        DataTable tablaAreas;
        DataTable tablaUsuarios;

        Area area;
        AreaDA areaDA;

        Usuario usuario;
        UsuarioDA usuarioDA;

        public frmConfiguracionUsuarios()
        {
            InitializeComponent();
            estadoComponentes(TipoVista.Inicial);
            Inicializando();
        }


        public void Inicializando()
        {
            areaDA = new AreaDA();
            area = new Area();

            usuarioDA = new UsuarioDA();
            usuario = new Usuario();

            //COMBO BOX LISTADO DE USUARIOS
            tablaAreas = areaDA.ListarAreas();
            cmbArea.DataSource = tablaAreas;
            cmbArea.DisplayMember = "descripcionArea";
            cmbArea.ValueMember = "idArea";

            llenadoTablaUsuarios();
        }

        public void llenadoTablaUsuarios()
        {
            //RELLENAR TABLA DE USUARIOS
            tablaUsuarios = usuarioDA.ListarUsuario();
            dgvUsuarios.PrimaryGrid.AutoGenerateColumns = true;
            dgvUsuarios.PrimaryGrid.DataSource = tablaUsuarios;
        }


        public void estadoComponentes(TipoVista estado)
        {
            switch (estado)
            {
                case TipoVista.Inicial: //ya esta

                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;

                    txtDni.Enabled = false;
                    txtNombre.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtClaveUsuario.Enabled = false;
                    txtEmail.Enabled = false;
                    cmbArea.Enabled = false;
                    dgvUsuarios.Enabled = true;
                    break;
                case TipoVista.Nuevo: //ya esta
                    //Inicializado(idUsuario, nombreUsuario);
                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;

                    txtDni.Enabled = true;
                    txtNombre.Enabled = true;
                    txtUsuario.Enabled = true;
                    txtClaveUsuario.Enabled = true;
                    txtEmail.Enabled = true;
                    cmbArea.Enabled = true;
                    dgvUsuarios.Enabled = false;
                    break;
                case TipoVista.Guardar: //ya esta listo
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;
                    dgvUsuarios.Enabled = false;
                    break;
                case TipoVista.Modificar://ya esta //Inicializado(idUsuario, nombreUsuario);
                    btnNuevo.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnGrabar.Enabled = true;
                    btnEditar.Enabled = false;
                    dgvUsuarios.Enabled = false;

                    txtDni.Enabled = false;
                    txtNombre.Enabled = true;
                    txtUsuario.Enabled = false;
                    txtClaveUsuario.Enabled = true;
                    txtEmail.Enabled = true;
                    cmbArea.Enabled = true;
                    dgvUsuarios.Enabled = false;
                    break;
                case TipoVista.Cancelar://ya esta //Inicializado(idUsuario, nombreUsuario);
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = true;

                    txtDni.Enabled = false;
                    txtNombre.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtClaveUsuario.Enabled = false;
                    txtEmail.Enabled = false;
                    cmbArea.Enabled = false;
                    dgvUsuarios.Enabled = true;
                    limpiar_componentes();
                    break;
                case TipoVista.Limpiar: //ya esta
                    btnNuevo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = false;
                    break;

            }
        }

        private void limpiar_componentes()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtClaveUsuario.Text = "";
            txtEmail.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmConfiguracionUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(TipoVista.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro?");
            estadoComponentes(TipoVista.Cancelar);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Trim().Length ==8 && validacionSoloNumeros(txtDni.Text.Trim()) == true) //VALIDACION DNI
            {
                if (txtNombre.Text.Trim().Length > 0 && validacionSoloLetras(txtNombre.Text.Trim()) == true)
                {
                    if (txtUsuario.Text.Trim().Length > 0)
                    {
                        if (txtClaveUsuario.Text.Trim().Length >4)
                        {
                            if (txtEmail.Text.Trim().Length > 0 && validacionCorreoLeasein(txtEmail.Text.Trim())==true)
                            {
                                //INSERTAR CON PROCEDURE -> RECUPERAMOS LOS ELEMENTOS

                                string dni = txtDni.Text.Trim();
                                string nombre = txtNombre.Text.Trim();
                                string usuario = txtUsuario.Text.Trim();
                                string claveUsuario = txtClaveUsuario.Text.Trim();
                                string email = txtEmail.Text.Trim();
                                int idArea = Convert.ToInt32(cmbArea.SelectedValue);


                                int resultado = usuarioDA.InsertarNuevoUsuario(dni,nombre,usuario,claveUsuario,email,idArea); //orUpdate
                                if (resultado == 0)
                                {
                                    MessageBox.Show("OCURRIO UN ERROR AL GUARDAR/MODIFICAR EL NUEVO USUARIO");
                                }
                                else
                                {
                                    
                                    MessageBox.Show("NUEVO USUARIO GUARDADO/MODIFICADO CORRECTAMENTE");
                                    llenadoTablaUsuarios(); //ACTUALIZA LA TABLA
                                    limpiar_componentes();
                                    estadoComponentes(TipoVista.Inicial);
                                    
                                }
                            }
                            else
                            {
                                MessageBox.Show("REVISE EL CORREO", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("LA CONTRASEÑA DEBE TENER UNA LONGITUD MINIMA DE 5", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("REVISE EL USUARIO", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("REVISE EL NOMBRE", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("REVISE EL DNI", "◄ AVISO | LEASEIN S.A.C. ►", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //VALIDACIONES CON EXPRESIONES REGULARES
        private bool validacionSoloNumeros(string numero) //PROBADO
        {
            return Regex.IsMatch(numero, "^[0-9]*$") ? true : false;
        }

        private bool validacionSoloLetras(string palabra) //PROBADO
        {
            return Regex.IsMatch(palabra, "^[a-zA-Z ]+$") ? true : false;
            
        }

        private bool validacionCorreoLeasein(string correo) //PROBADO
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            return Regex.IsMatch(correo, expresion) ? true : false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //VER PRIMERO SI HAY UN REGISTOR SELECCIONADO
            GridRow aux = (GridRow)dgvUsuarios.PrimaryGrid.ActiveRow;

            if (aux != null)
            {
                
                string dni = ((GridCell)(((GridRow)dgvUsuarios.PrimaryGrid.ActiveRow)[1])).Value.ToString();
                txtDni.Text = dni;

                string nombre = ((GridCell)(((GridRow)dgvUsuarios.PrimaryGrid.ActiveRow)[2])).Value.ToString();
                txtNombre.Text = nombre;

                string usuario = ((GridCell)(((GridRow)dgvUsuarios.PrimaryGrid.ActiveRow)[3])).Value.ToString();
                txtUsuario.Text = usuario;

                string claveUsuario = ((GridCell)(((GridRow)dgvUsuarios.PrimaryGrid.ActiveRow)[4])).Value.ToString();
                txtClaveUsuario.Text = claveUsuario;

                string email = ((GridCell)(((GridRow)dgvUsuarios.PrimaryGrid.ActiveRow)[6])).Value.ToString();
                txtEmail.Text=email;

                string idArea = ((GridCell)(((GridRow)dgvUsuarios.PrimaryGrid.ActiveRow)[12])).Value.ToString();
                cmbArea.SelectedValue = idArea;
                

            }
            estadoComponentes(TipoVista.Modificar);
        }
    }
}
