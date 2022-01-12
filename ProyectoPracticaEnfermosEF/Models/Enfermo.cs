using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoPracticaEnfermosEF.Models
{
    [Table("ENFERMO")]
    public class Enfermo
    {
        [Key]
        [Column("INSCRIPCION")]
        public int inscripcion { get; set; }
        [Column("APELLIDO")]
        public string apellido { get; set; }
        [Column("DIRECCION")]
        public string direccion { get; set; }
        [Column("FECHA_NAC")]
        public DateTime fecha_nac { get; set; }
        [Column("S")]
        public char sexo { get; set; }
        [Column("NSS")]
        public int nss { get; set; }
    }
}
