using DataAccsess.DbEntities;
using DataAccsess.Repository.Abstract;
using DataAccsess.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Repository.Concrete
{
    public class EfPostDal : GenericRepository<Post>, IPostDal
    {
        public EfPostDal(OADbContext dbContext) : base(dbContext)
        {
        }
    }
}
