using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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


    internal List<Castle> getAll()
    {
      string sql = @"SELECT * FROM castles";
      return _db.Query<Castle>(sql).ToList();
    }
    internal Castle getById(int id)
    {
      string sql = @"SELECT * FROM castles WHERE id = @id";
      return _db.QueryFirstOrDefault<Castle>(sql, new { id });
    }
  }
}