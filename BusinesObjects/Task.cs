using BusinessObjects.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    [Serializable]
    public class Task : BusinessObject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Status { get; set; }
        public int CategoryId {get; set; }

        public Task()
        {
            AddRule(new ValidateId("Id"));

            AddRule(new ValidateRequired("Title"));
            AddRule(new ValidateLength("Title", 1, 100));

            AddRule(new ValidateRequired("Description"));
            AddRule(new ValidateLength("Description", 1, 1000));

            AddRule(new ValidateId("CategoryId"));
        }
    }
}
