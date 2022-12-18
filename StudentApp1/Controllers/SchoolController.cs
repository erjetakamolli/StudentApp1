using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentApp1.Models;
using StudentApp1.VM;
using Microsoft.AspNetCore.Mvc;

namespace StudentApp1.Models.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SchoolController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        var allSchool = new List<School>()
            {
                new School()
                {
                    Id = 1,
                    Name = "School 1",
                    Address = "Address 1",
                    YearEstablished = 2002
                },
                new School()
                {
                    Id = 2,
                    Name = "School 2",
                    Address = "Address 2",
                    YearEstablished = 2003
                }
            };

        return Ok(allSchool);
    }


    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {

        var school = new School()
        {
            Id = 1,
            Name = "School 1",
            Address = "Address 1",
            YearEstablished = 2002
        };

        return Ok(school);
    }


    [HttpPost]
    public IActionResult AddSchool([FromBody] SchoolVM schoolVM)
    {

        var school = new School()
        {

            Name = schoolVM.Name,
            Address = schoolVM.Address,
            YearEstablished = schoolVM.YearEstablished,


            DateCreated = DateTime.UtcNow,
            DateUpdated = null
        };


        return Created("", school);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateSchool([FromBody] SchoolVM schoolVM, int id)
    {

        var school = new School()
        {
            Id = 1,
            Name = "Univesiteti Beder",
            Address = "Address 1",
            YearEstablished = 2002
        };



        school.Name = schoolVM.Name;
        school.Address = schoolVM.Address;
        school.YearEstablished = schoolVM.YearEstablished;
        school.DateUpdated = DateTime.UtcNow;



        return Ok($"School with id = {id} was updated");
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteById(int id)
    {


        return Ok($"School with id {id} deleted");
    }


}


