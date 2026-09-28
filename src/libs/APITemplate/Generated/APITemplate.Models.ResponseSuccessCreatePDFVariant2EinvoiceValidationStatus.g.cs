
#nullable enable

namespace APITemplate
{
    /// <summary>
    /// Overall ZUGFeRD/Factur-X validation status. Only returned when `einvoice=true`, `einvoice_validate=true` and `export_type=json` on a synchronous request.<br/>
    /// Example: valid
    /// </summary>
    public enum ResponseSuccessCreatePDFVariant2EinvoiceValidationStatus
    {
        /// <summary>
        ///
        /// </summary>
        Invalid,
        /// <summary>
        ///
        /// </summary>
        Valid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSuccessCreatePDFVariant2EinvoiceValidationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSuccessCreatePDFVariant2EinvoiceValidationStatus value)
        {
            return value switch
            {
                ResponseSuccessCreatePDFVariant2EinvoiceValidationStatus.Invalid => "invalid",
                ResponseSuccessCreatePDFVariant2EinvoiceValidationStatus.Valid => "valid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSuccessCreatePDFVariant2EinvoiceValidationStatus? ToEnum(string value)
        {
            return value switch
            {
                "invalid" => ResponseSuccessCreatePDFVariant2EinvoiceValidationStatus.Invalid,
                "valid" => ResponseSuccessCreatePDFVariant2EinvoiceValidationStatus.Valid,
                _ => null,
            };
        }
    }
}