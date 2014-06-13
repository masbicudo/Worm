using TablesSample;
using Worm.Core;
using WormSample.Models;

namespace WormSample
{
    public class PhoneWormap : IWormap<PhoneRow, DbFixedPhone>, IWormap<PhoneRow, DbMobilePhone>, IWormap<PhoneRow, DbPhone>
    {
        public PhoneWormap(IWormap<AddressRow, DbAddress> addressWormap)
        {
            this.AddressWormap = addressWormap;
        }

        public IWormap<AddressRow, DbAddress> AddressWormap { get; private set; }

        public void UpdateData(PhoneRow data, DbFixedPhone model)
        {
            if (data == null || model == null)
                return;

            data.Number = model.Number;
            data.AddressId = model.Address.Id;
        }

        public void UpdateModel(DbFixedPhone model, PhoneRow data)
        {
            if (data == null || model == null)
                return;

            model.Number = data.Number;
            model.Id = data.ContactId;
        }

        public void UpdateData(PhoneRow data, DbMobilePhone model)
        {
            if (data == null || model == null)
                return;

            throw new System.NotImplementedException();
        }

        public void UpdateModel(DbMobilePhone model, PhoneRow data)
        {
            if (data == null || model == null)
                return;

            throw new System.NotImplementedException();
        }

        public void UpdateData(PhoneRow data, DbPhone model)
        {
            if (data == null || model == null)
                return;

            this.UpdateData(data, model as DbMobilePhone);
            this.UpdateData(data, model as DbFixedPhone);
        }

        public void UpdateModel(DbPhone model, PhoneRow data)
        {
            if (data == null || model == null)
                return;

            throw new System.NotImplementedException();
        }
    }
}