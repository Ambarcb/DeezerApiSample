using ApiTests.Models;
using System.Threading.Tasks;

namespace ApiTests.Services
{
    interface IDeezerApiService
    {
        Task<Artist> GetArtistInfo(string Id);
    }
}
