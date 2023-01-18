namespace LastGregsList.Services;
public class HomesService
{
  private readonly HomesRepository _repo;

  public HomesService(HomesRepository repo)
  {
    _repo = repo;
  }
}