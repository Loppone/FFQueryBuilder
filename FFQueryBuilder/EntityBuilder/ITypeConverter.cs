using System;

namespace FFQueryBuilder.EntityBuilder
{
    public interface ITypeConverter
    {
        object Convert(object sourceValue, Type destinationObjectType);
    }
}
