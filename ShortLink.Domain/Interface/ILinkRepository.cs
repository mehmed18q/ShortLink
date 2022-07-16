using ShortLink.Domain.Models.Link;
using System;
using System.Threading.Tasks;

namespace ShortLink.Domain.Interface
{
    public interface ILinkRepository : IAsyncDisposable
    {
        #region link
        Task AddLink(ShortUrl url);
        Task AddOs(Os os);
        Task AddDevive(Device device);
        Task AddBrower(Brower brower);
        Task<ShortUrl> FindUrlByToken(string token);
        #endregion
        Task SaveChange();
    }
}
