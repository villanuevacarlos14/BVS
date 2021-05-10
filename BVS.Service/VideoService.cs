using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BVS.DTO;
using BVS.Repository;
using BVS.Repository.Model;
using Microsoft.EntityFrameworkCore;

namespace BVS.Service
{
    public interface IVideoService
    {
        Task<VideoDTO> Get(int Id);
        Task<IEnumerable<VideoDTO>> GetAll();
        Task<VideoDTO> Add(VideoDTO video);
        Task<VideoDTO> Update(VideoDTO video);
    }
    public class VideoService : IVideoService
    {
        private readonly IVideoRepository _repository;
        private readonly IMapper _mapper;

        public VideoService(IVideoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<VideoDTO> Add(VideoDTO video)
        {
            var result = await _repository.Add(_mapper.Map<Video>(video)).ConfigureAwait(false);
            return _mapper.Map<VideoDTO>(result);
        }

        public async Task<VideoDTO> Get(int Id)
        {
            var result = await _repository.Get(Id);
            return _mapper.Map<VideoDTO>(result);
        }

        public async Task<IEnumerable<VideoDTO>> GetAll()
        {
            var result = await _repository.GetAll().ToListAsync().ConfigureAwait(false);
            return _mapper.Map<IEnumerable<VideoDTO>>(result);
        }

        public async Task<VideoDTO> Update(VideoDTO video)
        {
            var result = await _repository.Update(_mapper.Map<Video>(video)).ConfigureAwait(false);
            return _mapper.Map<VideoDTO>(result);
        }
    }
}