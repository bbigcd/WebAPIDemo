using System;
namespace WebAPIDemo.Models
{
    public class UserModel
    {
        public UserModel()
        {
            this.userName = "bbigcd";
            this.password = "123456";
        }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
