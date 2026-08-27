
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// Status<br/>
    /// Example: success
    /// </summary>
    public enum ResponseSuccessStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSuccessStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSuccessStatus value)
        {
            return value switch
            {
                ResponseSuccessStatus.Error => "error",
                ResponseSuccessStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSuccessStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ResponseSuccessStatus.Error,
                "success" => ResponseSuccessStatus.Success,
                _ => null,
            };
        }
    }
}