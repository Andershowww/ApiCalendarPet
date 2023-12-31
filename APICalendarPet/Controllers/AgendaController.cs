﻿using APICalendarPet.Agenda;
using APICalendarPet.Models;
using APICalendarPet.Users;
using Microsoft.AspNetCore.Mvc;

namespace APICalendarPet.Controllers
{
    [ApiController]
    [Route("api/v1/Agenda")]
    public class AgendaController : ControllerBase
    {


        private IAgendaRepository _agendaRepository;
        public AgendaController(IAgendaRepository agenda)
        {
            _agendaRepository = agenda;
        }

        [HttpGet("buscasistema")]
        public async Task<ActionResult<List<Models.Agenda.Agenda>>> BuscaAgendamentosSistema(int IDEmpresa)
        {
            try
            {
                var agendas = await _agendaRepository.BuscaAgendamentoSistema(IDEmpresa);
                if (agendas.Count > 0)
                    return Ok(agendas);
            }
            catch (Exception ex)
            {

            }
            return Ok();
        }

        [HttpPost("atualizaservs")]
        public async void AtualizaServicos(List<Models.Agenda.AtualizaSistema> agenda)
        {
            try
            {
                _agendaRepository.AtualizaServicosAgendamentosSistema(agenda);
            }
            catch (Exception ex)
            {

            }

        }

        [HttpPost("cadagenda")]
        public async Task<ActionResult<Models.Agenda.Agenda>> CriaAgendamento(Models.Agenda.Agenda agenda)
        {
            try
            {
                await _agendaRepository.CadastraAgendamento(agenda);
            }
            catch (Exception ex)
            {

            }
            return agenda;
        }
    }
}
