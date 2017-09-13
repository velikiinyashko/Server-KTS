using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    class BaseModel
    {
        public class ObjectInfo
        {
            [Key]
            public int ObjectId { get; set; }
            public string OjectName { get; set; }

            [Required]
            public Users Users { get; set; }

            public Modules Modules { get; set; }
        }

        public class Modules
        {
            [Key]
            public int ModelId { get; set; }
            public string Client { get; set; }
            public string SerialNumber { get; set; }
            public int IMEI { get; set; }
            public string ModuleType { get; set; }
            public string GSM { get; set; }
            public string Comment { get; set; }
        }

        public class Users
        {
            [Key]
            public int UserId { get; set; }
            [MaxLength(32)]
            public string Login { get; set; }
            public string Password { get; set; }
            public string Rules { get; set; }

            public List<ObjectInfo> ObjectInfo { get; set; }
        }

        public class Rules
        {
            [Key]
            public int RulesId { get; set; }
            public string RulesName { get; set; }
        }

        public class GeoLocation
        {
            [Key]
            public int GeoLocationId { get; set; }
            public DateTime Time { get; set; }
            public Double Lan { get; set; }
            public Double lag { get; set; }
            public Double Speed { get; set; }
        }

        public class Client
        {
            [Key]
            public int ClientId { get; set; }
            [MaxLength(32)]
            public string Name { get; set; }
            [MaxLength(32)]
            public string SecondName { get; set; }
        }

        public class CarInfo
        {
            [Key]
            public int CarInfoId { get; set; }
            public string CarMark { get; set; }
            public string CarModel { get; set; }
            public string CarYear { get; set; }
            public string CarRegNumber { get; set; }
        }
    }
}
