using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegacyConquer.Api
{
    /// <summary>
    /// The Option Callback delegate for your script.
    /// </summary>
    public delegate void OptionCallback();
    /// <summary>
    /// The input callback delegate for your script.
    /// </summary>
    /// <param name="input"></param>
    public delegate void InputCallback(string input);

    /// <summary>
    /// The interface for handling npc dialog creation.
    /// </summary>
    public interface INpcDialog
    {
        /// <summary>
        /// The dialog text.
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// The dialog npc avatar
        /// </summary>
        ushort Avatar { get; set; }

        /// <summary>
        /// PreMade template to add an option that closes the dialog and has the text 'I See.'
        /// </summary>
        void ISee();

        /// <summary>
        /// PreMade template to add an option that closes the dialog and has the text 'Just passing by.'
        /// </summary>
        void PassingBy();

        /// <summary>
        /// Add a input option to the dialog
        /// </summary>
        /// <param name="callback">The input callback method. Check the InputCallback Delegate above.</param>
        /// <param name="text">The text to show above the input field.</param>
        /// <param name="maxLen">The max length of the input field.</param>
        void Input(InputCallback callback, string text, uint maxLen = 100);

        /// <summary>
        /// Adds an Option to the dialog.
        /// </summary>
        /// <param name="callback">The callback method when the user clicks the option, Check the OptionCallback delegate above.</param>
        /// <param name="text">The text for user to click.</param>
        void Option(OptionCallback callback, string text);
    }
}
