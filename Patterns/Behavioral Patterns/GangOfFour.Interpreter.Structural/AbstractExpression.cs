namespace GangOfFour.Interpreter.Structural
{
    /// <summary>
    /// The 'AbstractExpression' abstract class
    /// </summary>
    abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}