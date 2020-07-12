using CQRSAndMediatr.Domain.ResponseModels.QueryResponseModels;
using MediatR;
using System;

namespace CQRSAndMediatr.Domain.RequestModels.QueryRequestModels
{
    public class GetCourseByIdRequestModel : IRequest<GetCourseByIdResponseModel>
    {
        public Guid Id { get; set; }
    }
}
