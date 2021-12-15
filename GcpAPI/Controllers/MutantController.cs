using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using model.modelEF;
using service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GcpAPI.Controllers
{
    
    [ApiController]
    public class MutantController : ControllerBase
    {
        private MutantService mutantService = new MutantService();

        [HttpPost]
        [Route("mutant")]
        public ActionResult isMutant([FromBody] DnaSequenceModel dna)
        {
            Console.WriteLine("Llego al servicio");

            bool isMutant = mutantService.isMutant(dna);
            if (isMutant)
            {
                return Ok();
            }
            else
            {
                return Forbid();
            }
        }

        [HttpGet]
        [Route("stats")]
        public String getMutants()
        {
            return mutantService.getStats();
        }
    }
}
