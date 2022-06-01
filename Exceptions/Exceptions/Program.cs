using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Program
    {

        static void Main(string[] args)
        {

            var numbers = new Numbers();

            var logic = new Logic();
           
            Console.WriteLine("Programa de division. Introduzca dos numeros  \n");

            int num1 = 0;

            bool esnumero = false;

            while (!esnumero)
            {
                Console.WriteLine(" \nIntroduce el primer numero  \n");
                esnumero = int.TryParse(Console.ReadLine(), out num1);
                if (!esnumero)
                {
                    Console.WriteLine("Seguro Ingreso una letra o no ingreso nada!  \n" + Environment.NewLine);
                }
            }

            int num2 = 0;

            esnumero = false;

            while (!esnumero)
            {
                Console.WriteLine(" \nIntroduzca el segundo numero  \n");
                esnumero = int.TryParse(Console.ReadLine(), out num2);
                if (!esnumero)
                {
                    Console.WriteLine("Seguro Ingreso una letra o no ingreso nada!" + Environment.NewLine);
                }
            }

            var resultado = numbers.DivisorNumeros(num1, num2);

            Console.WriteLine(resultado);

            Console.WriteLine(" \nLa operación de división ha finalizado  \n");

            try
            {
                logic.LanzarExcepcion();
            }
            catch (Exception ex)
            {
                var tipoExcepcion = ex.GetType();
                var mensajeExcepcion = ex.Message;
                Console.WriteLine($"El tipo de excepcion es: {tipoExcepcion} y el mensaje es:  {mensajeExcepcion}  \n");
            }

            try
            {
                logic.LanzarCustom();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            

            Console.WriteLine("La ejecucion del programa ha terminado");


            Console.ReadKey();


        }

        
    }
}
