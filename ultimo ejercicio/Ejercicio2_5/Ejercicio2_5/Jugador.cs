using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_5
{
    class Jugador
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string sexo;
        private string masculino = "Masculino", femenino = "Femenino";
        private double dineroDeInvercion;
        private string alias;

        //1 datos generales 
        public Jugador(string nombre,string apellido,int edad,string sexo,double dineroDeInvercion,string alias)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.sexo = sexo;
            this.dineroDeInvercion = dineroDeInvercion;
            this.alias = alias;
        }
        //2 datos personales del jugador
        public Jugador(string nombre, string apellido, int edad, string sexo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.sexo = sexo;
        }
        //3 datos que se implementarian al juego
        public Jugador(string nombre, int edad, string alias)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.alias = alias;
        }
        //4 si solo se quiere ver con cuanto cueta y su alias 
        public Jugador(string alias, double dineroDeInvercion)
        {
            this.alias = alias;
            this.dineroDeInvercion = dineroDeInvercion;
        }

        public string Nombre{
            get
            {
                return nombre;
            }
            set
            {
                if (nombre == "")
                {
                    nombre = value;    
                }
                else
                {
                    nombre = "Dato no valido";
                }
            }
         
        }
        public string Apellido {
            get
            {
                return apellido;
            }
            set
            {
                if (apellido=="")
                {
                    apellido = value;
                }
                else
                {
                    apellido = "Dato no valido";
                }
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (edad >0 && edad > 100)
                {
                    edad = value;
                }
                else
                {
                    edad = 0;
                }
            }
        }
        public string Sexo
        {
            
            get
            {
                return sexo;
            }
            set
            {
                if (sexo == masculino|| sexo == femenino)
                {
                    sexo = value;
                }
                else
                {
                    sexo = "Dato invalido";
                }
            }
        }

        public double DineroInvertido
        {
            get
            {
                return dineroDeInvercion;
            }
            set
            {
                if (dineroDeInvercion>100.00)
                {
                    dineroDeInvercion = value;
                }
                else
                {
                    dineroDeInvercion = 0;
                }
            }
        }

        public String VerInfo()
        {
            return "Informacion del jugador: \nNombre: " + nombre + "\nApellido: " + apellido + "\nEdad: " + edad + "\nSexo: " + sexo + "\nAbatar"+alias+"\nCuenta: $" + dineroDeInvercion;
        }
    }
}
