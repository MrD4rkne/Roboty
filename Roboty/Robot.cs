using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Robots
{
    public class Robot
    {
        private const string Letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        /// <summary>
        /// Zmienna przechowująca nazwę robota
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Zmienna przechowująca typ robota
        /// </summary>
        public Type Type { get; private set; }
        public Robot(List<Robot> robots)
        {
            ChangeName(robots);
            this.Type = (Type)new Random().Next(0, 3);
        }
        /// <summary>
        /// Funkcja nadająca/zmieniająca nazwę robota
        /// </summary>
        /// <param name="robots"></param>
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
                Debug.WriteLine("Zmieniono nazwę z {0} na {1}",pre_name,this.Name);
        }
        /// <summary>
        /// Funkcja do resetowania robota do ustawień fabrycznych
        /// </summary>
        /// <param name="robots"></param>
        public void Reset(List<Robot> robots)
        {
            ChangeName(robots);
        }
        /// <summary>
        /// Funkcja do konwersji do stringa
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Name: {Name} Type: {Enum.GetName(typeof(Robots.Type), this.Type)}";
        }
        public string GetRobotName()
        {
            return this.Name;
        }
        public Type GetRobotType()
        {
            return this.Type;
        }
    }
    /// <summary>
    /// Enum opisujący typy robota
    /// </summary>
    public enum Type { Translator, CoffeeMaking, Bartender }
}
