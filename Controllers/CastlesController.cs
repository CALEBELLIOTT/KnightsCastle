

using System.Collections.Generic;
using KnightCastle.Models;
using KnightsCastle.Services;
using Microsoft.AspNetCore.Mvc;

namespace KnightsCastle.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CastlesController : ControllerBase
  {
    private readonly CastlesService _cs;

    public CastlesController(CastlesService cs)
    {
      _cs = cs;
    }

    [HttpPost]
    public ActionResult<Castle> Create([FromBody] Castle castleData)
    {
      try
      {
        Castle castle = _cs.Create(castleData);
        return Ok(castle);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet]
    public ActionResult<List<Castle>> GetAll()
    {
      try
      {
        List<Castle> castles = _cs.getAll();
        return Ok(castles);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Castle> getById(int id)
    {
      try
      {
        Castle castle = _cs.getById(id);
        return Ok(castle);
      }
      catch (System.Exception e)
      {
        return Ok(e.Message);
      }
    }

  }
}