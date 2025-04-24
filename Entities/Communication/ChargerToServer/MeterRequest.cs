using Entities.Communication.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities.Communication.ChargerToServer
{
    public class MeterRequest : SocketRequest
    {
        [StringLength(100)]
        public string? ServerTransactionId { get; set; }

        [StringLength(100)]
        public string? ChargerTransactionId { get; set; }

        /// <summary>
        /// ID of the EVSE (Electric Vehicle Supply Equipment)
        /// </summary>
        [Range(1, byte.MaxValue)]
        public byte? EvseId { get; set; }

        /// <summary>
        /// Optional ID of a specific connector within the EVSE
        /// </summary>

        [Range(1, byte.MaxValue)]
        public byte? ConnectorId { get; set; }

        [Range(1, int.MaxValue)]
        public int? RunningNumber { get; set; }

        [Required, MinLength(1)]
        public List<Meter> Meters { get; set; }


    }

    public class Meter
    {
        public Dictionary<string, object>? Extend { get; set; }

        [Required]
        public DateTime? TimeStamp { get; set; }

        [Required]
        public decimal? Val { get; set; }

        [Required]
        public UnitEnum? Unit { get; set; }

        [Required]
        public EventTypeEnum? EventType { get; set; } = EventTypeEnum.MeterTransaction;

        public MeterTypeEnum? MeterType { get; set; } = MeterTypeEnum.ActiveEnergyInRegister;
        public PhaseEnum? Phase { get; set; }
        public LocationEnum? Location { get; set; } = LocationEnum.Outlet;
    }

    public enum EventTypeEnum : byte
    {
        StartTransaction,
        StopTransaction,
        MeterTransaction,
        MeterInterval,
        StartInterruption,
        StopInterruption,
        Trigger,
        Other
    }
    public enum LocationEnum : byte
    {
        Body,
        Cable,
        EV,
        Inlet,
        Outlet,
    }
    public enum PhaseEnum : byte
    {
        L1, // phase 1

        L2, // phase 2

        L3, // phase 3

        N, // Neutral - grounding wire 

        // A connection between phase L1 and the neutral. Useful for single-phase voltage measurement in a three-phase electrical system.
        L1N,

        //A connection between phase L2 and the neutral. Similar to L1N but for the second phase.
        L2N,

        //A connection between phase L3 and the neutral.
        L3N,

        //A connection between phase L1 and phase L2. Used for three-phase measurement or to analyze the voltage between phases.
        L1L2,

        //A connection between phase L2 and phase L3.
        L2L3,

        //A connection between phase L3 and phase L1.
        L3L1,
    }


    public enum MeterTypeEnum : byte
    {
        // Current (Amps)
        CurrentOut,                      // Instantaneous current from EV to grid
        CurrentIn,                       // Instantaneous current from grid to EV
        CurrentOffered,                  // Maximum current offered to EV

        // Active Energy (Wh or kWh)
        ActiveEnergyOutRegister,         // Cumulative active energy sent to grid
        ActiveEnergyInRegister,          // Cumulative active energy received from grid
        ActiveEnergyOutInterval,         // Active energy sent to grid during interval
        ActiveEnergyInInterval,          // Active energy received from grid during interval
        ActiveEnergyNet,                 // Net active energy

        // Reactive Energy (varh or kvarh)
        ReactiveEnergyOutRegister,       // Cumulative reactive energy sent to grid
        ReactiveEnergyInRegister,        // Cumulative reactive energy received from grid
        ReactiveEnergyOutInterval,       // Reactive energy sent to grid during interval
        ReactiveEnergyInInterval,        // Reactive energy received from grid during interval
        ReactiveEnergyNet,               // Net reactive energy

        // Apparent Energy (VAh or kVAh)
        ApparentEnergyOut,               // Cumulative apparent energy sent to grid
        ApparentEnergyIn,                // Cumulative apparent energy received from grid
        ApparentEnergyNet,               // Net apparent energy

        // Power and Voltage
        ActivePowerOut,                  // Instantaneous active power sent to grid (W or kW)
        ActivePowerIn,                   // Instantaneous active power received from grid (W or kW)
        ReactivePowerOut,                // Instantaneous reactive power sent to grid (var or kvar)
        ReactivePowerIn,                 // Instantaneous reactive power received from grid (var or kvar)
        PowerOffered,                    // Maximum power offered to EV
        PowerFactor,                     // Instantaneous power factor
        Voltage,                         // Instantaneous voltage (AC or DC RMS)

        // Other
        Frequency,                       // Instantaneous line frequency (Hz)
        StateOfCharge                    // EV battery state of charge (%)
    }


}
