using Store_Application.Application.Services.Products.Commands.AddProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IProductFacad
    {
        IAddProductService AddProductService { get; }
    }
}
