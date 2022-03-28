using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DesktopCany.Entidades
{
    class BibliotecaEnt
    {
        [Key]
        public Int64 ID_Biblioteca { get; set; } = 0;

        [ForeignKey("FK_ID_Linguagem")][MaxLength(10)]
        public string ID_Linguagem { get; set; } = String.Empty;

        [ForeignKey("FK_ID_FcnModData")][MaxLength(10)]
        public string ID_FcnModData { get; set; } = String.Empty;

        [MaxLength(10)]
        public string Biblioteca { get; set; } = String.Empty;

        [MaxLength(200)]
        public string DescricaoLib { get; set; } = String.Empty;

        public LinguagemEnt? FK_ID_Linguagem { get; set; } = null;
        public FuncaoEnt? FK_ID_FcnModData { get; set; } = null;
    }
}
