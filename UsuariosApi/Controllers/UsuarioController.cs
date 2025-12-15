using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsuariosApi.Data;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;
using UsuariosApi.Profiles;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private CadastroService _cadastroService;

    public UsuarioController(CadastroService cadastroService)
    {
        _cadastroService = cadastroService;
    }

    [HttpPost]
    public async Task<IActionResult> CadastraUsuario([FromBody] CreateUsuarioDto dto)
    {
        await _cadastroService.Cadastra(dto);
        return Ok("Usuário cadastrado!");
    }
}
