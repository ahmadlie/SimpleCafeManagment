using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Role : BaseEntity
    {             
        public UserRole UserRole { get; set; }
        public List<User> Users { get; set; }

    }

    public enum UserRole
    {
        Admin,
        Member
    }
}
