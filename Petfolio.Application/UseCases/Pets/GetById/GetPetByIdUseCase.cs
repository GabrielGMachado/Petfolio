using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Birthday = new DateTime(year: 2022, month: 03, day: 22),
            Name = "Jamelo",
            Type = Communication.Enums.PetType.Cat
        };
    }
}
