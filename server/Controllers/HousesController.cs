namespace gregslist_csharp_2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HousesController : ControllerBase
{

    private readonly HousesService _housesService

public HousesController(HousesService _housesService)
    {
        _housesService = housesService;
    }

    [HttpGet]
    public ActionResult<List<House>> GetHouses()
    {
        try
        {
            List<House> houses = _housesService.GetHouses()
            return Ok(houses)
        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message)
        }
    }

}