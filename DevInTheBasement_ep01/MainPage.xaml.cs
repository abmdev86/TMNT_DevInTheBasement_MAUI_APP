namespace DevInTheBasement_ep01;

public partial class MainPage : ContentPage
{
	int count = 0;
	Random random = new Random();
	
	public MainPage()
	{
		InitializeComponent();
		

		 // TODO: ROTATE SHEDDER and display slider value
		Slider.Value = 180;
	

	}

	async void RotateShredder(double deg, uint time = 2000)
    {
		await Shredder.RotateTo(deg, time);

    }

    void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
    {
		
         double value = args.NewValue;
		sliderLabel.Text = $"{value}";
    }
    private  void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
        {
            CounterBtn.Text = $" Leonardo punched Shredder  {count} time";
           RotateShredder(Slider.Value);

        }

        else
        {
		
            CounterBtn.Text = $" Leonardo punched Shredder  {count} times";

			Slider.Value = random.Next(360);
            RotateShredder(Slider.Value);


        }




        SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

