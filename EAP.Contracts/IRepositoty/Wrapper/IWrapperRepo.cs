using EAP.Contracts.IRepositoty.Accounts;
using EAP.Contracts.IRepositoty.AddressRepo;
using EAP.Contracts.IRepositoty.CountryRepo;
using EAP.Contracts.IRepositoty.EmailSernderRepo;
using EAP.Contracts.IRepositoty.Owners;

namespace EAP.Contracts.IRepositoty.Wrapper
{
    public interface IWrapperRepo
    {
        IOwnerRepo Owner { get; set; }
        IAccountRepo Account { get; set; }
        ICountryRepo country { get; set; }
        IStatesRepo states { get; set; }
        IEmailSender sender { get; set; }
        void Save();
    }
}