namespace StripeTests
{
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class StringUtilsTest : BaseStripeTest
    {
        [Fact]
        public void ToSnakeCase()
        {
            var testCases = new[]
            {
                new { data = "Foo", want = "foo" },
                new { data = "FooBar", want = "foo_bar" },
                new { data = "FooBar123", want = "foo_bar123" },
                new { data = "Foo123Bar", want = "foo123_bar" },
                new { data = "FOOBar", want = "foo_bar" },
                new { data = "FooBAR", want = "foo_bar" },
                new { data = "FOOBAR", want = "foobar" },
                new { data = "FOO_BAR", want = "foo_bar" },
            };

            foreach (var testCase in testCases)
            {
                Assert.Equal(testCase.want, StringUtils.ToSnakeCase(testCase.data));
            }
        }

        [Fact]
        public void SecureEquals()
        {
            var testCases = new[]
            {
                new { data = new { a = "Hello", b = "Hello" }, want = true },
                new { data = new { a = "Hello", b = "hello" }, want = false },
                new { data = new { a = "Hello", b = "Helloo" }, want = false },
                new { data = new { a = "Hello", b = "Hell" }, want = false },
                new { data = new { a = "Hello", b = string.Empty }, want = false },
                new { data = new { a = string.Empty, b = "Hello" }, want = false },
                new { data = new { a = string.Empty, b = string.Empty }, want = true },
                new { data = new { a = "\0AAAAAAAAA", b = "\0BBBBBBBBBBBB" }, want = false },
            };

            foreach (var testCase in testCases)
            {
                Assert.Equal(
                    testCase.want,
                    StringUtils.SecureEquals(testCase.data.a, testCase.data.b));
            }
        }

        [Fact]
        public void ValidateApiKey()
        {
            var testCases = new[]
            {
                new { data = "sk_test_123", throws = false },
                new { data = "sk_test_4eC39HqLyjWDarjtT1zdp7dc", throws = false },
                new { data = "abc", throws = false },
                new { data = string.Empty, throws = false },
                new { data = (string)null, throws = false },
                new { data = "sk_test_123\n", throws = true },
                new { data = "\nsk_test_123", throws = true },
                new { data = "sk_test_\n123", throws = true },
                new { data = "sk_test_123 ", throws = true },
                new { data = " sk_test_123", throws = true },
                new { data = "sk_test_ 123", throws = true },
            };

            foreach (var testCase in testCases)
            {
                if (testCase.throws)
                {
                    Assert.Throws<StripeException>(() => StringUtils.ValidateApiKey(testCase.data));
                }
                else
                {
                    Assert.Equal(testCase.data, StringUtils.ValidateApiKey(testCase.data));
                }
            }
        }
    }
}
