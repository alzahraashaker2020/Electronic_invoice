using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IRepo
{
   public interface IRepoWrapper
    {

        IActivityType _ActivityType { get; }
        IAddress _Address { get; }
        IAddressProperty _AddressProperty { get; }
        IAddressPropertyEvent _AddressPropertyEvent { get; }
        IAddressPropertyValidation _AddressPropertyValidation { get; }
        IBranch _Branch { get; }
        IDelivery _Delivery { get; }
        IDiscount _Discount { get; }
        IDocument _Document { get; }
        IEvent _Eevent { get; }
        IInputController _InputController { get; }
        IInvoiceLine _InvoiceLine { get; }
        IPayment _Payment { get; }
        IRole _Role { get; }
        ISignature _Signature { get; }
        ITaxableItem _TaxableItem { get; }
        ITaxableType _TaxableType { get; }
        ITaxSubType _TaxSubType { get; }
        IUniteType _UniteType { get; }
        IUniteValue _UniteValue { get; }
        IUser _User { get; }
        IValidation _Validation { get; }
        IValidationType _ValidationType { get; }
        ICountries _Country { get; }

        List<T> CallQuery<T>(string query, Dictionary<string, object> para = null, int type = 0);
        void Save();
    }
}
