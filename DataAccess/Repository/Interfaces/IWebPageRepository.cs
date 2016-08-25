﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IWebpageRepository: IRepository<Webpage>
    {
        Task<Webpage> FindByUrl(string url);
    }
}
