using Order_Management_System___OODJ.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Order_Management_System___OODJ.utils
{
    internal class UserUtils
    {
        private static Utils utils = new Utils();
        public Users GetUserById(int id, string filePath)
        {
            List<string> lines = utils.ReadLinesFromTextFile(filePath);
            Users user = new Users();
            foreach (string line in lines)
            {
                string[] enteries = line.Split(',');
                if (enteries[0] == id.ToString())
                {
                    user.Id = int.Parse(enteries[0]);
                    user.UserFullName = enteries[1];
                    user.UserPassword = enteries[2];
                    user.UserEmail = enteries[3];
                    user.UserName = enteries[4];
                    user.UserRole = enteries[5];
                }
            }
            return user;
        }

        public Users getUserByEmail(string email, string filePath)
        {
            List<string> lines = utils.ReadLinesFromTextFile(filePath);
            Users user = new Users();
            foreach (string line in lines)
            {
                string[] enteries = line.Split(',');
                if (enteries[3] == email)
                {
                    user.Id = int.Parse(enteries[0]);
                    user.UserFullName = enteries[1];
                    user.UserPassword = enteries[2];
                    user.UserEmail = enteries[3];
                    user.UserName = enteries[4];
                    user.UserRole = enteries[5];
                }
            }
            return user;
        }

        public bool IsUserExist(string email, string filePath)
        {
            List<string> lines = utils.ReadLinesFromTextFile(filePath);
            foreach (string line in lines)
            {
                string[] enteries = line.Split(',');
                if (enteries[3] == email)
                {
                    return true;
                }
            }
            return false;
        }


        public Users Login(string email, string password, string filePath)
        {
            if (getUserByEmail(email, filePath) != null)
            {
                var user = getUserByEmail(email, filePath);
                if (user.UserPassword == password)
                {
                    return user;
                }
            }
            return null;
        }

        public Users getCurrentLoggedUser(string ActiveUsersFilePath, string UsersFilePath)
        {
            List<string> lines = utils.ReadLinesFromTextFile(ActiveUsersFilePath);
            Users user = new Users();
            foreach (string line in lines)
            {
                string[] enteries = line.Split(',');
                user.Id = int.Parse(enteries[0]);
                user.UserFullName = enteries[1];
                user.UserPassword = enteries[2];
                user.UserEmail = enteries[3];
                user.UserName = enteries[4];
                user.UserRole = enteries[5];
            }
            return GetUserById(user.Id, UsersFilePath);
        }

        public void LoggActiveUser(Users user, string activeUserFilePath)
        {
            string data = user.Id + "," + user.UserFullName + "," + user.UserPassword + "," + user.UserEmail + "," + user.UserName + "," + user.UserRole;
            utils.WriteLineToTxtFile(activeUserFilePath, data);
        }

        public void logout(string activeUserfilePath)
        {
            utils.DeleteAllLines(activeUserfilePath);
        }
        public List<Users> getAllUsers(string filePath)
        {
            List<Users> users = new List<Users>();
            List<string> lines = utils.ReadLinesFromTextFile(filePath);

            foreach (string line in lines)
            {
                string[] enteries = line.Split(',');
                Users user = new Users();
                user.Id = int.Parse(enteries[0]);
                user.UserFullName = enteries[1];
                user.UserPassword = enteries[2];
                user.UserEmail = enteries[3];
                user.UserName = enteries[4];
                user.UserRole = enteries[5];
                users.Add(user);
            }
            return users;
        }

        public void updateProfile(string filePath, Users user)
        {
            // TO DO
            Users userToUpdate = new Users();
            List<Users> users = getAllUsers(Variables.usersFilePath);
            userToUpdate.Id = user.Id;
            userToUpdate.UserName = user.UserName;
            userToUpdate.UserRole = user.UserRole;
            userToUpdate.UserPassword = user.UserPassword;
            userToUpdate.UserEmail = user.UserEmail;
            userToUpdate.UserFullName = user.UserFullName;
            users.RemoveAll(x => x.Id == user.Id);
            users.Add(userToUpdate);
            utils.DeleteAllLines(Variables.usersFilePath);
            string[] output = new string[users.Count];

            for (int i = 0; i < users.Count; i++)
            {
                output[i] = users[i].Id.ToString() + "," + users[i].UserFullName + "," + users[i].UserPassword+ "," + users[i].UserEmail + "," + users[i].UserName + "," + users[i].UserRole;
            }


            File.WriteAllLines(filePath, output);

        }

        public bool IsAdmin(int id, string filePath)
        {
            var user = GetUserById(id, filePath);
            if (user != null)
            {
                if (user.UserRole == "Admin" || user.UserRole == "admin")
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsCustomer(int id, string filePath)
        {
            var user = GetUserById(id, filePath);
            if (user != null)
            {
                if (user.UserRole == "Customer" || user.UserRole == "customer")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
