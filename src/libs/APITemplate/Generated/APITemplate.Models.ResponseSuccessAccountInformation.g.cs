
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseSuccessAccountInformation
    {
        /// <summary>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Example: APITemplate.io - Test
        /// </summary>
        /// <example>APITemplate.io - Test</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_product")]
        public string? SubscriptionProduct { get; set; }

        /// <summary>
        /// Example: 2024-12-03T08:22:47.000Z
        /// </summary>
        /// <example>2024-12-03T08:22:47.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_current_period_start")]
        public global::System.DateTime? SubscriptionCurrentPeriodStart { get; set; }

        /// <summary>
        /// Example: 2025-01-03T08:22:47.000Z
        /// </summary>
        /// <example>2025-01-03T08:22:47.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_current_period_end")]
        public global::System.DateTime? SubscriptionCurrentPeriodEnd { get; set; }

        /// <summary>
        /// Example: active
        /// </summary>
        /// <example>active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_status")]
        public string? SubscriptionStatus { get; set; }

        /// <summary>
        /// Example: month
        /// </summary>
        /// <example>month</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_interval")]
        public string? SubscriptionInterval { get; set; }

        /// <summary>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_quota")]
        public int? ApiQuota { get; set; }

        /// <summary>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_remaining")]
        public int? ApiRemaining { get; set; }

        /// <summary>
        /// Example: 0.00
        /// </summary>
        /// <example>0.00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_used")]
        public string? ApiUsed { get; set; }

        /// <summary>
        /// Example: -924
        /// </summary>
        /// <example>-924</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_remaining")]
        public int? TemplateRemaining { get; set; }

        /// <summary>
        /// Example: 1924
        /// </summary>
        /// <example>1924</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_count")]
        public int? TemplateCount { get; set; }

        /// <summary>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_quota")]
        public int? TemplateQuota { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessAccountInformation" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: success
        /// </param>
        /// <param name="subscriptionProduct">
        /// Example: APITemplate.io - Test
        /// </param>
        /// <param name="subscriptionCurrentPeriodStart">
        /// Example: 2024-12-03T08:22:47.000Z
        /// </param>
        /// <param name="subscriptionCurrentPeriodEnd">
        /// Example: 2025-01-03T08:22:47.000Z
        /// </param>
        /// <param name="subscriptionStatus">
        /// Example: active
        /// </param>
        /// <param name="subscriptionInterval">
        /// Example: month
        /// </param>
        /// <param name="apiQuota">
        /// Example: 1000
        /// </param>
        /// <param name="apiRemaining">
        /// Example: 1000
        /// </param>
        /// <param name="apiUsed">
        /// Example: 0.00
        /// </param>
        /// <param name="templateRemaining">
        /// Example: -924
        /// </param>
        /// <param name="templateCount">
        /// Example: 1924
        /// </param>
        /// <param name="templateQuota">
        /// Example: 1000
        /// </param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSuccessAccountInformation(
            string? status,
            string? subscriptionProduct,
            global::System.DateTime? subscriptionCurrentPeriodStart,
            global::System.DateTime? subscriptionCurrentPeriodEnd,
            string? subscriptionStatus,
            string? subscriptionInterval,
            int? apiQuota,
            int? apiRemaining,
            string? apiUsed,
            int? templateRemaining,
            int? templateCount,
            int? templateQuota,
            string? message)
        {
            this.Status = status;
            this.SubscriptionProduct = subscriptionProduct;
            this.SubscriptionCurrentPeriodStart = subscriptionCurrentPeriodStart;
            this.SubscriptionCurrentPeriodEnd = subscriptionCurrentPeriodEnd;
            this.SubscriptionStatus = subscriptionStatus;
            this.SubscriptionInterval = subscriptionInterval;
            this.ApiQuota = apiQuota;
            this.ApiRemaining = apiRemaining;
            this.ApiUsed = apiUsed;
            this.TemplateRemaining = templateRemaining;
            this.TemplateCount = templateCount;
            this.TemplateQuota = templateQuota;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSuccessAccountInformation" /> class.
        /// </summary>
        public ResponseSuccessAccountInformation()
        {
        }

    }
}