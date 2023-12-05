using APICalendarPet.API;
using Microsoft.EntityFrameworkCore;

namespace APICalendarPet.Agenda
{
    public class AgendaRepository : IAgendaRepository
    {

        private APIDataContext _context;

        //Carrega a connection string que aponta para o banco de dados
        public AgendaRepository(APIDataContext context)
        {
            _context = context;
        }

        public async Task<Models.Agenda.Agenda> CadastraAgendamento(Models.Agenda.Agenda agenda)
        {
            _context.Agenda.Add(agenda);
            _context.SaveChanges();
            return agenda;
        }
        public async Task<List<Models.Agenda.Agenda>> BuscaAgendamentoSistema(int IDEmpresa)
        {
            var agendamentos = _context.Agenda.AsQueryable();
            agendamentos = agendamentos.Where(x => x.IDEmpresa == IDEmpresa && x.AtualizadoSistema == false);
            return await agendamentos.ToListAsync();
        }

        public async void AtualizaServicosAgendamentosSistema(List<Models.Agenda.AtualizaSistema> listaIDs)
        {

            foreach (var item in listaIDs)
            {
                var agendamentos = _context.Agenda.AsQueryable();
                var agenda = agendamentos.Where(x => x.AgendaID==item.IDAgenda && x.AtualizadoSistema == false).FirstOrDefault();
                agenda.AtualizadoSistema = true;
                _context.SaveChanges();
            }

        }
    }
}
