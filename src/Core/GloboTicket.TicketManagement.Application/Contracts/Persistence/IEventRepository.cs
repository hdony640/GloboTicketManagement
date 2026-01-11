namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
    using GloboTicket.TicketManagement.Domain.Entities;

    //Repository interface for Event entity inheriting from the generic repository interface
    public interface IEventRepository : IAsyncRepository<Event>
    {
        //Additional methods specific to Event entity can be added here
    }
}