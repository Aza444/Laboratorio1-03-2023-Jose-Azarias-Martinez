using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio_1_Jose_Azarias_Martinez;

namespace Laboratorio-1_Jose Azarias Martinez
{
    public class ClsPersona
    {
        public string CalcularIMC  (Persona persona){

            double promedio = persona.Peso/Math.Pow(persona.Altura, 2);
            if (promedio <= 24){
                return ($"Su IMC es: {promedio} \nTiene un peso ideal");
            }else{
                return ($"Su IMC es: {promedio} \nTiene sobrepeso");
            }
        }

        public string EsMayordeEdad (Persona edad){
            
            if (edad.Edad < 18){
                return ("Es menor de edad");
            }else{
                return ("Es mayor de edad");
            }
        }
    }
}