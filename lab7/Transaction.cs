using System.Text.Json.Serialization;

namespace lab7
{
    public enum OperationType
    {
        Income,
        Expense
    }

    public class Transaction
    {
        public DateTime Date { get; set; }
        public OperationType Type { get; set; }
        public string Category { get; set; } = "";
        public decimal Amount { get; set; }
        public string Description { get; set; } = "";

        [JsonIgnore]
        public string TypeName => Type == OperationType.Income ? "Дохід" : "Витрата";
    }
}
