using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Properties.Controllers;

[ApiController]
[Route("animals")]
public class AnimalController : ControllerBase
{

    
    
    
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(DataBase._animals);
    }


    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = DataBase._animals.FirstOrDefault(i => i.ID == id);
        if (animal == null)
        {
            return NotFound("Animal with ID: " + id + " was not found");
        }

        return Ok(animal);
    }


    [HttpPost]
    public IActionResult PostAnimal(Animal animal)
    {
        var _animal = DataBase._animals.FirstOrDefault(a => a.ID ==animal.ID);
        if (_animal == null)
        {
            DataBase._animals.Add(animal);
            return StatusCode(StatusCodes.Status201Created);
        }

        return NotFound("Animal with ID: "+animal.ID+" already exist");
    }


    [HttpPut("{id:int}")]
    public IActionResult PutAnimal(int id, Animal animal)
    {
        var animalToEdit = DataBase._animals.FirstOrDefault(a => a.ID ==id);

        if (animalToEdit == null)
            return NotFound("Animal with ID: \" + id + \" was not found");


        DataBase._animals.Remove(animalToEdit);
        DataBase._animals.Add(animal);

        return NoContent();

    }
    
    [HttpDelete("{id:int}")]
    public IActionResult PutAnimal(int id)
    {
        var animalToDelete = DataBase._animals.FirstOrDefault(a => a.ID ==id);

        if (animalToDelete == null)
            return NotFound("Animal with ID: \" + id + \" was not found");


        DataBase._animals.Remove(animalToDelete);
        
        return NoContent();

    }
}