// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran.Inputs
{

    public sealed class ConnectorConfigAdobeAnalyticsConfigurationGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("calculatedMetrics")]
        private InputList<string>? _calculatedMetrics;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `adobe_analytics`: The calculated_metrics that you want to sync.
        /// </summary>
        public InputList<string> CalculatedMetrics
        {
            get => _calculatedMetrics ?? (_calculatedMetrics = new InputList<string>());
            set => _calculatedMetrics = value;
        }

        [Input("elements")]
        private InputList<string>? _elements;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `adobe_analytics`: The elements that you want to sync.
        /// </summary>
        public InputList<string> Elements
        {
            get => _elements ?? (_elements = new InputList<string>());
            set => _elements = value;
        }

        [Input("metrics")]
        private InputList<string>? _metrics;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `adobe_analytics`: The metrics that you want to sync.
        /// </summary>
        public InputList<string> Metrics
        {
            get => _metrics ?? (_metrics = new InputList<string>());
            set => _metrics = value;
        }

        [Input("reportSuites")]
        private InputList<string>? _reportSuites;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `adobe_analytics`: Specific report suites to sync. Must be populated if `sync_mode` is set to `SpecificReportSuites`.
        /// </summary>
        public InputList<string> ReportSuites
        {
            get => _reportSuites ?? (_reportSuites = new InputList<string>());
            set => _reportSuites = value;
        }

        [Input("segments")]
        private InputList<string>? _segments;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `adobe_analytics`: The segments that you want to sync.
        /// </summary>
        public InputList<string> Segments
        {
            get => _segments ?? (_segments = new InputList<string>());
            set => _segments = value;
        }

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `adobe_analytics`: Whether to sync all report suites or specific report suites. Default value: `AllReportSuites` .
        /// </summary>
        [Input("syncMode")]
        public Input<string>? SyncMode { get; set; }

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `adobe_analytics`: The table name unique within the schema to which connector will sync the data. Required for connector creation.
        /// </summary>
        [Input("table")]
        public Input<string>? Table { get; set; }

        public ConnectorConfigAdobeAnalyticsConfigurationGetArgs()
        {
        }
        public static new ConnectorConfigAdobeAnalyticsConfigurationGetArgs Empty => new ConnectorConfigAdobeAnalyticsConfigurationGetArgs();
    }
}
