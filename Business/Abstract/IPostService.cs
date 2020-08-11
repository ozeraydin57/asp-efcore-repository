using DataAccsess.DbEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPostService
    {
        void AddPost(Post data);
        List<Post> GetAllPost();
    }
}
