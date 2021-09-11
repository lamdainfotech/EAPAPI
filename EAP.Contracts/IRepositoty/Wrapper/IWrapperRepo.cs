using EAP.Contracts.IRepositoty.Accounts;
using EAP.Contracts.IRepositoty.Owners;

namespace EAP.Contracts.IRepositoty.Wrapper
{
    public interface IWrapperRepo
    {
        IOwnerRepo Owner { get; set; }
        IAccountRepo Account { get; set; }
        void Save();
    }
}