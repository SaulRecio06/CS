using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS.Services.CharacterService
{
    public interface INterCharacter
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();

        Task<ServiceResponse<Character>> GetCharacterById(int id);

       Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}