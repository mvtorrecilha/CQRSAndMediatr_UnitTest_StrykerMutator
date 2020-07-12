using CQRSAndMediatr.Domain.RequestModels.QueryRequestModels;
using CQRSAndMediatr.Domain.ResponseModels.QueryResponseModels;
using CQRSAndMediatr.Infra.Data.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
namespace CQRSAndMediatr.Domain.Handlers.QueryHandlers
{
    public class GetCourseByIdCommandHandler : IRequestHandler<GetCourseByIdRequestModel, GetCourseByIdResponseModel>
    {
        private readonly ICoursetRepository _courseRepository;
        public GetCourseByIdCommandHandler(ICoursetRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<GetCourseByIdResponseModel> Handle(GetCourseByIdRequestModel request, CancellationToken cancellationToken)
        {
            var courseDetails = await _courseRepository.GetByIdAsync(request.Id);

            var result = new GetCourseByIdResponseModel()
            {
                Id = courseDetails.Id,
                Name = courseDetails.Name,
                Description = courseDetails.Description
            };
            return result;
        }
    }
}
