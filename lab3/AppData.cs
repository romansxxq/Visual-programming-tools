namespace lab3
{
    public sealed class AppData
    {
        public List<StudentInfo> Students { get; set; } = new();
    }

    public sealed class StudentInfo
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string Major { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{Surname} {Name} {MiddleName}, {Birthday:dd.MM.yyyy}, {Gender}, {Major}";
        }
    }
}
