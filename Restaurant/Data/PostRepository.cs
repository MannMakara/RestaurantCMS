﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Restaurant.Models;

namespace Restaurant.Data
{
    public class PostRepository : IPostRepository
    {
        public void Create(Post model)
        {
            throw new NotImplementedException();
        }

        public void Edit(string id, Post updatedItem)
        {
            throw new NotImplementedException();
        }

        public Post Get(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}