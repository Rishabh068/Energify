using Energify.Data;
using Energify.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energify.Repository
{
    public class UserRepository
    {
        public EnergifyDbContext _dbcontext;
        public UserRepository(EnergifyDbContext dbcontext)
        {
            _dbcontext = dbcontext;

        }
        public UserEntity LoginUser(string mail,string pass)
        {
            foreach(var x in _dbcontext.UsersList)
            {
                if((String.Equals(x.Email,mail))&(String.Equals(x.Password, pass)))
                {
                    return x;
                    
                }
               

            }
            return new UserEntity() { Name = " User Not found", rolecode = -1, };
        }
        public UserEntity RegisterUser(string mail,string pass,string namee,string add,int role)
        {
            var registeritem = new UserEntity() {Email=mail,Password=pass,Name=namee,Address=add,rolecode=role};
            _dbcontext.UsersList.Add(registeritem);
            _dbcontext.SaveChanges();
            return registeritem;
            
        }
    }
}
