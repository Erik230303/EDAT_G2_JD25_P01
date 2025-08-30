using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos.Aleatorios
{
    public partial class frmDatosAleatorios : Form
    {
        public frmDatosAleatorios()
        {
            InitializeComponent();
            cmbGrupo.Items.AddRange(new object[] { "A", "B", "C", "D" });
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            // Crear instancia de Empleado
            Empleado emp = new Empleado();

            // Generar datos aleatorios
            emp.Numero = r.Next(1, 1001); // Número entre 1 y 1000

            string[] nombres = { "Juan", "María", "Pedro", "Ana", "Luis", "Laura", "Carlos", "Sofía" };
            string[] apellidos = { "Pérez", "Gómez", "Rodríguez", "Fernández", "López", "Martínez" };
            emp.Nombre = nombres[r.Next(nombres.Length)] + " " + apellidos[r.Next(apellidos.Length)];

            DateTime start = new DateTime(1950, 1, 1);
            int range = (DateTime.Today - start).Days;
            emp.FechaNacimiento = start.AddDays(r.Next(range)); // Fecha aleatoria desde 1950 hasta hoy

            string[] sexos = { "Masculino", "Femenino" };
            emp.Sexo = sexos[r.Next(sexos.Length)];

            char[] grupos = { 'A', 'B', 'C', 'D' };
            emp.Grupo = grupos[r.Next(grupos.Length)];

            emp.Sueldo = r.Next(1000, 10001) + r.NextDouble(); // Sueldo entre 1000 y 10000 con decimales
            emp.SeguroMedico = (r.Next(2) == 0); // 50% de probabilidad

            // Asignar valores a los controles del formulario
            txtNumero.Text = emp.Numero.ToString();
            txtNombre.Text = emp.Nombre;
            dtpFechaNacimiento.Value = emp.FechaNacimiento;

            if (emp.Sexo == "Masculino")
            {
                radMasculino.Checked = true;
                radFemenino.Checked = false;
            }
            else
            {
                radMasculino.Checked = false;
                radFemenino.Checked = true;
            }

            cmbGrupo.SelectedItem = emp.Grupo.ToString();
            txtSueldo.Text = emp.Sueldo.ToString("F2");
            chkSeguroMedico.Checked = emp.SeguroMedico;
        }
    }
}