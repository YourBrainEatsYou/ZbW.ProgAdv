using System;

namespace OverridingEquals {
    public class PhoneNumber {
        // First part of a phone number: (XXX) 000-0000
        public string AreaCode { get; set; }

        // Second part of a phone number: (000) XXX-0000
        public string Exchange { get; set; }

        // Third part of a phone number: (000) 000-XXXX
        public string SubscriberNumber { get; set; }

        // TODO: Implement Equals 
        public override bool Equals(object? obj)
        {
            if (obj is not PhoneNumber other)
            {
                return false;
            }

            return AreaCode == other.AreaCode &&
                   Exchange == other.Exchange &&
                   SubscriberNumber == other.SubscriberNumber;
        }

        public static bool operator ==(PhoneNumber? left, PhoneNumber? right)
        {
            if (left is null || right is null)
            {
               return left is null && right is null;
            }
            return left.Equals(right);
        }

        public static bool operator !=(PhoneNumber? left, PhoneNumber? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AreaCode, Exchange, SubscriberNumber);
        }
    }
}