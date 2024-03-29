﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly IModelService _modelService;

        public ModelsController(IModelService modelService)
        {
            _modelService = modelService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _modelService.GetAll();
            if (result.IsSucces)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Model model)
        {
            var result = _modelService.Add(model);
            if (result.IsSucces)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Model model)
        {
            var result = _modelService.Delete(model);
            if (result.IsSucces)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(Model model)
        {
            var result = _modelService.Update(model);
            if (result.IsSucces)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
