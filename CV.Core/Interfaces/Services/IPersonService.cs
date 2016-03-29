using CV.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Services
{
    public interface IPersonService
    {
        Task<PersonModel> GetPersonAsync();
        Task<IEnumerable<CardModel>> GetCardsAsync();
    }
}
