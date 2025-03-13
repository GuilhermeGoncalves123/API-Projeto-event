using Eveent_.Domains;

namespace Eveent_.Interfaces
{
    public interface ITiposEventos
    {
        void deletar(Guid id, TiposEventos novotiposeventos);
        void Cadastrar(TiposEventos novotipoevento);
        void atualizar(Guid id, TiposEventos novotipoevento);
        List<TiposEventos>Listar();
        TiposEventos BuscarPorId(Guid id);

    }
}
