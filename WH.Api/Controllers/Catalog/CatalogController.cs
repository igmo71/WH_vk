using Microsoft.AspNetCore.Mvc;
using WH.Api.Services;
using WH.Domain.Models;

namespace WH.Api.Controllers.Catalog
{
    //[Route("api/[controller]")]
    //[ApiController]
    public abstract class CatalogController<TEntity> : ControllerBase where TEntity : Entity
    {
        protected ICatalogService? _service;

        [HttpGet("loading")]
        public async Task<ActionResult<ServiceResult>> LoadingAsync()
        {
            if (_service == null)
                return Problem(detail: "Catalog Service not found");

            var result = await _service.LoadingAsync();
            return Ok(result);
        }

        [HttpGet("count")]
        public async Task<ActionResult<ServiceResult>> GetODataAndDbCountAsync()
        {
            if (_service == null)
                return Problem(detail: "Catalog Service not found");

            ServiceResult result = await _service.GetODataAndDbCountAsync();
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResult>> DeleteAsync()
        {
            if (_service == null)
                return Problem(detail: "Catalog Service not found");

            var result = await _service.DeleteAllAsync();
            return Ok(result);
        }
    }
}
