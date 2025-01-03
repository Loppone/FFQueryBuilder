﻿using System.Collections.Generic;

namespace FFQueryBuilder
{
    internal class ComparisonOperatorsBuilderSingleton
    {
        private static List<IComparisonOperator> instance;

        public static List<IComparisonOperator> GetInstance()
        {
            if (instance == null)
            {
                // Crea la lista di tutti gli operatori di confronto
                instance = new List<IComparisonOperator>()
                {
                    new EqualComparer(),
                    new NotEqualComparer(),
                    new GreaterThanComparer(),
                    new GreaterThanOrEqualComparer(),
                    new LessThanComparer(),
                    new LessThanOrEqualComparer(),
                    new IsNullComparer(),
                    new IsNotNullComparer(),
                    new ContainsComparer()
                };
            }

            return instance;
        }
    }
}
