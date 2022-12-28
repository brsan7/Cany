using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DesktopCany.Entidades
{
    class LinguagemEnt
    {
        [Key][MaxLength(30)]
        public string ID_Linguagem { get; set; } = String.Empty;

        [MaxLength(200)]
        public string DescricaoLang{ get; set; } = String.Empty;

    }
}
