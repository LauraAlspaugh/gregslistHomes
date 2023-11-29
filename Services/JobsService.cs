

namespace gregslistHomes.Services;
public class JobsService
{
    private readonly JobsRepository _jobsRepository;

    public JobsService(JobsRepository jobsRepository)
    {
        _jobsRepository = jobsRepository;
    }

    internal Job GetJobById(int jobId)
    {
        Job job = _jobsRepository.GetJobById(jobId);
        return job;
    }

    internal List<Job> GetJobs()
    {
        List<Job> job = _jobsRepository.GetJobs();
        return job;
    }
}
