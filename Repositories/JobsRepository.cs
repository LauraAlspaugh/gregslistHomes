

namespace gregslistHomes.Repositories;

public class JobsRepository
{
    private readonly IDbConnection _db;
    public JobsRepository(IDbConnection db)
    {
        _db = db;
    }

    internal Job GetJobById(int jobId)
    {
        string sql = "SELECT * FROM jobs WHERE id = @jobId;";
        Job job = _db.Query<Job>(sql, new { jobId }).FirstOrDefault();
        return job;
    }

    internal List<Job> GetJobs()
    {
        string sql = "SELECT * FROM jobs;";
        List<Job> jobs = _db.Query<Job>(sql).ToList();
        return jobs;
    }
}