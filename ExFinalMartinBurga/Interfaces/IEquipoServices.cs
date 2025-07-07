using ExFinalMartinBurga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFinalMartinBurga.Interfaces
{
    interface IEquipoServices
    {
        public void Init();
        public Task<List<Equipo>> DevuelveEquipos();
        public Task<bool> GuardarEquipos(Equipo equipo);
        public Task<bool> EliminarEquipos(int id);

    }
}
