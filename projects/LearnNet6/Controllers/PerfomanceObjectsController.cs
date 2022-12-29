

using LearnNet6.Data;
using LearnNet6.Data.Entity;
using LearnNet6.Data.Repositories;
using LearnNet6.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace LearnNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfomanceObjectsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IPerformanceObjectRepository performanceObjectRepository;
        private readonly IPerformanceTableRepository performanceTableRepository;
        public PerfomanceObjectsController(ApplicationDbContext context, IPerformanceObjectRepository performanceObjectRepository, IPerformanceTableRepository performanceTableRepository)
        {
            _context = context;
            this.performanceObjectRepository = performanceObjectRepository;
            this.performanceTableRepository = performanceTableRepository;
        }


        // POST: api/PerfomanceObjects
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PerfomanceObject>> PostPerfomanceObject(PerfomanceObject perfomanceObject)
        {
            var randomLines = System.IO.File.ReadAllLines("words.txt");

            for (int i = 0; i < 500000; i++)
            {
                var obj = new PerfomanceObject()
                {
                    Name = StringHelper.RandomString(new Random().Next(10, 200), randomLines),
                    Value = StringHelper.RandomString(new Random().Next(49), randomLines),
                    Note = StringHelper.RandomString(new Random().Next(49), randomLines)
                };
                var query = "INSERT INTO [PerfomanceObject] VALUES (@p1, @p2, @p3)";
                performanceTableRepository.ExecuteNoneQuery(query,
                    new SqlParameter("@p1", obj.Name),
                    new SqlParameter("@p2", obj.Value),
                    new SqlParameter("@p3", obj.Note));

            }
            return Ok(1);
        }



    }
}
