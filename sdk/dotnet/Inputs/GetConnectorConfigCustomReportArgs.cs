// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran.Inputs
{

    public sealed class GetConnectorConfigCustomReportInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `snapchat_ads`: Add fields for separate \"swipe-up\" and \"view\" variants of selected metrics
        /// </summary>
        [Input("addMetricVariants", required: true)]
        public Input<bool> AddMetricVariants { get; set; } = null!;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `tiktok_ads`: Time aggregation of report
        /// </summary>
        [Input("aggregate", required: true)]
        public Input<string> Aggregate { get; set; } = null!;

        [Input("baseMetricsFields", required: true)]
        private InputList<string>? _baseMetricsFields;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `snapchat_ads`: [List of Core, Additional and Conversion Metrics Stats Fields](https://fivetran.com/docs/connectors/applications/snapchat-ads/custom-reports#basemetricsfields).
        /// </summary>
        public InputList<string> BaseMetricsFields
        {
            get => _baseMetricsFields ?? (_baseMetricsFields = new InputList<string>());
            set => _baseMetricsFields = value;
        }

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `snapchat_ads`: [Sets Breakdown on custom report](https://fivetran.com/docs/connectors/applications/snapchat-ads/custom-reports#breakdown).
        /// </summary>
        [Input("breakdown", required: true)]
        public Input<string> Breakdown { get; set; } = null!;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `snapchat_ads`: [Sets Breakout on custom report](https://fivetran.com/docs/connectors/applications/snapchat-ads/custom-reports#breakout).
        /// </summary>
        [Input("breakout", required: true)]
        public Input<string> Breakout { get; set; } = null!;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `reddit_ads`: The boolean value specifying whether to enable or disable event conversions data synchronisation. Default value: `false`
        /// </summary>
        [Input("conversionsReportIncluded", required: true)]
        public Input<bool> ConversionsReportIncluded { get; set; } = null!;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `reddit_ads`: The boolean value specifying whether the custom events are included in event conversions report. Default value: `false`
        /// </summary>
        [Input("customEventsIncluded", required: true)]
        public Input<bool> CustomEventsIncluded { get; set; } = null!;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `snapchat_ads`: [Sets Dimension on custom report](https://fivetran.com/docs/connectors/applications/snapchat-ads/custom-reports#dimension).
        /// </summary>
        [Input("dimension", required: true)]
        public Input<string> Dimension { get; set; } = null!;

        [Input("dimensions", required: true)]
        private InputList<string>? _dimensions;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `tiktok_ads`: Dimensions to synced
        /// </summary>
        public InputList<string> Dimensions
        {
            get => _dimensions ?? (_dimensions = new InputList<string>());
            set => _dimensions = value;
        }

        [Input("eventNames", required: true)]
        private InputList<string>? _eventNames;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `reddit_ads`: The list of events the conversion data will be synchronised for
        /// </summary>
        public InputList<string> EventNames
        {
            get => _eventNames ?? (_eventNames = new InputList<string>());
            set => _eventNames = value;
        }

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `snapchat_ads`: [Sets Granularity on custom report](https://fivetran.com/docs/connectors/applications/snapchat-ads/customr-reports#granularity).
        /// </summary>
        [Input("granularity", required: true)]
        public Input<string> Granularity { get; set; } = null!;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `reddit_ads`: Level of custom report.
        /// </summary>
        [Input("level", required: true)]
        public Input<string> Level { get; set; } = null!;

        [Input("metrics", required: true)]
        private InputList<string>? _metrics;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `tiktok_ads`: Metrics to be synced
        /// </summary>
        public InputList<string> Metrics
        {
            get => _metrics ?? (_metrics = new InputList<string>());
            set => _metrics = value;
        }

        [Input("reportFields", required: true)]
        private InputList<string>? _reportFields;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `reddit_ads`: The list of fields included in custom report
        /// </summary>
        public InputList<string> ReportFields
        {
            get => _reportFields ?? (_reportFields = new InputList<string>());
            set => _reportFields = value;
        }

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `reddit_ads`: The table name within the schema to which connector syncs the data of the specific report.
        /// 	- Service `snapchat_ads`: Custom report name (must be unique)
        /// </summary>
        [Input("reportName", required: true)]
        public Input<string> ReportName { get; set; } = null!;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `tiktok_ads`: Type of report to be generated
        /// </summary>
        [Input("reportType", required: true)]
        public Input<string> ReportType { get; set; } = null!;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `reddit_ads`: Level of custom report.
        /// </summary>
        [Input("segmentation", required: true)]
        public Input<string> Segmentation { get; set; } = null!;

        [Input("skAdMetricsFields", required: true)]
        private InputList<string>? _skAdMetricsFields;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `snapchat_ads`: [List of SKAd  Metrics fields in custom report](https://fivetran.com/docs/connectors/applications/snapchat-ads/custom-reports#skadmetricsfields).
        /// </summary>
        public InputList<string> SkAdMetricsFields
        {
            get => _skAdMetricsFields ?? (_skAdMetricsFields = new InputList<string>());
            set => _skAdMetricsFields = value;
        }

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `tiktok_ads`: Destination Table name of report
        /// </summary>
        [Input("tableName", required: true)]
        public Input<string> TableName { get; set; } = null!;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `reddit_ads`: The specific time zone to sync report data if  `useAccountTimeZone` set to `false`.
        /// </summary>
        [Input("timeZone", required: true)]
        public Input<string> TimeZone { get; set; } = null!;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `reddit_ads`: When this parameter is set to `ACCOUNT`, connector will use account related time zone to sync report data. Default value: `ACCOUNT`. Possible values: `ACCOUNT`, `USER`
        /// </summary>
        [Input("timeZoneMode", required: true)]
        public Input<string> TimeZoneMode { get; set; } = null!;

        public GetConnectorConfigCustomReportInputArgs()
        {
        }
        public static new GetConnectorConfigCustomReportInputArgs Empty => new GetConnectorConfigCustomReportInputArgs();
    }
}
