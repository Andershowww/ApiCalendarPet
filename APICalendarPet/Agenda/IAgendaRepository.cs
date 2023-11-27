namespace APICalendarPet.Agenda
{
    public interface IAgendaRepository
    {
        Task<Models.Agenda> CadastraAgendamento(Models.Agenda agenda);
        Task<List<Models.Agenda>> BuscaAgendamentoSistema(int IDEmpresa);
    }
}
