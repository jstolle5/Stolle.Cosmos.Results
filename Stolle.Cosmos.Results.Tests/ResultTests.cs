#region Header
// Created By: Jason Stolle
// 20210607
// Stolle.Cosmos.ResultsStolle.Cosmos.Results.TestsResultTests.cs
#endregion

using Xunit;

namespace Stolle.Cosmos.Results.Tests
{
    public class ResultTests
    {
        [Fact]
        public void ResultSuccessTest()
        {
            var result = SuccessMethod();
            Assert.True(result.Success);
        }
        
        
        [Fact]
        public void ResultFailureTest()
        {
            var result = FailureMethod();
            Assert.False(result.Success);
        }

        private static IResult SuccessMethod()
        {
            return new Result
                   {
                       Success = true,
                       Message = "This method was successful."
                   };
        }
        
        
        private static IResult FailureMethod()
        {
            return new Result
                   {
                       Success = false,
                       Message = "This method failed."
                   };
        }
    }
}