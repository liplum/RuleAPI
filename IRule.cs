using System.Globalization;
using System.IO;

namespace RuleAPI
{
    public interface IRule
    {
        /// <summary>
        /// Via this rule , generate a string which is a part of new name.
        /// </summary>
        /// <param name="file">The file which is needed to rename.</param>
        /// <returns>A string which is made via this rule</returns>
        string GenerateString(FileInfo file);
        /// <summary>
        /// Getting a displayed name from the culture.
        /// </summary>
        /// <param name="culture">It decides the returned value.</param>
        /// <returns>The displayed name of this kind of rule by the culture.</returns>
        string DisplayedName(CultureInfo culture);
        /// <summary>
        /// Getting a displayed name from default culture.
        /// </summary>
        /// <returns>The displayed name of this kind of rule by default culture.</returns>
        string DisplayedName();
        /// <summary>
        /// Geting the function area where the users can use the function of this rule.
        /// </summary>
        /// <returns>A panel.</returns>
        object GetFuntionArea();
    }
}
