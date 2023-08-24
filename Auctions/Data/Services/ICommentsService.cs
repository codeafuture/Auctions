using Auctions.Models;

namespace Auctions.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
