using EasyMVVM.Core;
using EasyMVVM.EasyAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace TestClient.ViewModel
{
    public class MainWinowViewModel : EasyViewModel
    {

        [BindingCommand("GetNameCommand")]
        public void GetName(object o)
        {
            MessageBox.Show(Name);
        }

        /// <summary>
        /// 名称属性,使用自动更新UI特性
        /// </summary>
        [AutoUIProperdy]
        public string Name { set; get; }

        /// <summary>
        /// 年龄属性,不会自动更新UI
        /// </summary>
        public string Age { set; get; }

        /// <summary>
        /// 获取名称命令
        /// </summary>
        public EasyCommand GetNameCommand { set; get; }
    }
}
