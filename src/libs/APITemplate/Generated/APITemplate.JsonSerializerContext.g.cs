
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace APITemplate
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::APITemplate.JsonConverters.ResponseSuccessStatusJsonConverter),

            typeof(global::APITemplate.JsonConverters.ResponseSuccessStatusNullableJsonConverter),

            typeof(global::APITemplate.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.ResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.ResponseSuccessStatus), TypeInfoPropertyName = "ResponseSuccessStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.ResponseSuccessTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.ResponseSuccessPDFFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::APITemplate.ResponseSuccessPDFFilePostAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.ResponseSuccessPDFFilePostAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.ResponseSuccessImageFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::APITemplate.ResponseSuccessImageFilePostAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.ResponseSuccessImageFilePostAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.ResponseSuccessListTemplates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::APITemplate.ResponseSuccessListTemplatesTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.ResponseSuccessListTemplatesTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.ResponseSuccessListObjects))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::APITemplate.ResponseSuccessListObjectsObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.ResponseSuccessListObjectsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.ResponseSuccessDeleteObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.ResponseSuccessAccountInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.ResponseSuccessSingleFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.ResponseSuccessQueryImageTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.PDFGenerationSettingsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.CreatePdfFromHtmlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.CreatePdfFromUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.CreatePdfFromMarkdownRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.UpdateTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.UpdateTemplateRequestSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::APITemplate.MergePdfsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::APITemplate.ResponseSuccessPDFFilePostAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::APITemplate.ResponseSuccessImageFilePostAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::APITemplate.ResponseSuccessListTemplatesTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::APITemplate.ResponseSuccessListObjectsObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}