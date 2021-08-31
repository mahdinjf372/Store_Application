using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Sliders.Queries.GetSliders;
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

        private IGetSlidersService _getSlidersService;
        public IGetSlidersService GetSlidersService
        {
            get
            {
                return _getSlidersService = _getSlidersService ?? new GetSlidersService(_db);
            }
        }
    }
}
