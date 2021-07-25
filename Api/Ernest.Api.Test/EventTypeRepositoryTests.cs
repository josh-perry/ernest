using System.Linq;
using Ernest.Api.Repositories;
using Ernest.Api.Test.SetupUtilities;
using Xunit;

namespace Ernest.Api.Test
{
    public class EventTypeRepositoryTests
    {
        [Fact]
        public void Test_EventTypeRepository_GetByName_GetEventType()
        {
            // Arrange
            var dbContext = TestDbContextSeeder.InitializeDatabase();
            var eventTypeRepository = new EventTypeRepository(dbContext);

            // Act
            var eventType = eventTypeRepository.GetByName("Tea").FirstOrDefault();

            // Assert
            Assert.NotNull(eventType);
            Assert.True(eventType.Title == "Tea");
            Assert.True(eventType.BooleanFields.Count == 0);
            Assert.True(eventType.DecimalFields.Count == 0);
            Assert.True(eventType.IntegerFields.Count == 0);
            Assert.True(eventType.StringFields.Count == 0);
        }

        [Fact]
        public void Test_EventTypeRepository_GetByName_GetEventTypeWithFields()
        {
            // Arrange
            var dbContext = TestDbContextSeeder.InitializeDatabase();
            var eventTypeRepository = new EventTypeRepository(dbContext);

            // Act
            var eventType = eventTypeRepository.GetByName("Mood").FirstOrDefault();

            // Assert
            Assert.NotNull(eventType);
            Assert.True(eventType.Title == "Mood");
            Assert.True(eventType.BooleanFields.Count == 0);
            Assert.True(eventType.DecimalFields.Count == 0);
            Assert.True(eventType.IntegerFields.Count == 1);
            Assert.True(eventType.StringFields.Count == 1);
        }

        [Fact]
        public void Test_EventTypeRepository_GetByNames_GetEventTypesWithFields()
        {
            // Arrange
            var dbContext = TestDbContextSeeder.InitializeDatabase();
            var eventTypeRepository = new EventTypeRepository(dbContext);

            // Act
            var eventType = eventTypeRepository.GetByName(new[] { "Mood", "Tea" })
                .OrderBy(x => x.Title)
                .ToList();

            // Assert
            Assert.True(eventType.Count == 2);
            Assert.NotNull(eventType);

            var first = eventType[0];
            Assert.True(first.Title == "Mood");
            Assert.True(first.BooleanFields.Count == 0);
            Assert.True(first.DecimalFields.Count == 0);
            Assert.True(first.IntegerFields.Count == 1);
            Assert.True(first.StringFields.Count == 1);

            var second = eventType[1];
            Assert.True(second.Title == "Tea");
            Assert.True(second.BooleanFields.Count == 0);
            Assert.True(second.DecimalFields.Count == 0);
            Assert.True(second.IntegerFields.Count == 0);
            Assert.True(second.StringFields.Count == 0);
        }
    }
}
