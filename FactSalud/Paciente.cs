using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactSalud
{
    class Paciente
    {
        int    PacienteCodigo;
        string PacienteNombre;
        string pacienteTelefono;
        string PacienteDireccion;
        int    PacienteEdad;

        public Paciente(int pacienteCodigo, string pacienteNombre, string pacienteTelefono, string pacienteDireccion, int pacienteEdad)
        {
            PacienteCodigo = pacienteCodigo;
            PacienteNombre = pacienteNombre;
            this.pacienteTelefono = pacienteTelefono;
            PacienteDireccion = pacienteDireccion;
            PacienteEdad = pacienteEdad;
        }
    }
}
