using LegacyApp;

namespace LegacyAppTests
{
    public class UserServiceTests
    {
        [Fact]
        public void AddUser_Should_Return_False_When_Email_Without_At_And_Dot()
        {
            //Arrange
            string firstName = "Jan";
            string lastName = "Kowalski";
            DateTime birthDate = new DateTime(1980, 1, 1);
            int clientId = 1;
            string email = "Kowalski";
            var service = new UserService();

            //Act
            bool result = service.AddUser(firstName, lastName, email, birthDate, clientId);

            //Assert
            Assert.Equal(false, result);

        }

        [Fact]
        public void AddUser_Should_Return_False_When_FirstName_Is_Null()
        {
            //Arrange
            string firstName = null;
            string lastName = "Kowalski";
            DateTime birthDate = new DateTime(1980, 1, 1);
            int clientId = 1;
            string email = "Kowalski";
            var service = new UserService();

            //Act
            bool result = service.AddUser(firstName, lastName, email, birthDate, clientId);

            //Assert
            Assert.Equal(false, result);

        }
        [Fact]
        public void AddUser_Should_Return_False_When_FirstName_Is_Empty()
        {
            //Arrange
            string firstName = "";
            string lastName = "Kowalski";
            DateTime birthDate = new DateTime(1980, 1, 1);
            int clientId = 1;
            string email = "Kowalski";
            var service = new UserService();

            //Act
            bool result = service.AddUser(firstName, lastName, email, birthDate, clientId);

            //Assert
            Assert.Equal(false, result);

        }

        [Fact]
        public void AddUser_Should_Return_False_When_User_Younger_Than_21()
        {
            var service = new UserService();

            bool result = service.AddUser("Jan", "Kowalski", "kowalski", new DateTime(2012, 1, 1), 1);
            
            Assert.Equal(false, result);

        }
    }
}