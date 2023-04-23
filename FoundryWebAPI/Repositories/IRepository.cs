using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoundryWebAPI.Models;

namespace FoundryWebAPI.Repositories
{
    public interface IRepository
    {
        List<Actors>? Actor(string world);
        List<Journals>? Journal(string world);
        List<Worlds>? World();
    }
}