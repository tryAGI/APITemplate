#nullable enable

namespace APITemplate.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponseSuccessCreatePDFVariant2EinvoiceValidationStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::APITemplate.ResponseSuccessCreatePDFVariant2EinvoiceValidationStatus>
    {
        /// <inheritdoc />
        public override global::APITemplate.ResponseSuccessCreatePDFVariant2EinvoiceValidationStatus Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::APITemplate.ResponseSuccessCreatePDFVariant2EinvoiceValidationStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::APITemplate.ResponseSuccessCreatePDFVariant2EinvoiceValidationStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::APITemplate.ResponseSuccessCreatePDFVariant2EinvoiceValidationStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::APITemplate.ResponseSuccessCreatePDFVariant2EinvoiceValidationStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::APITemplate.ResponseSuccessCreatePDFVariant2EinvoiceValidationStatusExtensions.ToValueString(value));
        }
    }
}
