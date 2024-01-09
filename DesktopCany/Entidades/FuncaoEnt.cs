using System.ComponentModel.DataAnnotations;

namespace DesktopCany.Entidades
{
    class FuncaoEnt
    {
        [Key][MaxLength(100)]
        public string ID_FcnModData { get; set; } = String.Empty;

        [Required][MaxLength(50)]
        public string Funcao { get; set; } = String.Empty;

        [MaxLength(400)]
        public string DescricaoFcn { get; set; } = String.Empty;

        [Required][MaxLength(30)]
        public string ModProgramador { get; set; } = String.Empty;

        [Required]
        public bool ModEstavel { get; set; } = false;

        [Required][MaxLength(8000)]
        public string Snippet { get; set; } = String.Empty;
    }
}
