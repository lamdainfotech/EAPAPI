using EAP.Contracts.IRepositoty.Accounts;
using EAP.Contracts.IRepositoty.Owners;
using EAP.Contracts.IRepositoty.Wrapper;
using EAP.Entity.Data;
using EAP.Repository.Repo.Accounts;
using EAP.Repository.Repo.Owners;

namespace EAP.Repository.Repo.Wrapper
{
    public class WrapperRepo : IWrapperRepo
    {
        private EAPDbContext _context;
        private IOwnerRepo _owner;
        private IAccountRepo _account;
        public WrapperRepo(EAPDbContext context)
        {
            this._context = context;
        }
        public IOwnerRepo Owner
        {
            get
            {
                if (_owner == null)
                {
                    _owner = new OwnerRepo(_context);
                }
                return _owner;
            }
            set => throw new System.NotImplementedException();
        }
        public IAccountRepo Account
        {
            get
            {
                if (_account == null)
                {
                    _account = new AccountRepo(_context);
                }
                return _account;
            }
            set => throw new System.NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}