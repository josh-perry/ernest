using System.Linq;
using Ernest.Api.Repositories;
using Ernest.Api.Test.SetupUtilities;
using Xunit;

namespace Ernest.Api.Test
{
    public class EventTagRepositoryTests
    {
        [Fact]
        public void Test_EventTagRepository_ExistentGetByName_GetsTag()
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

        [Fact]
        public void Test_EventTagRepository_NonExistentGetByName_GetsNull()
        {
            // Arrange
            var dbContext = TestDbContextSeeder.InitializeDatabase();
            var eventTagRepository = new EventTagsRepository(dbContext);

            // Act
            var tag = eventTagRepository.GetByName("TagThatDoesn'tExist").FirstOrDefault();

            // Assert
            Assert.Null(tag);
        }

        [Fact]
        public void Test_EventTagRepository_GetByNamesArray_GetsCorrectTags()
        {
            // Arrange
            var dbContext = TestDbContextSeeder.InitializeDatabase();
            var eventTagRepository = new EventTagsRepository(dbContext);

            // Act
            var tags = eventTagRepository.GetByName(new[]
            {
                "TestTag",
                "TestTag2",
                "TestTag3"
            }).ToList();

            // Assert
            Assert.True(tags.Count == 3);
            Assert.True(tags.Count(x => x.Title == "TestTag") == 1);
            Assert.True(tags.Count(x => x.Title == "TestTag2") == 1);
            Assert.True(tags.Count(x => x.Title == "TestTag3") == 1);
        }
    }
}
