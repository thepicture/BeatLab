﻿using BeatLab.Models.Entities;
using System;
using System.Linq;
using System.Web.Security;

namespace BeatLab.Providers
{
    public class CustomRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            string[] roles = new string[] { };
            using (BeatLabDBEntities db = new BeatLabDBEntities())
            {
                User user = db.User.FirstOrDefault(u => u.Login == username);
                if (user != null && user.User_Type != null)
                {
                    roles = new string[] { user.User_Type.Name_User_Type };
                }
                return roles;
            }
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            bool outputResult = false;
            using (BeatLabDBEntities db = new BeatLabDBEntities())
            {
                // Получаем пользователя
                User user = db.User.FirstOrDefault(u => u.Login == username);
                if (user != null)
                {
                    User_Type userType = db.User_Type.Find(user.ID_User_Type);
                    if (userType != null && userType.Name_User_Type != null && userType.Name_User_Type == roleName)
                        outputResult = true;
                }
            }
            return outputResult;
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}