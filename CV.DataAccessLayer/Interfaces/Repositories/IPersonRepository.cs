using CV.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Repositories
{
    public interface IPersonRepository
    {
        Task<Person> GetPersonAsync();
        Task<IEnumerable<Card>> GetCardsAsync();
    }
}
