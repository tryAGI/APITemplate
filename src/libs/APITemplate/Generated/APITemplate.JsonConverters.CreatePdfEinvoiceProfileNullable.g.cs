#nullable enable

namespace APITemplate.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreatePdfEinvoiceProfileNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::APITemplate.CreatePdfEinvoiceProfile?>
    {
        /// <inheritdoc />
        public override global::APITemplate.CreatePdfEinvoiceProfile? Read(
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
                        return global::APITemplate.CreatePdfEinvoiceProfileExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::APITemplate.CreatePdfEinvoiceProfile)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::APITemplate.CreatePdfEinvoiceProfile?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::APITemplate.CreatePdfEinvoiceProfile? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::APITemplate.CreatePdfEinvoiceProfileExtensions.ToValueString(value.Value));
            }
        }
    }
}
