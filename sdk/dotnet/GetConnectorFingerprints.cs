// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran
{
    public static class GetConnectorFingerprints
    {
        /// <summary>
        /// This data source returns a list of SSH fingerprints approved for specified connector.
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Fivetran = Pulumi.Fivetran;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var connectorFingerprints = Fivetran.GetConnectorFingerprints.Invoke(new()
        ///     {
        ///         Id = "connector_id",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetConnectorFingerprintsResult> InvokeAsync(GetConnectorFingerprintsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetConnectorFingerprintsResult>("fivetran:index/getConnectorFingerprints:getConnectorFingerprints", args ?? new GetConnectorFingerprintsArgs(), options.WithDefaults());

        /// <summary>
        /// This data source returns a list of SSH fingerprints approved for specified connector.
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Fivetran = Pulumi.Fivetran;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var connectorFingerprints = Fivetran.GetConnectorFingerprints.Invoke(new()
        ///     {
        ///         Id = "connector_id",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetConnectorFingerprintsResult> Invoke(GetConnectorFingerprintsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetConnectorFingerprintsResult>("fivetran:index/getConnectorFingerprints:getConnectorFingerprints", args ?? new GetConnectorFingerprintsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetConnectorFingerprintsArgs : global::Pulumi.InvokeArgs
    {
        [Input("fingerprints")]
        private List<Inputs.GetConnectorFingerprintsFingerprintArgs>? _fingerprints;
        public List<Inputs.GetConnectorFingerprintsFingerprintArgs> Fingerprints
        {
            get => _fingerprints ?? (_fingerprints = new List<Inputs.GetConnectorFingerprintsFingerprintArgs>());
            set => _fingerprints = value;
        }

        /// <summary>
        /// The unique identifier for the resource. Equal to target connection id.
        /// </summary>
        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        public GetConnectorFingerprintsArgs()
        {
        }
        public static new GetConnectorFingerprintsArgs Empty => new GetConnectorFingerprintsArgs();
    }

    public sealed class GetConnectorFingerprintsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("fingerprints")]
        private InputList<Inputs.GetConnectorFingerprintsFingerprintInputArgs>? _fingerprints;
        public InputList<Inputs.GetConnectorFingerprintsFingerprintInputArgs> Fingerprints
        {
            get => _fingerprints ?? (_fingerprints = new InputList<Inputs.GetConnectorFingerprintsFingerprintInputArgs>());
            set => _fingerprints = value;
        }

        /// <summary>
        /// The unique identifier for the resource. Equal to target connection id.
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        public GetConnectorFingerprintsInvokeArgs()
        {
        }
        public static new GetConnectorFingerprintsInvokeArgs Empty => new GetConnectorFingerprintsInvokeArgs();
    }


    [OutputType]
    public sealed class GetConnectorFingerprintsResult
    {
        /// <summary>
        /// The unique identifier for the target connection within the Fivetran system.
        /// </summary>
        public readonly string ConnectorId;
        public readonly ImmutableArray<Outputs.GetConnectorFingerprintsFingerprintResult> Fingerprints;
        /// <summary>
        /// The unique identifier for the resource. Equal to target connection id.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetConnectorFingerprintsResult(
            string connectorId,

            ImmutableArray<Outputs.GetConnectorFingerprintsFingerprintResult> fingerprints,

            string id)
        {
            ConnectorId = connectorId;
            Fingerprints = fingerprints;
            Id = id;
        }
    }
}
