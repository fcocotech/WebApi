using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string st_addr { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public DateTime timestamp { get; set; }
        //private DBModel dbconn;

        public void AddUserEF()
        {
            using (ToDoContext cntxt = new ToDoContext())
            {
                cntxt.Database.EnsureCreated();
                cntxt.User.Add(new UserModel
                {
                    fname = this.fname,
                    lname = this.lname,
                    username = this.username,
                    password = this.password,
                    st_addr = this.st_addr,
                    city = this.city,
                    zip = this.zip,
                    tel = this.tel,
                    email = this.email,
                    timestamp = System.DateTime.Now
                });

                cntxt.SaveChanges();
            }
        }
    }
}
