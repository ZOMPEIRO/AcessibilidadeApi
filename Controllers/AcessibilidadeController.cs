using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TrabalhoTCC.Data;
using TrabalhoTCC.Models;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoTCC.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class AcessibilidadeController : ControllerBase
    {

        /*private static List<Acessibilidade> acessibilidades = new List<Acessibilidade>()
        {
            new Acessibilidade(){idAcessibilidade=1,idUsuario=1,modoContraste=true, tamanhoFonte="45", alertaSonoro=false,vibração=true},
            
           ****************************************} */
      /*  private readonly DataContext _context;

        public AcessibilidadeController(DataContext context)

        {
            _context = context;
        }

    };

    [HttpGet("(id)")]
    public async Task<IActionResult> GetSingle(int id)
    {
        try
        {
            Acessibilidade a = await _context.TB_ACESSIBILIDADE.FirstOrDefaaultAsync(aBusca => aBuscaa.Id == id);

            return Ok(a);
        }*/
    }


    
}