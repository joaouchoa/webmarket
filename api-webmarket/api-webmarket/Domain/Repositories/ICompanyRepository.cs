﻿using api_webmarket.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Domain.Repositories
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> ListAsync();
    }
}