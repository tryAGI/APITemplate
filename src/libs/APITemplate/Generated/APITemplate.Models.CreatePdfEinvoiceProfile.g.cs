
#nullable enable

namespace APITemplate
{
    /// <summary>
    ///
    /// </summary>
    public enum CreatePdfEinvoiceProfile
    {
        /// <summary>
        /// `BASIC`, `COMFORT`, `EXTENDED`.
        /// </summary>
        Basic,
        /// <summary>
        /// `MINIMUM`, `BASICWL`, `BASIC`, `EN16931`, `EXTENDED-CTC-FR`, `EXTENDED`, `XRECHNUNG`.
        /// </summary>
        Basicwl,
        /// <summary>
        /// `BASIC`, `COMFORT`, `EXTENDED`.
        /// </summary>
        Comfort,
        /// <summary>
        ///
        /// </summary>
        En16931,
        /// <summary>
        /// `BASIC`, `COMFORT`, `EXTENDED`.
        /// </summary>
        Extended,
        /// <summary>
        /// `MINIMUM`, `BASICWL`, `BASIC`, `EN16931`, `EXTENDED-CTC-FR`, `EXTENDED`, `XRECHNUNG`.
        /// </summary>
        ExtendedCtcFr,
        /// <summary>
        /// `MINIMUM`, `BASICWL`, `BASIC`, `EN16931`, `EXTENDED-CTC-FR`, `EXTENDED`, `XRECHNUNG`.
        /// </summary>
        Minimum,
        /// <summary>
        /// `MINIMUM`, `BASICWL`, `BASIC`, `EN16931`, `EXTENDED-CTC-FR`, `EXTENDED`, `XRECHNUNG`.
        /// </summary>
        Xrechnung,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePdfEinvoiceProfileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePdfEinvoiceProfile value)
        {
            return value switch
            {
                CreatePdfEinvoiceProfile.Basic => "BASIC",
                CreatePdfEinvoiceProfile.Basicwl => "BASICWL",
                CreatePdfEinvoiceProfile.Comfort => "COMFORT",
                CreatePdfEinvoiceProfile.En16931 => "EN16931",
                CreatePdfEinvoiceProfile.Extended => "EXTENDED",
                CreatePdfEinvoiceProfile.ExtendedCtcFr => "EXTENDED-CTC-FR",
                CreatePdfEinvoiceProfile.Minimum => "MINIMUM",
                CreatePdfEinvoiceProfile.Xrechnung => "XRECHNUNG",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePdfEinvoiceProfile? ToEnum(string value)
        {
            return value switch
            {
                "BASIC" => CreatePdfEinvoiceProfile.Basic,
                "BASICWL" => CreatePdfEinvoiceProfile.Basicwl,
                "COMFORT" => CreatePdfEinvoiceProfile.Comfort,
                "EN16931" => CreatePdfEinvoiceProfile.En16931,
                "EXTENDED" => CreatePdfEinvoiceProfile.Extended,
                "EXTENDED-CTC-FR" => CreatePdfEinvoiceProfile.ExtendedCtcFr,
                "MINIMUM" => CreatePdfEinvoiceProfile.Minimum,
                "XRECHNUNG" => CreatePdfEinvoiceProfile.Xrechnung,
                _ => null,
            };
        }
    }
}