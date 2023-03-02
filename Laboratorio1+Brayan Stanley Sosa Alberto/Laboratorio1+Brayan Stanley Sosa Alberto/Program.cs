using laboratorio1.Entidades;
using laboratorio1.Negocio;
using System;

namespace EjercicioPersona.programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese el nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Por Favor ingrese la edad:");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingrese el sexo (H o M):");
            char sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingrese el peso (kg):");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingrese la altura con decimales 0.00 (m):");
            double altura = double.Parse(Console.ReadLine());

            Persona persona = new Persona(nombre, edad, sexo, peso, altura);

            Console.WriteLine("Loa datos de la persona:");
            Console.WriteLine("Nombre: " + persona.Nombre);
            Console.WriteLine("Edad: " + persona.Edad);
            Console.WriteLine("Sexo: " + persona.Sexo);
            Console.WriteLine("Peso: " + persona.Peso);
            Console.WriteLine("Altura: " + persona.Altura);

            Console.WriteLine("IMC: " + laboratorio1.Negocio.ClsPersona.CalcularIMC(persona));
            Console.WriteLine("Es mayor de edad: " + laboratorio1.Negocio.ClsPersona.EsMayorDeEdad(persona));

            Console.ReadKey();
        }
    }
}
Footer
© 2023 GitHub, Inc.
Footer navigation
Terms
Privacy
Security
Status
Docs
Contact GitHub
Pricing
API
Training
Blog
About