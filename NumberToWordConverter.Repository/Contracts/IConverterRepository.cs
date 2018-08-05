using NumberToWordConverter.Entities;

namespace NumberToWordConverter.Repository.Contracts
{
    public interface IConverterRepository
    {
        OutputModel ConvertToWord(InputModel input);
        string ConvertNumberToWord(string number);
    }
}
