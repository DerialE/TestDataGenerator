using NUnit.Framework;
using System;
using TestDataGenerator.Data;

namespace TestDataGenerator.BL.Test
{
    [TestFixture]
    public class ScriptGeneratorTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GeneratorUser_NameRequired()
        {
            IScriptGenerator generator = null;

            UserEntity entity = generator.GenerateUser();
            string name = entity.Name;

            Assert.That(name, Is.Not.Empty);
        }
    }
}
