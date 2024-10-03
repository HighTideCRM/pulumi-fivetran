// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package fivetran

import (
	"context"
	"reflect"

	"errors"
	"github.com/HighTideCRM/pulumi-fivetran/sdk/go/fivetran/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## Import
//
// You don't need to import this resource as it is synthetic (doesn't create new instances in upstream).
type ConnectorSchemaConfig struct {
	pulumi.CustomResourceState

	// The unique identifier for the connector within the Fivetran system.
	ConnectorId pulumi.StringOutput `pulumi:"connectorId"`
	// Deprecated: Configure `schemas` instead. This attribute will be removed in the next major version of the provider.
	Schema ConnectorSchemaConfigSchemaArrayOutput `pulumi:"schema"`
	// The value specifying how new source data is handled.
	SchemaChangeHandling pulumi.StringPtrOutput `pulumi:"schemaChangeHandling"`
	// Map of schema configurations.
	Schemas ConnectorSchemaConfigSchemasMapOutput `pulumi:"schemas"`
	// Schema settings in Json format, following Fivetran API endpoint contract for `schemas` field (a map of schemas).
	SchemasJson pulumi.StringPtrOutput                 `pulumi:"schemasJson"`
	Timeouts    ConnectorSchemaConfigTimeoutsPtrOutput `pulumi:"timeouts"`
	// The value defines validation method. - NONE: no validation, any configuration accepted. - TABLES: validate table names,
	// fail on attempt to configure non-existing schemas/tables. - COLUMNS: validate the whole schema config including column
	// names. The resource will try to fetch columns for every configured table and verify column names.
	ValidationLevel pulumi.StringOutput `pulumi:"validationLevel"`
}

// NewConnectorSchemaConfig registers a new resource with the given unique name, arguments, and options.
func NewConnectorSchemaConfig(ctx *pulumi.Context,
	name string, args *ConnectorSchemaConfigArgs, opts ...pulumi.ResourceOption) (*ConnectorSchemaConfig, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ConnectorId == nil {
		return nil, errors.New("invalid value for required argument 'ConnectorId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ConnectorSchemaConfig
	err := ctx.RegisterResource("fivetran:index/connectorSchemaConfig:ConnectorSchemaConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConnectorSchemaConfig gets an existing ConnectorSchemaConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConnectorSchemaConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConnectorSchemaConfigState, opts ...pulumi.ResourceOption) (*ConnectorSchemaConfig, error) {
	var resource ConnectorSchemaConfig
	err := ctx.ReadResource("fivetran:index/connectorSchemaConfig:ConnectorSchemaConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ConnectorSchemaConfig resources.
type connectorSchemaConfigState struct {
	// The unique identifier for the connector within the Fivetran system.
	ConnectorId *string `pulumi:"connectorId"`
	// Deprecated: Configure `schemas` instead. This attribute will be removed in the next major version of the provider.
	Schema []ConnectorSchemaConfigSchema `pulumi:"schema"`
	// The value specifying how new source data is handled.
	SchemaChangeHandling *string `pulumi:"schemaChangeHandling"`
	// Map of schema configurations.
	Schemas map[string]ConnectorSchemaConfigSchemas `pulumi:"schemas"`
	// Schema settings in Json format, following Fivetran API endpoint contract for `schemas` field (a map of schemas).
	SchemasJson *string                        `pulumi:"schemasJson"`
	Timeouts    *ConnectorSchemaConfigTimeouts `pulumi:"timeouts"`
	// The value defines validation method. - NONE: no validation, any configuration accepted. - TABLES: validate table names,
	// fail on attempt to configure non-existing schemas/tables. - COLUMNS: validate the whole schema config including column
	// names. The resource will try to fetch columns for every configured table and verify column names.
	ValidationLevel *string `pulumi:"validationLevel"`
}

type ConnectorSchemaConfigState struct {
	// The unique identifier for the connector within the Fivetran system.
	ConnectorId pulumi.StringPtrInput
	// Deprecated: Configure `schemas` instead. This attribute will be removed in the next major version of the provider.
	Schema ConnectorSchemaConfigSchemaArrayInput
	// The value specifying how new source data is handled.
	SchemaChangeHandling pulumi.StringPtrInput
	// Map of schema configurations.
	Schemas ConnectorSchemaConfigSchemasMapInput
	// Schema settings in Json format, following Fivetran API endpoint contract for `schemas` field (a map of schemas).
	SchemasJson pulumi.StringPtrInput
	Timeouts    ConnectorSchemaConfigTimeoutsPtrInput
	// The value defines validation method. - NONE: no validation, any configuration accepted. - TABLES: validate table names,
	// fail on attempt to configure non-existing schemas/tables. - COLUMNS: validate the whole schema config including column
	// names. The resource will try to fetch columns for every configured table and verify column names.
	ValidationLevel pulumi.StringPtrInput
}

func (ConnectorSchemaConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*connectorSchemaConfigState)(nil)).Elem()
}

type connectorSchemaConfigArgs struct {
	// The unique identifier for the connector within the Fivetran system.
	ConnectorId string `pulumi:"connectorId"`
	// Deprecated: Configure `schemas` instead. This attribute will be removed in the next major version of the provider.
	Schema []ConnectorSchemaConfigSchema `pulumi:"schema"`
	// The value specifying how new source data is handled.
	SchemaChangeHandling *string `pulumi:"schemaChangeHandling"`
	// Map of schema configurations.
	Schemas map[string]ConnectorSchemaConfigSchemas `pulumi:"schemas"`
	// Schema settings in Json format, following Fivetran API endpoint contract for `schemas` field (a map of schemas).
	SchemasJson *string                        `pulumi:"schemasJson"`
	Timeouts    *ConnectorSchemaConfigTimeouts `pulumi:"timeouts"`
	// The value defines validation method. - NONE: no validation, any configuration accepted. - TABLES: validate table names,
	// fail on attempt to configure non-existing schemas/tables. - COLUMNS: validate the whole schema config including column
	// names. The resource will try to fetch columns for every configured table and verify column names.
	ValidationLevel *string `pulumi:"validationLevel"`
}

// The set of arguments for constructing a ConnectorSchemaConfig resource.
type ConnectorSchemaConfigArgs struct {
	// The unique identifier for the connector within the Fivetran system.
	ConnectorId pulumi.StringInput
	// Deprecated: Configure `schemas` instead. This attribute will be removed in the next major version of the provider.
	Schema ConnectorSchemaConfigSchemaArrayInput
	// The value specifying how new source data is handled.
	SchemaChangeHandling pulumi.StringPtrInput
	// Map of schema configurations.
	Schemas ConnectorSchemaConfigSchemasMapInput
	// Schema settings in Json format, following Fivetran API endpoint contract for `schemas` field (a map of schemas).
	SchemasJson pulumi.StringPtrInput
	Timeouts    ConnectorSchemaConfigTimeoutsPtrInput
	// The value defines validation method. - NONE: no validation, any configuration accepted. - TABLES: validate table names,
	// fail on attempt to configure non-existing schemas/tables. - COLUMNS: validate the whole schema config including column
	// names. The resource will try to fetch columns for every configured table and verify column names.
	ValidationLevel pulumi.StringPtrInput
}

func (ConnectorSchemaConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*connectorSchemaConfigArgs)(nil)).Elem()
}

type ConnectorSchemaConfigInput interface {
	pulumi.Input

	ToConnectorSchemaConfigOutput() ConnectorSchemaConfigOutput
	ToConnectorSchemaConfigOutputWithContext(ctx context.Context) ConnectorSchemaConfigOutput
}

func (*ConnectorSchemaConfig) ElementType() reflect.Type {
	return reflect.TypeOf((**ConnectorSchemaConfig)(nil)).Elem()
}

func (i *ConnectorSchemaConfig) ToConnectorSchemaConfigOutput() ConnectorSchemaConfigOutput {
	return i.ToConnectorSchemaConfigOutputWithContext(context.Background())
}

func (i *ConnectorSchemaConfig) ToConnectorSchemaConfigOutputWithContext(ctx context.Context) ConnectorSchemaConfigOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConnectorSchemaConfigOutput)
}

