using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Contracts.Features.Events.Queries.GetEventsList
{
    // This Class will be a message : IRequest
    // List<EventListViewModel> - type of Data the query will be getting back
    // ViewModel will contain just the UI Data
    public class GetEventsListQuery : IRequest<List<EventListVm>>
    {
    }
}
