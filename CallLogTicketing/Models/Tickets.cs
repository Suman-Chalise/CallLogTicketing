using CallLogTicketing.Models;
using CallLogTicketing.Enum;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CallLogTicketing.Models
{
    public class Tickets
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Subject is required")]
        public string Subject { get; set; }

        public string Description { get; set; }


        //-- relation with Assign Table

        [Required(ErrorMessage = "Assign field is required.")]
        public int AssignId { get; set; }
        [ForeignKey("AssignId")]
        [ValidateNever]
        [Required(ErrorMessage = "Please select an assignment.")]
        public Assign Assign { get; set; }
        
        // -- relation with Customer table

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        [ValidateNever]
        public Customer Customer { get; set; }



        public DateTime Created { get; set; } = DateTime.Now;

        // --- relation with Project Table

        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        [ValidateNever]

        public Project Project { get; set; }

        //---- relation with reseller ---

        public int ResellerId { get; set; }
        [ForeignKey("ResellerId")]
        [ValidateNever]
        public Reseller Reseller { get; set; }

        // -------relation with TicketType ---

        public int TicketTypeId { get; set; }
        [ForeignKey("TicketTypeId")]
        [ValidateNever]

        public TicketType TicketType { get; set; }

        // --- Enum below



        [EnumDataType(typeof(Status))]
        public Status Status { get; set; } // this is enum
        // public string Status { get; set;}  // this will also work as well, however the value will be saved as sting not integer. on above value will be saved as ID 

        [EnumDataType(typeof(Priority))]
        //[Required(ErrorMessage = "Please select a priority.")]
        public Priority Priority { get; set; } // this is enum

        
       public string file { get; set; }

    }
}


//public int Id { get; set; }

//public string Subject { get; set; }

//public string Description { get; set; }


////-- relation with Assign Table
//public int assignId { get; set; }
//public Assign Assign { get; set; }

//// -- relation with Customer table

//public int customerId { get; set; }
//public Customer Customer { get; set; }



//public DateTime Created { get; set; } = DateTime.Now;

//// --- relation with Project Table

//public int projectId { get; set; }
//public Project Project { get; set; }

////---- relation with reseller ---

//public int resellerId { get; set; }

//public Reseller Reseller { get; set; }

//// -------relation with TicketType ---

//public int ticketId { get; set; }

//public TicketType TicketType { get; set; }

//// --- Enum below

//public Status Status { get; set; } // this is enum

//public Priority Priority { get; set; } // this is enum

//public string file { get; set; }