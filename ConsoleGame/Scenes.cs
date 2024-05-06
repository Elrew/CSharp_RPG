using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Scenes
    {
        public string Name { get; set; }
        public Action OnEnter { get; set; }
        public Action OnExit { get; set; }
        public bool IsActive { get; set; }


        public Scenes(string name, Action onEnter, Action onExit,bool IsActive)
        {
            Name = name;
            OnEnter = onEnter;
            OnExit = onExit;
            IsActive = false;
        }

        public void Enter()
        {
            Console.Clear();
            IsActive= true;
            OnEnter?.Invoke();
        }

        public void Exit()
        {
            IsActive= false;
            OnExit?.Invoke();
        }
    }


}
