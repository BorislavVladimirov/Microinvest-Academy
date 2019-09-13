using PhoneTask.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneTask.Models
{
    public class GSM
    {
        private string model;
        private string simMobileNumber;

        public GSM(string model)
        {
            Model = model;
        }

        #region Property
        public string Model
        {
            get => this.model;

            private set
            {
                if (this.model == value)
                {
                    return;
                }

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidModel);
                }

                this.model = value;
            }
        }

        public bool HasSimCard { get; private set; }

        public string SimMobileNumber
        {
            get => this.simMobileNumber;

            set
            {
                if (this.simMobileNumber == value)
                {
                    return;
                }

                if (!value.StartsWith("08") || value.Length != 10)
                {
                    throw new ArgumentException(GlobalConstants.InvalidSimNumber);
                }

                this.simMobileNumber = value;
            }
        }


        public double OutgoingCallsDuration { get; private set; }

        public Call LastIncomingCall { get; private set; }

        public Call LastOutgoingCall { get; private set; }
        #endregion

        #region Method
        public void InsertSimCard(string simMobileNumber)
        {
            this.SimMobileNumber = simMobileNumber;
            this.HasSimCard = true;

            this.OutgoingCallsDuration = 0;
        }

        public void RemoveSimCard()
        {
            if (this.HasSimCard)
            {
                this.HasSimCard = false;
            }
            else
            {
                throw new ArgumentException(GlobalConstants.InvalidSimRemove);
            }
        }

        public void Call(GSM receiver, double duration)
        {   
            if (duration < 0 || duration >= 60)
            {
                throw new ArgumentException(GlobalConstants.InvalidCallDuration);
            }

            if (this.SimMobileNumber == receiver.SimMobileNumber)
            {
                throw new ArgumentException(GlobalConstants.EqualNumbers);
            }

            if (!this.HasSimCard || !receiver.HasSimCard)
            {
                throw new ArgumentException(GlobalConstants.MissingSimCard);
            }

            Call call = new Call(receiver.SimMobileNumber, duration);

            call.Caller = this.SimMobileNumber;

            this.LastOutgoingCall = call;
            receiver.LastIncomingCall = call;

            this.OutgoingCallsDuration += duration;
        }

        public string GetSumForCall()
        {
            StringBuilder sb = new StringBuilder();

            string result = $"{((decimal)this.OutgoingCallsDuration * Models.Call.PriceForAMinute):f2}";

            return sb.AppendLine($"Текущата сметка на номер {this.simMobileNumber} е {result} лева").ToString();
        }

        public string PrintInfoForTheLastOutgoingCall()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Last outgoing call info:");
            sb.AppendLine($"Caller: {this.LastOutgoingCall.Caller}");
            sb.AppendLine($"Receiver: {this.LastOutgoingCall.Receiver}");
            sb.AppendLine($"Duration: {this.LastOutgoingCall.Duration:f2} minutes");

            return sb.ToString();
        }

        public string PrintInfoForTheLastIncomingCall()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Last incoming call info:");
            sb.AppendLine($"Caller: {this.LastIncomingCall.Caller}");
            sb.AppendLine($"Receiver: {this.LastIncomingCall.Receiver}");
            sb.AppendLine($"Duration: {this.LastIncomingCall.Duration:f2} minutes");

            return sb.ToString();
        }
        #endregion
    }
}
