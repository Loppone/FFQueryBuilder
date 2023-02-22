using System.Linq;

namespace FFQueryBuilder
{
    internal static class ConditionOperatorFactory
    {
        public static IComparisonOperator CreateConditionOperators(CompareOperator @operator)
        {
            var comparers = ComparisonOperatorsBuilderSingleton.GetInstance();
            return comparers.FirstOrDefault(x => x.Operator == @operator);
        }
    }
}
