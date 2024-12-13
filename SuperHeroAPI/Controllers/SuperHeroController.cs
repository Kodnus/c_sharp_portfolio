using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Controllers.Entities;
using SuperHeroAPI.Data;

namespace SuperHeroAPI.Controllers
{
    //Controller for our web API where we store our CRUD logic


    [Route("api/[controller]")]
    //[Route("/")] 
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        //Our reference to DataContext to perform our database operations
        private readonly DataContext _context;

        //Making our DataContext available as a constructor
        public SuperHeroController(DataContext context) 
        { 
            _context = context;
        }


        //All of our CRUD actions are placed beneath here


        [HttpGet] //Defining our http method
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            //We are expecting a list of heroes from our database
            var heroes = await _context.SuperHeroes.ToListAsync();

            //If OK we get the list
            return Ok(heroes);
        }

        [HttpGet("{id}")] //Get by ID
        public async Task<ActionResult<SuperHero>> GetHero(int id)
        {
            //Here we dont expect at list, just one retuend entity
            var hero = await _context.SuperHeroes.FindAsync(id);

            //If we cannot find the hero based on the id, we get an error message telling us so
            if (hero is null)
                return BadRequest("Hero not found");

            return Ok(hero);
        }

        [HttpPost] //Update our database with JSON input

        //Could create DTO entity for SuperHero
        //Since we do not have to update the ID ourselves
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero) //Expecting a list as our return data
        {
             _context.SuperHeroes.Add(hero);
            await _context.SaveChangesAsync();

            //Here we are returning the full list of superheroes
            //In future as the DB grows, this would be removed since it would bloat as a list
            //Instead it could just return the newly added hero
            return Ok(await _context.SuperHeroes.ToListAsync());
            //return Ok(hero);
        }

        [HttpPut] //Update superhero based on id
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero updatedHero)
        {
            //First we find the superhero
            var dbHero = await _context.SuperHeroes.FindAsync(updatedHero.Id);
            //If not found, return error
            if (dbHero is null)
                return BadRequest("Hero not found");

            //Data to be updated
            dbHero.Name = updatedHero.Name;
            dbHero.FirstName = updatedHero.FirstName;
            dbHero.LastName = updatedHero.LastName;
            dbHero.Place = updatedHero.Place;

            //Save the changes
            await _context.SaveChangesAsync();

            //Return the newly updated hero + list of others
            //Same logic goes here in regards to bloat
            return Ok(await _context.SuperHeroes.ToListAsync());
            //return Ok(dbHero);
        }

        [HttpDelete] //Delete hero based on id
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            //Find the hero
            var dbHero = await _context.SuperHeroes.FindAsync(id);
            if (dbHero is null)
                return BadRequest("Hero not found");

            //Remove the hero if request is ok
            _context.SuperHeroes.Remove(dbHero);

            //Save the changes
            await _context.SaveChangesAsync();

            //Return the new list from db
            return Ok(await _context.SuperHeroes.ToListAsync());
        }
    }
}
