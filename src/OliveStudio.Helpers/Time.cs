﻿using System;

namespace OliveStudio;

/// <summary>
/// Provides access to time-related functionality.
/// </summary>
public static class Time
{
    /// <summary>
    /// Gets or sets the time that has elapsed since the last frame or update.
    /// </summary>
    public static TimeSpan DeltaTime { get; set; }

    /// <summary>
    /// Gets the adjusted time that has elapsed since the last frame or update.
    /// </summary>
    public static TimeSpan AdjustedDeltaTime => new TimeSpan((long)(DeltaTime.Ticks * Speed));

    public static float Speed { get; set; } = 1.0f;
}
