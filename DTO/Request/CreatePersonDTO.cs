using Domain.Enum;

namespace DTO.Request
{
    public class CreatePersonDTO
    {
        public string Name { get; set; }
        public PersonType PersonType { get; set; }
    }
}
