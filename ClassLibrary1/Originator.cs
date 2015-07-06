using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Originator
    {
        //需要保存的属性，可以是多个
        private String _state = "";

        public String GetState()
        {
            return _state;
        }
        public void SetState(String state)
        {
            this._state = state;
        }

        //创建备忘录，将当前需要保存的信息导入并实例化出一个Memento对象
        public Memento CreateMemento()
        {
            return new Memento(this._state);
        }
        //回复备忘录，将Memento导入并将相关数据恢复
        public void RestoreMemento(Memento memento)
        {
            this.SetState(memento.GetState());
        }
    }
}
