using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyMVVM.EasyAttributes
{
    [AttributeUsage(AttributeTargets.Method,AllowMultiple=true,Inherited=false)]
    public class BindingCommandAttribute : Attribute
    {
        public BindingCommandAttribute(string CommandName)
        {
            this.CommandName = CommandName;
        }

        /// <summary>
        /// 所绑定的命令的名称
        /// </summary>
        public string CommandName { set; get; }
    }
}
