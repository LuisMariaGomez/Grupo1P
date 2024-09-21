using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class CU_008___Empleado___Armado_interfaz : Form
    {
        public CU_008___Empleado___Armado_interfaz()
        {
            InitializeComponent();
        }

        private void listView1_Resultado_Busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CU_008___Empleado___Armado_interfaz_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            CU___015___Empleado___Alta_empleado interfazEmpleadosAgregar = new CU___015___Empleado___Alta_empleado();
            interfazEmpleadosAgregar.ShowDialog();
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            CU_015___Empleado___Modificar_empleado interfazEmpleadosAgregar = new CU_015___Empleado___Modificar_empleado();
            interfazEmpleadosAgregar.ShowDialog();
            
        }
    }
}
