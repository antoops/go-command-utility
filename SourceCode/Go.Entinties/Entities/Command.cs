namespace Go.Common.Entities
{
    public abstract class Command
    {
        public string Name { get; set; }
        public string ActionScript { get; set; }
        public string Parameter { get; set; }

        public CommandType Type { get; set; }

        public abstract bool Execute(string parameter);
    }
}
