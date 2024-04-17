using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Properties.Controllers;


[ApiController]
[Route("visits")]
public class VisitController:ControllerBase
{
    
    [HttpGet]
    public IActionResult GetVisits()
    {
        return Ok(DataBase._visits);
    }
    
    [HttpPost("{id:int}/{animalId:int}")]
    public IActionResult PostAnimal(int id, int animalId, string date,string description, double cost)
    {
        var _animal = DataBase._animals.FirstOrDefault(a => a.ID ==animalId);
        var _visit = DataBase._visits.FirstOrDefault(v => v.ID == id);
        
        if (_animal == null)
        {
            return NotFound("Animal with ID: "+animalId+" does not exist");
        }

        if (_visit != null)
        {
            return NotFound("Visit with ID: "+id+" already exist");
        }
            
        DataBase._visits.Add(new Visit(id,date,_animal,description,cost)); 
        return StatusCode(StatusCodes.Status201Created);
        
    }
    
    
}