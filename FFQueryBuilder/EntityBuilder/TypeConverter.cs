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

        private static T ConvertToNullable<T>(object value, T destinationTypeObjectPlaceholder)
        {
            if (value == null || value == DBNull.Value)
            {
                return default(T);
            }

            var underlyingType = Nullable.GetUnderlyingType(destinationTypeObjectPlaceholder.GetType());
            if (underlyingType != null)
            {
                var x1 = (T)System.Convert.ChangeType(value, underlyingType);
                var x1a = x1.GetType();

                return x1;
            }

            var x2 = (T)System.Convert.ChangeType(value, typeof(T));
            var x2a = x2.GetType();

            return x2;
        }
    }
}
