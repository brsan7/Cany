using System.ComponentModel.DataAnnotations;

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
