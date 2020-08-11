using Business.Abstract;
using DataAccsess.DbEntities;
using DataAccsess.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class PostManager : IPostService
    {
        private IPostDal _postRepository;

        public PostManager(IPostDal postRepository)
        {
            _postRepository = postRepository;
        }

        public void AddPost(Post data)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAllPost()
        {
            return _postRepository.All().ToList();
        }
    }
}
