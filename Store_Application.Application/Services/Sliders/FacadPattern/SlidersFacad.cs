using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Sliders.Queries.GetSlidersForAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Sliders.FacadPattern
{
    public class SlidersFacad : ISlidersFacad
    {
        private readonly IDataBaseContext _db;
        public SlidersFacad(IDataBaseContext db)
        {
            _db = db;
        }

        private IGetSlidersForAdminService _getSlidersForAdminService;
        public IGetSlidersForAdminService GetSlidersForAdminService
        {
            get
            {
                return _getSlidersForAdminService = _getSlidersForAdminService ?? new GetSlidersForAdminService(_db);
            }
        }
    }
}
