using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 备忘录模式
{
    class Originator
    {
        private string _name;
        private int _age;
        private int _heigth;

        public Originator(string name,int age,int heigth)
        {
            this.Name = name;
            this.Age = age;
            this.Heigth = heigth;
        }

        public void SetMemento(Memento m)
        {
            this.Name = m.State.Name;
            this.Age = m.State.Age;
            this.Heigth = m.State.Heigth;
        }

        public Memento CreateMemento()
        {
            State state = new State();
            state.Name = this.Name;
            state.Age = this.Age;
            state.Heigth = this.Heigth;
            return new Memento(state);
        }

        public override string ToString()
        {
            return Name + " " + Age + " " + Heigth;
        }

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public int Heigth { get => _heigth; set => _heigth = value; }
    }
}
