using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace BitPayAPI
{
    public class Invoice
    {
	    public const String STATUS_NEW = "new";
	    public const String STATUS_PAID = "paid";
	    public const String STATUS_CONFIRMED = "confirmed";
	    public const String STATUS_COMPLETE = "complete";
	    public const String STATUS_INVALID = "invalid";
	    public const String EXSTATUS_FALSE = "false";
	    public const String EXSTATUS_PAID_OVER = "paidOver";
        public const String EXSTATUS_PAID_PARTIAL = "paidPartial";

        /// <summary>
        /// Creates an uninitialized invoice request object.
        /// </summary>
        public Invoice() {}

        // Creates a minimal inovice request object.
        public Invoice(double price, String currency)
        {
            Price = price;
            Currency = currency;
        }

        // API fields
        //

        [JsonProperty(PropertyName = "guid")]
        public string Guid { get; set; }

        [JsonProperty(PropertyName = "nonce")]
        public long Nonce { get; set; }
        public bool ShouldSerializeNonce() { return Nonce != 0; }

        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

        // Required fields
        //

        [JsonProperty(PropertyName = "price")]
        public double Price { get; set; }

        String _currency = "";
        [JsonProperty(PropertyName = "currency")]
        public string Currency
        {
            get { return _currency; }
            set
            {
                if (value.Length != 3)
                {
                    throw new BitPayException("Error: currency code must be exactly three characters");
                }
                _currency = value;
            }
        }

        // Optional fields
        //

        [JsonProperty(PropertyName = "orderId")]
        public string OrderId { get; set; }
        public bool ShouldSerializeOrderId() { return !String.IsNullOrEmpty(OrderId); }

        [JsonProperty(PropertyName = "itemDesc")]
        public string ItemDesc { get; set; }
        public bool ShouldSerializeItemDesc() { return !String.IsNullOrEmpty(ItemDesc); }

        [JsonProperty(PropertyName = "itemCode")]
        public string ItemCode { get; set; }
        public bool ShouldSerializeItemCode() { return !String.IsNullOrEmpty(ItemCode); }

        [JsonProperty(PropertyName = "posData")]
        public string PosData { get; set; }
        public bool ShouldSerializePosData() { return !String.IsNullOrEmpty(PosData); }

        [JsonProperty(PropertyName = "notificationURL")]
        public string NotificationURL { get; set; }
        public bool ShouldSerializeNotificationURL() { return !String.IsNullOrEmpty(NotificationURL); }

        [JsonProperty(PropertyName = "transactionSpeed")]
        public string TransactionSpeed { get; set; }
        public bool ShouldSerializeTransactionSpeed() { return !String.IsNullOrEmpty(TransactionSpeed); }

        [JsonProperty(PropertyName = "fullNotifications")]
        public bool FullNotifications { get; set; }
        public bool ShouldSerializeFullNotifications() { return FullNotifications; }

        [JsonProperty(PropertyName = "extendedNotifications")]
        public bool ExtendedNotifications { get; set; }
        public bool ShouldSerializeExtendedNotifications() { return ExtendedNotifications; }

        [JsonProperty(PropertyName = "notificationEmail")]
        public string NotificationEmail { get; set; }
        public bool ShouldSerializeNotificationEmail() { return !String.IsNullOrEmpty(NotificationEmail); }

        [JsonProperty(PropertyName = "redirectURL")]
        public string RedirectURL { get; set; }
        public bool ShouldSerializeRedirectURL() { return !String.IsNullOrEmpty(RedirectURL); }

        [JsonProperty(PropertyName = "physical")]
        public bool Physical { get; set; }
        public bool ShouldSerializePhysical() { return Physical; }

        [JsonProperty(PropertyName = "buyer")]
        public Buyer Buyer { get; set; }
        public bool ShouldSerializeBuyer() { return Buyer != null; }

        [JsonProperty(PropertyName = "buyerName")]
        public string BuyerName { get; set; }
        public bool ShouldSerializeBuyerName() { return !String.IsNullOrEmpty(BuyerName); }

        [JsonProperty(PropertyName = "buyerAddress1")]
        public string BuyerAddress1 { get; set; }
        public bool ShouldSerializeBuyerAddress1() { return !String.IsNullOrEmpty(BuyerAddress1); }

        [JsonProperty(PropertyName = "buyerAddress2")]
        public string BuyerAddress2 { get; set; }
        public bool ShouldSerializeBuyerAddress2() { return !String.IsNullOrEmpty(BuyerAddress2); }

        [JsonProperty(PropertyName = "buyerCity")]
        public string BuyerCity { get; set; }
        public bool ShouldSerializeBuyerCity() { return !String.IsNullOrEmpty(BuyerCity); }

        [JsonProperty(PropertyName = "buyerState")]
        public string BuyerState { get; set; }
        public bool ShouldSerializeBuyerState() { return !String.IsNullOrEmpty(BuyerState); }

        [JsonProperty(PropertyName = "buyerZip")]
        public string BuyerZip { get; set; }
        public bool ShouldSerializeBuyerZip() { return !String.IsNullOrEmpty(BuyerZip); }

        [JsonProperty(PropertyName = "buyerCountry")]
        public string BuyerCountry { get; set; }
        public bool ShouldSerializeBuyerCountry() { return !String.IsNullOrEmpty(BuyerCountry); }

        [JsonProperty(PropertyName = "buyerEmail")]
        public string BuyerEmail { get; set; }
        public bool ShouldSerializeBuyerEmail() { return !String.IsNullOrEmpty(BuyerEmail); }

        [JsonProperty(PropertyName = "buyerPhone")]
        public string BuyerPhone { get; set; }
        public bool ShouldSerializeBuyerPhone() { return !String.IsNullOrEmpty(BuyerPhone); }

        // Response fields
        //

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public bool ShouldSerializeId() { return false; }

        [JsonProperty(PropertyName = "úrl")]
        public string Url { get; set; }
        public bool ShouldSerializeUrl() { return false; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        public bool ShouldSerializeStatus() { return false; }

        [JsonProperty(PropertyName = "invoiceTime")]
        public long InvoiceTime { get; set; }
        public bool ShouldSerializeInvoiceTime() { return false; }

        [JsonProperty(PropertyName = "expirationTime")]
        public long ExpirationTime { get; set; }
        public bool ShouldSerializeExpirationTime() { return false; }

        [JsonProperty(PropertyName = "currentTime")]
        public long CurrentTime { get; set; }
        public bool ShouldSerializeCurrentTime() { return false; }

        [JsonProperty(PropertyName = "btcPrice")]
        public double BtcPrice { get; set; }
        public bool ShouldSerializeBtcPrice() { return false; }

        [JsonProperty(PropertyName = "btcPaid")]
        public double BtcPaid { get; set; }
        public bool ShouldSerializeBtcPaid() { return false; }

        [JsonProperty(PropertyName = "btcDue")]
        public double BtcDue { get; set; }
        public bool ShouldSerializeBtcDue() { return false; }

        [JsonProperty(PropertyName = "transactions")]
        public List<InvoiceTransaction> Transactions { get; set; }
        public bool ShouldSerializeTransactions() { return false; }

        [JsonProperty(PropertyName = "rate")]
        public double Rate { get; set; }
        public bool ShouldSerializeRate() { return false; }

        [JsonProperty(PropertyName = "exRates")]
        public Dictionary<string, string> ExRates { get; set; }
        public bool ShouldSerializeExRates() { return false; }

        [JsonProperty(PropertyName = "exceptionStatus")]
        public string ExceptionStatus { get; set; }
        public bool ShouldSerializeExceptionStatus() { return false; }

        [JsonProperty(PropertyName = "paymentUrls")]
        public InvoicePaymentUrls PaymentUrls { get; set; }
        public bool ShouldSerializePaymentUrls() { return false; }

        public bool Refundable
        {
            get { return this.Flags.Refundable; }
        }
        public bool ShouldSerializeRefundable() { return false; }

        [JsonProperty(PropertyName = "flags")]
        private Flags Flags { get; set; }
        public bool ShouldSerializeFlags() { return false; }

        [JsonProperty(PropertyName = "refundAddressRequestPending")]
        public bool RefundAddressRequestPending { get; set; }

        [JsonProperty(PropertyName = "paymentSubtotals")]
        public Dictionary<string, long> PaymentSubtotals { get; set; }

        [JsonProperty(PropertyName = "paymentTotals")]
        public Dictionary<string, long> PaymentTotals { get; set; }

        [JsonProperty(PropertyName = "exchangeRates")]
        public ExchangeRates ExchangeRates { get; set; }

        [JsonProperty(PropertyName = "supportedTransactionCurrencies")]
        public Dictionary<string, SupportedTransactionCurrency> SupportedTransactionCurrencies { get; set; }

        [JsonProperty(PropertyName = "minerFees")]
        public Dictionary<string, MinerFee> MinerFees { get; set; }

        [JsonProperty(PropertyName = "paymentCodes")]
        public Dictionary<string, Dictionary<string, string>> PaymentCodes { get; set; }

        [JsonProperty(PropertyName = "lowFeeDetected")]
        public bool LowFeeDetected { get; set; }

        [JsonProperty(PropertyName = "amountPaid")]
        public long AmountPaid { get; set; }

        [JsonProperty(PropertyName = "buyerProvidedInfo")]
        public BuyerProvidedInfo BuyerProvidedInfo { get; set; }

        [JsonProperty(PropertyName = "transactionCurrency")]
        public string TransactionCurrency { get; set; }

        [JsonProperty(PropertyName = "refundInfo")]
        public RefundInfo RefundInfo { get; set; }

        [JsonProperty(PropertyName = "refundAddresses")]
        public Dictionary<string, RefundAddress>[] RefundAddresses { get; set; }

        [JsonProperty(PropertyName = "buyerProvidedEmail")]
        public string BuyerProvidedEmail { get; set; }

        [JsonProperty(PropertyName = "creditedOverpaymentAmounts")]
        public Dictionary<string, long> CreditedOverpaymentAmounts { get; set; }
    }

    public partial class ExchangeRates
    {
        [JsonProperty(PropertyName = "BTC")]
        public Dictionary<string, double> Btc { get; set; }

        [JsonProperty(PropertyName = "BCH")]
        public Dictionary<string, double> Bch { get; set; }
    }

    public partial class BuyerProvidedInfo
    {
        [JsonProperty(PropertyName = "selectedTransactionCurrency")]
        public string SelectedTransactionCurrency { get; set; }

        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }
    }

    public partial class RefundAddress
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTimeOffset Date { get; set; }
    }

    public partial class MinerFee
    {
        [JsonProperty(PropertyName = "satoshisPerByte")]
        public double SatoshisPerByte { get; set; }

        [JsonProperty(PropertyName = "totalFee")]
        public long TotalFee { get; set; }
    }

    public partial class SupportedTransactionCurrency
    {
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }
    }

    class Flags
    {
        [JsonProperty(PropertyName = "refundable")]
        public bool Refundable { get; set; }
    }
}
