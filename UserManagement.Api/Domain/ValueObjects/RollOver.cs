using UserManagement.API.Domain.Common;

namespace UserManagement.Api.Domain.ValueObjects
{
    public class RollOver : AuditableEntity
    {
        public bool IsEnabled { get; set; }
        public byte Type { get; set; }
        public int Frequency { get; set; }
        public int GracePeriod { get; set; }
        public Guid? ChargeId { get; set; }
        public RollOver(bool isEnabled, byte type, byte frequency, int gracePeriod, Guid? chargeId)
        {
            IsEnabled = isEnabled;
            Type = type;
            Frequency = frequency;
            GracePeriod = gracePeriod;
            ChargeId = chargeId;
        }
    }
}