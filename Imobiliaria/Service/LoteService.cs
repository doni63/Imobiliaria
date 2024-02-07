namespace Imobiliaria.Service;
using Imobiliaria.Data;
using Imobiliaria.Models;

public class LoteService
{
    private readonly ImobiliariaContext _context;

    public LoteService(ImobiliariaContext context)
    {
        _context = context;
    }

    //Listar todos os Lotes
    public List<Lote> LoteList()
    {
        return _context.Lote.ToList();
    }

    //método para inserir no banco de dados
    public void Insert(Lote lote)
    {
        _context.Add(lote);
        _context.SaveChanges();
    }
}
