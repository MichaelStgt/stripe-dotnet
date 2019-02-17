namespace StripeTests
{
    using Stripe;
    using Xunit;

    public class StripeConfigurationTest : BaseStripeTest
    {
        [Fact]
        public void ApiKey_Set_ThrowsOnInvalidKey()
        {
            Assert.Throws<StripeException>(() => StripeConfiguration.ApiKey = "sk_test_123\n");
        }
    }
}
