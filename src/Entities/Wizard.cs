namespace projeto_poo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) 
        : base(Name, Level, HeroType)
        {
        }

        public override string Attack(){
            return this.Name + " " + "lanca magia";
        }
    }
}