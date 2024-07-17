using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models;
[Table("Categorias")]
public class Categoria
{   
    public Categoria() { // boas práticas: inicializar a coleção
       Produtos = new Collection<Produto>();
    }
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }


    // Uma categoria pode ter vários produtos, portanto tem o relacionamento um-para-muitos
    //No EF CORE, realizamos este relacionamento criando uma coleção

    public ICollection<Produto> Produtos { get; set; }
}
