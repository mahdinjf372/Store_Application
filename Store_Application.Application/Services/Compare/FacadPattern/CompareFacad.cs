using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Compare.Commands.AddToCompare;
using Store_Application.Application.Services.Compare.Commands.MergeCompare;
using Store_Application.Application.Services.Compare.Commands.RemoveFromCompare;
using Store_Application.Application.Services.Compare.Queries.GetCompareList;

namespace Store_Application.Application.Services.Compare.FacadPattern
{
    public class CompareFacad : ICompareFacad
    {
        private readonly IDataBaseContext _db;
        public CompareFacad(IDataBaseContext db)
        {
            _db = db;   
        }

        private IAddToCompareService _addToCompareService;

        public IAddToCompareService AddToCompareService
        {
            get
            {
                return _addToCompareService ??= new AddToCompareService(_db);
            }
        }

        private IRemoveFromFavoriteService _removeFromFavoriteService;
        public IRemoveFromFavoriteService RemoveFromFavoriteService
        {
            get
            {
                return _removeFromFavoriteService ??= new RemoveFromFavoriteService(_db);
            }
        }
        

        private IMergeCompareService _mergeCompareService;
        public IMergeCompareService MergeCompareService
        {
            get
            {
                return _mergeCompareService ??= new MergeCompareService(_db);
            }
        }
        
        private IGetCompareListService _getCompareListService;
        public IGetCompareListService GetCompareListService
        {
            get
            {
                return _getCompareListService ??= new GetCompareListService(_db);
            }
        }
    }
}
