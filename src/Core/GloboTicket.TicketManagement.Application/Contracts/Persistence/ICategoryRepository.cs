namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
    using GloboTicket.TicketManagement.Domain.Entities;

    public interface ICategoryRepository: IAsyncRepository<Category>
    {

    }
}