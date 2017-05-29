using System;
using Xunit;

namespace Accenture.ContinuousIntegration.WebApi.Tests
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
	}
}
