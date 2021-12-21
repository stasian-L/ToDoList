using BusinessObjects;
using BusinessObjects.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesObjects
{
    [Serializable]
    public class Category : BusinessObject
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public Category()
        {
            AddRule(new ValidateId("CategoryId"));

            AddRule(new ValidateRequired("CategoryName"));
            AddRule(new ValidateLength("CategoryName", 1, 100));
        }
    }
}
