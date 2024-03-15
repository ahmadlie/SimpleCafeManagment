using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;

namespace Business.Abstract
{
    public interface IUserService : IBaseService<UserDTO,User>
    {
        IQueryable<Role> Login(UserDTO userDTO);
        void SignUp(UserDTO userDTO, string repeatPssword);
    }
}
