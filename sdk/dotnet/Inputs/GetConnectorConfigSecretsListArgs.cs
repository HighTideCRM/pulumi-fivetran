// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran.Inputs
{

    public sealed class GetConnectorConfigSecretsListInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `aws_lambda`: Secret Key.
        /// 	- Service `azure_function`: Key
        /// 	- Service `google_cloud_function`: Key
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("value", required: true)]
        private Input<string>? _value;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `aws_lambda`: Secret Value.
        /// 	- Service `azure_function`: Value
        /// 	- Service `google_cloud_function`: Value
        /// </summary>
        public Input<string>? Value
        {
            get => _value;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _value = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public GetConnectorConfigSecretsListInputArgs()
        {
        }
        public static new GetConnectorConfigSecretsListInputArgs Empty => new GetConnectorConfigSecretsListInputArgs();
    }
}
