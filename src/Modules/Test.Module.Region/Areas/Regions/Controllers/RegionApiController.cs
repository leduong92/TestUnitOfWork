using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Core.Models;

namespace Test.Module.Region.Areas.Regions.Controllers
{
    [Area("Regions")]
    [Authorize(Roles = "admin")]
    [Route("api/regions")]
    public class RegionApiController : Controller
    {
        private readonly IRepository<UserRegion> _userRegionRepository;
        public RegionApiController(IRepository<UserRegion> userRegionRepository)
        {
            _userRegionRepository = userRegionRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var regions = await _userRegionRepository.Query().Select(x => new
            {

            }).ToListAsync();
            return Json(regions);
        }

    }
}