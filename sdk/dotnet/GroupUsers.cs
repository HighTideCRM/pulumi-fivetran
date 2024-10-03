// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran
{
    /// <summary>
    /// This resource allows you to create, update, and delete user memberships in groups.
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
    ///     var groupUsers = new Fivetran.GroupUsers("groupUsers", new()
    ///     {
    ///         GroupId = fivetran_group.Group.Id,
    ///         Users = new[]
    ///         {
    ///             new Fivetran.Inputs.GroupUsersUserArgs
    ///             {
    ///                 Email = "mail@example.com",
    ///                 Role = "Destination Analyst",
    ///             },
    ///             new Fivetran.Inputs.GroupUsersUserArgs
    ///             {
    ///                 Email = "another_mail@example.com",
    ///                 Role = "Destination Analyst",
    ///             },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [FivetranResourceType("fivetran:index/groupUsers:GroupUsers")]
    public partial class GroupUsers : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The unique identifier for the Group within the Fivetran system.
        /// </summary>
        [Output("groupId")]
        public Output<string> GroupId { get; private set; } = null!;

        [Output("lastUpdated")]
        public Output<string> LastUpdated { get; private set; } = null!;

        [Output("users")]
        public Output<ImmutableArray<Outputs.GroupUsersUser>> Users { get; private set; } = null!;


        /// <summary>
        /// Create a GroupUsers resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GroupUsers(string name, GroupUsersArgs args, CustomResourceOptions? options = null)
            : base("fivetran:index/groupUsers:GroupUsers", name, args ?? new GroupUsersArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GroupUsers(string name, Input<string> id, GroupUsersState? state = null, CustomResourceOptions? options = null)
            : base("fivetran:index/groupUsers:GroupUsers", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing GroupUsers resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GroupUsers Get(string name, Input<string> id, GroupUsersState? state = null, CustomResourceOptions? options = null)
        {
            return new GroupUsers(name, id, state, options);
        }
    }

    public sealed class GroupUsersArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The unique identifier for the Group within the Fivetran system.
        /// </summary>
        [Input("groupId", required: true)]
        public Input<string> GroupId { get; set; } = null!;

        [Input("users")]
        private InputList<Inputs.GroupUsersUserArgs>? _users;
        public InputList<Inputs.GroupUsersUserArgs> Users
        {
            get => _users ?? (_users = new InputList<Inputs.GroupUsersUserArgs>());
            set => _users = value;
        }

        public GroupUsersArgs()
        {
        }
        public static new GroupUsersArgs Empty => new GroupUsersArgs();
    }

    public sealed class GroupUsersState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The unique identifier for the Group within the Fivetran system.
        /// </summary>
        [Input("groupId")]
        public Input<string>? GroupId { get; set; }

        [Input("lastUpdated")]
        public Input<string>? LastUpdated { get; set; }

        [Input("users")]
        private InputList<Inputs.GroupUsersUserGetArgs>? _users;
        public InputList<Inputs.GroupUsersUserGetArgs> Users
        {
            get => _users ?? (_users = new InputList<Inputs.GroupUsersUserGetArgs>());
            set => _users = value;
        }

        public GroupUsersState()
        {
        }
        public static new GroupUsersState Empty => new GroupUsersState();
    }
}
