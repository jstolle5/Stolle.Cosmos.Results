#region Header
// Created By: Jason Stolle
// 20210607
// Stolle.Cosmos.ResultsStolle.Cosmos.Results.TestsResultTests.cs
#endregion

using System;
using Xunit;

namespace Stolle.Cosmos.Results.Tests
{
    public class ResultTests
    {
        [Fact]
        public void SuccessResultTest()
        {
            var result = SuccessMethod();
            Assert.True(result.Success);
        }
        
        
        [Fact]
        public void FailureResultTest()
        {
            var result = FailureMethod();
            Assert.False(result.Success);
        }
        
        
        [Fact]
        public void ContentResultTest()
        {
            var result = ContentMethod();
            Assert.True(result.Success);
            Assert.NotNull(result.Content);
        }

        private static IResult<string> ContentMethod()
        {
            return new Result<string>
                   {
                       Success = true,
                       Message = "This is a method with content to return.",
                       Content = "Hello world!"
                   };
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
                       Message = "This method failed.",
                       Exception = new Exception()
                   };
        }
    }
}