using Business.Abstract;
using DataAccess.Entities;
using DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class UserService : BaseService<UserDTO, User>, IUserService
    {
        public IQueryable<Role> Login(UserDTO userDTO)
        {
            var users = _dbSet.ToList();
            foreach (var user in users)
            {
                if (user.Username == userDTO.Username && user.Password == userDTO.Password)
                {
                    //var userRoles = _dbContext.Users.Include(x => x.Role).Where(x => x.Username == userDTO.Username);
                    var role = _dbContext.Users.Where(x => x.Username == userDTO.Username).Select(x => x.Role);
                    return role;

                }
            }
            return null;
        }

        public void SignUp(UserDTO userDTO, string repeatPssword)
        {
            if (CheckPasswordEquals(userDTO.Password, repeatPssword))
            {
                bool isHas = false;
                var users = _dbSet.ToList();
                for (int i = 0; i < users.Count; i++)
                {
                    if (userDTO.Username == users[i].Username)
                    {
                        isHas = true;
                    }
                }
                if (!isHas)
                {
                    if (userDTO.Username == "admin" && userDTO.Password == "admin123") 
                    {
                        userDTO.RoleId = 1;
                    }
                    else { userDTO.RoleId = 2; };
                }
                else
                {
                    throw new Exception("This username already exsits!");
                }
                Create(userDTO);
            }
            else
            {
                throw new Exception("Passwords cannot be empty or not different");

            }
        }

        private bool CheckPasswordEquals(string password, string repeatPassword)
        {
            if (password != null && repeatPassword != null && password == repeatPassword) { return true; }
            else { return false; }
        }
    }
}
