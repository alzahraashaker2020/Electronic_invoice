using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.ModelsView
{
    public class RegisteredDate_VM
    {
        public List<ActivityTypes_VM> activityTypes_VM { get; set; }
        public List<Countries_VM> countries_VM { get; set; }
        public List<AddressValidations_VM> addressValidation { get; set; }

    }
}
