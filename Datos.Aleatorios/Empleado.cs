using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Aleatorios
{
    public class Empleado
    {

        public int Numero { get; set; } = 0; // Valor por defecto
        public string Nombre { get; set; } = string.Empty; // Valor por defecto
        public DateTime FechaNacimiento { get; set; } = DateTime.MinValue; // Valor por defecto
        public string Sexo { get; set; } = string.Empty; // Valor por defecto
        public char Grupo { get; set; } = ' '; // Valor por defecto
        public double Sueldo { get; set; } = 0.0; // Valor por defecto
        public bool SeguroMedico { get; set; } = false; // Valor por defecto

        public override string ToString()
        {
            return $"Numero: {Numero}, Nombre: {Nombre}, Fecha Nacimiento: {FechaNacimiento.ToShortDateString()}, Sexo: {Sexo}, Grupo: {Grupo}, Sueldo: {Sueldo:F2}, Seguro Médico: {SeguroMedico}";
        }

    }
}
