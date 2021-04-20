using DataLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IBaseRepository<MarksModel> _repo;

        public StudentController(IBaseRepository<MarksModel> repo)
        {
            this._repo = repo;

        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
          
            
            return Ok(await _repo.GetAll());

        }


        [HttpGet("GetById/{studid}")]
        public async Task<IActionResult> Get(string studid)
        {
            if (studid == null)
            {
                return BadRequest();
            }

            var studMarksList = await _repo.Get(studid);
            if (studMarksList== null)
            {
                return NotFound();
            }

            return Ok(studMarksList);
        }

        [HttpPost]
        public async Task<IActionResult> Post(MarksModel marksModel)
        {
            if (ModelState.IsValid)
            {
                await _repo.Insert(marksModel);
                return Ok(marksModel);
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Put(MarksModel marksModel)
        {
            if ((string.IsNullOrEmpty(marksModel.StudentID))|| (string.IsNullOrEmpty(marksModel.SubjectID)))
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _repo.Update(marksModel);

                return Ok(marksModel);
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(string marksid)
        {
            if (marksid == null)
            {
                return NotFound();
            }

            var employeeModel = await _repo.Get(marksid);
            if (employeeModel == null)
            {
                return NotFound();
            }
            await _repo.Delete(marksid);
            return Ok(employeeModel);
        }
    }
}
