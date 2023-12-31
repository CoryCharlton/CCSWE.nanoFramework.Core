using nanoFramework.TestFramework;
using System;

namespace CCSWE.nanoFramework.Core.UnitTests
{
    [TestClass]
    public class EnsureTests
    {
        [TestMethod]
        public void GetException_returns_ArgumentException()
        {
            Assert.IsType(typeof(ArgumentException), Ensure.GetException(typeof(ArgumentException), nameof(EnsureTests)));
        }

        [TestMethod]
        public void GetException_returns_ArgumentNullException()
        {
            Assert.IsType(typeof(ArgumentNullException), Ensure.GetException(typeof(ArgumentNullException), nameof(EnsureTests)));
        }

        [TestMethod]
        public void GetException_returns_ArgumentOutOfRangeException()
        {
            Assert.IsType(typeof(ArgumentOutOfRangeException), Ensure.GetException(typeof(ArgumentOutOfRangeException), nameof(EnsureTests)));
        }

        [TestMethod]
        public void GetException_returns_IndexOutOfRangeException()
        {
            Assert.IsType(typeof(IndexOutOfRangeException), Ensure.GetException(typeof(IndexOutOfRangeException), nameof(EnsureTests)));
        }

        [TestMethod]
        public void GetException_returns_InvalidOperationException()
        {
            Assert.IsType(typeof(InvalidOperationException), Ensure.GetException(typeof(InvalidOperationException), nameof(EnsureTests)));
        }

        [TestMethod]
        public void IsInRange_does_not_throw()
        {
            Ensure.IsInRange(nameof(EnsureTests), true);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void IsInRange_does_not_throw_for_double()
        {
            Ensure.IsInRange(nameof(EnsureTests), 1d, 0, 1);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void IsInRange_does_not_throw_for_float()
        {
            Ensure.IsInRange(nameof(EnsureTests), 1f, 0, 1);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void IsInRange_does_not_throw_for_int()
        {
            Ensure.IsInRange(nameof(EnsureTests), 1, 0, 1);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void IsInRange_does_not_throw_for_long()
        {
            Ensure.IsInRange(nameof(EnsureTests), 1L, 0, 1);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void IsInRange_throws()
        {
            Assert.ThrowsException(typeof(ArgumentOutOfRangeException), () => Ensure.IsInRange(nameof(EnsureTests), false));
        }

        [TestMethod]
        public void IsInRange_throws_for_double()
        {
            Assert.ThrowsException(typeof(ArgumentOutOfRangeException), () => Ensure.IsInRange(nameof(EnsureTests), -1d, 0, 1));
        }

        [TestMethod]
        public void IsInRange_throws_for_float()
        {
            Assert.ThrowsException(typeof(ArgumentOutOfRangeException), () => Ensure.IsInRange(nameof(EnsureTests), -1f, 0, 1));
        }

        [TestMethod]
        public void IsInRange_throws_for_int()
        {
            Assert.ThrowsException(typeof(ArgumentOutOfRangeException), () => Ensure.IsInRange(nameof(EnsureTests), -1, 0, 1));
        }

        [TestMethod]
        public void IsInRange_throws_for_long()
        {
            Assert.ThrowsException(typeof(ArgumentOutOfRangeException), () => Ensure.IsInRange(nameof(EnsureTests), -1L, 0, 1));
        }

        [TestMethod]
        public void IsNotNull_does_not_throw()
        {
            Ensure.IsNotNull(nameof(EnsureTests), new object());
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void IsNotNull_throws()
        {
            Assert.ThrowsException(typeof(ArgumentNullException), () => Ensure.IsNotNull(nameof(EnsureTests), null));
        }

        [TestMethod]
        public void IsNotNullOrEmpty_does_not_throw()
        {
            Ensure.IsNotNullOrEmpty(nameof(EnsureTests), nameof(IsNotNullOrEmpty_does_not_throw));
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void IsNotNullOrEmpty_throws()
        {
            Assert.ThrowsException(typeof(ArgumentException), () => Ensure.IsNotNullOrEmpty(nameof(EnsureTests), null));
            Assert.ThrowsException(typeof(ArgumentException), () => Ensure.IsNotNullOrEmpty(nameof(EnsureTests), string.Empty));
        }

        [TestMethod]
        public void IsValid_does_not_throws()
        {
            Ensure.IsValid(nameof(EnsureTests), true);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void IsValid_throws()
        {
            Assert.ThrowsException(typeof(ArgumentException), () => Ensure.IsValid(nameof(EnsureTests), false));
        }
    }
}
