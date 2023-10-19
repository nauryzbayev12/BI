using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BI.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ILogger<CountryController> _logger;
        private readonly IMapper _mapper;

        public CountryController( ILogger<CountryController> logger,
            IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

       
    }
}
