


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
}