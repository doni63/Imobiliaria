namespace Imobiliaria.Models;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Rg { get; set; }
    public string Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public string EstadoCivil { get; set; }
    public string Profissao { get; set; }
    public string Nacionalidade { get; set; }
    
    public ICollection<Lote> Lotes { get; set; } = new List<Lote>();

    public Cliente(int id, string nome, string rg, string cpf, DateTime dataNascimento, string telefone, string email, string estadoCivil, string profissao, string nacionalidade)
    {
        Id = id;
        Nome = nome;
        Rg = rg;
        Cpf = cpf;
        DataNascimento = dataNascimento;
        Telefone = telefone;
        Email = email;
        EstadoCivil = estadoCivil;
        Profissao = profissao;
        Nacionalidade = nacionalidade;
    }

    public Cliente()
    {
        
    }
}
