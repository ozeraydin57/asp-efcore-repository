using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.DbEntities
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FullContent { get; set; }
    }
}