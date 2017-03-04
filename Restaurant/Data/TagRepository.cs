using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant.Data
{
    public class TagRepository : ITagRepository
    {
        public void Delete(string tag)
        {
            throw new NotImplementedException();
        }

        public void Edit(string existingTag, string newTag)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string tag)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}