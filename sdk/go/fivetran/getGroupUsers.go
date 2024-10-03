// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package fivetran

import (
	"context"
	"reflect"

	"github.com/HighTideCRM/pulumi-fivetran/sdk/go/fivetran/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source returns a list of information about all users within a group in your Fivetran account.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/HighTideCRM/pulumi-fivetran/sdk/go/fivetran"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := fivetran.LookupGroupUsers(ctx, &fivetran.LookupGroupUsersArgs{
//				Id: "anonymous_mystery",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupGroupUsers(ctx *pulumi.Context, args *LookupGroupUsersArgs, opts ...pulumi.InvokeOption) (*LookupGroupUsersResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupGroupUsersResult
	err := ctx.Invoke("fivetran:index/getGroupUsers:getGroupUsers", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getGroupUsers.
type LookupGroupUsersArgs struct {
	// The unique identifier for the group within the Fivetran system. Data-source will represent a set of users who has membership in this group.
	Id    string              `pulumi:"id"`
	Users []GetGroupUsersUser `pulumi:"users"`
}

// A collection of values returned by getGroupUsers.
type LookupGroupUsersResult struct {
	// The unique identifier for the group within the Fivetran system. Data-source will represent a set of users who has membership in this group.
	Id    string              `pulumi:"id"`
	Users []GetGroupUsersUser `pulumi:"users"`
}

func LookupGroupUsersOutput(ctx *pulumi.Context, args LookupGroupUsersOutputArgs, opts ...pulumi.InvokeOption) LookupGroupUsersResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupGroupUsersResultOutput, error) {
			args := v.(LookupGroupUsersArgs)
			opts = internal.PkgInvokeDefaultOpts(opts)
			var rv LookupGroupUsersResult
			secret, err := ctx.InvokePackageRaw("fivetran:index/getGroupUsers:getGroupUsers", args, &rv, "", opts...)
			if err != nil {
				return LookupGroupUsersResultOutput{}, err
			}

			output := pulumi.ToOutput(rv).(LookupGroupUsersResultOutput)
			if secret {
				return pulumi.ToSecret(output).(LookupGroupUsersResultOutput), nil
			}
			return output, nil
		}).(LookupGroupUsersResultOutput)
}

// A collection of arguments for invoking getGroupUsers.
type LookupGroupUsersOutputArgs struct {
	// The unique identifier for the group within the Fivetran system. Data-source will represent a set of users who has membership in this group.
	Id    pulumi.StringInput          `pulumi:"id"`
	Users GetGroupUsersUserArrayInput `pulumi:"users"`
}

func (LookupGroupUsersOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupGroupUsersArgs)(nil)).Elem()
}

// A collection of values returned by getGroupUsers.
type LookupGroupUsersResultOutput struct{ *pulumi.OutputState }

func (LookupGroupUsersResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupGroupUsersResult)(nil)).Elem()
}

func (o LookupGroupUsersResultOutput) ToLookupGroupUsersResultOutput() LookupGroupUsersResultOutput {
	return o
}

func (o LookupGroupUsersResultOutput) ToLookupGroupUsersResultOutputWithContext(ctx context.Context) LookupGroupUsersResultOutput {
	return o
}

// The unique identifier for the group within the Fivetran system. Data-source will represent a set of users who has membership in this group.
func (o LookupGroupUsersResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupGroupUsersResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupGroupUsersResultOutput) Users() GetGroupUsersUserArrayOutput {
	return o.ApplyT(func(v LookupGroupUsersResult) []GetGroupUsersUser { return v.Users }).(GetGroupUsersUserArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupGroupUsersResultOutput{})
}
