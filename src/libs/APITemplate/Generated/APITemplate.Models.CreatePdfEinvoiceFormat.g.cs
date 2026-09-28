
#nullable enable

namespace APITemplate
{
    /// <summary>
    ///
    /// </summary>
    public enum CreatePdfEinvoiceFormat
    {
        /// <summary>
        ///
        /// </summary>
        Fx,
        /// <summary>
        ///
        /// </summary>
        Zf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePdfEinvoiceFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePdfEinvoiceFormat value)
        {
            return value switch
            {
                CreatePdfEinvoiceFormat.Fx => "fx",
                CreatePdfEinvoiceFormat.Zf => "zf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePdfEinvoiceFormat? ToEnum(string value)
        {
            return value switch
            {
                "fx" => CreatePdfEinvoiceFormat.Fx,
                "zf" => CreatePdfEinvoiceFormat.Zf,
                _ => null,
            };
        }
    }
}