﻿using CV.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Services
{
    public interface IQualificationService
    {
        Task<IEnumerable<QualificationModel>> GetQualificationsAsync();
    }
}
