using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_MemberArea
{
    public class User
    {
        public User()
        {
            CreatedDate = DateTime.Now;
        }
        public  string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime CreatedDate { get; set; }

        public static List<User> Users = new List<User>();


        //Kullanıcı Listeleme metodu
        public static void UserList()
        {
            User user1 = new User();
            user1.UserName = "fatih";
            user1.Email = "fatih.gunalp@bilgeadam.com";
            user1.Password = "1234";
            user1.Role = "admin";

            User user2 = new User();
            user2.UserName = "kadir";
            user2.Email = "kadir@bilgeadam.com";
            user2.Password = "1234";
            user2.Role = "user";

            User user3 = new User();
            user3.UserName = "irem";
            user3.Email = "irem@bilgeadam.com";
            user3.Password = "1234";
            user3.Role = "user";
             

            User.Users.Add(user1);
            User.Users.Add(user2);
            User.Users.Add(user3);
        }


        //Kullanıcı Ekleme Metodu
        public static void AddUser(User user) //User tipinde  user parametresi alır
        {
            Users.Add(user);// Users listedir içine user attık .
        }

        //Kullanıcı Silme

        public static void RemoveUser(User user)
        {
            if (Users.Contains(user))
            {
                Users.Remove(user);
            }
        }

        //Todo: Güncelleme işlemi yapılacak.

        public override string ToString()
        {
            return UserName + " " + Email + " " + Role;
        }


        //kullanıcı Giriş metodu
        public static void LoginUser()
        {

        }
    }
}
