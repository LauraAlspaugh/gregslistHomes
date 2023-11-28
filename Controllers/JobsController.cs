namespace gregslistHomes.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobsController : ControllerBase
{
    private readonly JobsService _jobsService;
    public JobsController(JobsService jobsService)
    {

    }

}