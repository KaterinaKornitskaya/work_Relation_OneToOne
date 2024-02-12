using work_Relation_OneToOne.Data;
using work_Relation_OneToOne.Repository;
using work_Relation_OneToOne.Model;
using Microsoft.EntityFrameworkCore.Storage;

namespace work_Relation_OneToOne
{
    internal class Program
    {
        static UserRepository userRepository;
        public static ApplicationContext DbContext()
        {
            return new ApplicationContextFactory().CreateDbContext();
        }
        static void Main(string[] args)
        {
            userRepository = new UserRepository();
            
            // userRepository.AddUser();

            userRepository.AddTestData();

            userRepository.DeleteUser();

            //userRepository.DeleteUser2(7);

            userRepository.GetUserById(2);
        }
    }
}
