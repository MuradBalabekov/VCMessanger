using Microsoft.Maui.Controls.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace VCMessanger.Pages;

public partial class ChatPage : ContentPage
{
    public ChatPage()
    {
        InitializeComponent();
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        Border border = new()
        {
            HorizontalOptions = LayoutOptions.End,
            StrokeShape = new RoundRectangle()
            {
                CornerRadius = 10
            },
            Content = new VerticalStackLayout()
            {
                HorizontalOptions = LayoutOptions.End,
                Children = { 
                    new Label
                    {
                        Text = InputText.Text,
                        FontSize = 18,
                        VerticalOptions = LayoutOptions.End,
                        HorizontalOptions = LayoutOptions.Start,
                        Margin = new Thickness(10, 0, 10, 0)
                    },
                    new Label
                    {
                        Text = InputText.Text,
                        FontSize = 18,
                        VerticalOptions = LayoutOptions.End,
                        HorizontalOptions = LayoutOptions.Start,
                        Margin = new Thickness(10, 0, 10, 0)
                    },
                    new Label
                    {
                        Text = DateTime.Now.ToString("T"),
                        FontSize = 12,
                        VerticalOptions = LayoutOptions.End,
                        HorizontalOptions = LayoutOptions.End,
                        Margin = new Thickness(10, 0, 10, 10)
                    }
                }
            }
        };

        layout.Children.Add(border);
    }
}