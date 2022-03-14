using controlleParc.Models;
using controlleParc.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controlleParc.Controllers
{
    [Route("mamoudou/[controller]")]
    [ApiController]
    public class ConducteurController : Controller
    {
       public IConducteurRepo ConducteurRepo { get; }

        public ConducteurController(IConducteurRepo conducteurRepo)
        {
            ConducteurRepo = conducteurRepo;
        }
        // GET: mamoudou/conducteurs
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(ConducteurRepo.findAll().Result);
        }
        // GET: mamoudou/conducteurs/1
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id == 0)
                return BadRequest("Value must be passed in the request body.");
            else
            {
                Conducteur conducteur = ConducteurRepo.findById(id).Result;
                if (conducteur == null)
                    return NotFound("Aucun client pour cet ID");
                else
                    return Ok(conducteur);
            }
        }

        [HttpPost]
        public ActionResult AddConducteur(Conducteur conducteur)
        {
            ConducteurRepo.AddConducteur(conducteur);
            return Ok(conducteur);
           
        }
        [HttpPut]
        public ActionResult Put(Conducteur conducteur)
        {


            ConducteurRepo.UpdateConducteur(conducteur);
            return null;

        }
    }
}
