using laboratorio1.Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio1.Negocio
{


    public class ClsPersona
    {
        public static string CalcularIMC(Persona persona)
        {
            double imc = persona.Peso / (persona.Altura * 2);
            if (imc < 24)
            {
                return "El peso que usted tiene es el correcto";
            }
            else
            {
                return "En los resultados que se dieron usted tiene sobre peso";
            }
        }

        public static string EsMayorDeEdad(Persona persona)
        {
            if (persona.Edad >= 18)
            {
                return "Sí";
            }
            else
            {
                return "No";
            }
        }
    }
}