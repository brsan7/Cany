using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesktopCany.Entidades
{
    class FuncaoEnt
    {
        [Key][MaxLength(20)]
        public string ID_FcnModData { get; set; } = String.Empty;

        [Required][MaxLength(10)]
        public string Funcao { get; set; } = String.Empty;

        [MaxLength(200)]
        public string DescricaoFcn { get; set; } = String.Empty;

        [Required][MaxLength(10)]
        public string ModProgramador { get; set; } = String.Empty;

        [Required]
        public bool ModEstavel { get; set; } = false;

        [Required][MaxLength(400)]
        public string Snippet { get; set; } = String.Empty;
    }
}
