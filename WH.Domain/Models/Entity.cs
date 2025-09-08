namespace WH.Domain.Models
{
    public abstract class Entity
    { }

    public interface IHaveId
    {
        public string? Id { get; set; }
    }

    public interface IHaveDate
    {
        public DateTime Date { get; set; }
    }

    public interface IHaveName
    {
        public string? Name { get; set; }
    }

    public interface IHaveRecorder
    {
        public string? Recorder { get; set; }
    }

    public interface IHaveLineNumber
    {
        public int LineNumber { get; set; }
    }
}
