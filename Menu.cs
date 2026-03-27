using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Taller3D
{
    
    
    
    internal class Menu
    {
        public void ejecutable()
        {
            string name;
            Console.WriteLine("Cuál es tu nombre?");
            name = Console.ReadLine();
            Console.WriteLine($"Hola {name}");
        }

        public void ejercicio1()
        {
            float base1;
            float altura;
            
            Console.WriteLine("Ingresa la base de un rectangulo");
            base1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ahora ingresa la altura");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("El área de tu rectángulo es:");
            
            float área = base1 * altura;
            Console.WriteLine(área);

            Console.WriteLine("Y su perímetro es:");
            float perimetro = (base1 + altura) * 2;
            Console.WriteLine(perimetro);
        }

        public void ejercicio2()
        {
            float base1;
            float altura;

            Console.WriteLine("Ingresa la base del triángulo");
            base1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ahora ingresa la altura");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("El área de tu triángulo es:");

            float área = (base1 * altura) / 2;
            Console.WriteLine(área);
        }

        public void ejercicio3()
        {
            int año;
            Console.WriteLine("Ingresa un año para saber si es bisiesto o no:");
            año = int.Parse(Console.ReadLine());

            if ((año % 4 == 0 && año != 100) || (año % 400 == 0))
            {
                Console.WriteLine($"Tu año: {año} SI es bisiesto");
            }
            else
            {
                Console.WriteLine($"Tu año: {año} NO es bisiesto");
            }
        }

        public void ejercicio4()
        {

            Console.WriteLine("Ingresa 2 valores:");
            float valor1;
            valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Tu primer valor es {valor1}, ingresa el valor 2");
            float valor2;
            valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine($" Tu segundo valor es {valor2}");
            Console.WriteLine("Que operación quieres hacer con tus 2 valores ingresados?");
            float sumar = valor1 + valor2;
            float restar = valor1 - valor2;
            float multiplicar = valor1 * valor2;
            float dividir = valor1 / valor2;
            float Elresto = valor2 % valor2;

            Console.WriteLine("Sumar = + / restar = - / multiplicar = * / dividir = / / resto = %");
            string operacion = Console.ReadLine();

            if (operacion == "+")
            {
                Console.WriteLine($"La suma de los dos valores es {sumar}");
            }
            else if (operacion == "-")
            {
                Console.WriteLine($"La resta de los dos valores es {restar}");
            }
            else if (operacion == "%")
            {
                Console.WriteLine($"El residuo de los dos valores es {Elresto}");
            }
            else if (operacion == "*")
            {
                Console.WriteLine($"La multiplicación de los dos valores es {multiplicar}");
            }
            else if (operacion == "/")
            {
                Console.WriteLine($"La división de los dos valores {dividir}");
            }
            else
            {
                Console.WriteLine($"ingresa una operación valida registrada");
                 
            }

          
     








        }
    }
}


