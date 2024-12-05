using Application.Interface;
using AutoMapper;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace TesteLabs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaController : ControllerBase
    {
        private readonly ISalaService _service;
        private readonly IMapper _mapper;

        public SalaController(ISalaService corpoAppService, IMapper mapper)
        {
            _service = corpoAppService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalaViewModel>>> Get()
        {
            try
            {
                return Ok(_service.Query());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest,
                    ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<SalaViewModel>> GetById(Guid id)
        {
            try
            {
                return _mapper.Map<SalaViewModel?>(await _service.FirstOrDefaultAsync(x => x.Id == id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(SalaViewModel request)
        {
            try
            {
                var entity = await _service.FirstOrDefaultAsync(x => x.Id == request.Id) ?? throw new Exception("Não foi encontrado nenhum registro para exclusão.");

                _service.Add(entity);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest,
                    ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put(SalaViewModel request)
        {
            try
            {
                var entity = await _service.FirstOrDefaultAsync(x => x.Id == request.Id) ?? throw new Exception("Não foi encontrado nenhum registro para exclusão.");

                _service.Update(entity);

                return Ok("Sala atualizado com sucesso.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest,
                    ex.Message);
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(IdViewModel request)
        {
            try
            {
                var entity = await _service.FirstOrDefaultAsync(x => x.Id == request.Id) ?? throw new Exception("Não foi encontrado nenhum registro para exclusão.");
                
                _service.Delete(entity);

                return Ok("Registro deletado com sucesso");

            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest,
                    ex.Message);
            }
        }
    }
}
