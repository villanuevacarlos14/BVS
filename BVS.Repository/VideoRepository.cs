using System.Linq;
using System.Threading.Tasks;
using BVS.Repository.Model;
using Microsoft.EntityFrameworkCore;

namespace BVS.Repository
{
    public interface IVideoRepository
    {
        Task<Video> Get(int Id);
        IQueryable<Video> GetAll();
        Task<Video> Add(Video video);
        Task<Video> Update(Video video);
    }
    public class VideoRepository : IVideoRepository
    {
        private readonly BVSContext _context;
        public VideoRepository(BVSContext context)
        {
            _context = context;
        }
        public async Task<Video> Add(Video video)
        {
            await _context.Videos.AddAsync(video).ConfigureAwait(false);
            await _context.SaveChangesAsync().ConfigureAwait(false);
            return video;
        }

        public async Task<Video> Get(int Id)
        {
            return await _context.Videos.SingleOrDefaultAsync(x => x.Id == Id).ConfigureAwait(false);
        }

        public IQueryable<Video> GetAll()
        {
            return _context.Videos.AsQueryable();
        }

        public async Task<Video> Update(Video video)
        {
            _context.Update(video);
            await _context.SaveChangesAsync().ConfigureAwait(false);

            return video;
        }
    }
}