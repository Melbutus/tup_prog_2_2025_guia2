using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1_Agregacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Servicio servicio = new Servicio();
        public Persona persona;

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            DatosPersona ventanaDatos = new DatosPersona();

            if (ventanaDatos.ShowDialog() == DialogResult.OK)
            {
                string nombre = ventanaDatos.tbx_nombre.Text;
                int dni = Convert.ToInt32(ventanaDatos.tbx_dni.Text);
                
                Persona persona = new Persona(dni, nombre); 
                servicio.AgregarPersona(persona);
                ventanaDatos.tbx_nombre.Clear();
                ventanaDatos.tbx_dni.Clear();
            }
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < servicio._personas.Count; i++)
            {
                lbx_mostrar.Items.Add(servicio._personas[i].Describir());
            }
            lbx_mostrar.Refresh();
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string n = lbx_mostrar.SelectedItem.ToString();
            int dni = Convert.ToInt32(n.Split('-')[1]);
            string nombre = n.Split('-')[0];
            Persona UnaPersona = new Persona(dni, nombre);
            servicio.EliminarPersona(UnaPersona);
        }
    }
}
