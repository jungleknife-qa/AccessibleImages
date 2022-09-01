using AccessibleImages.Models;

namespace AccessibleImages.UnitTests
{

    public class UserTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckPassword_IncludesNumeric_ReturnsTrue()
        {
            var user = new User();
            var result = user.CheckPassword("D3m0bb3d");
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckPassword_NoNumeric_ReturnsFalse()
        {
            var user = new User();
            var result = user.CheckPassword("Demobbed");
            Assert.IsFalse(result);
        }

        [Test]
        public void CheckPasswordLength_EightCharacters_ReturnsTrue()
        {
            var user = new User();
            var result = user.CheckPasswordLength("D3m0bbed");
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckPasswordLength_SixCharacters_ReturnsFalse()
        {
            var user = new User();
            var result = user.CheckPasswordLength("m0bbed");
            Assert.IsFalse(result);
        }
    }
}
