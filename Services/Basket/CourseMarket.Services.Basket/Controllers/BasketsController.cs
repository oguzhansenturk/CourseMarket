using CourseMarket.Services.Basket.Dtos;
using CourseMarket.Services.Basket.Services;
using CourseMarket.Shared.ControllerBases;
using CourseMarket.Shared.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMarket.Services.Basket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : CustomBaseController
    {
        private readonly IBasketService _basketServce;
        private readonly ISharedIdentityService _sharedIdentityService;

        public BasketsController(IBasketService basketServce, ISharedIdentityService sharedIdentityService)
        {
            _basketServce = basketServce;
            _sharedIdentityService = sharedIdentityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBasket()
        {
            //var cleaims = User.Claims;
            return CreateActionResultInstance(await _basketServce.GetBasket(_sharedIdentityService.GetUserId));
        }

        [HttpPost]
        public async Task<IActionResult> SaveOrUpdateBasket(BasketDto basketDto)
        {
            var response = await _basketServce.SaveOrUpdate(basketDto);
            return CreateActionResultInstance(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBasket()
        {
            return CreateActionResultInstance(await _basketServce.Delete(_sharedIdentityService.GetUserId));
        }

    }
}
