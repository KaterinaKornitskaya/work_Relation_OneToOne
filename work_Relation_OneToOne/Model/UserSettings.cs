using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_Relation_OneToOne.Model
{
    internal class UserSettings
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Passport { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
