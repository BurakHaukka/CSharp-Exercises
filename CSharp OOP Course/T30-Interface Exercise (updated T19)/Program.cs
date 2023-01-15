using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T30
{
    internal class Program
    {
        public interface ICharacterCalculations 
        {
            void calcDamage();
            void calcMagicDamage();
            void physResist();
            void magiResist();
            
        }
        
        public class BaseStats
        {
            public string Name { get; set; }
            public string Weapon { get; set; }
            public int WeaponDamage { get; set; }
            public int Damage { get; set; }
            public int magicDamage { get; set; }
            public int HP { get; set; }
            public int Mana { get; set; }
            public int Str { get; set; }
            public int Dex { get; set; }
            public int Vit { get; set; }
            public int Int { get; set; }
            public int Char { get; set; }

            //Resistances of the character
            public int PhysicalResistance { get; set; }
            public int MagicalResistance { get; set; }

            


        }

        public class Orc : BaseStats, ICharacterCalculations
        {
            public int OrcStr
            {
                get { return Str; }
                set
                {
                    Str = value + 2;
                    return;
                }
            }

            public int OrcInt
            {
                get { return Int; }
                set
                {
                    Int = value - 1;
                    return;
                }
            }
            public int OrcHp
            {
                get { return HP; }
                set
                {
                    HP = value + 10;
                }
            }

            public virtual string ToString()
            {
                return $"Name: {Name}\nStrength: {Str}\nDexterity: {Dex}\nVitality: {Vit}\nIntelligence: {Int}\nCharisma: {Char}\n\nWeapon: {Weapon}-Damage: {WeaponDamage}\nDamage: {Damage}\nHP: {HP}\nMana: {Mana}\nMagic Damage: {magicDamage}\n\nResistances:\nPhysical: {PhysicalResistance}\nMagical: {MagicalResistance}\n";
            }


            public void magiResist()
            {
                MagicalResistance = (OrcInt + Vit) / 5;
            }

            public void physResist() 
            {
                PhysicalResistance = (OrcStr + Vit) / 5;
            }

            public void calcDamage() 
            {
                Damage = WeaponDamage + (OrcStr / 5);
            }

            public void calcMagicDamage()
            {
                magicDamage = (OrcInt / 5);
            }

        }

     

        public class Elf : BaseStats, ICharacterCalculations
        {
            public int ElfInt
            {
                get { return Int; }
                set
                {
                    Int = value + 2;
                }
            }


            public int ElfChar
            {
                get { return Char; }
                set
                {
                    Char = value + 2;
                }
            }
            public int ElfMana
            {
                get { return Mana; }
                set
                {
                    Mana = value + 10;
                }
            }

            public int ElfDex
            {
                get { return Dex; }
                set
                {
                    Dex = value + 2;
                }
            }

            public int ElfStr
            {
                get { return Str; }
                set
                {
                    Str = value - 2;
                }
            }

            public virtual string ToString()
            {
                return $"Name: {Name}\nStrength: {Str}\nDexterity: {Dex}\nVitality: {Vit}\nIntelligence: {Int}\nCharisma: {Char}\n\nWeapon: {Weapon}-Damage: {WeaponDamage}\nDamage: {Damage}\nHP: {HP}\nMana: {Mana}\nMagic Damage: {magicDamage}\n\nResistances:\nPhysical: {PhysicalResistance}\nMagical: {MagicalResistance}\n";
            }

            public void magiResist()
            {
                MagicalResistance = (ElfInt + Vit) / 5;
            }

            public void physResist()
            {
                PhysicalResistance = (ElfStr + Vit) / 5;
            }

            public void calcDamage()
            {
                Damage = WeaponDamage + (ElfStr / 5);
            }

            public void calcMagicDamage()
            {
                magicDamage = (ElfInt / 5);
            }
        }

        private static void Main(string[] args)

        // Base Stats are updated according to racial bonuses. Ex: Orc is given Str= 10 but saved as 12 because orcs get +2 to strength
        // Elf get a bonus to mana and other attributes :)

        // I updated my previous homework to calculate attibutes of the characters by using Interfaces The math is not exact but it works :)

        // Physical & Magical resistances

        // Physical & Magical Damage
        {
            
            Orc Lurtz = new Orc() { OrcStr = 10, Dex = 6, Vit = 7, OrcInt = 5, Char = 4, Name = "Lurtz", Weapon = "Axe", WeaponDamage = 8, Mana = 20, OrcHp = 20 };
            Console.WriteLine($"-----------\nCharacter: {Lurtz.Name}\n-----------\n");
            Lurtz.calcDamage();
            Lurtz.calcMagicDamage();
            Lurtz.magiResist();
            Lurtz.physResist();

            Console.WriteLine(Lurtz.ToString());
            Elf Legola = new Elf() { ElfStr = 7, ElfDex = 8, Vit = 5, ElfInt = 8, ElfChar = 6, Name = "Legola", Weapon = "Staff", WeaponDamage = 3, ElfMana = 30, HP = 20 };
            Console.WriteLine($"-----------\nCharacter: {Legola.Name}\n-----------\n");
            Legola.calcDamage();
            Legola.calcMagicDamage();
            Legola.magiResist();
            Legola.physResist();

            Console.WriteLine(Legola.ToString());
        }
    }
}
