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
        public int Id { get; set; }
        [NotNull, MaxLength(100)]
        public string Dispositivo { get; set; }
        [NotNull, MaxLength(50)]
        public string Marca { get; set; }
        [NotNull]
        public bool GarantiaActiva { get; set; }
        [NotNull]
        public int VidaUtil { get; set; }
    }
}
