namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceSubscriptionItemOptions : BaseOptions
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        [JsonProperty("plan")]
        public string PlanId { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }
    }
}
