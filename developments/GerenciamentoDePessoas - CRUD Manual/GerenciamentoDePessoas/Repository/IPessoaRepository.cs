using GerenciamentoDePessoas.Models;

namespace GerenciamentoDePessoas.Repository
{
    public interface IPessoaRepository
    {
       Task<List<Pessoa>> BuscarTodos();
        Task<bool> VerificarSePessoaExiste(string cpf);
        Task<Pessoa> Criar(Pessoa pessoa);
        Task<Pessoa> BuscarPorId(int id);
        Task<Pessoa> Editar(Pessoa pessoa);
        Task Apagar(Pessoa pessoa);
    }
}
