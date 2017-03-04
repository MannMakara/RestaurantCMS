using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data
{
    public interface IPostRepository
    {
        Post Get(string id);
        void Edit(string id, Post updatedItem);
    }
}
