using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Advertinig.Commands.Add;
using Store_Application.Application.Services.Advertinig.Commands.Delete;
using Store_Application.Application.Services.Advertinig.Commands.Edit;
using Store_Application.Application.Services.Advertinig.Queries.GetAdvertisings;
using Store_Application.Application.Services.Advertinig.Queries.IsExist;

namespace Store_Application.Application.Services.Advertinig.FacadPattern
{
    public class AdvertisingFacad : IAdvertisingFacad
    {
        private readonly IDataBaseContext _db;
        public AdvertisingFacad(IDataBaseContext db)
        {
            _db = db;
        }

        private IGetAdvertisingsService _getAdvertisingsService;
        public IGetAdvertisingsService GetAdvertisingsService
        {
            get
            {
                return _getAdvertisingsService = _getAdvertisingsService ?? new GetAdvertisingsService(_db);
            }
        }


        private IAddAdvertisingService _addAdvertisingService;
        public IAddAdvertisingService AddAdvertisingService
        {
            get
            {
                return _addAdvertisingService = _addAdvertisingService ?? new AddAdvertisingService(_db);
            }
        }

        private IEditAdvertisingService _editAdvertisingService;
        public IEditAdvertisingService EditAdvertisingService
        {
            get
            {
                return _editAdvertisingService = _editAdvertisingService ?? new EditAdvertisingService(_db);
            }
        }

        private IisExistAdvertisingService _isExistAdvertisingService;
        public IisExistAdvertisingService IsExistAdvertisingService
        {
            get
            {
                return _isExistAdvertisingService = _isExistAdvertisingService ?? new IsExistAdvertisingService(_db);
            }
        }
        

        private IDeleteAdvertisingService _deleteAdvertisingService;
        public IDeleteAdvertisingService DeleteAdvertisingService
        {
            get
            {
                return _deleteAdvertisingService = _deleteAdvertisingService ?? new DeleteAdvertisingService(_db);
            }
        }
    }
}
