using Eveent_.Domains;

namespace ProjectE__SENAI.Interfaces
{
    public interface IComentarioEvento
    {
        void Cadastrar(ComentarioEvento novocomentarioevento);
        void atualizar(Guid id, ComentarioEvento novocomentarioevento);
        void deletar(Guid id);
        List<ComentarioEvento> Comentarios();
        List<ComentarioEvento> BuscarPorId(Guid id);
    }
}
