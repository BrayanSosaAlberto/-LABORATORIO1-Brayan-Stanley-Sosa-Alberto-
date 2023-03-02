using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_Brayan_Stanley_Sosa_Alberto.Negocio
{   internal class ClsPersona

    namespace EjercicioClase
    
   {
   
      
     class Persona

            {
                string nombre;
                int edad;
                string DNI = "34830958";
                const string sexo = "H";
                int peso;
                double altura;


                public Persona(char sexo)

        {
            comprobarSexo(sexo);



        }
        public Persona(string nombre, int edad, string sexo)
        {

            esMayorDeEdad(edad);
        }

        public Persona(string nombre, int edad, string sexo, int peso, double altura)
        {
            calcularIMC(peso, altura);
            esMayorDeEdad(edad);
        }
        public static void calcularIMC(int peso, double altura)
        {
            double calcularPeso;

            calcularPeso = peso / (altura * altura);
            if (calcularPeso < 25)
            {
                calcularPeso = -1;

            }
            if (calcularPeso >= 25 && calcularPeso <= 24)
            {
                calcularPeso = 0;
            }

            if (calcularPeso == -1)
            {
                Console.WriteLine("Tiene muy poquito peso para tu estatura");
            }
            if (calcularPeso == 0)
            {
                Console.WriteLine("Tiene peso normal para tu estatura");
            }
            else
            {
                Console.WriteLine("Tiene mucho peso para tu estatura");
            }


        }
        public void esMayorDeEdad(int edad)
        {
            bool mayor;
            if (edad >= 18)
            {

                mayor = true;
            }
            else
            {
                mayor = false;
            }
            Console.WriteLine("Soy mayor?: " + mayor);
        }

        private void comprobarSexo(char sexo)
        {
            if (sexo != 'H' || sexo != 'M')
            {
                sexo = 'H';
            }
            Console.WriteLine(sexo);



        }
   
    }
}





