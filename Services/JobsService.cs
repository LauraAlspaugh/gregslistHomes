





namespace gregslistHomes.Services;
public class JobsService
{
    private readonly JobsRepository _jobsRepository;

    public JobsService(JobsRepository jobsRepository)
    {
        _jobsRepository = jobsRepository;
    }

    internal Job CreateJob(Job jobData)
    {
        Job job = _jobsRepository.CreateJob(jobData);
        return job;
    }

    internal string DestroyJob(int jobId)
    {
        Job job = GetJobById(jobId);
        _jobsRepository.DestroyJob(jobId);
        return "this job has been destroyed";
    }

    internal Job EditJob(int jobId, Job jobData)
    {
        Job job = GetJobById(jobId);
        job.Name = jobData.Name ?? job.Name;
        job.Description = jobData.Description ?? job.Description;
        job.Wage = jobData.Wage;
        _jobsRepository.EditJob(job);
        return job;
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
