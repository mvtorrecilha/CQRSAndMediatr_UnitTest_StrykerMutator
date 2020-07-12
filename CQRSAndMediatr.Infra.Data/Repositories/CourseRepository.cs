using CQRSAndMediatr.Domain.Entities;
using CQRSAndMediatr.Infra.Data.Context;
using CQRSAndMediatr.Infra.Data.Interfaces;

namespace CQRSAndMediatr.Infra.Data.Repositories
{
    public class CourseRepository : RepositoryBase<Course>, ICoursetRepository
    {
        private readonly CqrsMediatrDBContext _context;

        public CourseRepository(CqrsMediatrDBContext context)
             : base(context)
        {
            _context = context;
        }
    }
}
