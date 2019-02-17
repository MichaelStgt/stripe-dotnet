namespace StripeTests
{
    using Stripe;
    using Xunit;

    public class RequestOptionsTest : BaseStripeTest
    {
        [Fact]
        public void ApiKey_Set_ThrowsOnInvalidKey()
        {
            Assert.Throws<StripeException>(() => new RequestOptions { ApiKey = "sk_test_123\n" });
        }
    }
}
