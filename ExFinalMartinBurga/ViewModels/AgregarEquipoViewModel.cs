using ExFinalMartinBurga.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFinalMartinBurga.ViewModels
{
    class AgregarEquipoViewModel : INotifyPropertyChanged
    {
        public string Dispositivo { get; set; }
        public string Marca { get; set; }
        public bool GarantiaActiva { get; set; }
        public int VidaUtil { get; set; }

        public Command Guardar { get; }
        private IEquipoServices _servicios;
        public AgregarEquipoViewModel(IEquipoServices servicios)
        {
            _servicios = servicios;
            Guardar = new Command(async () => await GuardarEquipo());
        }
        public async Task GuardarEquipo()
        {
            if (string.IsNullOrWhiteSpace(Dispositivo) || string.IsNullOrWhiteSpace(Marca) || VidaUtil <= 0)
            {
                Exception exception = new Exception("Todos los campos son obligatorios y la vida útil debe ser mayor a 0.");
                return;
            }
            var equipo = new Models.Equipo
            {
                Dispositivo = Dispositivo,
                Marca = Marca,
                GarantiaActiva = GarantiaActiva,
                VidaUtil = VidaUtil
            };
            bool resultado = await _servicios.GuardarEquipos(equipo);
            
        }


        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
