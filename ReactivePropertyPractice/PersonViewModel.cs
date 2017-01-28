using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reactive.Bindings;

namespace ReactivePropertyPractice
{
    public class PersonViewModel
    {
        public ReactiveProperty<string> Name { get; } = new ReactiveProperty<string>();
    }
}
