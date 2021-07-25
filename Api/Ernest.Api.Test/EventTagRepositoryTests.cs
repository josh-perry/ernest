using System.Linq;
using Ernest.Api.Repositories;
using Xunit;

namespace Ernest.Api.Test
{
    public class EventTagRepositoryTests
    {
        [Fact]
        public void Test_EventTagRepository_GetByName_GetsTag()
        {
            // Arrange
            var dbContext = TestDbContextSeeder.InitializeDatabase();
            var eventTagRepository = new EventTagsRepository(dbContext);

            // Act
            var tag = eventTagRepository.GetByName("TestTag").FirstOrDefault();

            // Assert
            Assert.NotNull(tag);
            Assert.True(tag.Title == "TestTag");
        }
    }
}
