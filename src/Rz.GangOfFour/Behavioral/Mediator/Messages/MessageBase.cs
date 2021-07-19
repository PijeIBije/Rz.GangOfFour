namespace Rz.GangOfFour.Behavioral.Mediator.Messages
{
    public abstract class MessageBase
    {
        public object Source { get; }

        protected MessageBase(object source)
        {
            Source = source;
        }
    }
}
