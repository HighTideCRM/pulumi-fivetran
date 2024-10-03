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
    public sealed class ConnectorDestinationSchema
    {
        /// <summary>
        /// The connector schema name in destination. Has to be unique within the group (destination). Required for connector creation.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The connector schema prefix has to be unique within the group (destination). Each replicated schema is prefixed with the provided value. Required for connector creation.
        /// </summary>
        public readonly string? Prefix;
        /// <summary>
        /// The table name unique within the schema to which connector will sync the data. Required for connector creation.
        /// </summary>
        public readonly string? Table;

        [OutputConstructor]
        private ConnectorDestinationSchema(
            string? name,

            string? prefix,

            string? table)
        {
            Name = name;
            Prefix = prefix;
            Table = table;
        }
    }
}
