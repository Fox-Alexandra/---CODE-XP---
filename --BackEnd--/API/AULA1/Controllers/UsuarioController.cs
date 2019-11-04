using System.Collections.Generic;
using System.Linq;
using AULA1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AULA1.Controllers
{
    [ApiController]
    [Route("v1/[controller]")] //Cria uma rota pra acessar os métodos desse controller
    [Produces("application/json")] //Define o tipo de dado que vai ser transmitido
    public class UsuarioController : ControllerBase
    {
        //acesso os metodos dessa classe 
        List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>(); //Cria uma lista
        
        [HttpGet("Listar")]
        public IActionResult Usuarios() //retorna um resultado de uma ação em um metodo
        {
            //Primeiro Usuario
            UsuarioModel usuario1 = new UsuarioModel();
            usuario1.usuarioId = 1;
            usuario1.usuarioNome = "Alexandra da Silveira";
            usuario1.usuarioEmail = "alexandra.silveira@live.com";
            usuario1.usuarioSenha = "12345678";
            
            //Segundo Usuario
            UsuarioModel usuario2 = new UsuarioModel();
            usuario2.usuarioId = 2;
            usuario2.usuarioNome = "Alexia da Silveira";
            usuario2.usuarioEmail = "alexia.silveira@live.com";
            usuario2.usuarioSenha = "12345678";

            //Terceiro Usuario
            UsuarioModel usuario3 = new UsuarioModel();
            usuario3.usuarioId = 3;
            usuario3.usuarioNome = "Alexania da Silveira";
            usuario3.usuarioEmail = "alexania.silveira@live.com";
            usuario3.usuarioSenha = "12345678";

            //Quarto Usuario
            UsuarioModel usuario4 = new UsuarioModel();
            usuario4.usuarioId = 4;
            usuario4.usuarioNome = "Alexandro da Silveira";
            usuario4.usuarioEmail = "alexandro.silveira@live.com";
            usuario4.usuarioSenha = "12345678";

            //Adicionando á lista
            listaDeUsuarios.Add(usuario1);
            listaDeUsuarios.Add(usuario2);
            listaDeUsuarios.Add(usuario3);
            listaDeUsuarios.Add(usuario4);

            return Ok(listaDeUsuarios);
        }

        [HttpGet ("listar/{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Usuarios();
            return Ok (listaDeUsuarios.FirstOrDefault(x => x.usuarioId == id)); // dentro do usuario "x" vamos pegar o usuario"x".usuarioId e comparar com o Id digitado
            
        }

        [HttpPost("cadastro")]
        public IActionResult Cadastrar (UsuarioModel usuario){
            Usuarios();
            listaDeUsuarios.Add(usuario);
            return Ok(listaDeUsuarios);
        }
        
    }
}