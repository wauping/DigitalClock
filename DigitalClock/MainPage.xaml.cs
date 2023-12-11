﻿namespace DigitalClock
{
    public partial class MainPage : ContentPage
    {
        private readonly Indicator _indicator1 = new();
        private readonly Indicator _indicator2 = new();
        private readonly Indicator _indicator3 = new();
        private readonly Indicator _indicator4 = new();
        private readonly Indicator _indicator5 = new();
        private readonly Indicator _indicator6 = new();

        public MainPage()
        {
            InitializeComponent();
            StartTimer();
        }

        private async void StartTimer()
        {
            var timer = new PeriodicTimer(TimeSpan.FromSeconds(1));

            while (await timer.WaitForNextTickAsync())
            {
                SegmentDot1.IsVisible = SegmentDot2.IsVisible = !SegmentDot1.IsVisible;

                var now = DateTime.Now;

                _indicator1.DigitOfIndicator(now.Hour / 10);
                _indicator2.DigitOfIndicator(now.Hour % 10);
                _indicator3.DigitOfIndicator(now.Minute / 10);
                _indicator4.DigitOfIndicator(now.Minute % 10);
                _indicator5.DigitOfIndicator(now.Second / 10);
                _indicator6.DigitOfIndicator(now.Second % 10);
                UpdateIndicators();
            }
        }

        private void UpdateIndicators()
        {
            _indicator1.UpdateSegments(Segment000, Segment010, Segment011, Segment020, Segment030, Segment031, Segment040);
            _indicator2.UpdateSegments(Segment100, Segment110, Segment111, Segment120, Segment130, Segment131, Segment140);
            _indicator3.UpdateSegments(Segment200, Segment210, Segment211, Segment220, Segment230, Segment231, Segment240);
            _indicator4.UpdateSegments(Segment300, Segment310, Segment311, Segment320, Segment330, Segment331, Segment340);
            _indicator5.UpdateSegments(Segment400, Segment410, Segment411, Segment420, Segment430, Segment431, Segment440);
            _indicator6.UpdateSegments(Segment500, Segment510, Segment511, Segment520, Segment530, Segment531, Segment540);
        }
    }
}