// ConnectorSchemaConfigArrayInput is an input type that accepts ConnectorSchemaConfigArray and ConnectorSchemaConfigArrayOutput values.
// You can construct a concrete instance of `ConnectorSchemaConfigArrayInput` via:
//
//	ConnectorSchemaConfigArray{ ConnectorSchemaConfigArgs{...} }
type ConnectorSchemaConfigArrayInput interface {
	pulumi.Input

	ToConnectorSchemaConfigArrayOutput() ConnectorSchemaConfigArrayOutput
	ToConnectorSchemaConfigArrayOutputWithContext(context.Context) ConnectorSchemaConfigArrayOutput
}

type ConnectorSchemaConfigArray []ConnectorSchemaConfigInput

func (ConnectorSchemaConfigArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ConnectorSchemaConfig)(nil)).Elem()
}

func (i ConnectorSchemaConfigArray) ToConnectorSchemaConfigArrayOutput() ConnectorSchemaConfigArrayOutput {
	return i.ToConnectorSchemaConfigArrayOutputWithContext(context.Background())
}

func (i ConnectorSchemaConfigArray) ToConnectorSchemaConfigArrayOutputWithContext(ctx context.Context) ConnectorSchemaConfigArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConnectorSchemaConfigArrayOutput)
}

