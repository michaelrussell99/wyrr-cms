//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PENPAL.DataStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class logTransactionDetail
    {
        public long TxnLogID { get; set; }
        public string TxnID { get; set; }
        public string TxnType { get; set; }
        public long UserID { get; set; }
        public string SenderAddress { get; set; }
        public string ReceiverAddress { get; set; }
        public decimal AmountGiven { get; set; }
        public string CurrencyGiven { get; set; }
        public decimal AmountReceived { get; set; }
        public string CurrencyReceived { get; set; }
        public string PaypalMargin { get; set; }
        public Nullable<decimal> PaypalMarginAmt { get; set; }
        public string PaypalClientMargin { get; set; }
        public Nullable<decimal> PaypalClientMarginAmt { get; set; }
        public string ChangellyMargin { get; set; }
        public Nullable<decimal> ChangellyMarginAmt { get; set; }
        public string ChangellyClientMargin { get; set; }
        public Nullable<decimal> ChangellyClientMarginAmt { get; set; }
        public string TxnStatus { get; set; }
        public System.DateTime TxnDate { get; set; }
        public Nullable<decimal> LumeninUSD { get; set; }
        public string CoinbaseMargin { get; set; }
        public Nullable<decimal> CoinbaseMarginAmt { get; set; }
        public string CoinbaseClientMargin { get; set; }
        public Nullable<decimal> CoinbaseClientMarginAmt { get; set; }
        public string Memo { get; set; }
    }
}
