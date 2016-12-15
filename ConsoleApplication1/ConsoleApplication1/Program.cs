using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  interface IWarior {
        void attack(string weapon, int powerOfAttack);
        void defend(int damage, int health);
                    }
public class Program
    {
          static void Main(string[] args)
        {
           // Ork class entitty creation and method calling 
           Ork ork = new Ork();
           ork.fields();
           ork.attack(Ork.weapon, Ork.powerOfAttack);
           ork.defend(Ork.damage, Ork.health);
           Console.WriteLine("-----------------------------");

            // Elf class entitty creation and method calling 
            Elf elf = new Elf();
            elf.fields();
            elf.attack(Elf.weapon, Elf.powerOfAttack);
            elf.defend(Elf.damage, Elf.health);
            Console.WriteLine("-----------------------------");

            // Hobbit class entitty creation and method calling 
            Hobbit hobbit = new Hobbit();
            hobbit.fields();
            hobbit.attack(Hobbit.weapon, Hobbit.powerOfAttack);
            hobbit.defend(Hobbit.damage, Hobbit.health);
            Console.WriteLine("-----------------------------");

            // Gnome class entitty creation and method calling 
            Gnome gnome = new Gnome();
            gnome.fields();
            gnome.attack(Gnome.weapon, Gnome.powerOfAttack);
            gnome.defend(Gnome.damage, Gnome.health);
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
        } 
           }
class Ork : IWarior  // class which describes Ork's properties and skills 
    {
        // Ork's properties declaration section
        public static string weapon;
        public static int health;
        public static int powerOfAttack;
        public static int damage;

        // Random class entity creation (for randomizing)
        Random rnd = new Random();
       
        // Fields initialization method
        public void fields()
        {
            Console.WriteLine("Enter Ork's damage");
            Ork.damage = Convert.ToInt32(Console.ReadLine());
            Ork.weapon = "Strily";
            Ork.health = rnd.Next(0, 100);
            Ork.powerOfAttack = rnd.Next(0, 100);
        }

        // Method realize Ork's attack function
        public void attack(string Weapon,int PowerOfAttack)
        {
           Console.WriteLine("Ork's weapon - " + Ork.weapon);
           Console.WriteLine("Ork's power of Attack- " + powerOfAttack);
        }

        // Method realize Ork's defend function and determins if he is alive or not
        public void defend(int damage, int health)
        {
            Console.WriteLine("Ork's health - " + Ork.health);
            if (damage < health)
            {
                Console.WriteLine("Ork is alive");
            } else {
                Console.WriteLine("Ork is dead");
            }
       }

        // Default constructor for Ork class
        public Ork() { }
    }
    class Elf : IWarior  // class which describes Elf's properties and skills 
    {
        // Elf's properties declaration section
        public static string weapon;
        public static int health;
        public static int powerOfAttack;
        public static int damage;

        // Random class entity creation (for randomizing)
        Random rnd = new Random();

        // Fields initialization method
        public void fields()
        {
            Console.WriteLine("Enter Elf's damage");
            Elf.damage = Convert.ToInt32(Console.ReadLine());
            Elf.weapon = "AK47";
            Elf.health = rnd.Next(0, 100);
            Elf.powerOfAttack = rnd.Next(0, 100);
        }

        // Method realize Elf's attack function
        public void attack(string Weapon, int powerOfAttack)
        {
            Console.WriteLine("Elf's weapon - " + weapon);
            Console.WriteLine("Elf's power of Attack- " + powerOfAttack);
        }

        // Method realize Elf's defend function and determins if he is alive or not
        public void defend(int damage, int health)
        {
            Console.WriteLine("Elf's health - " + Elf.health);
            if (damage < health)
            {
                Console.WriteLine("Elf is alive");
            }
            else
            {
                Console.WriteLine("Elf is dead");
            }
        }

        // Default constructor for Elf class
        public Elf() { }

            }
    class Hobbit : IWarior  // class which describes Hobbit's properties and skills 
    {
        // Hobbit's properties declaration section
        public static string weapon;
        public static int health;
        public static int powerOfAttack;
        public static int damage;

        // Random class entity creation (for randomizing)
        Random rnd = new Random();

        // Fields initialization method
        public void fields()
        {
            Console.WriteLine("Enter Hobbit's damage");
            Hobbit.damage = Convert.ToInt32(Console.ReadLine());
            Hobbit.weapon = "AK47";
            Hobbit.health = rnd.Next(0, 100);
            Hobbit.powerOfAttack = rnd.Next(0, 100);
        }

        // Method realize Hobbit's attack function
        public void attack(string weapon, int powerOfAttack)
        {
            Console.WriteLine("Hobbit's weapon - " + weapon);
            Console.WriteLine("Hobbit's power of Attack- " + powerOfAttack);
        }

        // Method realize Hobbit's defend function and determins if he is alive or not
        public void defend(int damage, int health)
        {
            Console.WriteLine("Hobbit's health - " + Hobbit.health);
            if (damage < health)
            {
                Console.WriteLine("Hobbit is alive");
            }
            else
            {
                Console.WriteLine("Hobbit is dead");
            }
        }

        // Default constructor for Hobbit class
        public Hobbit() { }
    }
    class Gnome : IWarior  // class which describes Gnome's properties and skills 
    {
        // Gnome's properties declaration section
        public static string weapon;
        public static int health;
        public static int powerOfAttack;
        public static int damage;

        // Random class entity creation (for randomizing)
        Random rnd = new Random();

        // Fields initialization method
        public void fields()
        {
            Console.WriteLine("Enter Gnome's damage");
            Gnome.damage = Convert.ToInt32(Console.ReadLine());
            Gnome.weapon = "AK47";
            Gnome.health = rnd.Next(0, 100);
            Gnome.powerOfAttack = rnd.Next(0, 100);
        }

        // Method realize Gnome's attack function
        public void attack(string weapon, int powerOfAttack)
        {
            Console.WriteLine("Gnome's weapon - " + weapon);
            Console.WriteLine("Gnome's power of Attack- " + powerOfAttack);
        }

        // Method realize Gnome's defend function and determins if he is alive or not
        public void defend(int damage, int health)
        {
            Console.WriteLine("Gnom's health - " + Gnome.health);
            if (damage < health)
            {
                Console.WriteLine("Gnome is alive");
            }
            else
            {
                Console.WriteLine("Gnome is dead");
            }
        }

        // Default constructor for Gnome class
        public Gnome() { }
    }

}