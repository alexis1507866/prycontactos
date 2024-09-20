using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prycontactos
{
    public partial class frmcontactos : Form
    {
       

        public frmcontactos()
        {
            InitializeComponent();
           
        }
        conexionBD Conexion = new conexionBD();


        private void contactos_Load(object sender, EventArgs e)
        {

            Conexion.editar(dgvGrilla);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
      
           
            

            
        


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtapellido.Text;
            string telefono = msktelefono.Text;
            string contacto = mskcontacto.Text;
            string correo = mskcoreo.Text;
            string categoria = cmdcategoria.Text;
            Conexion.agregar(nombre, apellido, telefono, contacto, correo, categoria);
         


        }

        private void label1_Click(object sender, EventArgs e)
        {
           




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            

        }

        private void txttexto_TextChanged(object sender, EventArgs e)
        {
            
            
            
            
            

        }

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex<=0)
            {
                DataGridViewRow filaselec = dgvGrilla.Rows[e.RowIndex];
                txtNombre.Text = filaselec.Cells["nombre"].Value.ToString();

            }

        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void mskcoreo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskcontacto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
    }
    

