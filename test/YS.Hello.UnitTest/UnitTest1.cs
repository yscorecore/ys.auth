using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hello.UnitTest
{
    [TestClass]
    public class UnitTest1:YS.Knife.Hosting.KnifeHost
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        protected override void OnConfigureLogging(HostBuilderContext context, ILoggingBuilder loggingBuilder)
        {
            base.OnConfigureLogging(context, loggingBuilder);
        }
    }
}
