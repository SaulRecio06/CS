using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS.Services.CharacterService
{
    public interface INterCharacter
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

       Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);

       Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);

       Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);


    }

    
}