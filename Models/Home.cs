namespace LastGregsList.Models;

public class Home
{
  public int Id { get; set; }
  public string ImgUrl { get; set; }
  public int? price { get; set; }
  public int? rooms { get; set; }
  public int? bathrooms { get; set; }
  public int? squarefeet { get; set; }
  public string description { get; set; }
}
