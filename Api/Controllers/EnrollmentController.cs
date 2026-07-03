using AutoMapper;
using Escola.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Controllers;

[ApiController]
[Route("[controller]")]

public class EnrollmentController : ControllerBase
{

    protected readonly IEnrollmentService serv;
    protected readonly IMapper mapper;
    public EnrollmentController(IEnrollmentService _serv, IMapper _mapper)
    {
        serv = _serv;
        mapper = _mapper;
    }

    [HttpGet]
    public async Task<IActionResult> ObterTodos()
    {
        var matriculas = await serv.ObterTodos();
        return Ok(mapper.Map<IEnumerable<EnrollmentDto>>(matriculas));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ObterPorId(int id)
    {
        var matricula = await serv.ObterPorId(id);
        return Ok(matricula);
    }

    [HttpPost]
    public async Task<IActionResult> Adicionar(EnrollmentCreateDto enrollment)
    {
        await serv.Adicionar(mapper.Map<Enrollment>(enrollment));
        return Created("", enrollment);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Atualizar(int id, Enrollment enrollment)
    {
        enrollment.EnrollmentID = id;
        await serv.Atualizar(enrollment);
        return Ok(enrollment);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Remover(int id)
    {
        var matricula = await serv.ObterPorId(id);
        await serv.Remover(matricula);
        return Ok(matricula);
    }
}