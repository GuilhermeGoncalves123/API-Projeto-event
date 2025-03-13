using Eveent_.Domains;

namespace ProjectE__SENAI.Interfaces
{
    public interface IEventos
    {
        void Cadastrar(Eventos novoEvento);

        List<Eventos> Listar();

        void Atualizar(Guid id, IEventos evento);

        void Deletar(Guid id);

        Eventos BuscarPorId(Guid id);
        
    }
}
