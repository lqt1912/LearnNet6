

using LearnNet6.Data;
using LearnNet6.Data.Entity;
using LearnNet6.Data.Repositories;
using LearnNet6.Utilities;
using Microsoft.AspNetCore.Authorization;
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

        private const string POST_SQL_QUERY = "INSERT INTO [PerfomanceObject] VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
        private const string GET_SQL_QUERY = "select * from [PerfomanceObject] where Id = (select INDENT_CURRENT('PerfomanceObject'))";

        public PerfomanceObjectsController(ApplicationDbContext context, IPerformanceObjectRepository performanceObjectRepository, IPerformanceTableRepository performanceTableRepository)
        {
            _context = context;
            this.performanceObjectRepository = performanceObjectRepository;
            this.performanceTableRepository = performanceTableRepository;
        }


        // POST: api/PerfomanceObjects
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PerfomanceObject>> PostPerfomanceObject()
        {
            var randomLines = System.IO.File.ReadAllLines("words.txt");
            var obj = new
            {
                Name = StringHelper.RandomString(new Random().Next(10, 200), randomLines),
                Value = StringHelper.RandomString(new Random().Next(49), randomLines),
                Note = StringHelper.RandomString(new Random().Next(49), randomLines),
                CardAuthor = Guid.Parse("76DC8982-85C2-439E-831E-76561F2F141F"),
                AssignTo = Guid.Parse("76DC8982-85C2-439E-831E-76561F2F141F"),
                CardType = 1,
                Id = 1

            };

            var exec = performanceObjectRepository.ExecuteNoneQuery(POST_SQL_QUERY,
                new SqlParameter("@p1", obj.Name),
                new SqlParameter("@p2", obj.Value),
                new SqlParameter("@p3", obj.Note),
                new SqlParameter("@p4", obj.CardAuthor),
                new SqlParameter("@p5", obj.AssignTo),
                new SqlParameter("@p6", obj.CardType));

            if (exec > 0)
            {
                var result = performanceObjectRepository.ExecuteSqlRawForQueryType(GET_SQL_QUERY).FirstOrDefault();
                return Ok(result);
            }
            else
            {
                return Ok(new PerfomanceObject());
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Card>>> GetCardPaged(int skip, int take)
        {
            var query = " SELECT * FROM PerfomanceObject ORDER BY Id desc offset @p1 rows FETCH NEXT @p2 ROWS ONLY";
            var resultQuery = performanceObjectRepository.ExecuteSqlRaw(query,
                new SqlParameter("@p1", skip),
                new SqlParameter("@p2", take));
            var response = new
            {
                records = resultQuery.OrderBy(x => x.Id),
                skip = skip,
                take = take
            };

            return Ok(response);
        }

    }
}
