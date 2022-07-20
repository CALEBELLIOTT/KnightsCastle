
using System;
using System.Collections.Generic;
using KnightCastle.Models;
using KnightsCastle.Repositories;

namespace KnightsCastle.Services
{

  public class CastlesService
  {
    private readonly CastlesRepository repo;
    public CastlesService(CastlesRepository cr)
    {
      repo = cr;
    }


    internal Castle Create(Castle castleData)
    {
      return repo.Create(castleData);
    }



    internal List<Castle> getAll()
    {
      return repo.getAll();
    }

    internal Castle getById(int id)
    {
      return repo.getById(id);
    }
  }
}