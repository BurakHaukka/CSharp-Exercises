// Implementing a simple inheritance. Using fantasy races for a game.

internal class Program
{
    //public class BaseInfo 
    //{
    //    public string Name { get; set; }
    //    public string Background { get; set; }
    //    public string Deity { get; set; }
    //}
    public class BaseStats
    {
        public string Name { get; set; }
        public string Weapon { get; set; }
        public int WeaponDamage { get; set; }
        public int HP { get; set; }
        public int Mana { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Vit { get; set; }
        public int Int { get; set; }
        public int Char { get; set; }

    }

    public class Orc : BaseStats 
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
            return $"Name: {Name}\nStrength: {Str}\nDexterity: {Dex}\nVitality: {Vit}\nIntelligence: {Int}\nCharisma: {Char}\n\nWeapon: {Weapon}\nDamage: {WeaponDamage}\nHP: {HP}\nMana: {Mana}\n\n";
        }
    }

    public class Elf : BaseStats
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
            return $"Name: {Name}\nStrength: {Str}\nDexterity: {Dex}\nVitality: {Vit}\nIntelligence: {Int}\nCharisma: {Char}\n\nWeapon: {Weapon}\nDamage: {WeaponDamage}\nHP: {HP}\nMana: {Mana}\n\n";
        }
    }

    private static void Main(string[] args)

        // Base Stats are updated according to racial bonuses. Ex: Orc is given Str= 10 but saved as 12 because orcs get +2 to strength
        // Elf get a bonus to mana and other attributes :)
    {
        Orc Lurtz = new Orc() {OrcStr = 10, Dex = 6, Vit = 7, OrcInt = 5, Char = 4, Name = "Lurtz", Weapon = "Axe", WeaponDamage = 8, Mana = 20, OrcHp = 20};
        Console.WriteLine(Lurtz.ToString());

        Elf Legola = new Elf() {ElfStr = 7, ElfDex = 8, Vit = 5, ElfInt = 8, ElfChar = 6, Name = "Legola", Weapon = "Bow", WeaponDamage = 5, ElfMana = 30, HP = 20 };
        Console.WriteLine(Legola.ToString());
    }
}