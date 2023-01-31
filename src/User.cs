using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom_V4
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lasnName { get; set; }
        public string fn { 
            get {
                return name + " " + lasnName;   
            } 
        }
        public string email { get; set; }
        public string userType { get; set; }
        public string password { get; set; }
        public string numGroup { get; set; }

        public User Copy() 
        {
            return new User() { 
                id = this.id, 
                name = this.name, 
                email = this.email, 
                lasnName = this.lasnName, 
                userType = this.userType, 
                password = this.password,
                numGroup = this.numGroup
            };
        }
    }
}
