using CQRSAndMediatr.Domain.RequestModels.QueryRequestModels;
using CQRSAndMediatr.Domain.ResponseModels.QueryResponseModels;

namespace CQRSAndMediatr.Domain.Interfaces.IQueryHandlers
{
    public interface IGetCourseByIdQueryHandler
    {
        GetCourseByIdResponseModel GetCourseById(GetCourseByIdRequestModel requestModel);
    }
}
