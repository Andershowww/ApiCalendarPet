namespace APICalendarPet.Agenda
{
    public interface IAgendaRepository
    {
        Task<Models.Agenda.Agenda> CadastraAgendamento(Models.Agenda.Agenda agenda);
        Task<List<Models.Agenda.Agenda>> BuscaAgendamentoSistema(int IDEmpresa);
        public  void AtualizaServicosAgendamentosSistema(List<Models.Agenda.AtualizaSistema> listaIDs);
    }
}
