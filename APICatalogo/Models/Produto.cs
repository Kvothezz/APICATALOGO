namespace APICatalogo.Models;

public class Produto
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal Preco { get; set; }
    public string? ImagemUrl { get; set; }
    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }

    public int CategoriaId { get; set; } // Foreign key
    public Categoria? Categoria { get; set; } // propriedade de navegação para definir que produto tá mapeado para categoria e cada categoria pode ter uma coleção de produto

}
