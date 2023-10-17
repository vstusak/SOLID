using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_SRP.Tests
// ToDo: What is Abstract

{
    public class TestBase
    {
        protected MockRepository mockRepository;

        [SetUp]
        public void SetUp()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

        }

        [TearDown]
        public void TearDown()
        {
            mockRepository.VerifyAll();
        }
    }
}
