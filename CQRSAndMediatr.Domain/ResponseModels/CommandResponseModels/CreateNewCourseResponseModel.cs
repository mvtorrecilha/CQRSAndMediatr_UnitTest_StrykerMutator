using System;

namespace CQRSAndMediatr.Domain.ResponseModels.CommandResponseModels
{
    public class CreateNewCourseResponseModel
    {
        public bool IsSuccess { get; set; }
        public Guid Id { get; set; }
    }
}
