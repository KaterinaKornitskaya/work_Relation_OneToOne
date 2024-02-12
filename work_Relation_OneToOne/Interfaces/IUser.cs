using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_Relation_OneToOne.Model;

namespace work_Relation_OneToOne.Interfaces
{
    internal interface IUser
    {
        public void AddUser();

        public void DeleteUser();

        public void DeleteUser2(int id);

        public void GetUserById(int id);
        public void AddTestData();
    }
}
