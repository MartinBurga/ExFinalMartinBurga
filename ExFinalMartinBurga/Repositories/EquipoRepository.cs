using ExFinalMartinBurga.Interfaces;
using ExFinalMartinBurga.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFinalMartinBurga.Repositories
{
    class EquipoRepository : IEquipoServices
    {
        private SQLiteAsyncConnection _connection;
        private string _dbPath = FileSystem.AppDataDirectory + "/equipos.db3";
        public void Init()
        {
            throw new NotImplementedException();
        }
        public Task<List<Equipo>> DevuelveEquipos()
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarEquipos(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GuardarEquipos(Equipo equipo)
        {
            throw new NotImplementedException();
        }

        
    }
}
