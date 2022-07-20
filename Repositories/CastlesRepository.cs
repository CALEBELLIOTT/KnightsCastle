using System;
using System.Data;
using Dapper;
using KnightCastle.Models;

namespace KnightsCastle.Repositories
{
  public class CastlesRepository
  {
    private readonly IDbConnection _db;

    public CastlesRepository(IDbConnection db)
    {
      _db = db;
    }

    internal Castle Create(Castle castleData)
    {
      string sql = @"INSERT INTO castles
      (name, isDestroyed)
      VALUES
      (@Name, @Destroyed);
      ";

      int id = _db.ExecuteScalar<int>(sql, castleData);
      castleData.Id = id;
      return castleData;
    }
  }
}