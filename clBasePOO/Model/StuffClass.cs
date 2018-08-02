using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using clBasePOO.Enums;

namespace clBasePOO.Model
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
