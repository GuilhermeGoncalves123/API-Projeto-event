using Eveent_.Domains;

namespace Eveent_.Interfaces
{
    public interface IUsuarios
    {
        void Cadastrar(Usuarios novoUsuario);
        void Deletar(Guid id);
        Usuarios BuscarPorId(Guid id);

        Usuarios BuscarPorEmailSenha(string email, string senha);
    }
}
