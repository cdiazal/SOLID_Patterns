namespace GangOfFour.State.Structural
{
    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    abstract class State
    {
        public abstract void Handle(Context context);
    }
}