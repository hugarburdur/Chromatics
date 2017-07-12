﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chromatics.DeviceInterfaces.EffectLibrary
{
    class DeviceEffects
    {
        //Key Groups

        //All Keys
        public readonly static string[] _GlobalKeys = { "Y", "D5", "D6", "D7", "T", "U", "G", "H", "J", "F3", "F4", "F5", "F6", "F7", "D4", "D8", "R", "F", "C", "V", "B", "N", "M", "K", "I", "F2", "F8", "D3", "E", "D", "X", "Space", "OemComma", "L", "O", "D9", "F1", "F9", "D2", "D0", "W", "S", "Z", "LeftAlt", "P", "OemSemicolon", "OemPeriod", "RightAlt", "D1", "Q", "A", "LeftWindows", "F10", "OemMinus", "OemLeftBracket", "OemApostrophe", "OemSlash", "Function", "Escape", "OemTilde", "Tab", "CapsLock", "LeftShift", "LeftControl", "F11", "OemEquals", "RightMenu", "OemRightBracket", "Macro1", "Macro2", "Macro3", "Macro4", "Macro5", "F12", "Backspace", "OemBackslash", "Enter", "RightShift", "RightControl" };

        //Central Keys
        public readonly static string[] _GlobalKeys2 = { "Y", "D5", "D6", "D7", "T", "U", "G", "H", "J", "D4", "D8", "R", "F", "C", "V", "B", "N", "M", "K", "I", "D3", "E", "D", "X", "Space", "OemComma", "L", "O", "D9", "D2", "D0", "W", "S", "Z", "LeftAlt", "P", "OemSemicolon", "OemPeriod", "RightAlt", "D1", "Q", "A", "LeftWindows", "OemMinus", "OemLeftBracket", "OemApostrophe", "OemSlash", "Function", "Escape", "OemTilde", "Tab", "CapsLock", "LeftShift", "LeftControl", "OemEquals", "RightMenu", "OemRightBracket", "Macro1", "Macro2", "Macro3", "Macro4", "Macro5", "Backspace", "OemBackslash", "Enter", "RightShift", "RightControl" };

        //Outer Keys
        public readonly static string[] _GlobalKeys3 = { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "NumLock", "Num0", "Num1", "Num2", "Num3", "Num4", "Num5", "Num6", "Num7", "Num8", "Num9", "NumDivide", "NumMultiply", "NumSubtract", "NumAdd", "NumEnter", "NumDecimal" };

        //Pulse Out From Centre
        public readonly static string[] _PulseOutStep0 = { "Y" };
        public readonly static string[] _PulseOutStep1 = { "D5", "D6", "D7", "T", "U", "G", "H", "J" };
        public readonly static string[] _PulseOutStep2 = { "F3", "F4", "F5", "F6", "F7", "D4", "D8", "R", "F", "C", "V", "B", "N", "M", "K", "I" };
        public readonly static string[] _PulseOutStep3 = { "F2", "F8", "D3", "E", "D", "X", "Space", "OemComma", "L", "O", "D9" };
        public readonly static string[] _PulseOutStep4 = { "F1", "F9", "D2", "D0", "W", "S", "Z", "LeftAlt", "P", "OemSemicolon", "OemPeriod", "RightAlt" };
        public readonly static string[] _PulseOutStep5 = { "D1", "Q", "A", "LeftWindows", "F10", "OemMinus", "OemLeftBracket", "OemApostrophe", "OemSlash", "Function" };
        public readonly static string[] _PulseOutStep6 = { "Escape", "OemTilde", "Tab", "CapsLock", "LeftShift", "LeftControl", "F11", "OemEquals", "RightMenu", "OemRightBracket", "OemBackslash" };
        public readonly static string[] _PulseOutStep7 = { "Macro1", "Macro2", "Macro3", "Macro4", "Macro5", "F12", "Backspace", "Enter", "RightShift", "RightControl" };

        //Numpad Flash Effect
        public readonly static string[] _NumFlash = { "NumLock", "NumDivide", "NumMultiply", "Num7", "Num8", "Num9", "Num4", "Num5", "Num6", "Num1", "Num2", "Num3" };
    }
}
