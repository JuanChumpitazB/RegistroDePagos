using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDAD;
using BL;

namespace PRESENTACION
{
    public partial class Form1 : Form
    {
        PersonaBL personaBL = new PersonaBL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarListaPersona();
        }
        private void CargarListaPersona()
        {
            dgv_Persona.DataSource = personaBL.Listado();
        }
    }
}
