namespace Rz.GangOfFour.Behavioral.Command
{
    public class CastSpellCommand:ICommand
    {
        private readonly Character character;
        private readonly string spell;

        public CastSpellCommand(
            Character character, string spell)
        {
            this.character = character;
            this.spell = spell;
        }


        public void Execute()
        {
            character.CastSpell(spell);
        }
    }
}
