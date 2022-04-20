namespace projeto_poo.src.Entities
{
    public class Mage : Wizard
    {
        public Mage(string Name, int Level, string HeroType) 
        : base(Name, Level, HeroType)
        {
        }

        public override string Attack(){
            return this.Name + " " + "lanca feiticos";
        }
    }
}