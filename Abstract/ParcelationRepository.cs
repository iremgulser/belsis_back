using System;
using System.Collections.Generic;
using System.Text;
namespace belsisbackend.Abstract
{
    public interface ParcelationRepository
    {
        List<Parcelation> GetAllParcelations();

        Parcelation GetParcelationById(int id);

        Parcelation CreateParcelation(Parcelation parcelation);

        Parcelation UpdateParcelation(Parcelation parcelation);

        void DeleteParcelation(int id);
    }
}

