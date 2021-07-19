namespace Rz.GangOfFour.Behavioral.Command
{
    public class MoveCommand:ICommand
    {
        private readonly Character character;
        private readonly int x;
        private readonly int y;

        public MoveCommand(Character character, int x, int y)
        {
            this.character = character;
            this.x = x;
            this.y = y;
        }

        public void Execute()
        {
            character.Move(y,x);
        }
    }
}
