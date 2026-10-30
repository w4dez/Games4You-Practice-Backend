namespace games4youDomain;

public class Genre
{
  public int id { get; set; }

  public string? Bezeichnung { get; set; }

  public List<Spiel> Spiel { get; set; } = new List<Spiel>();
}