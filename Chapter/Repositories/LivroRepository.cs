using Chapter.Contexts;
using Chapter.Models;

namespace Chapter.Repositories
{
    public class LivroRepository
    {
    private readonly ChapterContext _context;
     public LivroRepository(ChapterContext context)
     {
     _context = context;
     }
    // retorna a lista de livros public
     public List<Livro> Listar() {
    // SELECT Id, Titulo, QuantidadePaginas, Disponivel FROM Livros;
        return _context.Livros.ToList(); }

     }
}
