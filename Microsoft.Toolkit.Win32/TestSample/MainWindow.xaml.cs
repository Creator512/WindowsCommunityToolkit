﻿using Microsoft.Toolkit.Win32.UI.Controls.WPF;
using System;
using System.Threading.Tasks;
using System.Windows;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Storage;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;

namespace TestSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly Windows.Devices.Geolocation.Geopoint SeattleGeopoint = new Windows.Devices.Geolocation.Geopoint(new BasicGeoposition() { Latitude = 47.604, Longitude = -122.329 });

        public MainWindow()
        {
            InitializeComponent();
        }

        private void inkCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            inkCanvas.InkPresenter.InputDeviceTypes = CoreInputDeviceTypes.Mouse | CoreInputDeviceTypes.Pen | CoreInputDeviceTypes.Touch;
        }

        private void inkToolbar_Initialized(object sender, EventArgs e)
        {

        }

        private void inkToolbar_ActiveToolChanged(object sender, object e)
        {

        }

        private void inkToolbar_InkDrawingAttributesChanged(object sender, object e)
        {

        }

        private void inkToolbar_IsStencilButtonCheckedChanged(object sender, Microsoft.Toolkit.Win32.UI.Controls.WPF.InkToolbarIsStencilButtonCheckedChangedEventArgs e)
        {

        }

        private void WebBrowser_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void myMap_Loaded(object sender, RoutedEventArgs e)
        {
            myMap.Center = SeattleGeopoint;
            myMap.ZoomLevel = 12;
            myMap.Style = Microsoft.Toolkit.Win32.UI.Controls.WPF.MapStyle.Road;
            myMap.MapProjection = Microsoft.Toolkit.Win32.UI.Controls.WPF.MapProjection.Globe;
            
        }

        private void ColorspacesCombo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void TonemappersCombo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void ScalingCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void WhiteLevelSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void ScalingCheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void swapChainPanel_Loaded(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("https://mediaplatstorage1.blob.core.windows.net/windows-universal-samples-media/image-scrgb-icc.jxr");
            var task = StorageFile.CreateStreamedFileFromUriAsync("image-scRGB-ICC.jxr", uri, null);
            var file = (StorageFile)null;
            task.Completed += new Windows.Foundation.AsyncOperationCompletedHandler<StorageFile>((t, s) => { file = t.GetResults(); });
            
        }
    }

}