// ConnectorSchemaConfigMapInput is an input type that accepts ConnectorSchemaConfigMap and ConnectorSchemaConfigMapOutput values.
// You can construct a concrete instance of `ConnectorSchemaConfigMapInput` via:
//
//	ConnectorSchemaConfigMap{ "key": ConnectorSchemaConfigArgs{...} }
type ConnectorSchemaConfigMapInput interface {
	pulumi.Input

	ToConnectorSchemaConfigMapOutput() ConnectorSchemaConfigMapOutput
	ToConnectorSchemaConfigMapOutputWithContext(context.Context) ConnectorSchemaConfigMapOutput
}

type ConnectorSchemaConfigMap map[string]ConnectorSchemaConfigInput

func (ConnectorSchemaConfigMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ConnectorSchemaConfig)(nil)).Elem()
}

func (i ConnectorSchemaConfigMap) ToConnectorSchemaConfigMapOutput() ConnectorSchemaConfigMapOutput {
	return i.ToConnectorSchemaConfigMapOutputWithContext(context.Background())
}

func (i ConnectorSchemaConfigMap) ToConnectorSchemaConfigMapOutputWithContext(ctx context.Context) ConnectorSchemaConfigMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConnectorSchemaConfigMapOutput)
}

type ConnectorSchemaConfigOutput struct{ *pulumi.OutputState }

func (ConnectorSchemaConfigOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ConnectorSchemaConfig)(nil)).Elem()
}

func (o ConnectorSchemaConfigOutput) ToConnectorSchemaConfigOutput() ConnectorSchemaConfigOutput {
	return o
}

func (o ConnectorSchemaConfigOutput) ToConnectorSchemaConfigOutputWithContext(ctx context.Context) ConnectorSchemaConfigOutput {
	return o
}

// The unique identifier for the connector within the Fivetran system.
func (o ConnectorSchemaConfigOutput) ConnectorId() pulumi.StringOutput {
	return o.ApplyT(func(v *ConnectorSchemaConfig) pulumi.StringOutput { return v.ConnectorId }).(pulumi.StringOutput)
}

// Deprecated: Configure `schemas` instead. This attribute will be removed in the next major version of the provider.
func (o ConnectorSchemaConfigOutput) Schema() ConnectorSchemaConfigSchemaArrayOutput {
	return o.ApplyT(func(v *ConnectorSchemaConfig) ConnectorSchemaConfigSchemaArrayOutput { return v.Schema }).(ConnectorSchemaConfigSchemaArrayOutput)
}

