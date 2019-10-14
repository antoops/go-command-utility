namespace Go.Common.Entities
{
    public abstract class BuiltInCommand : Command
    {
        public string Configuration { get; set; }
        public BuiltInCommand()
        {
            Type = CommandType.BuiltIn;
        }
        public abstract override bool Execute(string parameter);
    }
}
