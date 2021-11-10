using System.Collections.Generic;

namespace Pokemon_Repository
{
    public class PokemonRepository
    {
        List<Pokemon> _pokemonTeam = new List<Pokemon>();

        //add to list (limit pokemon to 6)
        public void AddPokemonToTeam(Pokemon pokemon)
        {
            List<Pokemon> pokemonList = GetPokemonTeam();
            int listCount = pokemonList.Count;
            if (listCount <= 5)
            {
                _pokemonTeam.Add(pokemon);
            }
        }
        //get list
        public List<Pokemon> GetPokemonTeam()
        {
            return _pokemonTeam;
        }
        //get one pokemon
        // Follow up on
        public Pokemon GetPokemonByTeamPosition(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            return pokemon;
        }
        //update pokemon
        public void UpdatePokemonByTeamPosition(int teamPosition, Pokemon updates)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            pokemon.PokemonSpeciesName = updates.PokemonSpeciesName;
            pokemon.PokemonNickName = updates.PokemonNickName;
            pokemon.Level = updates.Level;
            pokemon.PokemonType = updates.PokemonType;
            pokemon.SecondaryType = updates.SecondaryType;
            pokemon.MoveOne = updates.MoveOne;
            pokemon.MoveTwo = updates.MoveTwo;
            pokemon.MoveThree = updates.MoveThree;
            pokemon.MoveFour = updates.MoveFour;
        }

        public void UpdatePokemonByNickName(string nickName, Pokemon newPokemon)
        {
            Pokemon oldPokemon = GetPokemonByNickname(nickName);
            oldPokemon.PokemonNickName = newPokemon.PokemonNickName;
            oldPokemon.PokemonSpeciesName = newPokemon.PokemonSpeciesName;
            oldPokemon.PokemonType = newPokemon.PokemonType;
            oldPokemon.MoveOne = newPokemon.MoveOne;
            oldPokemon.MoveTwo = newPokemon.MoveTwo;
            oldPokemon.MoveThree = newPokemon.MoveThree;
            oldPokemon.MoveFour = newPokemon.MoveFour;
            oldPokemon.Level = newPokemon.Level;
            oldPokemon.SecondaryType = newPokemon.SecondaryType;
        }

        public Pokemon GetPokemonByNickname(string nickName)
        {
            foreach(Pokemon p in _pokemonTeam)
            {
                if(nickName == p.PokemonNickName)
                {
                    return p;
                }
            }
            return null;
        }

        //remove pokemon
        public void RemovePokemonFromTeam(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            _pokemonTeam.Remove(pokemon);
        }
    }
}
