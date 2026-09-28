#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace APITemplate
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ResponseSuccessCreatePDF : global::System.IEquatable<ResponseSuccessCreatePDF>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::APITemplate.ResponseSuccessPDFFile? File { get; init; }
#else
        public global::APITemplate.ResponseSuccessPDFFile? File { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::APITemplate.ResponseSuccessPDFFile? value)
        {
            value = File;
            return IsFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessPDFFile PickFile() => File is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'File' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::APITemplate.ResponseSuccessCreatePDFVariant2? ResponseSuccessCreatePDFVariant2 { get; init; }
#else
        public global::APITemplate.ResponseSuccessCreatePDFVariant2? ResponseSuccessCreatePDFVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseSuccessCreatePDFVariant2))]
#endif
        public bool IsResponseSuccessCreatePDFVariant2 => ResponseSuccessCreatePDFVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseSuccessCreatePDFVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::APITemplate.ResponseSuccessCreatePDFVariant2? value)
        {
            value = ResponseSuccessCreatePDFVariant2;
            return IsResponseSuccessCreatePDFVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::APITemplate.ResponseSuccessCreatePDFVariant2 PickResponseSuccessCreatePDFVariant2() => ResponseSuccessCreatePDFVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseSuccessCreatePDFVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseSuccessCreatePDF(global::APITemplate.ResponseSuccessPDFFile value) => new ResponseSuccessCreatePDF((global::APITemplate.ResponseSuccessPDFFile?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::APITemplate.ResponseSuccessPDFFile?(ResponseSuccessCreatePDF @this) => @this.File;

        /// <summary>
        ///
        /// </summary>
        public ResponseSuccessCreatePDF(global::APITemplate.ResponseSuccessPDFFile? value)
        {
            File = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseSuccessCreatePDF FromFile(global::APITemplate.ResponseSuccessPDFFile? value) => new ResponseSuccessCreatePDF(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseSuccessCreatePDF(global::APITemplate.ResponseSuccessCreatePDFVariant2 value) => new ResponseSuccessCreatePDF((global::APITemplate.ResponseSuccessCreatePDFVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::APITemplate.ResponseSuccessCreatePDFVariant2?(ResponseSuccessCreatePDF @this) => @this.ResponseSuccessCreatePDFVariant2;

        /// <summary>
        ///
        /// </summary>
        public ResponseSuccessCreatePDF(global::APITemplate.ResponseSuccessCreatePDFVariant2? value)
        {
            ResponseSuccessCreatePDFVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseSuccessCreatePDF FromResponseSuccessCreatePDFVariant2(global::APITemplate.ResponseSuccessCreatePDFVariant2? value) => new ResponseSuccessCreatePDF(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseSuccessCreatePDF(
            global::APITemplate.ResponseSuccessPDFFile? file,
            global::APITemplate.ResponseSuccessCreatePDFVariant2? responseSuccessCreatePDFVariant2
            )
        {
            File = file;
            ResponseSuccessCreatePDFVariant2 = responseSuccessCreatePDFVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ResponseSuccessCreatePDFVariant2 as object ??
            File as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            File?.ToString() ??
            ResponseSuccessCreatePDFVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFile && IsResponseSuccessCreatePDFVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::APITemplate.ResponseSuccessPDFFile, TResult>? file = null,
            global::System.Func<global::APITemplate.ResponseSuccessCreatePDFVariant2, TResult>? responseSuccessCreatePDFVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (File is { } __value0 && file != null)
            {
                return file(__value0);
            }
            else if (ResponseSuccessCreatePDFVariant2 is { } __value1 && responseSuccessCreatePDFVariant2 != null)
            {
                return responseSuccessCreatePDFVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::APITemplate.ResponseSuccessPDFFile>? file = null,

            global::System.Action<global::APITemplate.ResponseSuccessCreatePDFVariant2>? responseSuccessCreatePDFVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (File is { } __value0)
            {
                file?.Invoke(__value0);
            }
            else if (ResponseSuccessCreatePDFVariant2 is { } __value1)
            {
                responseSuccessCreatePDFVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::APITemplate.ResponseSuccessPDFFile>? file = null,
            global::System.Action<global::APITemplate.ResponseSuccessCreatePDFVariant2>? responseSuccessCreatePDFVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (File is { } __value0)
            {
                file?.Invoke(__value0);
            }
            else if (ResponseSuccessCreatePDFVariant2 is { } __value1)
            {
                responseSuccessCreatePDFVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                File,
                typeof(global::APITemplate.ResponseSuccessPDFFile),
                ResponseSuccessCreatePDFVariant2,
                typeof(global::APITemplate.ResponseSuccessCreatePDFVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ResponseSuccessCreatePDF other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::APITemplate.ResponseSuccessPDFFile?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::APITemplate.ResponseSuccessCreatePDFVariant2?>.Default.Equals(ResponseSuccessCreatePDFVariant2, other.ResponseSuccessCreatePDFVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseSuccessCreatePDF obj1, ResponseSuccessCreatePDF obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseSuccessCreatePDF>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseSuccessCreatePDF obj1, ResponseSuccessCreatePDF obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseSuccessCreatePDF o && Equals(o);
        }
    }
}
