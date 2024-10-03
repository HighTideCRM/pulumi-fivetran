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
    /// This resource allows you to create, update, and delete group membership for user
    /// 
    /// ## Import
    /// 
    /// 1. To import an existing `fivetran_user_group_membership` resource into your Terraform state, you need to get `user_id` and `group_id`
    /// 
    /// You can retrieve all users using the [fivetran_users data source](/docs/data-sources/users).
    /// 
    /// 2. Define an empty resource in your `.tf` configuration:
    /// 
    /// hcl
    /// 
    /// resource "fivetran_user_group_membership" "my_imported_fivetran_user_group_membership" {
    /// 
    /// }
    /// 
    /// 3. Run the `pulumi import` command:
    /// 
    /// ```sh
    /// $ pulumi import fivetran:index/userGroupMembership:UserGroupMembership my_imported_fivetran_user_group_membership {user_id}
    /// ```
    /// 
    /// 4. Use the `terraform state show` command to get the values from the state:
    /// 
    /// terraform state show 'fivetran_user_group_membership.my_imported_fivetran_user_group_membership'
    /// 
    /// 5. Copy the values and paste them to your `.tf` configuration.
    /// </summary>
    [FivetranResourceType("fivetran:index/userGroupMembership:UserGroupMembership")]
    public partial class UserGroupMembership : global::Pulumi.CustomResource
    {
        [Output("groups")]
        public Output<ImmutableArray<Outputs.UserGroupMembershipGroup>> Groups { get; private set; } = null!;

        /// <summary>
        /// The unique identifier for the user within your account.
        /// </summary>
        [Output("userId")]
        public Output<string> UserId { get; private set; } = null!;


        /// <summary>
        /// Create a UserGroupMembership resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public UserGroupMembership(string name, UserGroupMembershipArgs args, CustomResourceOptions? options = null)
            : base("fivetran:index/userGroupMembership:UserGroupMembership", name, args ?? new UserGroupMembershipArgs(), MakeResourceOptions(options, ""))
        {
        }

        private UserGroupMembership(string name, Input<string> id, UserGroupMembershipState? state = null, CustomResourceOptions? options = null)
            : base("fivetran:index/userGroupMembership:UserGroupMembership", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/HighTideCRM/pulumi-fivetran",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing UserGroupMembership resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static UserGroupMembership Get(string name, Input<string> id, UserGroupMembershipState? state = null, CustomResourceOptions? options = null)
        {
            return new UserGroupMembership(name, id, state, options);
        }
    }

    public sealed class UserGroupMembershipArgs : global::Pulumi.ResourceArgs
    {
        [Input("groups")]
        private InputList<Inputs.UserGroupMembershipGroupArgs>? _groups;
        public InputList<Inputs.UserGroupMembershipGroupArgs> Groups
        {
            get => _groups ?? (_groups = new InputList<Inputs.UserGroupMembershipGroupArgs>());
            set => _groups = value;
        }

        /// <summary>
        /// The unique identifier for the user within your account.
        /// </summary>
        [Input("userId", required: true)]
        public Input<string> UserId { get; set; } = null!;

        public UserGroupMembershipArgs()
        {
        }
        public static new UserGroupMembershipArgs Empty => new UserGroupMembershipArgs();
    }

    public sealed class UserGroupMembershipState : global::Pulumi.ResourceArgs
    {
        [Input("groups")]
        private InputList<Inputs.UserGroupMembershipGroupGetArgs>? _groups;
        public InputList<Inputs.UserGroupMembershipGroupGetArgs> Groups
        {
            get => _groups ?? (_groups = new InputList<Inputs.UserGroupMembershipGroupGetArgs>());
            set => _groups = value;
        }

        /// <summary>
        /// The unique identifier for the user within your account.
        /// </summary>
        [Input("userId")]
        public Input<string>? UserId { get; set; }

        public UserGroupMembershipState()
        {
        }
        public static new UserGroupMembershipState Empty => new UserGroupMembershipState();
    }
}
