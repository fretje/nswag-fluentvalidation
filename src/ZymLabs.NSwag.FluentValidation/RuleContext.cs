using FluentValidation.Validators;
using NJsonSchema;
using NJsonSchema.Generation;

namespace ZymLabs.NSwag.FluentValidation
{
    /// <summary>
    /// RuleContext.
    /// </summary>
    public class RuleContext
    {
        /// <summary>
        /// SchemaProcessorContext.
        /// </summary>
        public SchemaProcessorContext SchemaProcessorContext { get; }

        /// <summary>
        /// Schema to process.
        /// </summary>
        public JsonSchema Schema { get; }

        /// <summary>
        /// Property name.
        /// </summary>
        public string PropertyKey { get; }

        /// <summary>
        /// Property validator.
        /// </summary>
        public IPropertyValidator PropertyValidator { get; }

        /// <summary>
        /// Creates new instance of <see cref="RuleContext"/>.
        /// </summary>
        /// <param name="schemaProcessorContext">SchemaProcessorContext.</param>
        /// <param name="schema">Schema to process.</param>
        /// <param name="propertyKey">Property name.</param>
        /// <param name="propertyValidator">Property validator.</param>
        public RuleContext(SchemaProcessorContext schemaProcessorContext, JsonSchema schema, string propertyKey, IPropertyValidator propertyValidator)
        {
            SchemaProcessorContext = schemaProcessorContext;
            Schema = schema;
            PropertyKey = propertyKey;
            PropertyValidator = propertyValidator;
        }
    }
}