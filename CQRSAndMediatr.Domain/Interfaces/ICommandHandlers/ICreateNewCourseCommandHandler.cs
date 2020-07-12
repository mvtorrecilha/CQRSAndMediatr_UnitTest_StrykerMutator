using CQRSAndMediatr.Domain.RequestModels.CommandRequestModels;
using CQRSAndMediatr.Domain.ResponseModels.CommandResponseModels;

namespace CQRSAndMediatr.Domain.Interfaces.ICommandHandlers
{
    public interface ICreateNewCourseCommandHandler
    {
        CreateNewCourseResponseModel CreateNewCourse(CreateNewCourseRequestModel requestModel);
    }
}
