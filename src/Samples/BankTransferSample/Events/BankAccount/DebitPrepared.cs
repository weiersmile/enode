﻿using System;
using ENode.Eventing;

namespace BankTransferSample.Events
{
    /// <summary>交易预转出成功
    /// </summary>
    [Serializable]
    public class DebitPrepared  : DomainEvent<string>, ISourcingEvent
    {
        public Guid TransactionId { get; private set; }
        public double Amount { get; private set; }

        public DebitPrepared(string accountId, Guid transactionId, double amount) : base(accountId)
        {
            TransactionId = transactionId;
            Amount = amount;
        }
    }
}