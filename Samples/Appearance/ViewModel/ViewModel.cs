

using Syncfusion.Windows.Shared;
using System.Windows;
using System.Windows.Media;

namespace Appearance
{
    class ViewModel : NotificationObject
    {
        private FlowDirection flowDirection;
        private Brush background = Brushes.LightYellow;
        private Brush borderBrush = Brushes.DarkOrange;
        private Brush foreground = Brushes.Red;

        public Brush Background
        {
            get { return background; }
            set
            {
                background = value;
                this.RaisePropertyChanged(nameof(Background));
            }
        }
        public Brush BorderBrush
        {
            get { return borderBrush; }
            set
            {
                borderBrush = value;
                this.RaisePropertyChanged(nameof(BorderBrush));
            }
        }
        public Brush Foreground
        {
            get { return foreground; }
            set
            {
                foreground = value;
                this.RaisePropertyChanged(nameof(Foreground));
            }
        }

        public FlowDirection FlowDirection
        {
            get { return flowDirection; }
            set
            {
                flowDirection = value;
                this.RaisePropertyChanged(nameof(FlowDirection));
            }
        }

        public ViewModel()
        {

        }
    }
}