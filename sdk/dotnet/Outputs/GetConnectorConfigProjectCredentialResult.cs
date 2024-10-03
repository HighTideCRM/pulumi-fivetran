// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran.Outputs
{

    [OutputType]
    public sealed class GetConnectorConfigProjectCredentialResult
    {
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `amplitude`: The API key of the project.
        /// </summary>
        public readonly string ApiKey;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `amplitude`: The project name you wish to use with Fivetran.
        /// </summary>
        public readonly string Project;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `amplitude`: The secret key of the project.
        /// </summary>
        public readonly string SecretKey;

        [OutputConstructor]
        private GetConnectorConfigProjectCredentialResult(
            string apiKey,

            string project,

            string secretKey)
        {
            ApiKey = apiKey;
            Project = project;
            SecretKey = secretKey;
        }
    }
}
