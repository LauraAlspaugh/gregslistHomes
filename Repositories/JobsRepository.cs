




namespace gregslistHomes.Repositories;

public class JobsRepository
{
    private readonly IDbConnection _db;
    public JobsRepository(IDbConnection db)
    {
        _db = db;
    }

    internal Job CreateJob(Job jobData)
    {
        string sql = @"
    INSERT INTO jobs(name, description, wage)
    VALUES(@Name, @Description, @Wage);
       SELECT * FROM jobs WHERE id = LAST_INSERT_ID();";
        Job job = _db.Query<Job>(sql, jobData).FirstOrDefault();
        return job;
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

    internal void DestroyJob(int jobId)
    {
        string sql = "DELETE FROM jobs WHERE id = @jobId LIMIT 1;";
        _db.Execute(sql, new { jobId });
    }
}