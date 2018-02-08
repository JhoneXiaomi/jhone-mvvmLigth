using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
很简单，仅仅是包含一个实体对象，这边注意的的是那他继承了一个父类：ObservableObject，这个父类的作用就是保证能够检测属性是否被改变。
它实现了INotifyPropertyChanged接口，通过触发PropertyChanged事件达到通知UI更改的目的；
所以我们在定义实体对象的时候，只需要调用RaisePropertyChanged(PropertyName)就可以进行属性更改通知了。
所以实体里面定义的每个属性都加上RaisePropertyChanged(PropertyName)的调用，就可以实现对UI的交互更新了。
*/
namespace jhone_mvvmLigth.View
{

   public class WelcomeModel: ObservableObject
    {
        private String introduction;

        public String Introduction
        {
            get { return introduction; }
            set { introduction = value;RaisePropertyChanged(() => Introduction); }
        }
    }
}
