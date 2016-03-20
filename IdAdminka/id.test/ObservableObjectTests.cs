using System.ComponentModel;
using System.Runtime.Remoting.Channels;
using Id.domen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace id.test
{
    [TestClass]
    public class ObservableObjectTests
    {
        [TestMethod]
        public void PropertyChangedEventHandlerIsRised()
        {
            var obj = new StubObservableObject();
            bool rised = false;
            obj.PropertyChanged += (sender, e) =>
            {
                Assert.IsTrue(e.PropertyName == "ChangedProperty");
                rised = true;
            };
            obj.ChangedProperty = "Some value";
            if(!rised) Assert.Fail("PropertyChanged was never invoked");
        }
    }

    class StubObservableObject:ObservableObject
    {
        private string _changedProperty;

        public string ChangedProperty
        {
            get
            {
                return _changedProperty;
            }
            set
            {
                _changedProperty = value;
                NotifyPropertyChanged();
            }
        }
    }
}