using System;
using System.IO;
using System.Runtime.Serialization;
using System.Windows;

namespace RuleAPI
{
    public interface IRule
    {
        /// <summary>
        /// Via this rule,generating a string which is a part of new name.
        /// </summary>
        /// <param name="file">The file which is needed to rename.</param>
        /// <returns>A string which is made via this rule.It could return "" if it does nothing.</returns>
        /// <exception cref="NotInitializeException"></exception>
        /// <exception cref="InvalidFunctionAreaParameterException"></exception>
        /// <exception cref="CannotGenerateStringException"></exception>
        /// <exception cref="FileNotExistsException"></exception>
        /// <exception cref="FileReadException"></exception>
        string GenerateString(FileInfo file);
        /// <summary>
        /// Getting a displayed name.
        /// </summary>
        /// <returns>The displayed name of this kind of rule.If there is no name,it would return "".</returns>
        string DisplayedName();
        /// <summary>
        /// Geting the function area where the users can type some parameters.
        /// </summary>
        /// <returns>A UIElement.If it didn't need a Function Area,it would return null.</returns>
        UIElement GetFuntionArea();
        /// <summary>
        /// Setting the Resources Manager even though this rule don't need.It should be called after constructed.
        /// </summary>
        /// <param name="resourcesManager">The implementation of IResourcesManager,which this rule uses.</param>
        /// <exception cref="ArgumentNullException">If the resourcesManager is null.</exception>
        void SetResourcesManager(IResourcesManager resourcesManager);
        /// <summary>
        /// Initializing this rule.It should be called after the <code>GetFuntionArea()</code> but before <code>GetFuntionArea()</code> .It can do something about Initialize the component.
        /// </summary>
        /// <exception cref="InitializationException"></exception>
        void Initialize();
    }

    /// <summary>
    /// If this rule needs intialization but not do it.
    /// </summary>
    [Serializable]
    public class NotInitializeException : Exception
    {
        public NotInitializeException() { }
        public NotInitializeException(string message) : base(message) { }
        public NotInitializeException(string message, Exception inner) : base(message, inner) { }
        protected NotInitializeException(
          SerializationInfo info,
          StreamingContext context) : base(info, context) { }
    }

    /// <summary>
    /// The Function Area contains the invalid parameter(s).It'll be displayed for the user on the window,so it should be localized.
    /// </summary>
    [Serializable]
    public class InvalidFunctionAreaParameterException : Exception
    {
        public InvalidFunctionAreaParameterException() { }
        public InvalidFunctionAreaParameterException(string message) : base(message) { }
        public InvalidFunctionAreaParameterException(string message, Exception inner) : base(message, inner) { }
        protected InvalidFunctionAreaParameterException(
          SerializationInfo info,
          StreamingContext context) : base(info, context) { }
    }

    /// <summary>
    /// There are something wrong,thus,it can't generate the string.
    /// </summary>
    [Serializable]
    public class CannotGenerateStringException : Exception
    {
        public CannotGenerateStringException() { }
        public CannotGenerateStringException(string message) : base(message) { }
        public CannotGenerateStringException(string message, Exception inner) : base(message, inner) { }
        protected CannotGenerateStringException(
          SerializationInfo info,
          StreamingContext context) : base(info, context) { }
    }

    /// <summary>
    /// There are something wrong,thus,it can't be Initialized.It maybe determine whether this rule object will be abandoned or not.
    /// </summary>
    [Serializable]
    public class InitializationException : Exception
    {
        public InitializationException() { }
        public InitializationException(string message) : base(message) { }
        public InitializationException(string message, Exception inner) : base(message, inner) { }
        protected InitializationException(
          SerializationInfo info,
          StreamingContext context) : base(info, context) { }
    }

    /// <summary>
    /// The file which is the parameter of <code>GenerateString(FileInof)</code> doesn't exist.
    /// </summary>
    [Serializable]
    public class FileNotExistsException : Exception
    {
        public FileNotExistsException() { }
        public FileNotExistsException(string message) : base(message) { }
        public FileNotExistsException(string message, Exception inner) : base(message, inner) { }
        protected FileNotExistsException(
          SerializationInfo info,
          StreamingContext context) : base(info, context) { }
    }

    /// <summary>
    /// The file which is the parameter of <code>GenerateString(FileInof)</code> can't be read.
    /// </summary>
    [Serializable]
    public class FileReadException : Exception
    {
        public FileReadException() { }
        public FileReadException(string message) : base(message) { }
        public FileReadException(string message, Exception inner) : base(message, inner) { }
        protected FileReadException(
          SerializationInfo info,
          StreamingContext context) : base(info, context) { }
    }
}
