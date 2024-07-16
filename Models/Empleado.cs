using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_UML.Models
{
    public class Empleado
    {
        private Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        private double SueldoBase { get; set; }
        public double PorcentajePension { get; set; }
        public double PorcentajeSalud { get; set; }
        private double PorcentajeAhorroCooperativa { get; set; }

        public Empleado(string nombre, string apellido, string correo, double sueldobase, double porcentajepension, double porcentajesalud, double porcentajeahorrocooperativa)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            SueldoBase = sueldobase;
            PorcentajePension = porcentajepension;
            PorcentajeSalud = porcentajesalud;
            PorcentajeAhorroCooperativa = porcentajeahorrocooperativa;
        }
        
        public double CalcularSueldoEmpleado()
        {
            var sueldoEmpleado = SueldoBase - CalcularDeducciones();
            return sueldoEmpleado; 
        }

        private double CalcularDeducciones()
        {
            var deducciones = SueldoBase * (PorcentajePension / 100) + SueldoBase * (PorcentajeSalud / 100) + SueldoBase * (PorcentajeAhorroCooperativa / 100);
            return deducciones;
        }

        private double CalcularAhorro()
        {
            var ahorro = SueldoBase * (PorcentajeAhorroCooperativa / 100);
            return ahorro;
        }

        //Imprimir info con ToString
        public  string ToString()
        {
            return $"Empleado: {Nombre} {Apellido}, Correo: {Correo}, Sueldo Base: {SueldoBase}, Deducciones: {CalcularDeducciones()}, Ahorro: {CalcularAhorro()}, Sueldo Empleado: {CalcularSueldoEmpleado()}";
        }
    }
}