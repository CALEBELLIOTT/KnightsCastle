namespace KnightsCastle.Models
{
  public class KnightCastle
  {


    public KnightCastle(string name, string castleId)
    {
      Name = name;
      CastleId = castleId;
    }

    public string Name { get; set; }
    public string CastleId { get; set; }
  }
}