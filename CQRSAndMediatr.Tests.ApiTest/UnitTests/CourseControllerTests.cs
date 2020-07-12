using CQRSAndMediatr.Domain.RequestModels.CommandRequestModels;
using CQRSAndMediatr.Domain.RequestModels.QueryRequestModels;
using CQRSAndMediatr.Domain.ResponseModels.CommandResponseModels;
using CQRSAndMediatr.Domain.ResponseModels.QueryResponseModels;
using CQRSAndMediatr.Services.Api.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Threading;
using Xunit;

namespace CQRSAndMediatr.Tests.ApiTest.UnitTests
{
    public class CourseControllerTests
    {
        private Mock<IMediator> Mediator;
        public CourseControllerTests()
        {
            Mediator = new Mock<IMediator>();
        }

        [Fact]
        public void CreateNewProduct_Success_Result()
        {
            var createNewCourseRequestModel = new CreateNewCourseRequestModel();
            Mediator.Setup(x => x.Send(It.IsAny<CreateNewCourseRequestModel>(), new CancellationToken())).
                ReturnsAsync(new CreateNewCourseResponseModel { IsSuccess = true, Id = Guid.NewGuid() });

            var courseController = new CourseController(Mediator.Object);

            //Action
            var result = courseController.Post(createNewCourseRequestModel);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetProductById_Success_Result()
        {
            var getCoursetByIdRequestModel = new GetCourseByIdRequestModel();
            Mediator.Setup(x => x.Send(It.IsAny<GetCourseByIdRequestModel>(), new CancellationToken())).
                ReturnsAsync(new GetCourseByIdResponseModel());

            var courseController = new CourseController(Mediator.Object);

            //Action
            var result = courseController.GetCourseById(new Guid());

            //Assert
            Assert.IsType<OkObjectResult>(result.Result);
        }

        [Fact]
        public void CreateNewProduct_BadRequest_Result()
        {
            var createNewCourseRequestModel = new CreateNewCourseRequestModel();
            Mediator.Setup(x => x.Send(It.IsAny<CreateNewCourseRequestModel>(), new CancellationToken())).
                ReturnsAsync(new CreateNewCourseResponseModel { IsSuccess = false, Id = Guid.NewGuid() });

            var courseController = new CourseController(Mediator.Object);

            //Action
            IActionResult result = courseController.Post(createNewCourseRequestModel);

            //Assert
            string expected = "Failed to post data!";
            var actualResult = result as BadRequestObjectResult;
            Assert.Equal(expected, actualResult.Value);
        }

    }
}
