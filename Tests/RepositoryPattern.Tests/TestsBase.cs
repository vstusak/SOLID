using Moq;
using NUnit.Framework;

namespace RepositoryPattern.Tests;

public class TestsBase
{
    public MockRepository MockRepository { get; set; }

    [SetUp]
    public void SetUp()
    {
        MockRepository = new MockRepository(MockBehavior.Strict);
    }

    [TearDown]
    public void TearDown()
    {
        MockRepository.VerifyAll(); //Check everything (mocks) was setup
    }
}