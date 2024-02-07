namespace Imobiliaria.Models;

public class Lote
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public Cliente cliente { get; set; }

    public Lote(int id, string descricao, Cliente? cliente)
    {
        Id = id;
        Descricao = descricao;
        this.cliente = cliente;
    }
    public Lote()
    {
        
    }
}
