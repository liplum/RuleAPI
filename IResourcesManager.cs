using System;
using System.Collections.Generic;

namespace RuleAPI
{
    public interface IResourcesManager
    {
        /// <summary>
        /// Getting the localized resouce's content via the key.
        /// </summary>
        /// <param name="fullKey">Format by "{packageID}.{ruleID}.{key}" .</param>
        /// <returns>The localized content.</returns>
        /// <exception cref="KeyNotFoundException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public string GetResourceBy(string fullKey);

        /// <summary>
        /// Trying getting the localized resouce's content via the key.
        /// </summary>
        /// <param name="fullKey">Format by "{packageID}.{ruleID}.{key}" .</param>
        /// <param name="content"></param>
        /// <returns>Whether this operation is successful.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool TryGetResourceBy(string fullKey, out string content);
    }
}