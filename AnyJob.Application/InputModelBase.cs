using System.Reflection;

namespace AnyJob.Application
{
    /// <summary>
    /// Base class for input models
    /// </summary>
    public class InputModelBase
    {
        /// <summary>
        /// Prepare model for using
        /// </summary>
        public void Prepare()
        {
            // Gets all properties of model
            PropertyInfo[] properties = GetType().GetProperties();

            // Gets all string properties which could be trimmed
            IEnumerable<PropertyInfo> stringProperties = properties.Where(p => p.PropertyType == typeof(string)
                                                                            && p.CustomAttributes.All(a => a.AttributeType != typeof(NotTrimableAttribute)));
            foreach (PropertyInfo stringProperty in stringProperties)
                if (stringProperty.GetMethod!.Invoke(this, Array.Empty<object>()) is string value && !string.IsNullOrWhiteSpace(value))
                    stringProperty.SetMethod!.Invoke(this, new object[] { value.Trim() });

            // Perform the same method for children of target model
            IEnumerable<PropertyInfo> childModelsProperties = properties.Where(p => p.PropertyType.IsSubclassOf(GetType()));
            foreach (PropertyInfo childModelProperty in childModelsProperties)
            {
                InputModelBase childModel = (childModelProperty.GetMethod!.Invoke(this, Array.Empty<object>()) as InputModelBase)!;
                childModel.Prepare();
            }
        }
    }

    /// <summary>
    /// Attribute is marked only for that string properties of the model which should not be trimmed
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class NotTrimableAttribute : Attribute
    {
    }
}
