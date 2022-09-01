using AccessibleImages.Models;

namespace AccessibleImages.UnitTests
{
    public class ImageTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckTitle_AlphaOnly_ReturnsTrue()
        {
            var image = new Image();
            var result = image.CheckTitle("qwerty");
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckTitle_AlphaNumeric_ReturnsFalse()
        {
            var image = new Image();
            var result = image.CheckTitle("qwerty123");
            Assert.IsFalse(result);
        }

        [Test]
        public void CheckAlternativeText_GreaterThan16_ReturnsTrue()
        {
            var image = new Image();
            var result = image.CheckAlternativeText("This picture shows a mouse in a house");
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckAlternativeText_LessThan16_ReturnsFalse()
        {
            var image = new Image();
            var result = image.CheckAlternativeText("mouse");
            Assert.IsFalse(result);
        }
    }
}