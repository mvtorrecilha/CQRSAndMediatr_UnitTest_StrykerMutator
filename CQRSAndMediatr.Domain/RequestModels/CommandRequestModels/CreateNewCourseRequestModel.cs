using CQRSAndMediatr.Domain.ResponseModels.CommandResponseModels;
using MediatR;
using System;

namespace CQRSAndMediatr.Domain.RequestModels.CommandRequestModels
{
    public class CreateNewCourseRequestModel : IRequest<CreateNewCourseResponseModel>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
