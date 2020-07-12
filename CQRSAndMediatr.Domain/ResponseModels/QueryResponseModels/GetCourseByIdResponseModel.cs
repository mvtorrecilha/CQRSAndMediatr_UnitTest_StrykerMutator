using System;

namespace CQRSAndMediatr.Domain.ResponseModels.QueryResponseModels
{
    public class GetCourseByIdResponseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
