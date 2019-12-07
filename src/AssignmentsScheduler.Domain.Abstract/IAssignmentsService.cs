using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentsScheduler.Domain.Models;

namespace AssignmentsScheduler.Domain.Abstract
{
    public interface IAssignmentsService
    {
        IEnumerable<Assignment> GetAssignments();
    }
}
