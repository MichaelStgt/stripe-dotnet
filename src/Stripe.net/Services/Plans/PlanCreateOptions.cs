namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PlanCreateOptions : BaseOptions
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("aggregate_usage")]
        public string AggregateUsage { get; set; }

        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("billing_scheme")]
        public string BillingScheme { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("interval_count")]
        public long? IntervalCount { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("product")]
        public PlanProductCreateOptions Product { get; set; }

        [JsonProperty("product")]
        public string ProductId { get; set; }

        [JsonProperty("tiers")]
        public List<PlanTierOptions> Tiers { get; set; }

        [JsonProperty("tiers_mode")]
        public string TiersMode { get; set; }

        [JsonProperty("transform_usage")]
        public PlanTransformUsageOptions TransformUsage { get; set; }

        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }

        [JsonProperty("usage_type")]
        public string UsageType { get; set; }
    }
}
