namespace gregslistHomes.Controllers;

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
    public ActionResult<List<Home>> GetHomes()
    {
        try
        {
            List<Home> homes = _homesService.GetHomes();
            return Ok(homes);
        }
        catch (Exception error)
        {


            return BadRequest(error.Message);
        }

    }
    [HttpGet("{homeId}")]
    public ActionResult<Home> GetHomeById(int homeId)
    {
        try
        {
            Home home = _homesService.GetHomeById(homeId);
            return home;
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
    [HttpPost]
    public ActionResult<Home> CreateHome([FromBody] Home homeData)
    {
        try
        {
            Home home = _homesService.CreateHome(homeData);
            return Ok(home);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);

        }
    }
    [HttpDelete("{homeId}")]
    public ActionResult<string> DestroyHome(int homeId)
    {
        try
        {
            string message = _homesService.DestroyHome(homeId);
            return Ok(message);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
    [HttpPut("{homeId}")]
    public ActionResult<Home> UpdateHome(int homeId, [FromBody] Home homeData)
    {
        try
        {
            Home home = _homesService.UpdateHome(homeId, homeData);
            return Ok(home);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
}