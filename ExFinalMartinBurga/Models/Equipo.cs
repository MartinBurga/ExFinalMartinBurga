using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFinalMartinBurga.Models
{
    [Table("Equipo")]
    class Equipo
    {
        [AutoIncrement: PrimaryKey]
        string Dispositivo { get; set; }
        [NotNull]
        string Marca { get; set; }
        [NotNull]
        bool GarantiaActiva { get; set; }
        [NotNull]
        int VidaUtil { get; set; }
        [NotNull]

    }
}
