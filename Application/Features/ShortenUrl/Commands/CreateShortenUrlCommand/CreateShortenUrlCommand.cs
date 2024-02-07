using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ShortenUrl.Commands.CreateShortenUrlCommand
{
    public class CreateShortenUrlCommand 
    {
        public string OriginalUrl { get; set; }
        public string ShortUrl { get; set; }
        public DateTime CreatedDate { get; set; }

    }

    public class CreateShortenUrlCommandHandler
    {
        private readonly IRepositoryAsync<Domain.Entities.ShortenUrl> _repositoryAsync;
        private readonly IMapper _mapper;

        public CreateShortenUrlCommandHandler(IRepositoryAsync<Domain.Entities.ShortenUrl> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateShortenUrlCommand request,CancellationToken cancellationToken)
        {
            var NewShortenUrl = _mapper.Map<Domain.Entities.ShortenUrl>(request);
            var data = await _repositoryAsync.AddAsync(NewShortenUrl);
            return data.ShortenId;
        }
    }
}
