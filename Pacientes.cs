﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio_Hospital_Clinica_APP
{
    internal class Pacientes : Personas
    {
        private int codPaciente, obraSocial, barrio, localidad, provincia;

        public int CodPaciente { set { codPaciente = value; } get { return codPaciente; } }
        public int ObraSocial { set { obraSocial = value; } get { return obraSocial; } }
        public int Barrio { set { barrio = value; } get { return barrio; } }
        public int Localidad { set { localidad = value; } get { return localidad; } }
        public int Provincia { set { provincia = value; } get { return provincia; } }

        public Pacientes () : base()
        {
            codPaciente = 0;
            obraSocial = 0;
            barrio = 0;
            localidad = 0;
            provincia = 0;
        }
        public Pacientes(int codPaciente, int obraSocial, int barrio, int localidad, int provincia,int sexo, string nombre, string apellido,string domicilio, string eMail,int dni,int celular,int edad,int estadoCivil,DateTime fechaNacimiento) : base 
            (sexo,nombre,apellido,domicilio,eMail,dni,celular,edad,estadoCivil,fechaNacimiento)
        {
            this.codPaciente = codPaciente;
            this.obraSocial = obraSocial;
            this.barrio = barrio;
            this.localidad = localidad;
            this.provincia = provincia;
        }
        public override string ToString()
        {
            return base.ToString() + codPaciente + obraSocial + barrio + localidad + provincia;
        }

    }
}
