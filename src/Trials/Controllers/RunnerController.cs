using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trials.Models;

namespace Trials.Controllers
{
    [Route("api/[controller]")]
    public class RunnerController:Controller
    {
        // GET api/runner
        [HttpGet]
        public Runner[] Get()
        {
            var runners = new List<Runner>();

            runners.Add(new Runner() { Id = 1, First = "Shayne", Last = "Boyer", Age = 42, FavoriteBeer = "Guiness" });
            runners.Add(new Runner() { Id = 2, First = "Jennifer", Last = "Locker", Age = 33, FavoriteBeer = "Monkey Brand" });
            runners.Add(new Runner() { Id = 3, First = "Kristy", Last = "Boyer", Age = 35, FavoriteBeer = "Monkey Ber" });

            return runners.ToArray();
        }

        // GET api/runner/5
        [HttpGet("{id}")]
        public Runner Get(int id)
        {
            return Get().Where(r => r.Id == id).FirstOrDefault();
        }

        

    }
}
