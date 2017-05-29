using System;
using Xunit;

namespace Accenture.ContinuousIntegration.Business.Tests
{
    public class UnitTest1
    {
		[Fact]
		public void TestTrue()
		{
			Assert.True(true);
		}

		[Fact]
		public void TestFalse()
		{
			Assert.False(false);
		}

		[Fact]
		public void TestNull()
		{
			Assert.Null(null);
		}
	}
}
