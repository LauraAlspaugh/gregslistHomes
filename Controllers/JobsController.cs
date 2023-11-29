namespace gregslistHomes.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobsController : ControllerBase
{
    private readonly JobsService _jobsService;
    public JobsController(JobsService jobsService)
    {
        _jobsService = jobsService;
    }
    [HttpGet]
    public ActionResult<List<Job>> GetJobs()
    {
        try
        {
            List<Job> jobs = _jobsService.GetJobs();
            return Ok(jobs);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
    [HttpGet("{jobId}")]
    public ActionResult<Job> GetJobById(int jobId)
    {
        try
        {
            Job job = _jobsService.GetJobById(jobId);
            return Ok(job);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }

}