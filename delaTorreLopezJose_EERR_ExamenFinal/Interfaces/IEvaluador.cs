using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using delaTorreLopezJose_EERR_ExamenFinal.Models;

namespace delaTorreLopezJose_EERR_ExamenFinal.Interfaces
{
    interface IEvaluador
    {
        void Evaluar(Alumno a, float nota);
    }
}
