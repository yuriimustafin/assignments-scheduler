using AssignmentsScheduler.Domain.Abstract;
using AssignmentsScheduler.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsScheduler.Domain
{
    public class AssignmentsService : IAssignmentsService
    {
        public IEnumerable<Assignment> GetAssignments()
        {
            // TODO: Add DAL
            throw new NotImplementedException();
        }
    }
}
