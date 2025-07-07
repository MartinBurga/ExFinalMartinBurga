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
        private SQLiteAsyncConnection _connection = null!;
        private string _dbPath = FileSystem.AppDataDirectory + "/equipos.db3";

        public EquipoRepository()
        {
            Init();
        }

        public async void Init()
        {
            if (_connection != null)
            {
                return;
            }
            _connection = new SQLiteAsyncConnection(_dbPath);

            await _connection.CreateTableAsync<Equipo>();
        }

        public async Task<List<Equipo>> DevuelveEquipos()
        {
            try
            {
                List<Equipo> equipos = await _connection.Table<Equipo>().ToListAsync();
                return equipos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> EliminarEquipos(int id)
        {
            try
            {
                await _connection.DeleteAsync<Equipo>(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> GuardarEquipos(Equipo equipo)
        {
            try
            {
                await _connection.InsertAsync(equipo);
                string logPath = Path.Combine(FileSystem.AppDataDirectory, "Burga.txt");
                File.AppendAllText(logPath, $"{DateTime.Now}: Equipo guardado: {equipo.Dispositivo}, Marca: {equipo.Marca}, Garantía Activa: {equipo.GarantiaActiva}, Vida Útil: {equipo.VidaUtil}\n");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
