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

        public async Task<Models.Agenda> CadastraAgendamento(Models.Agenda agenda)
        {
            _context.Agenda.Add(agenda);
            _context.SaveChanges();
            return agenda;
        }
        public async Task<List<Models.Agenda>> BuscaAgendamentoSistema(int IDEmpresa)
        {
            var agendamentos = _context.Agenda.AsQueryable();
            agendamentos = agendamentos.Where(x => x.IDEmpresa == IDEmpresa && x.AtualizadoSistema == false);
            return await agendamentos.ToListAsync();
        }
    }
}
