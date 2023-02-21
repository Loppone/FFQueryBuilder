using System;

namespace FFQueryBuilder
{
    public interface IFilterValue
    {
        bool CanHandle(Type TypeOfValue);
        object GetValue(string value);
    }
}



//object value;

//if (valueType == typeof(DateTime) || valueType == typeof(DateTime?))
//{
//    value = DateTime.Parse(item.Value);
//}
//else if (valueType == typeof(int))
//{
//    value = int.Parse(item.Value);
//}
//else if (valueType == typeof(string))
//{
//    value = item.Value;
//}
//else
//{
//    // Aggiungere altre conversioni a seconda dei tipi di proprietà supportati
//    throw new NotSupportedException($"Il tipo di proprietà {valueType.Name} non è supportato.");
//}

// var condition = Expression.Equal(prop, Expression.Constant(Convert.ChangeType(item.Valore, valueType), valueType));
