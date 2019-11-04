using System.Collections.Generic;
using System.Linq;
using AULA2.Context;
using AULA2.Context.Models;
using Microsoft.AspNetCore.Mvc;

namespace AULA2.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        AULA2Context context = new AULA2Context();
        
        [HttpGet]

        public IActionResult Listar() {
            List<UsuarioModel> listaDeUsuarios = context.tbl_usuario.ToList(); //Pega a lista da tabela usuarios 
            return Ok(listaDeUsuarios);
        }

        [HttpPost]
        public IActionResult Cadastrar(UsuarioModel usuario) {
            context.tbl_usuario.Add(usuario); //Acessar a tabela do banco de dados
            context.SaveChanges();

            return Ok();
        }
        
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id){
            UsuarioModel usuarioRetornado = context.tbl_usuario.FirstOrDefault(x => x.Usuario_Id == id);

            return Ok (usuarioRetornado);
        }
    }
}