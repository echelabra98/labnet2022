using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Numbers
    {
        
        public Numbers()
        {

        }

        public string DivisorNumeros(int numero1, int numero2)
        {

            try
            {
                int division = numero1 / numero2;

                return $"El resultado de la division es: {division}  \n";

                
            }
            catch (DivideByZeroException e)
            {
                
                return $"Solo Chuck Norris divide por cero! {e.Message}  \n";
                

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
            
        }


    }
}
