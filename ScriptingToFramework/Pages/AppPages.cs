using System;
using Framework.Selenium;

namespace ScriptingToFramework.Pages
{
    public class AppPages
    {
        [ThreadStatic]
        public static NameSelection NameSelect;
        
        [ThreadStatic]
        public static xyzBank Bank;

        public static void Init()
        {
            NameSelect = new NameSelection(Driver.Current);
            Bank = new xyzBank(Driver.Current);
        }

    }
}