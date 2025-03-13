using Eveent_.Domains;

namespace Eveent_.Interfaces
{
    public interface ITiposUsuarios
    {
        void Cadastrar(TiposUsuarios novotipousuario);
        void Atualizar(Guid Id, TiposUsuarios tiposUsuario);
        void Deletar(Guid Id);
        List<TiposUsuarios> Listar();
        Usuarios BuscarPorId(Guid id);

    }


    public class Usuarios
    {
    }
}