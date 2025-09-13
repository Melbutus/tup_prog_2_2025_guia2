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

        public Servicio servicio; //= new Servicio();
        public Persona persona;

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            DatosPersona ventanaDatos = new DatosPersona();

            ventanaDatos.tbx_nombre.Clear();
            ventanaDatos.tbx_dni.Clear();

            if (ventanaDatos.ShowDialog() == DialogResult.OK)
            {
                
                string nombre = ventanaDatos.tbx_nombre.Text;
                int dni = Convert.ToInt32(ventanaDatos.tbx_dni.Text);
                Persona persona = new Persona(dni, nombre);

                ActualizarLista();
            }
            
            
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
           
            
            Persona pers = lbx_mostrar.SelectedItem as Persona;
            if (pers == null) 
            {

                MessageBox.Show("Seleccione una persona"); return;
                
            }
            MessageBox.Show($"DNI: { pers.DNI}\n Nombre:,{pers.Nombre}");     
                
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
            Form1 form1 = new Form1();

            Persona seleccionada = servicio.VerPersona(lbx_mostrar.SelectedIndex);
            
            if(seleccionada != null)
            {
                servicio.EliminarPersona(seleccionada); // quitamos pers de servicio
                lbx_mostrar.Items.RemoveAt(lbx_mostrar.SelectedIndex); // quitamos del lbx
            }

            ActualizarLista();
            
        }

        private void ActualizarLista()
        { 
            for(int n=0; n< servicio.VerCantidadPersonas(); n++)
            {
                Persona p = servicio.VerPersona(n);
                lbx_mostrar.Items.Add(p.Describir());   
            }
        }


    }
}
