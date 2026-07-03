using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    protected readonly IStudentService serv;
    protected readonly IMapper mapper;

    public StudentController(IStudentService _serv, IMapper _mapper)
    {
        mapper = _mapper;
        serv = _serv;
    }

    [HttpGet]
    public async Task<IActionResult> ObterTodos()
    {
        var estudantes = await serv.ObterTodos();
        return Ok(mapper.Map<IEnumerable<StudentDto>>(estudantes));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ObterPorId(int id)
    {
        var estudante = await serv.ObterPorId(id);
        return Ok(estudante);
    }

    [HttpPost]
    public async Task<IActionResult> Adicionar(StudentCreateDto student)
    {
        await serv.Adicionar(mapper.Map<Student>(student));
        return Created("", student);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Atualizar(int id, Student student)
    {
        student.StudentID = id;
        await serv.Atualizar(student);
        return Ok(student);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Remover(int id)
    {
        var estudante = await serv.ObterPorId(id);
        await serv.Remover(estudante);
        return Ok(estudante);
    }

    [HttpGet("reprovados")]
    public async Task<IActionResult> Reprovados()
    {
        var reprovados = await serv.Reprovados();
        return Ok(reprovados);
    }
}
