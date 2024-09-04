using CallLogTicketing.Models;

namespace CallLogTicketing.ViewModels
{
    public class TicketsViewModel
    {

        public Tickets? Tickets { get; set; }
        public List<Assign>? assignL { get; set; }
        public List<Customer>? CustomersL { get; set; }
        public List<Project>? projectsL { get; set; }
        public List<Reseller>? resellersL { get; set;}
        public List<TicketType>? ticketTypeL { get; set; }
        public List<Tickets>? ticketsL { get; set; }

        //public TicketsViewModel()
        //{
        //    assignL = new List<Assign>();
        //    CustomersL = new List<Customer>();
        //    projectsL = new List<Project>();
        //    ticketTypeL = new List<TicketType>();


        //}

    }
}
