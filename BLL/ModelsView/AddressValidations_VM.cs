using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.ModelsView
{
    public class AddressValidations_VM
    {
        public int AddressPropId { get; set; }
        public string AddressPropName { get; set; }
        public bool hasValidation { get; set; }
        public string controleName { get; set; }
        public int addressValidationId { get; set; }
        public string value { get; set; }
        public int validationId { get; set; }
        public string validitionName { get; set; }
        public bool hasValue { get; set; }

    }
}
