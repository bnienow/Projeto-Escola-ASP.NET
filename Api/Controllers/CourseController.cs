using AutoMapper;
using Escola.Domain.Model;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class CourseController : ControllerBase
{
    protected readonly ICourseService serv;
    protected readonly IMapper mapper;
    public CourseController(ICourseService _serv, IMapper _mapper)
    {
        serv = _serv;
        mapper = _mapper;
    }

    [HttpGet]
    public async Task<IActionResult> ObterTodos()
    {
        var cursos = await serv.ObterTodos();
        return Ok(mapper.Map<IEnumerable<CourseDto>>(cursos));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ObterPorId(int id)
    {
        var curso = await serv.ObterPorId(id);
        return Ok(curso);
    }

    [HttpPost]
    public async Task<IActionResult> Adicionar(CourseCreateDto curso)
    {
        await serv.Adicionar(mapper.Map<Course>(curso));
        return Created("", curso);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Atualizar(int id, Course curso)
    {
        curso.CourseID = id;
        await serv.Atualizar(curso);
        return Ok(curso);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Remover(int id)
    {
        var curso = await serv.ObterPorId(id);
        await serv.Remover(curso);
        return Ok(curso);
    }
     
}