using System;
using System.Collections.Generic;
using System.Text;

namespace EQUIPO1
{
    class cManejoCadenas
    {
        //método para obtener un carácter de una cadena de texto
        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }
        //método para obtener la longitud de la cadena de caracteres en la frase
        public int tamaño(string cadena)
        {
            int longitud;
            longitud = cadena.Length;
            return longitud;
        }
        //método para obtener el total de vocales dentro de la frase

        public int vocales(string cadena)
        {
            Int16 vocal = 0;
            for (Int16 i = 0; i < cadena.Length; i++)
            {
                switch (Mid(cadena.ToUpper(), i, 1))
                {
                    case "A":
                        vocal += 1;
                        break;
                    case "E":
                        vocal += 1;
                        break;
                    case "I":
                        vocal += 1;
                        break;
                    case "O":
                        vocal += 1;
                        break;
                    case "U":
                        vocal += 1;
                        break;
                }
            }
            return vocal;
        }
        //método para obtener el número de consonantes dentro de la frase
        public int consonantes(string cadena)
        {
            Int16 consonante = Convert.ToInt16(cadena.Length);
            for (Int16 i = 0; i < cadena.Length; i++)
            {
                switch (Mid(cadena.ToUpper(), i, 1))
                {
                    case "A":
                        consonante -= 1;
                        break;
                    case "E":
                        consonante -= 1;
                        break;
                    case "I":
                        consonante -= 1;
                        break;
                    case "O":
                        consonante -= 1;
                        break;
                    case "U":
                        consonante -= 1;
                        break;
                    case " ":
                        consonante -= 1;
                        break;
                }
            }
            return consonante;
        }
        //método para encontrar el total de palabras dentro de la frase
        public int palabras(string cadena)
        {
            Int16 palabras = 1;
            for (Int16 i = 1; i < cadena.Length; i++)
            {
                switch (Mid(cadena.ToUpper(), i, 1))
                {
                    case " ":
                        palabras += 1;
                        break;
                }
            }
            return palabras;
        }
    }
}
