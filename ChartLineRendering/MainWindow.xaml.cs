using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace ChartLineRendering {
    public partial class MainWindow : Window {
        const int count = 20000;
        readonly Random rnd = new Random();

        public ObservableCollection<Point> LineData { get; set; }
        public ObservableCollection<Point> SplineData { get; set; }
       
        public MainWindow() {
            InitializeComponent();
            GenerateData(count);
            this.DataContext = this;
        }

        void GenerateData(int count) {
            ObservableCollection<Point> lineData = new ObservableCollection<Point>();
            ObservableCollection<Point> splineData = new ObservableCollection<Point>();
            for(int i = 0; i < count; i++) {
                lineData.Add(new Point(i, Math.Sin(i / 20)));
                if(i % 25 == 0)
                    splineData.Add(new Point(i, rnd.Next(10, 20)));
            }
            LineData = lineData;
            SplineData = splineData;
        }
    }
}
