using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Blather.Core.Helpers;
using System.ComponentModel;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Media;

namespace Blather.Models
{
    public class ConsoleViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the ConsoleViewModel class.
        /// </summary>
        public ConsoleViewModel()
        {
			_ImageSource = new System.Windows.Controls.Image();
        }

		private string _SomeString;
		public string SomeString
		{
			get { return _SomeString; }
			set
			{
				_SomeString = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("SomeString"));
                }
			}
		}
        

        private System.Windows.Controls.Image _ImageSource;
        public System.Windows.Controls.Image ImageSource
        {
            get
            {
                return _ImageSource;
            }
            set
            {
                _ImageSource = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ImageSource"));
                }
            }
        }

        public BitmapImage BM { get; set; }

		public void SetImage(Bitmap bitmap)
		{
            ImageSource.Source = Imaging.CreateBitmapSourceFromHBitmap(
                bitmap.GetHbitmap(),
                IntPtr.Zero, Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions()
                );
            //var m = new MemoryStream();
            ////using (var m = new MemoryStream())
            ////{
            //    bitmap.Save(m, ImageFormat.Bmp);
            //    m.Seek(0, SeekOrigin.Begin);

            //    BitmapImage wpfBitmap = new BitmapImage();
            //    wpfBitmap.BeginInit();
            //    wpfBitmap.StreamSource = m;
            //    wpfBitmap.EndInit();

            //    ImageSource.Source = wpfBitmap;

            //    var converter = new ImageSourceConverter();
            //    //ImageSource.Source = converter.ConvertFrom(bitmap);

            ////}
		}

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
