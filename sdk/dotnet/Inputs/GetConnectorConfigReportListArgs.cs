// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran.Inputs
{

    public sealed class GetConnectorConfigReportListInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `spotify_ads`: The dimension (entity_type) to sync.
        /// </summary>
        [Input("dimension", required: true)]
        public Input<string> Dimension { get; set; } = null!;

        [Input("fields", required: true)]
        private InputList<string>? _fields;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `spotify_ads`: A list of the fields (metrics) to sync.
        /// </summary>
        public InputList<string> Fields
        {
            get => _fields ?? (_fields = new InputList<string>());
            set => _fields = value;
        }

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `spotify_ads`: The report granularity.
        /// </summary>
        [Input("granularity", required: true)]
        public Input<string> Granularity { get; set; } = null!;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `spotify_ads`: The table name within the schema to which connector will sync the data of the specific report.
        /// </summary>
        [Input("table", required: true)]
        public Input<string> Table { get; set; } = null!;

        public GetConnectorConfigReportListInputArgs()
        {
        }
        public static new GetConnectorConfigReportListInputArgs Empty => new GetConnectorConfigReportListInputArgs();
    }
}
