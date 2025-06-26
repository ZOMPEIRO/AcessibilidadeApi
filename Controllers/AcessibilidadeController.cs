using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TrabalhoTCC.Data;
using TrabalhoTCC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace TrabalhoTCC.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class AcessibilidadeController : ControllerBase
    {
        private readonly DataContext _context;

        public AcessibilidadeController(DataContext context)
        {
            _context = context;
        }


     [HttpGet("{id}")]
     public async Task<IActionResult> GetSingle(int id)
     {
        try
        {
            Acessibilidade a = await _context.TB_ACESSIBILIDADE.FirstOrDefaultAsync(aBusca => aBusca.idAcessibilidade == id);//

            return Ok(a);
        }
        catch(System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
     }

     [HttpGet("GetAll")]
     public async Task<IActionResult> Get()
     {
        try
        {
          List<Acessibilidade> lista = await _context.TB_ACESSIBILIDADE.ToListAsync();
          return Ok(lista);
        }
        catch (System.Exception ex)
        {
          return BadRequest(ex.Message);
        }
     }

     [HttpPost]
     public async Task<IActionResult> Add(Acessibilidade novaAcessibilidade)
     {
        try
        {
            await _context.TB_ACESSIBILIDADE.AddAsync(novaAcessibilidade);
            await _context.SaveChangesAsync();

            return Ok(novaAcessibilidade.idAcessibilidade);//
        }
        catch (System.Exception ex)
        {
           return BadRequest(ex.Message);
        }

     }

     [HttpPut]
     public async Task<IActionResult> Update(Acessibilidade novaAcessibildade)
     {
        try 
        {
            _context.TB_ACESSIBILIDADE.Update(novaAcessibildade);
            int linhasAfetadas = await _context.SaveChangesAsync();

            return Ok(linhasAfetadas);
        }
        catch(System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
     }

     [HttpDelete]
     public async Task<IActionResult> Delete(int id)
     {
        try
        {
            Acessibilidade aRemover = await _context.TB_ACESSIBILIDADE.FirstOrDefaultAsync(a => a.idAcessibilidade == id);

            _context.TB_ACESSIBILIDADE.Remove(aRemover);
            int linhasAfetadas = await _context.SaveChangesAsync();
            return Ok (linhasAfetadas);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
     }



    }


    
}



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