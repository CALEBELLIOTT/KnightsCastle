

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

  }
}