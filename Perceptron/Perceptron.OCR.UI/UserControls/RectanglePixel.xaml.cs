using System.Windows.Controls;
using Perceptron.OCR.Model.Model.Abstract;
using Perceptron.OCR.ViewModel.ViewModel.Abstract;

namespace Perceptron.OCR.UI.UserControls
{
    /// <summary>
    /// Logique d'interaction pour RectanglePixel.xaml
    /// </summary>
    public partial class RectanglePixel : UserControl
    {
        #region Properties

        public IPixel Pixel { get; private set; }

        #endregion


        #region Constructor

        public RectanglePixel(IMainViewModel mainViewModel, IPixel pixel)
        {
            Pixel = pixel;
            DataContext = mainViewModel;

            InitializeComponent();
        }

        #endregion
    }
}
