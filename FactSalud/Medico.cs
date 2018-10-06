using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactSalud
{
    class Medico
    {
           int MedicoCodigo;
        string MedicoNombre;
        string MedicoEspecialidad;

        public Medico(int medicoCodigo, string medicoNombre, string medicoEspecialidad)
        {
            MedicoCodigo = medicoCodigo;
            MedicoNombre = medicoNombre;
            MedicoEspecialidad = medicoEspecialidad;
        }
    }
}
