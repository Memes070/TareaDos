using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDos
{

    internal class SalariosEmpleados
    {
        //Declaramos es el arreglo definido
        int[] salarios;

        public static int ObtenerAguinaldo(int salarioActual)
        {

            return salarioActual *= 12;

        }



        public void ObtenerSalario()
        {
            salarios = new int[6];//Inicializamos el arreglo
            for (int f = 0; f < salarios.Length; f++)
            {
                Console.WriteLine("Ingrese el salario del empleado " + f + ": ");
                String linea;
                linea = Console.ReadLine();
                salarios[f] = int.Parse(linea);
                Imprimir(salarios[f]);
                Console.WriteLine("El aguilando del empleado es: " + ObtenerAguinaldo(salarios[f]));

            }

        }
        public void Imprimir(float salario)
        {
            Console.WriteLine("El salarios de los empleados son:");

            foreach (float f in salarios)
            {
                Console.WriteLine(f);
            }

        }




        static void Main(string[] args)
        {
            SalariosEmpleados pv = new SalariosEmpleados();
            pv.ObtenerSalario();

        }
    }
}
