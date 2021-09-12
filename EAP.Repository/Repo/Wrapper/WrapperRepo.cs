using EAP.Contracts.IRepositoty.Accounts;
using EAP.Contracts.IRepositoty.AddressRepo;
using EAP.Contracts.IRepositoty.CountryRepo;
using EAP.Contracts.IRepositoty.Owners;
using EAP.Contracts.IRepositoty.Wrapper;
using EAP.Entity.Data;
using EAP.Repository.Repo.Accounts;
using EAP.Repository.Repo.AddressRepo;
using EAP.Repository.Repo.BaseRepo;
using EAP.Repository.Repo.Owners;

namespace EAP.Repository.Repo.Wrapper
{
    public class WrapperRepo : IWrapperRepo
    {
        private EAPDbContext _context;
        private IOwnerRepo _owner;
        private IAccountRepo _account;
        private ICountryRepo _country;
        private IStatesRepo _states;
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

        public ICountryRepo country
        {
            get
            {
                if (_country == null)
                {
                    _country = new CountryRepo(_context);
                }
                return _country;
            }
            set => throw new System.NotImplementedException();
        }

        public IStatesRepo states
        {
            get
            {
                if (_states == null)
                {
                    _states = new StatesRepo(_context);
                }
                return _states;
            }
            set => throw new System.NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}