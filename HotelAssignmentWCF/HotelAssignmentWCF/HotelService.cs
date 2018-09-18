using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAssignmentWCF
{
    class HotelService : IHotelService
    {
        public Hotel GetHotelById(int id)
        {
            List<Hotel> hotel = new List<Hotel>();
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            path = path + "/../../" + "database.json";
            using (StreamReader streamReader = new StreamReader(path))
            {
                var json = streamReader.ReadToEnd();
                hotel = JsonConvert.DeserializeObject<List<Hotel>>(json);
            }
            foreach(Hotel hotell in hotel)
            {
                if(hotell.Id == id)
                {
                    return hotell;
                }
            }
            return null;
        }

        public List<Hotel> GetHotels()
        {
            List<Hotel> hotel = new List<Hotel>();
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            path = path + "/../../" + "database.json";
            using (StreamReader streamReader = new StreamReader(path))
            {
                var json = streamReader.ReadToEnd();
                hotel = JsonConvert.DeserializeObject<List<Hotel>>(json);
            }
            return hotel;
        }
    }
}
