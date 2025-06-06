﻿namespace Entities.Communication.Common
{
    public enum UnitEnum : byte
    {
        A, // Amperes (current)
        ASU, // Arbitrary Strength Unit (Signal Strength)
        B, // Bytes
        Celsius, // Degrees (temperature)
        dB, // Decibel (for example Signal Strength)
        dBm, // Power relative to 1mW (10log(P/1mW))
        Deg, // Degrees (angle/rotation)
        Fahrenheit, // Degrees (temperature)
        Hz, // Hertz (frequency)
        K, // Degrees Kelvin (temperature)
        lx, // Lux (Light Intensity)
        m, // Meter (length)
        ms2, // m/s2 (Acceleration)
        N, // Newtons (Force)
        Ohm, // Ohm (Impedance)
        kPa, // kiloPascal (Pressure)
        Percent, // Percentage
        RH, // Relative Humidity%
        RPM, // Revolutions per Minute
        s, // Seconds (Time)
        V, // Voltage (DC or r.m.s. AC)
        VA, // Volt-Ampere (apparent power)
        kVA, // kiloVolt-Ampere (apparent power)
        VAh, // Volt-Ampere-hours (apparent energy)
        kVAh, // kiloVolt-Ampere-hours (apparent energy)
        var, // vars (reactive power)
        kvar, // kilovars (reactive power)
        varh, // var-hours (reactive energy)
        kvarh, // kilovar-hours (reactive energy)
        W, // Watts (power)
        kW, // kilowatts (power)
        Wh, // Watt-hours (energy). Default
        kWh  // kilowatt-hours (energy)
    }
}
