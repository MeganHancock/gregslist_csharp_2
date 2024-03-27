namespace gregslist_csharp_2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HousesController : ControllerBase
{

    private readonly HousesService _housesService;
    private readonly Auth0Provider _auth0Provider;

    public HousesController(HousesService housesService, Auth0Provider auth0Provider)
    {
        _housesService = housesService;
        _auth0Provider = auth0Provider;
    }

    [HttpGet]
    public ActionResult<List<House>> GetHouses()
    {
        try
        {
            List<House> houses = _housesService.GetHouses();
            return Ok(houses);
        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message);
        }
    }

    [HttpGet("{houseId}")]
    public ActionResult<House> GetHouseById(int houseId)
    {
        try
        {
            House house = _housesService.GetHouseById(houseId);
            return Ok(house);
        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message);
        }
    }


    [HttpDelete("{houseId}")]
    [Authorize]
    public async Task<ActionResult<string>> DestroyHouse(int houseId)
    {
        try
        {
            Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
            string message = _housesService.DestroyHouse(houseId, userInfo.Id);
        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message);
        }
    }
}