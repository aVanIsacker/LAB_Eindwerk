using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface ITypeBetalingRepository
    {
        IEnumerable<TypeBetaling> GetAllTypeBetalingen(bool trackChanges);
        TypeBetaling GetTypeBetaling(int id, bool trackChanges);
        void CreateTypeBetaling(TypeBetaling typeBetaling);
        void DeleteTypeBetaling(TypeBetaling typeBetaling);
    }
}
