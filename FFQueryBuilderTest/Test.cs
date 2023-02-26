namespace FFQueryBuilder.Test
{
    public class FFQueryBuilderExtensionMethodsTests
    {
        [Fact]
        public void CreateFilters_ReturnsFilterThatCanHandleTypeInt()
        {
            // Arrange
            var type = typeof(int);

            // Act
            var filter =  FilterFactory.CreateFilters(type);

            // Assert
            Assert.NotNull(filter);
            Assert.IsAssignableFrom<IFilterValue>(filter);
            Assert.IsType<IntFilter>(filter);
        }

        [Fact]
        public void CreateFilters_ReturnsFilterThatCanHandleTypeFloat()
        {
            // Arrange
            var type = typeof(float);

            // Act
            var filter = FilterFactory.CreateFilters(type);

            // Assert
            Assert.NotNull(filter);
            Assert.IsAssignableFrom<IFilterValue>(filter);
            Assert.IsType<FloatFilter>(filter);
        }
    }
}