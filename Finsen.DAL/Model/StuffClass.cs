using MongoDB.Bson;
using Finsen.Elementary.Enums;

namespace Finsen.Elementary.Model
{
    public class StuffClass
    {
        private StatusObject _status;

        public ObjectId _id { get; set; }

        public StatusObject Status { get { return _status; } }

        public StuffClass()
        {
            _status = StatusObject.soBrownse;
        }

        public void Insert()
        {
            _status = StatusObject.soInsert;
        } 

        public void Edit()
        {
            _status = StatusObject.soEdit;
        } 

        public void Delete()
        {
            _status = StatusObject.soDelete;
        }


    }
}
