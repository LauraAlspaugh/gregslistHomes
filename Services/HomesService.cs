




namespace gregslistHomes.Services;

public class HomesService
{
    private readonly HomesRepository _homesRepository;
    public HomesService(HomesRepository homesRepository)
    {
        _homesRepository = homesRepository;
    }

    internal Home CreateHome(Home homeData)
    {
        Home home = _homesRepository.CreateHome(homeData);
        return home;
    }

    internal string DestroyHome(int homeId)
    {
        Home home = GetHomeById(homeId);
        _homesRepository.DestroyHome(homeId);
        return "this home has been destroyed";
    }

    internal Home GetHomeById(int homeId)
    {
        Home home = _homesRepository.GetHomeById(homeId);
        return home;
    }

    internal List<Home> GetHomes()
    {
        List<Home> homes = _homesRepository.GetHomes();
        return homes;
    }

    internal Home UpdateHome(int homeId, Home homeData)
    {
        Home newHome = GetHomeById(homeId);
        newHome.Name = homeData.Name ?? newHome.Name;
        newHome.Description = homeData.Description ?? newHome.Description;
        newHome.Price = homeData.Price;
        _homesRepository.UpdateHome(newHome);
        return newHome;

    }
}