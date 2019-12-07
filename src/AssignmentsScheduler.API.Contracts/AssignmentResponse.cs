using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsScheduler.API.Contracts
{
    public class AssignmentResponse
    {
        Guid Id { get; set; }
        string Title { get; set; }
    }
}
