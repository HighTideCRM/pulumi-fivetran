// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package fivetran

import (
	"context"
	"reflect"

	"github.com/HighTideCRM/pulumi-fivetran/sdk/go/fivetran/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source returns a dbt Transformation object.
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
//			_, err := fivetran.LookupDbtTransformation(ctx, &fivetran.LookupDbtTransformationArgs{
//				Id: "transformation_id",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupDbtTransformation(ctx *pulumi.Context, args *LookupDbtTransformationArgs, opts ...pulumi.InvokeOption) (*LookupDbtTransformationResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupDbtTransformationResult
	err := ctx.Invoke("fivetran:index/getDbtTransformation:getDbtTransformation", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getDbtTransformation.
type LookupDbtTransformationArgs struct {
	// The unique identifier for the dbt Transformation within the Fivetran system.
	Id       string                        `pulumi:"id"`
	Schedule *GetDbtTransformationSchedule `pulumi:"schedule"`
}

// A collection of values returned by getDbtTransformation.
type LookupDbtTransformationResult struct {
	// Identifiers of related connectors.
	ConnectorIds []string `pulumi:"connectorIds"`
	// The timestamp of the dbt Transformation creation.
	CreatedAt string `pulumi:"createdAt"`
	// The unique identifier for the dbt Model within the Fivetran system.
	DbtModelId string `pulumi:"dbtModelId"`
	// Target dbt Model name.
	DbtModelName string `pulumi:"dbtModelName"`
	// The unique identifier for the dbt Project within the Fivetran system.
	DbtProjectId string `pulumi:"dbtProjectId"`
	// The unique identifier for the dbt Transformation within the Fivetran system.
	Id string `pulumi:"id"`
	// Identifiers of related models.
	ModelIds []string `pulumi:"modelIds"`
	// The dbt Model name.
	OutputModelName string `pulumi:"outputModelName"`
	// The field indicating whether the transformation will be set into the paused state. By default, the value is false.
	Paused bool `pulumi:"paused"`
	// The field indicating whether the tests have been configured for dbt Transformation. By default, the value is false.
	RunTests bool                          `pulumi:"runTests"`
	Schedule *GetDbtTransformationSchedule `pulumi:"schedule"`
}

func LookupDbtTransformationOutput(ctx *pulumi.Context, args LookupDbtTransformationOutputArgs, opts ...pulumi.InvokeOption) LookupDbtTransformationResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupDbtTransformationResultOutput, error) {
			args := v.(LookupDbtTransformationArgs)
			opts = internal.PkgInvokeDefaultOpts(opts)
			var rv LookupDbtTransformationResult
			secret, err := ctx.InvokePackageRaw("fivetran:index/getDbtTransformation:getDbtTransformation", args, &rv, "", opts...)
			if err != nil {
				return LookupDbtTransformationResultOutput{}, err
			}

			output := pulumi.ToOutput(rv).(LookupDbtTransformationResultOutput)
			if secret {
				return pulumi.ToSecret(output).(LookupDbtTransformationResultOutput), nil
			}
			return output, nil
		}).(LookupDbtTransformationResultOutput)
}

// A collection of arguments for invoking getDbtTransformation.
type LookupDbtTransformationOutputArgs struct {
	// The unique identifier for the dbt Transformation within the Fivetran system.
	Id       pulumi.StringInput                   `pulumi:"id"`
	Schedule GetDbtTransformationSchedulePtrInput `pulumi:"schedule"`
}

func (LookupDbtTransformationOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupDbtTransformationArgs)(nil)).Elem()
}

// A collection of values returned by getDbtTransformation.
type LookupDbtTransformationResultOutput struct{ *pulumi.OutputState }

func (LookupDbtTransformationResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupDbtTransformationResult)(nil)).Elem()
}

func (o LookupDbtTransformationResultOutput) ToLookupDbtTransformationResultOutput() LookupDbtTransformationResultOutput {
	return o
}

func (o LookupDbtTransformationResultOutput) ToLookupDbtTransformationResultOutputWithContext(ctx context.Context) LookupDbtTransformationResultOutput {
	return o
}

// Identifiers of related connectors.
func (o LookupDbtTransformationResultOutput) ConnectorIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupDbtTransformationResult) []string { return v.ConnectorIds }).(pulumi.StringArrayOutput)
}

// The timestamp of the dbt Transformation creation.
func (o LookupDbtTransformationResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDbtTransformationResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

// The unique identifier for the dbt Model within the Fivetran system.
func (o LookupDbtTransformationResultOutput) DbtModelId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDbtTransformationResult) string { return v.DbtModelId }).(pulumi.StringOutput)
}

// Target dbt Model name.
func (o LookupDbtTransformationResultOutput) DbtModelName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDbtTransformationResult) string { return v.DbtModelName }).(pulumi.StringOutput)
}

// The unique identifier for the dbt Project within the Fivetran system.
func (o LookupDbtTransformationResultOutput) DbtProjectId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDbtTransformationResult) string { return v.DbtProjectId }).(pulumi.StringOutput)
}

// The unique identifier for the dbt Transformation within the Fivetran system.
func (o LookupDbtTransformationResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDbtTransformationResult) string { return v.Id }).(pulumi.StringOutput)
}

// Identifiers of related models.
func (o LookupDbtTransformationResultOutput) ModelIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupDbtTransformationResult) []string { return v.ModelIds }).(pulumi.StringArrayOutput)
}

// The dbt Model name.
func (o LookupDbtTransformationResultOutput) OutputModelName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDbtTransformationResult) string { return v.OutputModelName }).(pulumi.StringOutput)
}

// The field indicating whether the transformation will be set into the paused state. By default, the value is false.
func (o LookupDbtTransformationResultOutput) Paused() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupDbtTransformationResult) bool { return v.Paused }).(pulumi.BoolOutput)
}

// The field indicating whether the tests have been configured for dbt Transformation. By default, the value is false.
func (o LookupDbtTransformationResultOutput) RunTests() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupDbtTransformationResult) bool { return v.RunTests }).(pulumi.BoolOutput)
}

func (o LookupDbtTransformationResultOutput) Schedule() GetDbtTransformationSchedulePtrOutput {
	return o.ApplyT(func(v LookupDbtTransformationResult) *GetDbtTransformationSchedule { return v.Schedule }).(GetDbtTransformationSchedulePtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupDbtTransformationResultOutput{})
}
