using System;

namespace FFQueryBuilder.EntityBuilder
{

    internal class TypeConverter : ITypeConverter
    {
        public object Convert(object sourceValue, Type destinationObjectType)
        {
            if (Nullable.GetUnderlyingType(destinationObjectType) == null)
            {
                return System.Convert.ChangeType(sourceValue, destinationObjectType);
            }
            else
            {
                Type underlyingType = Nullable.GetUnderlyingType(destinationObjectType); // Tipo sottostante del tipo nullable
                dynamic _ = Activator.CreateInstance(destinationObjectType,
                    underlyingType == null ? null : Activator.CreateInstance(underlyingType)); // Crea un'oggetto nullable con valore di default

                return ConvertToNullable(sourceValue, _);
            }
        }

        private static T ConvertToNullable<T>(object value, T _)
        {
            if (value == null || value == DBNull.Value)
            {
                return default(T);
            }

            var underlyingType = Nullable.GetUnderlyingType(_.GetType());
            if (underlyingType != null)
            {
                return (T)System.Convert.ChangeType(value, underlyingType);
            }

            return (T)System.Convert.ChangeType(value, typeof(T));
        }
    }
}
