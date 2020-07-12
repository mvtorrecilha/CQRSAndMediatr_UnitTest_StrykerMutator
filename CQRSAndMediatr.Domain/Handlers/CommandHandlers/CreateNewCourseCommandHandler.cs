using CQRSAndMediatr.Domain.Entities;
using CQRSAndMediatr.Domain.RequestModels.CommandRequestModels;
using CQRSAndMediatr.Domain.ResponseModels.CommandResponseModels;
using CQRSAndMediatr.Infra.Data.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
namespace CQRSAndMediatr.Domain.Handlers.CommandHandlers
{
    public class CreateNewCourseCommandHandler : IRequestHandler<CreateNewCourseRequestModel, CreateNewCourseResponseModel>
    {
        private readonly ICoursetRepository _courseRepository;
        public CreateNewCourseCommandHandler(ICoursetRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<CreateNewCourseResponseModel> Handle(CreateNewCourseRequestModel request, CancellationToken cancellationToken)
        {
            var result = new CreateNewCourseResponseModel();

            _courseRepository.Add(new Course() { Name = request.Name, Description = request.Description });

            if (await _courseRepository.SaveChangesAsync())
            {
                result.IsSuccess = true;
            }        

            return result;
        }
    }
}
