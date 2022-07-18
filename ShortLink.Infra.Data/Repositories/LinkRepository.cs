﻿using Microsoft.EntityFrameworkCore;
using ShortLink.Domain.Interface;
using ShortLink.Domain.Models.Link;
using ShortLink.Domain.ViewModels.Link;
using ShortLink.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortLink.Infra.Data.Repositories
{
    public class LinkRepository : ILinkRepository
    {
        #region constractor
        private readonly ShortLinkContext _context;
        public LinkRepository(ShortLinkContext context)
        {
            _context = context;
        }

        #endregion

        #region link
        public async Task AddLink(ShortUrl url)
        {
            await _context.ShortUrls.AddAsync(url);
        }

        public async Task AddOs(Os os)
        {
            await _context.Os.AddAsync(os);
        }

        public async Task AddBrower(Brower brower)
        {
            await _context.Browers.AddAsync(brower);
        }

        public async Task AddDevive(Device device)
        {
            await _context.Devices.AddAsync(device);
        }
        public async Task<ShortUrl> FindUrlByToken(string token)
        {
            return await _context.ShortUrls.AsQueryable().SingleOrDefaultAsync(u => u.Token == token);
        }
        public async Task AddRequsetUrl(RequestUrl requestUrl)
        {
            await _context.RequestUrls.AddAsync(requestUrl);
        }

        public async Task<List<AllLinkViewModel>> GetAllLink()
        {
            return await _context.ShortUrls.AsQueryable()
                .Select(c => new AllLinkViewModel
                {
                    OrginalUrl = c.OrginalUrl.ToString(),
                    Token = c.Token.ToString(),
                    CreateDate = c.CreateDate,
                    Value = c.Value.ToString()
                }).ToListAsync();
        }
        #endregion

        #region dispose & save change
        public async ValueTask DisposeAsync()
        {
            if (_context != null) await _context.DisposeAsync();
        }

        public async Task SaveChange()
        {
            await _context.SaveChangesAsync();
        }
        #endregion
    }
}
