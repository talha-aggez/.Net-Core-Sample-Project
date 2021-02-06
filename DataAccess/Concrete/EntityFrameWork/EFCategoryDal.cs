using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EFCategoryDal : EfEntityRepositoryBase<Category, NortwindContext>,ICategoryDal
    {
        
    }
}
