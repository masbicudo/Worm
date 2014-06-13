using TablesSample;
using Worm.Core;
using WormSample.Models;

namespace WormSample
{
    public class EmailWormap : IWormap<EmailRow, DbEmail>
    {
        public void UpdateData(EmailRow data, DbEmail model)
        {
            data.At = model.EmailAddress;
            data.ContactId = model.Id;
            data.OwnerPersonId = model.OwnerId;
        }

        public void UpdateModel(DbEmail model, EmailRow data)
        {
            model.EmailAddress = data.At;
            model.Id = data.ContactId;
            model.OwnerId = data.OwnerPersonId;
        }
    }
}