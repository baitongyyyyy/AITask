using AITaskDomain.Entites;
using AITaskInterfastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace AITaskTest
{
    public class UnitTest1
    {
        private readonly ApplicationDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public UnitTest1()
        {
            _serviceProvider = new ServiceCollection()
                .AddDbContext<ApplicationDbContext>(options =>
                    options.UseInMemoryDatabase("TestDatabase"))
                .BuildServiceProvider();

            _context = _serviceProvider.GetRequiredService<ApplicationDbContext>();
        }

        [Fact]
        public void TestContext()
        {
            Assert.NotNull(_context);
        }

        [Fact]
        public void AddAndRetrieveUser()
        {
            var user = new UserEntity
            {
                Name = "Test User",
                Email = "Test@mail.com",
                Password = "TestPassword",
                LoginBy = "TestLogin",
                CreatedAt = DateTime.UtcNow
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            var retrivedUser = _context.Users.FirstOrDefault(x => x.Email == "Test@mail.com");
            Assert.NotNull(retrivedUser);
            Assert.Equal("Test User", retrivedUser.Name);
        }

        [Fact]
        public void AddAndRetrieveTask() 
        {
            var tasks = new TaskEntity
            {
                Title = "Test Task",
                Description = "This is a test task",
                CreatedAt = DateTime.UtcNow,
                UserId = 1 // Assuming a user with ID 1 exists
            };

            _context.Tasks.Add(tasks);
            _context.SaveChanges();

            var retrievedTask = _context.Tasks.FirstOrDefault(x => x.Title == "Test Task");
            Assert.NotNull(retrievedTask);
            Assert.Equal("This is a test task", retrievedTask.Description);
        }
    }
}