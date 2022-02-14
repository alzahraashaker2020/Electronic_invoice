using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repo
{
   public class RepoWrapper : IRepoWrapper
    {
        private Invoice_ElectronicContext _contex;
        private IActivityType activityType;
        private ITaxableType taxableType;
        private ITaxSubType taxSubType;
        private IUniteType uniteType;
        private ICountries country;
        public IAddressPropertyValidation addressPropertyValidation;
        public IBranch branch;
        public IDelivery delivery;
        public IDiscount discount;
        public IDocument document;
        public IEvent eevent;
        public IInputController inputController;
        public IInvoiceLine invoiceLine;
        public IPayment payment;
        public IRole role;
        public ISignature signature;
        public ITaxableItem taxableItem;
        public IUniteValue uniteValue;
        public IUser user;
        public IValidation validation;
        public IValidationType validationType;
        private IAddressProperty addressProperty;
        public IAddress address;
        public IAddressPropertyEvent addressPropertyEvent;

        public RepoWrapper(Invoice_ElectronicContext context)
        {
            _contex = context;
        }
        public IActivityType _ActivityType
        {
            get
            {
                if (activityType == null) activityType = new ActivityTypeRepo(_contex); return activityType;
            }
        }
        public ITaxableType _TaxableType
        {
            get
            {
                if (taxableType == null) taxableType = new TaxableTypeRepo(_contex); return taxableType;
            }
        }

        public ITaxSubType _TaxSubType
        {
            get
            {
                if (taxSubType == null) taxSubType = new TaxSubTypeRepo(_contex); return taxSubType;
            }
        }

        public IUniteType _UniteType
        {
            get
            {
                if (uniteType == null) uniteType = new UniteTypeRepo(_contex); return uniteType;
            }
        }

        public ICountries _Country
        {
            get
            {
                if (country == null) country = new CoutriesRepo(_contex); return country;
            }
        }

        public IAddressProperty _AddressProperty
        {
            get
            {
                if (addressProperty == null) addressProperty = new AddressPropertyRepo(_contex); return addressProperty;
            }
        }

        public IAddress _Address { get { if (address == null) address = new AddressRepo(_contex); return address; } }

        public IAddressPropertyEvent _AddressPropertyEvent { get { if (addressPropertyEvent == null) addressPropertyEvent = new AddressPropertyEventRepo(_contex); return addressPropertyEvent; } }

        public IAddressPropertyValidation _AddressPropertyValidation { get { if (addressPropertyValidation == null) addressPropertyValidation = new AddressPropertyValidationRepo(_contex); return addressPropertyValidation; } }

        public IBranch _Branch { get { if (branch == null) branch = new BranchRepo(_contex); return branch; } }

        public IDelivery _Delivery { get { if (delivery == null) delivery = new DeliveryRepo(_contex); return delivery; } }

        public IDiscount _Discount { get { if (discount == null) discount = new DiscountRepo(_contex); return discount; } }

        public IDocument _Document { get { if (document == null) document = new DocumentRepo(_contex); return document; } }

        public IEvent _Eevent { get { if (eevent == null) eevent = new EventRepo(_contex); return eevent; } }

        public IInputController _InputController { get { if (inputController == null) inputController = new InputControllerRepo(_contex); return inputController; } }

        public IInvoiceLine _InvoiceLine { get { if (invoiceLine == null) invoiceLine = new InvoiceLineRepo(_contex); return invoiceLine; } }

        public IPayment _Payment { get { if (payment == null) payment = new PaymentRepo(_contex); return payment; } }

        public IRole _Role { get { if (role == null) role = new RoleRepo(_contex); return role; } }

        public ISignature _Signature { get { if (signature == null) signature = new SignatureRepo(_contex); return signature; } }

        public ITaxableItem _TaxableItem { get { if (taxableItem == null) taxableItem = new TaxableItemRepo(_contex); return taxableItem; } }

        public IUniteValue _UniteValue { get { if (uniteValue == null) uniteValue = new UniteValueRepo(_contex); return uniteValue; } }

        public IUser _User { get { if (user == null) user = new UserRepo(_contex); return user; } }

        public IValidation _Validation { get { if (validation == null) validation = new ValidationRepo(_contex); return validation; } }

        public IValidationType _ValidationType { get { if (validationType == null) validationType = new ValidationTypeRepo(_contex); return validationType; } }

        public  List<T> CallQuery<T>(string query, Dictionary<string, object> para = null, int type = 0)
        {
            var result =  TestQuery.Get<T>(query, para, type);
            return result;
        }
        public  void Save()
        {
             _contex.SaveChanges();
        }
    }
}
