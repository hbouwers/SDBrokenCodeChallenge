using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Repository
{
    public class PokemonRepository
    {
        List<Pokemon> _pokemonTeam = new List<Pokemon>();

        //add to list (limit pokemon to 6)
        public void AddPokemonToTeam(Pokemon pokemon)
        {
            _pokemonTeam.Add(pokemon);
        }
        //get list
        public List<Pokemon> GetPokemonTeam()
        {
            return _pokemonTeam;
        }
        //get one pokemon
        public Pokemon GetPokemonByTeamPosition(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            return pokemon;
        }
        //update pokemon
        public bool UpdatePokemonByTeamPosition(int teamPosition, Pokemon updates)
        {
            // find pokemon
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];

            // null check
            if (pokemon != null)
            {
                pokemon.PokemonSpeciesName = updates.PokemonSpeciesName;
                pokemon.PokemonNickName = updates.PokemonNickName;
                pokemon.Level = updates.Level;
                pokemon.PokemonType = updates.PokemonType;
                pokemon.SecondaryType = updates.SecondaryType;
                pokemon.MoveOne = updates.MoveOne;
                pokemon.MoveTwo = updates.MoveTwo;
                pokemon.MoveThree = updates.MoveThree;
                pokemon.MoveFour = updates.MoveFour;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdatePokemonByNickName(string nickName, Pokemon updates)
        {
            foreach (Pokemon pokemon in _pokemonTeam)
            {
                if (nickName == pokemon.PokemonNickName)
                {
                    pokemon.PokemonSpeciesName = updates.PokemonSpeciesName;
                    pokemon.PokemonNickName = updates.PokemonNickName;
                    pokemon.Level = updates.Level;
                    pokemon.PokemonType = updates.PokemonType;
                    pokemon.SecondaryType = updates.SecondaryType;
                    pokemon.MoveOne = updates.MoveOne;
                    pokemon.MoveTwo = updates.MoveTwo;
                    pokemon.MoveThree = updates.MoveThree;
                    pokemon.MoveFour = updates.MoveFour;
                    return true;
                }
            }
            return false;
        }

        //remove pokemon
        public bool RemovePokemonFromTeam(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];

            if (pokemon != null)
            {
                return _pokemonTeam.Remove(pokemon);
            }
            else
            {
                return false;
            }
        }
    }
}
