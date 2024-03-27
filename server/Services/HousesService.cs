namespace gregslist_csharp_2.Services;

public class HousesService
{
    private readonly HousesRepository _repository;

    public HousesService(HousesRepository repository)
    {
        _repository = repository;
    }

    internal List<House> GetHouses()
    {
        List<House> houses = _repository.GetHouses();
        return houses;
    }

    internal House GetHouseById(int houseId)
    {
        House house = _repository.GetHouseById(houseId);

        if (house == null)
        {
            throw new Exception($"Invalid ID: {houseId}");
        }
        return house;
    }

    internal string DestroyHouse(int houseId, string userId)
    {
        House houseToDestroy = GetHouseById(houseId);

        if (houseToDestroy.CreatorId != userId)
        {
            throw new Exception("Not Your Car");
        }

        _repository.DestroyCar(houseId);

        return $"{houseToDestroy.Title} has been destroyed";
    }
}