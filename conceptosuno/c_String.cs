using System;
using System.Collections.Generic;
using System.Text;

namespace conceptosuno
{
    class c_String
    {
        //constructor
        public c_String() { }

         public void FuncionString()
        {
            string palabra = "Carlos Roberto Blanco Osoy";

            Console.WriteLine("Tamaño de la cadena: " + palabra.Length + " Caracteres");
            Console.WriteLine("SubString es: " + palabra.Substring(7, 5));
            Console.WriteLine("en mayusculas: " + palabra.ToUpper());

            int numero = 50;
            string num = numero.ToString();
            Console.WriteLine("Convertir numero a String " + num);
        }


    }
}
