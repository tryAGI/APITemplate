
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace APITemplate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.Error? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccess? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessStatus? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessTemplate? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessPDFFile? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::APITemplate.ResponseSuccessPDFFilePostAction>? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessPDFFilePostAction? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessCreatePDF? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessCreatePDFVariant2? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessCreatePDFVariant2EinvoiceValidationStatus? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessImageFile? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::APITemplate.ResponseSuccessImageFilePostAction>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessImageFilePostAction? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessListTemplates? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::APITemplate.ResponseSuccessListTemplatesTemplate>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessListTemplatesTemplate? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessListObjects? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessDeleteObject? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessAccountInformation? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessSingleFile? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessQueryImageTemplate? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.PDFGenerationSettingsObject? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.CreatePdfRequest? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.CreatePdfFromHtmlRequest? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.CreatePdfFromUrlRequest? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.CreatePdfFromMarkdownRequest? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.UpdateTemplateRequest? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.UpdateTemplateRequestSettings? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.MergePdfsRequest? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.CreatePdfEinvoiceFormat? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.CreatePdfEinvoiceProfile? Type36 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::APITemplate.ResponseSuccessPDFFilePostAction>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::APITemplate.ResponseSuccessImageFilePostAction>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::APITemplate.ResponseSuccessListTemplatesTemplate>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType3 { get; set; }
    }
}