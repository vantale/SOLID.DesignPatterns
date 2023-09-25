using SOLID.DesignPatterns.Singleton.Code.NewFolder;
using System.Threading.Tasks;
using Xunit;

namespace SOLID.DesignPatterns.Tests.Singleton.LazyAsyncInitialization
{

    public class TypeWithExpensiveLazyAsyncWorkTest
    {
        [Fact]
        public async Task Test1Async()
        {
            var sut = new TypeWithExpensiveLazyAsyncWork();
            var result = await sut.DoSomethingAsync("Kamil");

            Assert.Equal("", result);
        }
    }
}
