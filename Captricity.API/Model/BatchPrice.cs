using System.Runtime.Serialization;
using Captricity.API.Definition;

namespace Captricity.API.Model {
    [DataContract]
    public class BatchPrice : ApiResource {
        public BatchPrice() {
        }

        internal override ApiResourceDefinition ResourceDefinition { get { return new BatchPriceDefinition(); } }

        /// <summary>
        /// Total batch cost in Captricity fields: 
        /// ((page_count * user_fields_per_page) + (overage_field_count * user_fields_per_overage_field)).
        /// </summary>
        [DataMember(Name = "total_batch_cost_in_fields")]
        public decimal TotalBatchCostInFields { get; set; }

        /// <summary>
        /// The included fields in each page the user runs.
        /// Additional fields will incur overage charge.
        /// </summary>
        [DataMember(Name = "user_included_fields_per_page")]
        public int UserIncludedFieldsPerPage { get; set; }

        /// <summary>
        /// Whether or not the batch is ready to be priced.
        /// </summary>
        [DataMember(Name = "can_be_priced")]
        public bool CanBePriced { get; set; }

        /// <summary>
        /// Existing pay-go fields applied to the cost before 
        /// calculating amount due from the user
        /// </summary>
        [DataMember(Name = "user_pay_go_fields_applied")]
        public int UserPayGoFieldsApplied { get; set; }

        /// <summary>
        /// Number of pages expected to be processed with this batch
        /// </summary>
        [DataMember(Name = "page_count")]
        public int PageCount { get; set; }

        /// <summary>
        /// Total cost in US cents that the user must pay to run this batch. 
        /// This is equivalent to the cents value of total_user_cost_in_fields.
        /// </summary>
        [DataMember(Name = "total_user_cost_in_cents")]
        public int TotalUserCostInCents { get; set; }

        /// <summary>
        /// Subscription fields applied to the cost before calculating amount due from the user
        /// </summary>
        [DataMember(Name = "user_subscription_fields_applied")]
        public int UserSubscriptionFieldsApplied { get; set; }

        /// <summary>
        /// Subscription fields the user's account gains every month
        /// </summary>
        [DataMember(Name = "user_subscription_fields_per_month")]
        public int UserSubscriptionFieldsPerMonth { get; set; }

        /// <summary>
        /// Total number of fields beyond the included fields per page in this batch.
        /// </summary>
        [DataMember(Name = "overage_field_count")]
        public int OverageFieldCount { get; set; }

        /// <summary>
        /// Total cost in Captricity fields that the user must pay to run this batch. 
        /// Factors in any existing account fields.
        /// </summary>
        [DataMember(Name = "total_user_cost_in_fields")]
        public int TotalUserCostInFields { get; set; }

        /// <summary>
        /// ID of the batch to which these pricing details belong.
        /// </summary>
        [DataMember(Name = "btch_id")]
        public int BatchID { get; set; }

        /// <summary>
        /// Subscription fields in the user's account
        /// </summary>
        [DataMember(Name = "user_subscription_fields")]
        public int UserSubscriptionFields { get; set; }

        /// <summary>
        /// Subscription fields in the user's account
        /// </summary>
        [DataMember(Name = "user_page_go_fields")]
        public int UserPageGoFields { get; set; }

        /// <summary>
        /// Overage charge in Captricity fields this user is charged for 
        /// each field beyond the included fields.
        /// </summary>
        [DataMember(Name = "user_fields_per_overage_field")]
        public int UserFieldsPerOverageField { get; set; }

        /// <summary>
        /// Captricity fields per page this user is charged
        /// </summary>
        [DataMember(Name = "user_fields_per_page")]
        public int UserFieldsPerPage { get; set; }
    }
}
