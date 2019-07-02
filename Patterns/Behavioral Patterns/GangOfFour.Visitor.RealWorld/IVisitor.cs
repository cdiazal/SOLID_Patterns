namespace GangOfFour.Visitor.RealWorld
{
    /// <summary>
    /// The 'Visitor' interface
    /// </summary>
    interface IVisitor
    {
        void Visit(Element element);
    }
}