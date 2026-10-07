namespace lab13;

public partial class Form1 : Form
{
    private const decimal SeatPrice = 180m;
    private readonly List<Button> selectedSeats = new();

    public Form1()
    {
        InitializeComponent();
        CreateSeatMap();
        UpdateSummary();
    }

    private void CreateSeatMap()
    {
        for (var row = 0; row < 6; row++)
        {
            for (var seat = 0; seat < 8; seat++)
            {
                var button = new Button
                {
                    Text = $"{row + 1}-{seat + 1}",
                    Size = new Size(58, 48),
                    Margin = new Padding(6),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(220, 252, 231),
                    ForeColor = Color.FromArgb(22, 101, 52),
                    Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold),
                    Tag = false,
                    Cursor = Cursors.Hand,
                };
                button.FlatAppearance.BorderColor = Color.FromArgb(134, 239, 172);
                button.FlatAppearance.BorderSize = 1;
                button.Click += Seat_Click;
                seatsTable.Controls.Add(button, seat, row);
            }
        }
    }

    private void Seat_Click(object? sender, EventArgs e)
    {
        if (sender is not Button seat)
            return;

        var isSelected = (bool)seat.Tag!;
        seat.Tag = !isSelected;
        if (isSelected)
        {
            selectedSeats.Remove(seat);
            SetSeatStyle(seat, false);
        }
        else
        {
            selectedSeats.Add(seat);
            SetSeatStyle(seat, true);
        }

        UpdateSummary();
    }

    private static void SetSeatStyle(Button seat, bool selected)
    {
        seat.BackColor = selected ? Color.FromArgb(37, 99, 235) : Color.FromArgb(220, 252, 231);
        seat.ForeColor = selected ? Color.White : Color.FromArgb(22, 101, 52);
        seat.FlatAppearance.BorderColor = selected ? Color.FromArgb(29, 78, 216) : Color.FromArgb(134, 239, 172);
    }

    private void UpdateSummary()
    {
        var count = selectedSeats.Count;
        lblSelected.Text = count == 0 ? "Місця не обрано" : $"{count} {GetSeatWord(count)} обрано";
        lblTotal.Text = $"{count * SeatPrice:N0} грн";
        lblTotal.Text = lblTotal.Text.Replace(",", " ");
    }

    private static string GetSeatWord(int count) =>
        count % 10 == 1 && count % 100 != 11 ? "місце" :
        count % 10 is >= 2 and <= 4 && (count % 100 < 10 || count % 100 >= 20) ? "місця" :
        "місць";

    private void btnClear_Click(object? sender, EventArgs e)
    {
        foreach (var seat in selectedSeats.ToArray())
        {
            seat.Tag = false;
            SetSeatStyle(seat, false);
        }

        selectedSeats.Clear();
        UpdateSummary();
    }
}
