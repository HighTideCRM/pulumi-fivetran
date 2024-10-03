// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran
{
    public static class GetUser
    {
        /// <summary>
        /// This data source returns a user object.
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
        ///     var myUser = Fivetran.GetUser.Invoke(new()
        ///     {
        ///         Id = "anonymous_mystery",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetUserResult> InvokeAsync(GetUserArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetUserResult>("fivetran:index/getUser:getUser", args ?? new GetUserArgs(), options.WithDefaults());

        /// <summary>
        /// This data source returns a user object.
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
        ///     var myUser = Fivetran.GetUser.Invoke(new()
        ///     {
        ///         Id = "anonymous_mystery",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetUserResult> Invoke(GetUserInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetUserResult>("fivetran:index/getUser:getUser", args ?? new GetUserInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetUserArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The unique identifier for the user within the Fivetran system.
        /// </summary>
        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        public GetUserArgs()
        {
        }
        public static new GetUserArgs Empty => new GetUserArgs();
    }

    public sealed class GetUserInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The unique identifier for the user within the Fivetran system.
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        public GetUserInvokeArgs()
        {
        }
        public static new GetUserInvokeArgs Empty => new GetUserInvokeArgs();
    }


    [OutputType]
    public sealed class GetUserResult
    {
        /// <summary>
        /// The timestamp that the user created their Fivetran account.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// The email address that the user has associated with their user profile.
        /// </summary>
        public readonly string Email;
        /// <summary>
        /// The last name of the user.
        /// </summary>
        public readonly string FamilyName;
        /// <summary>
        /// The first name of the user.
        /// </summary>
        public readonly string GivenName;
        /// <summary>
        /// The unique identifier for the user within the Fivetran system.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The field indicates whether the user has been invited to your account.
        /// </summary>
        public readonly bool Invited;
        /// <summary>
        /// The last time that the user has logged into their Fivetran account.
        /// </summary>
        public readonly string LoggedInAt;
        /// <summary>
        /// The phone number of the user.
        /// </summary>
        public readonly string Phone;
        /// <summary>
        /// The user's avatar as a URL link (for example, 'http://mycompany.com/avatars/john_white.png') or base64 data URI (for example, 'data:image/png;base64,aHR0cDovL215Y29tcGFueS5jb20vYXZhdGFycy9qb2huX3doaXRlLnBuZw==')
        /// </summary>
        public readonly string Picture;
        /// <summary>
        /// The role that you would like to assign to the user.
        /// </summary>
        public readonly string Role;
        /// <summary>
        /// The field indicates whether the user has verified their email address in the account creation process.
        /// </summary>
        public readonly bool Verified;

        [OutputConstructor]
        private GetUserResult(
            string createdAt,

            string email,

            string familyName,

            string givenName,

            string id,

            bool invited,

            string loggedInAt,

            string phone,

            string picture,

            string role,

            bool verified)
        {
            CreatedAt = createdAt;
            Email = email;
            FamilyName = familyName;
            GivenName = givenName;
            Id = id;
            Invited = invited;
            LoggedInAt = loggedInAt;
            Phone = phone;
            Picture = picture;
            Role = role;
            Verified = verified;
        }
    }
}
