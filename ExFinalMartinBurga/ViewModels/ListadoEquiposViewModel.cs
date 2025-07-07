using ExFinalMartinBurga.Interfaces;
using ExFinalMartinBurga.Repositories;
using ExFinalMartinBurga.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFinalMartinBurga.ViewModels
{
    class ListadoEquiposViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Models.Equipo> Equipos { get; set; }
        private IEquipoServices _equiposervices;

        public ListadoEquiposViewModel()
        {
            _equiposervices = new EquipoRepository();
            Equipos = new ObservableCollection<Models.Equipo>();
            CargarEquipos();
        }

        public async Task CargarEquipos()
        {
            var datos = await _equiposervices.DevuelveEquipos();
            Equipos.Clear();
            foreach (var equipo in datos)
            {
                Equipos.Add(equipo);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
