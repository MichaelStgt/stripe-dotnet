﻿namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class OrderCreateOptions : BaseOptions, ISupportMetadata
    {
        /// <summary>
        /// REQUIRED: Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [FormProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A coupon code that represents a discount to be applied to this order. Must be one-time duration and in tbe same currency as the order.
        /// </summary>
        [FormProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// The ID of an existing customer to use for this order. If provided, the customer email and shipping address will be used to create the order. Subsequently, the customer will also be charged to pay the order. If email or shipping are also provided, they will override the values retrieved from the customer object.
        /// </summary>
        [FormProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// The email address of the customer placing the order.
        /// </summary>
        [FormProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// List of items constituting the order.
        /// </summary>
        [FormProperty("items")]
        public List<OrderItemOptions> Items { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to an order object. It can be useful for storing additional information about the order in a structured format.
        /// </summary>
        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Shipping address for the order. Required if any of the SKUs are for products that have shippable set to true.
        /// </summary>
        [FormProperty("shipping")]
        public ShippingOptions Shipping { get; set; }
    }
}
