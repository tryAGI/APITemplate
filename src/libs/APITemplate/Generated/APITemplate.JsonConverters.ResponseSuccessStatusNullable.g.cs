#nullable enable

namespace APITemplate.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponseSuccessStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::APITemplate.ResponseSuccessStatus?>
    {
        /// <inheritdoc />
        public override global::APITemplate.ResponseSuccessStatus? Read(
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
                        return global::APITemplate.ResponseSuccessStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::APITemplate.ResponseSuccessStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::APITemplate.ResponseSuccessStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::APITemplate.ResponseSuccessStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::APITemplate.ResponseSuccessStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
