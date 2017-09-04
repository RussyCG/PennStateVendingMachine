using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DataAccess._110_DatabaseSystem._114_Interfaces.Services.BaseService;

namespace DataAccess._110_DatabaseSystem._114_Interfaces.Services
{
    interface IService : IBaseService
    {
        DataTable Select();
        bool Insert();
        bool Update();
        bool Delete();
    }
}
