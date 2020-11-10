using System.Collections.Generic;
using System.Linq;
using Database.Model;

namespace Database.DataModel
{
    public class DataModel{
        public IList<User> getUsername()
        {
            User[] us = {
                new User{
                    username = "Jannik",
                    password = "1234"
                },
                new User{
                    username = "Maria",
                    password = "4321"
                },
                new User{
                    username = "Dumi",
                    password = "1234"
                },
                new User{
                    username = "Wojtek",
                    password = "1234",
                },
                new User{
                    username = "Pawel",
                    password = "1234",
                },
            };
            return us.ToList();
        }
    }
}