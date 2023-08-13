namespace ControlesTipoVista.Controles;

public partial class CardView : ContentView
{
	public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CardView), string.Empty);

	public string CardTitle
	{
		get => (string)GetValue(CardView.CardTitleProperty);
		set => SetValue(CardView.CardTitleProperty, value);
	}

    public static readonly BindableProperty CardDescriptionProperty = BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(CardView), string.Empty);

    public string CardDescription
    {
        get => (string)GetValue(CardView.CardDescriptionProperty);
        set => SetValue(CardView.CardDescriptionProperty, value);
    }

    public static readonly BindableProperty IconImageSourceProperty = BindableProperty.Create(nameof(IconImageSource), typeof(ImageSource), typeof(CardView), defaultValue: null);

    public ImageSource IconImageSource
    {
        get => (ImageSource)GetValue(CardView.IconImageSourceProperty);
        set => SetValue(CardView.IconImageSourceProperty, value);
    }

    public static readonly BindableProperty IconBackgroundColorProperty = BindableProperty.Create(nameof(IconBackgroundColor), typeof(Color), typeof(CardView), defaultValue: default(Color));

    public Color IconBackgroundColor
    {
        get => (Color)GetValue(CardView.IconBackgroundColorProperty);
        set => SetValue(CardView.IconBackgroundColorProperty, value);
    }

    public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CardView), defaultValue: default(Color));

    public Color BorderColor
    {
        get => (Color)GetValue(CardView.BorderColorProperty);
        set => SetValue(CardView.BorderColorProperty, value);
    }
    public static readonly BindableProperty CardColorProperty = BindableProperty.Create(nameof(CardColor), typeof(Color), typeof(CardView), defaultValue: default(Color));

    public Color CardColor
    {
        get => (Color)GetValue(CardView.CardColorProperty);
        set => SetValue(CardView.CardColorProperty, value);
    }

    public CardView()
	{
		InitializeComponent();
	}
}