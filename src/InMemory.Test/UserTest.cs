using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemoryDatabaseAspNetCore.Model;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace InMemory.Test
{
    public class UserTest
    {
        private InMemoryContext _context;
        public UserTest()
        {
            var builder = new DbContextOptionsBuilder<InMemoryContext>();
            builder.UseInMemoryDatabase();
            var options = builder.Options;
            _context = new InMemoryContext(options);
        }
        [Fact]
        public void RunTests()
        {
            AddUser();
            GetAllUser();
            UpdateUser();
        }

       
        private void AddUser()
        {
            // Act
            var user = new ApplicationUser()
            {
                Email = "satasiya.kalpesh2006@gmail.com",
                Birthday = new DateTime(1988, 10, 21),
                Gender = "Male",
                Name = "Kalpesh Satasiya",
                UserName = "kalpeshsatasiya",
            };

            _context.Users.Add(user);
            var newUser = _context.SaveChanges();
            // Assert
            Assert.NotNull(newUser);
        }

        private void GetAllUser()
        {
            var users = _context.Users.Select(x=>x).ToList();
            Assert.NotNull(users);
            Assert.True(users.Any(), "Not record found");
        }

        private void UpdateUser()
        {
            var users = _context.Users.Select(x => x).ToList();
            if (users.Any())
            {
                users[0].UserName = "KalpeshSatasiyaTest";
                users[0].Email = "satasiya.kalpesh2006Test@gmail.com";
                users[0].Name = "Kalpesh Satasiya";
                users[0].Country = "India";

                _context.Users.Update(users[0]);
                var updateUser = _context.SaveChanges();
                Assert.NotNull(updateUser);
            }

        }

    }
}
