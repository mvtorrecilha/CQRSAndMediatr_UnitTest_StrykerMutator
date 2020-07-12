using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using CQRSAndMediatr.Domain.RequestModels.CommandRequestModels;
using CQRSAndMediatr.Domain.RequestModels.QueryRequestModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSAndMediatr.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : Controller
    {
        private readonly IMediator _mediator;
        public CourseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateNewCourseRequestModel requestModel)
        {
            var response = _mediator.Send(requestModel);

            if (!response.Result.IsSuccess) return BadRequest("Failed to post data!");

            return Ok(response);
        }

        [HttpGet("GetCourseById/{courseId}")]
        public async Task<IActionResult> GetCourseById(Guid courseId)
        {
            var response = await _mediator.Send(new GetCourseByIdRequestModel() { Id = courseId });
            return Ok(response);
        }
    }
}