using EasyMVVM.EasyAttributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace EasyMVVM.Core
{
    public class EasyViewModel
    {
        public EasyViewModel()
        {
            this.GetType().GetMethods().ToList().ForEach(
                method => { 
                    var BindingedCommand=method.GetCustomAttributes(false).FirstOrDefault(p =>p.GetType().Name==
                        typeof(BindingCommandAttribute).Name) as BindingCommandAttribute;
                    if (BindingedCommand != null)
                    {
                        var Command = this.GetType().GetProperties().FirstOrDefault(p => p.Name == BindingedCommand.CommandName);
                        if (Command != null)
                        {
                            Command.SetValue(this, new EasyCommand() { ExecuteAction = (o) => method.Invoke(this, new[] { o }) }, null);
                        }
                    }
                });
        }
    }
}
