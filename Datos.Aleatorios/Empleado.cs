using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Aleatorios
{
    public class Empleado
    {

        public int Numero { get; set; } = 0; 
        public string Nombre { get; set; } = string.Empty; 
        public DateTime FechaNacimiento { get; set; } = DateTime.MinValue; 
        public string Sexo { get; set; } = string.Empty; 
        public char Grupo { get; set; } = ' '; 
        public double Sueldo { get; set; } = 0.0; 
        public bool SeguroMedico { get; set; } = false; 

        public override string ToString()
        {
            return $"Numero: {Numero}, Nombre: {Nombre}, Fecha Nacimiento: {FechaNacimiento.ToShortDateString()}, Sexo: {Sexo}, Grupo: {Grupo}, Sueldo: {Sueldo:F2}, Seguro Médico: {SeguroMedico}";
        }

    }
}
