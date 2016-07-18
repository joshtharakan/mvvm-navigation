// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="saramgsilva">
//   Copyright (c) 2014 saramgsilva. All rights reserved.
// </copyright>
// <summary>
//   Interaction logic for MainWindow.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Linq;
using System.Windows.Media;
using FirstFloor.ModernUI.Presentation;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ModernUIForWPFSample.Navigation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// </summary>
    public partial class MainWindow 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public ICommand ResourcesCommand { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            AppearanceManager.Current.AccentColor = Colors.Orange;
            ContentSource = MenuLinkGroups.First().Links.First().Source;
            ResourcesCommand = new GalaSoft.MvvmLight.Command.RelayCommand(ShowResources);
        }
        /// <summary>
        /// Shows the resources.
        /// </summary>
        private void ShowResources()
        {
        }
    }
}
