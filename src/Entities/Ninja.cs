namespace projeto_poo.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType) 
        : base(Name, Level, HeroType)
        {
        }

        public new string Attack(){
            return this.Name + " " + "usa artes marciais";
        }
    }
}