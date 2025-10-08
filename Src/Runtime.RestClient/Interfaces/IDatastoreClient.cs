using ErrorOr;
using Runtime.DTO.ApiModels;

namespace Runtime.RestClient.Interfaces
{
    public interface IDatastoreClient
    {
        Task<ErrorOr<TableResponse>> GetTable(string token, long id);
    }
}