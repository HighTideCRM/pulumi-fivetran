// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran.Inputs
{

    public sealed class GetUsersUserInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The timestamp that the user created their Fivetran account
        /// </summary>
        [Input("createdAt", required: true)]
        public Input<string> CreatedAt { get; set; } = null!;

        /// <summary>
        /// The email address that the user has associated with their user profile.
        /// </summary>
        [Input("email", required: true)]
        public Input<string> Email { get; set; } = null!;

        /// <summary>
        /// The last name of the user.
        /// </summary>
        [Input("familyName", required: true)]
        public Input<string> FamilyName { get; set; } = null!;

        /// <summary>
        /// The first name of the user.
        /// </summary>
        [Input("givenName", required: true)]
        public Input<string> GivenName { get; set; } = null!;

        /// <summary>
        /// The unique identifier for the user within your account.
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        /// <summary>
        /// The field indicates whether the user has been invited to your account.
        /// </summary>
        [Input("invited", required: true)]
        public Input<bool> Invited { get; set; } = null!;

        /// <summary>
        /// The last time that the user has logged into their Fivetran account.
        /// </summary>
        [Input("loggedInAt", required: true)]
        public Input<string> LoggedInAt { get; set; } = null!;

        /// <summary>
        /// The phone number of the user.
        /// </summary>
        [Input("phone", required: true)]
        public Input<string> Phone { get; set; } = null!;

        /// <summary>
        /// The user's avatar as a URL link (for example, 'http://mycompany.com/avatars/john_white.png') or base64 data URI (for example, 'data:image/png;base64,aHR0cDovL215Y29tcGFueS5jb20vYXZhdGFycy9qb2huX3doaXRlLnBuZw==')
        /// </summary>
        [Input("picture", required: true)]
        public Input<string> Picture { get; set; } = null!;

        /// <summary>
        /// The field indicates whether the user has verified their email address in the account creation process.
        /// </summary>
        [Input("verified", required: true)]
        public Input<bool> Verified { get; set; } = null!;

        public GetUsersUserInputArgs()
        {
        }
        public static new GetUsersUserInputArgs Empty => new GetUsersUserInputArgs();
    }
}