// The value specifying how new source data is handled.
func (o ConnectorSchemaConfigOutput) SchemaChangeHandling() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ConnectorSchemaConfig) pulumi.StringPtrOutput { return v.SchemaChangeHandling }).(pulumi.StringPtrOutput)
}

// Map of schema configurations.
func (o ConnectorSchemaConfigOutput) Schemas() ConnectorSchemaConfigSchemasMapOutput {
	return o.ApplyT(func(v *ConnectorSchemaConfig) ConnectorSchemaConfigSchemasMapOutput { return v.Schemas }).(ConnectorSchemaConfigSchemasMapOutput)
}

// Schema settings in Json format, following Fivetran API endpoint contract for `schemas` field (a map of schemas).
func (o ConnectorSchemaConfigOutput) SchemasJson() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ConnectorSchemaConfig) pulumi.StringPtrOutput { return v.SchemasJson }).(pulumi.StringPtrOutput)
}

func (o ConnectorSchemaConfigOutput) Timeouts() ConnectorSchemaConfigTimeoutsPtrOutput {
	return o.ApplyT(func(v *ConnectorSchemaConfig) ConnectorSchemaConfigTimeoutsPtrOutput { return v.Timeouts }).(ConnectorSchemaConfigTimeoutsPtrOutput)
}

// The value defines validation method. - NONE: no validation, any configuration accepted. - TABLES: validate table names,
// fail on attempt to configure non-existing schemas/tables. - COLUMNS: validate the whole schema config including column
// names. The resource will try to fetch columns for every configured table and verify column names.
func (o ConnectorSchemaConfigOutput) ValidationLevel() pulumi.StringOutput {
	return o.ApplyT(func(v *ConnectorSchemaConfig) pulumi.StringOutput { return v.ValidationLevel }).(pulumi.StringOutput)
}

type ConnectorSchemaConfigArrayOutput struct{ *pulumi.OutputState }

func (ConnectorSchemaConfigArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ConnectorSchemaConfig)(nil)).Elem()
}

func (o ConnectorSchemaConfigArrayOutput) ToConnectorSchemaConfigArrayOutput() ConnectorSchemaConfigArrayOutput {
	return o
}

func (o ConnectorSchemaConfigArrayOutput) ToConnectorSchemaConfigArrayOutputWithContext(ctx context.Context) ConnectorSchemaConfigArrayOutput {
	return o
}

func (o ConnectorSchemaConfigArrayOutput) Index(i pulumi.IntInput) ConnectorSchemaConfigOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ConnectorSchemaConfig {
		return vs[0].([]*ConnectorSchemaConfig)[vs[1].(int)]
	}).(ConnectorSchemaConfigOutput)
}

type ConnectorSchemaConfigMapOutput struct{ *pulumi.OutputState }

func (ConnectorSchemaConfigMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ConnectorSchemaConfig)(nil)).Elem()
}

func (o ConnectorSchemaConfigMapOutput) ToConnectorSchemaConfigMapOutput() ConnectorSchemaConfigMapOutput {
	return o
}

func (o ConnectorSchemaConfigMapOutput) ToConnectorSchemaConfigMapOutputWithContext(ctx context.Context) ConnectorSchemaConfigMapOutput {
	return o
}

func (o ConnectorSchemaConfigMapOutput) MapIndex(k pulumi.StringInput) ConnectorSchemaConfigOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ConnectorSchemaConfig {
		return vs[0].(map[string]*ConnectorSchemaConfig)[vs[1].(string)]
	}).(ConnectorSchemaConfigOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ConnectorSchemaConfigInput)(nil)).Elem(), &ConnectorSchemaConfig{})
	pulumi.RegisterInputType(reflect.TypeOf((*ConnectorSchemaConfigArrayInput)(nil)).Elem(), ConnectorSchemaConfigArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ConnectorSchemaConfigMapInput)(nil)).Elem(), ConnectorSchemaConfigMap{})
	pulumi.RegisterOutputType(ConnectorSchemaConfigOutput{})
	pulumi.RegisterOutputType(ConnectorSchemaConfigArrayOutput{})
	pulumi.RegisterOutputType(ConnectorSchemaConfigMapOutput{})
}
