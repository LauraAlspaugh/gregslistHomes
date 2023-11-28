using Microsoft.AspNetCore.SignalR;

namespace gregslistHomes.Models;
public class Home
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }

}