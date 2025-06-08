using System;
using System.ComponentModel;
using System.Reflection;

namespace AlfredAutoClick.Core
{
    /// <summary>
    /// Represents the type of mouse button used for clicking.
    /// </summary>
    public enum ClickType
    {
        [Description("Left click")]
        Left,

        [Description("Right click")]
        Right,

        [Description("Middle click")]
        Middle
    }

    /// <summary>
    /// Defines how the click action is performed.
    /// </summary>
    public enum ClickMode
    {
        [Description("Multiple clicks")]
        MultiClick,

        [Description("Hold button down")]
        HoldDown
    }

    /// <summary>
    /// Defines how the hotkey triggers the click action.
    /// </summary>
    public enum TriggerMode
    {
        [Description("Toggle")]
        Toggle,

        [Description("Single trigger")]
        SingleTrigger
    }

    /// <summary>
    /// Provides utility methods for working with enums.
    /// </summary>
    public static class EnumUtils
    {
        /// <summary>
        /// Gets the DescriptionAttribute text from an enum value, or its name if no description is set.
        /// </summary>
        public static string GetDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attr = field.GetCustomAttribute<DescriptionAttribute>();
            return attr != null ? attr.Description : value.ToString();
        }
    }
}
