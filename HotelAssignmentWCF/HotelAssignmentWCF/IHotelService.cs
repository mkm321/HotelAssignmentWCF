using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HotelAssignmentWCF
{
    [ServiceContract]
    interface IHotelService
    {
        [OperationContract]
        List<Hotel> GetHotels();
        [OperationContract]
        Hotel GetHotelById(int id);
    }
}
