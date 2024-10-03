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
    public sealed class DbtProjectModel
    {
        /// <summary>
        /// The unique identifier for the dbt Model within the Fivetran system.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The dbt Model name.
        /// </summary>
        public readonly string? ModelName;
        /// <summary>
        /// Boolean specifying whether the model is selected for execution in the dashboard.
        /// </summary>
        public readonly bool? Scheduled;

        [OutputConstructor]
        private DbtProjectModel(
            string? id,

            string? modelName,

            bool? scheduled)
        {
            Id = id;
            ModelName = modelName;
            Scheduled = scheduled;
        }
    }
}
