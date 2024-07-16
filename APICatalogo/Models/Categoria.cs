using System.Collections.ObjectModel;

namespace APICatalogo.Models;

public class Categoria
{   
    public Categoria() { // boas práticas: inicializar a coleção
       Produtos = new Collection<Produto>();  
    }
    public int Id { get; set; }
    public string? Nome { get; set; }

    public string? ImagemUrl { get; set; }


    // Uma categoria pode ter vários produtos, portanto tem o relacionamento um-para-muitos
    //No EF CORE, realizamos este relacionamento criando uma coleção

    public ICollection<Produto> Produtos { get; set; }
}
