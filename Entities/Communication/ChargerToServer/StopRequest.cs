using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ChargerToServer
{
    public class StopRequest : SocketRequest
    {
        [StringLength(100)]
        public string? ServerTransactionId { get; set; }

        [Required, StringLength(100)]
        public string ChargerTransactionId { get; set; }

        [Range(0, int.MaxValue)]
        public int? TotalChargingTime { get; set; }

        [Range(0, int.MaxValue)]
        public int? TotalParkingTime { get; set; }

        public StopReasonEnum? StopReason { get; set; }

    }

    public enum StopReasonEnum : byte
    {
        UnauthorizedAccess,         // Charging stopped due to de-authorization
        EmergencyShutdown,          // Emergency stop was triggered
        EnergyLimitReached,         // Energy limit for the session was reached
        VehicleDisconnected,        // EV was unplugged or disconnected
        GroundFaultDetected,        // Ground fault was detected by the system
        ImmediateRestartRequested,  // Charging stopped due to immediate reset request
        StoppedLocally,             // Manually stopped by user on the station
        CreditDepleted,             // User ran out of credit
        MasterCardOverride,         // Session overridden by master card/pass
        UnknownReason,              // Reason not specified or unclassified
        OvercurrentDetected,        // Charging stopped due to overcurrent
        PowerLost,                  // Station lost power
        PowerQualityIssue,          // Poor power quality triggered stop
        SystemReboot,               // Station rebooted during session
        StoppedRemotely,            // Remotely stopped via backend
        ChargeLevelReached,         // EV reached configured SoC limit
        VehicleRequestedStop,       // EV itself requested to stop charging
        TimeLimitReached,           // Maximum session duration reached
        SessionTimeout              // No activity; session timed out
    }


}
