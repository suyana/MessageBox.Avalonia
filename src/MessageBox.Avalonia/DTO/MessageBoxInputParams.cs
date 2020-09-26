namespace MessageBox.Avalonia.DTO
{
    public class MessageBoxInputParams : MessageBoxCustomParams
    {
        public bool IsPassword { get; set; } = false;
        public string WatermarkText { get; set; } = null;
    }
}