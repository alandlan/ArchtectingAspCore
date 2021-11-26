using MediatR;
using System;
using System.Collections.Generic;

namespace GlobalTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail
{
    public class GetEventDetailQuery : IRequest<EventDetailVm>
    {
        public Guid Id{ get; set; }
    }
}
