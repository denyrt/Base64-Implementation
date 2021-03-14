using Base64Encoding.Core;
using NUnit.Framework;
using System;
using System.Text;

namespace Base64Encoding.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EncodingTest()
        {
            var inputText = Encoding.Default.GetBytes("Hello, World!");
            var standartBase64 = Convert.ToBase64String(inputText);
            var customBase64 = Base64.Encode(inputText);

            Assert.AreEqual(standartBase64, customBase64);
        }

        [Test]
        public void DecodingTest()
        {
            var inputBase64 = "SGVsbG8sIFdvcmxkIQ=="; // "Hello, World!" in base64.
            var standartBase64 = Encoding.Default.GetString(Convert.FromBase64String(inputBase64));
            var customBase64 = Encoding.Default.GetString(Base64.Decode(inputBase64));
            Assert.AreEqual(standartBase64, customBase64);
        }
    }
}