namespace Stripe
{
    using Newtonsoft.Json;

    public class ApplicationFeeListOptions : ListOptionsWithCreated
    {
        [JsonProperty("charge")]
        public string ChargeId { get; set; }
    }
}
