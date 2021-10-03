using ApiPokemon.Controller.Data;
using ApiPokemon.Controller.Data.Dtos;
using ApiPokemon.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPokemon.Controller
{
    [ApiController]
    [Route("[api/controller]")]
    public class PokemonController : ControllerBase
    {
        private RepositoryPokemon _repo;
        private IMapper _mapper;

        public PokemonController(RepositoryPokemon repository, IMapper mapper)
        {
            _repo = repository;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AdicionaPokemon([FromBody] CreatePokemon pokemonDto)
        {
            Pokemon pokemon = _mapper.Map<Pokemon>(pokemonDto);

            _repo.Pokemon.Add(pokemon);
            _repo.SaveChanges();
            return CreatedAtAction(nameof(RecuperaPokemonId), new { Id = pokemon.Codigo }, pokemon);

        }


        [HttpGet]
        public IActionResult Recuperar()
        {
            return Ok(_repo.Pokemon); 
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaPokemonId(int codigo)
        {
            Pokemon pokemon = _repo.Pokemon.FirstOrDefault(pokemon => pokemon.Codigo == codigo);
            if (pokemon == null)
            {

                return NotFound();
                
            }
            return Ok(pokemon);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaPokemon(int codigo)
        {
            Pokemon pokemon = _repo.Pokemon.FirstOrDefault(pokemon => pokemon.Codigo == codigo);
            if (pokemon == null)
            {
                return NotFound();
            }
            _repo.Remove(pokemon);
            _repo.SaveChanges();
            return NoContent(); //203
        }
        
    }
}
