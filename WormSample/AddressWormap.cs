using TablesSample;
using Worm.Core;
using WormSample.Models;

namespace WormSample
{
    public class AddressWormap : IWormap<AddressRow, DbAddress>
    {
        public void UpdateData(AddressRow data, DbAddress model)
        {
            data.Code = model.Code;
            data.Complement = model.Complement;
            data.Country = model.Country;
            data.Number = model.Number;
            data.Place = model.Place;
        }

        public void UpdateModel(DbAddress model, AddressRow data)
        {
            model.Code = data.Code;
            model.Complement = data.Complement;
            model.Country = data.Country;
            model.Number = data.Number;
            model.Place = data.Place;
            model.Id = data.AddressId;
        }
    }
}