using DistributeurAutomatique.viewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class BeverageViewModelTest
    {
        [TestMethod]
        public void Beverages_OnLoad_IsPopulated()
        {
            var reader = new TestReader();
            var viewModel = new BeveragesViewModel(reader);
            Assert.IsNotNull(viewModel.Beverages);
            Assert.AreEqual(2, viewModel.Beverages.ToList().Count);
        }
    }
}
