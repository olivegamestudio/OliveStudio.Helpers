using System;

namespace Utility;

/// <summary>
/// Provides access to time-related functionality.
/// </summary>
public static class Time
{
    /// <summary>
    /// Gets or sets the time that has elapsed since the last frame or update.
    /// </summary>
    public static TimeSpan DeltaTime { get; set; }
}
