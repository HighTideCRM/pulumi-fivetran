// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package fivetran

import (
	"context"
	"reflect"

	"github.com/HighTideCRM/pulumi-fivetran/sdk/go/fivetran/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source returns a list of all dbt Models available for specified dbt Project id.
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
//			_, err := fivetran.GetDbtModels(ctx, &fivetran.GetDbtModelsArgs{
//				ProjectId: "project_id",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func GetDbtModels(ctx *pulumi.Context, args *GetDbtModelsArgs, opts ...pulumi.InvokeOption) (*GetDbtModelsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetDbtModelsResult
	err := ctx.Invoke("fivetran:index/getDbtModels:getDbtModels", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getDbtModels.
type GetDbtModelsArgs struct {
	Models []GetDbtModelsModel `pulumi:"models"`
	// The unique identifier for the dbt Project within the Fivetran system.
	ProjectId string `pulumi:"projectId"`
}

// A collection of values returned by getDbtModels.
type GetDbtModelsResult struct {
	// The ID of this datasource (equals to `projectId`).
	Id     string              `pulumi:"id"`
	Models []GetDbtModelsModel `pulumi:"models"`
	// The unique identifier for the dbt Project within the Fivetran system.
	ProjectId string `pulumi:"projectId"`
}

func GetDbtModelsOutput(ctx *pulumi.Context, args GetDbtModelsOutputArgs, opts ...pulumi.InvokeOption) GetDbtModelsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetDbtModelsResultOutput, error) {
			args := v.(GetDbtModelsArgs)
			opts = internal.PkgInvokeDefaultOpts(opts)
			var rv GetDbtModelsResult
			secret, err := ctx.InvokePackageRaw("fivetran:index/getDbtModels:getDbtModels", args, &rv, "", opts...)
			if err != nil {
				return GetDbtModelsResultOutput{}, err
			}

			output := pulumi.ToOutput(rv).(GetDbtModelsResultOutput)
			if secret {
				return pulumi.ToSecret(output).(GetDbtModelsResultOutput), nil
			}
			return output, nil
		}).(GetDbtModelsResultOutput)
}

// A collection of arguments for invoking getDbtModels.
type GetDbtModelsOutputArgs struct {
	Models GetDbtModelsModelArrayInput `pulumi:"models"`
	// The unique identifier for the dbt Project within the Fivetran system.
	ProjectId pulumi.StringInput `pulumi:"projectId"`
}

func (GetDbtModelsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetDbtModelsArgs)(nil)).Elem()
}

// A collection of values returned by getDbtModels.
type GetDbtModelsResultOutput struct{ *pulumi.OutputState }

func (GetDbtModelsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetDbtModelsResult)(nil)).Elem()
}

func (o GetDbtModelsResultOutput) ToGetDbtModelsResultOutput() GetDbtModelsResultOutput {
	return o
}

func (o GetDbtModelsResultOutput) ToGetDbtModelsResultOutputWithContext(ctx context.Context) GetDbtModelsResultOutput {
	return o
}

// The ID of this datasource (equals to `projectId`).
func (o GetDbtModelsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetDbtModelsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetDbtModelsResultOutput) Models() GetDbtModelsModelArrayOutput {
	return o.ApplyT(func(v GetDbtModelsResult) []GetDbtModelsModel { return v.Models }).(GetDbtModelsModelArrayOutput)
}

// The unique identifier for the dbt Project within the Fivetran system.
func (o GetDbtModelsResultOutput) ProjectId() pulumi.StringOutput {
	return o.ApplyT(func(v GetDbtModelsResult) string { return v.ProjectId }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetDbtModelsResultOutput{})
}
