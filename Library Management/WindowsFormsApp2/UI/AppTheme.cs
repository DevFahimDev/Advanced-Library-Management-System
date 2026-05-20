using System.Drawing;

namespace AdvancedLibrarySystem.UI
{
    // A 'static' class means we don't need to create an object to use it.
    // We can just call AppTheme.Background anywhere in our app!
    public static class AppTheme
    {
        // 1. Background Colors
        public static Color Background = Color.FromArgb(30, 30, 44);     // Deep Slate
        public static Color PanelBackground = Color.FromArgb(37, 37, 53); // Lighter Slate for sidebars

        // 2. Text Colors
        public static Color PrimaryText = Color.White;
        public static Color MutedText = Color.FromArgb(160, 160, 160);    // Gray for placeholders

        // 3. Button Gradients (Deep Blue to Vibrant Blue)
        public static Color ButtonGradientLeft = Color.FromArgb(0, 82, 212);
        public static Color ButtonGradientRight = Color.FromArgb(67, 100, 247);

        // 4. Borders and Lines
        public static Color BorderColor = Color.FromArgb(63, 63, 90);
    }
}