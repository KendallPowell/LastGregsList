namespace LastGregsList.Controllers;
[ApiController]
[Route("api/[controller]")]
public class HomesController : ControllerBase
{
  private readonly HomesService _homesService;

  public HomesController(HomesService homesService)
  {
    _homesService = homesService;
  }


  [HttpGet]
  public ActionResult<List<Home>> Get()
  {
    try
    {
      List<Home> homes = _homesService.Get();
      return Ok(homes);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}