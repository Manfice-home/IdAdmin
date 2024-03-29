﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Id.domen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace id.test
{
    [TestClass]
    public class ViewMoelTests
    {
        [TestMethod]
        public void IsAbstractBaseClass()
        {
            Type t = typeof (ViewModel);
            Assert.IsTrue(t.IsAbstract);
        }

        [TestMethod]
        public void IsIDataErrorInfo()
        {
            Assert.IsTrue(typeof(IDataErrorInfo).IsAssignableFrom(typeof(ViewModel)));
        }

        [TestMethod]
        public void IsObservableObject()
        {
            Assert.IsTrue(typeof(ViewModel).BaseType==typeof(ObservableObject));
        }
        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void IDataErrorInfo_ErrorProperty_IsNotSupported()
        {
            var viewModel = new StubViewModel();
            var value = viewModel.Error;
        }

        [TestMethod]
        public void IndexerPropertyValidatesPropertyNameWithInvalidValue()
        {
            var viewModel = new StubViewModel();
            Assert.IsNotNull(viewModel["RequiredProperty"]);
        }

        [TestMethod]
        public void IndexerPropertyValidatesPropertyNameValidValue()
        {
            var viewModel = new StubViewModel
            {
                RequiredProperty = "Some Value"
            };
            Assert.IsNull(viewModel["RequiredProperty"]);
        }
    }

    class StubViewModel : ViewModel
    {
        [Required]
        public string RequiredProperty { get; set; }
    }
}