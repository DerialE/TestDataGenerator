using System;

namespace TestDataGenerator.Data
{
    /// <summary>
    /// This class ONLY purpose is to holds data for user and 
    /// nothing more (Not parsing some date ..., and not other purpose)
    /// </summary>
    public class UserEntity
    {   

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
