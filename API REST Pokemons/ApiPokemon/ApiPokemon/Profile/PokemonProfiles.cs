using ApiPokemon.Controller.Data.Dtos;
using ApiPokemon.Model;
using AutoMapper;

namespace ApiPokemon.Profiles
{
    public class PokemonProfiles : Profile
    {
        public PokemonProfiles()
        {
            CreateMap<CreatePokemon, Pokemon>();
        }
    }
}
