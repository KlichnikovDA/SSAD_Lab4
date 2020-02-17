using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class Component
    {
        protected string Name;
        protected string Function;

        public virtual void Add(Component Item) { }

        public virtual void Remove(Component Item) { }

        public virtual void GetDescription() { }
    }

    class SmartThingsGroup : Component
    {
        List<Component> Children;

        public SmartThingsGroup(string Name, string Func)
        {
            this.Name = Name;
            Function = Func;
            Children = new List<Component>();
        }

        public override void Add(Component Item)
        {
            Children.Add(Item);
        }

        public override void Remove(Component Item)
        {
            Children.Remove(Item);
        }

        public override void GetDescription()
        {
            Console.WriteLine("Группа {0}, реализующая функцию {1}", Name, Function);
            Console.WriteLine("Данная группа образована из следующих элементов:");
            foreach (Component Child in Children)
                Child.GetDescription();
            Console.WriteLine();
        }
    }

    class SmartThing : Component
    {
        public SmartThing(string Name, string Func)
        {
            this.Name = Name;
            Function = Func;
        }

        public override void GetDescription()
        {
            Console.WriteLine("Элемент {0}, реализующий функцию {1}", Name, Function);
        }
    }
}
