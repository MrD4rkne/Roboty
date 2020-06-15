using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Robots
{
    public class Robot
    {
        private const string Letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string Name { get; private set; }
        public Type Type { get; private set; }
        public Robot(List<Robot> robots)
        {
            ChangeName(robots);
            this.Type = (Type)new Random().Next(0, 3);
        }
        private void ChangeName(List<Robot> robots)
        {
            string pre_name = string.Empty, new_name = string.Empty;
            if (this.Name != null)
                pre_name = this.Name;
            do
            {
                Random rd = new Random();
                new_name = string.Empty;
                new_name += Letters[rd.Next(0, Letters.Length)];
                new_name += Letters[rd.Next(0, Letters.Length)];
                new_name += (char)rd.Next(48, 58);
                new_name += (char)rd.Next(48, 58);
                new_name += (char)rd.Next(48, 58);               
            } while (robots.FindIndex(x => x.Name == new_name) >= 0);
            this.Name = new_name;
            if(pre_name!=string.Empty)
                Debug.WriteLine("Znieniono nazwę z {0} na {1}",pre_name,this.Name);
        }
        public void Reset(List<Robot> robots)
        {
            ChangeName(robots);
        }
        public override string ToString()
        {
            return $"Name: {Name} Type: {Enum.GetName(typeof(Robots.Type), this.Type)}";
        }
    }
    public enum Type { Translator, CoffeeMaking, Bartender }
}
