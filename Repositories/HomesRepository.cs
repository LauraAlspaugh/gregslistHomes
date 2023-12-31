





namespace gregslistHomes.Repositories;

public class HomesRepository
{
    private readonly IDbConnection _db;
    public HomesRepository(IDbConnection db)
    {
        _db = db;
    }

    internal Home CreateHome(Home homeData)
    {
        string sql = @"
        INSERT INTO homes(name, description, price)
        VALUES(@Name, @Description, @Price);
        SELECT * FROM homes WHERE id = LAST_INSERT_ID();
        ";
        Home home = _db.Query<Home>(sql, homeData).FirstOrDefault();
        return home;
    }



    internal Home GetHomeById(int homeId)
    {
        string sql = "SELECT * FROM homes WHERE id = @homeId;";
        Home home = _db.Query<Home>(sql, new { homeId }).FirstOrDefault();
        return home;
    }

    internal List<Home> GetHomes()
    {
        string sql = "SELECT * FROM homes;";
        List<Home> homes = _db.Query<Home>(sql).ToList();
        return homes;
    }

    internal void DestroyHome(int homeId)
    {
        string sql = "DELETE FROM homes WHERE id = @homeId LIMIT 1;";
        _db.Execute(sql, new { homeId });
    }

    internal void UpdateHome(Home newHome)
    {
        string sql = @"
        UPDATE homes SET 
        name = @Name,
        description = @Description,
        price = @Price
        WHERE id = @id;";
        _db.Execute(sql, newHome);
    }
}