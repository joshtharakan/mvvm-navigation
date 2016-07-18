using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight.Views;
namespace ModernUIForWPFSample.Navigation__MVVM_.Services
{
    /// <summary>
    /// The ModernNavigationService interface.
    /// </summary>
    public interface IModernNavigationService : INavigationService
    {
        /// <summary>
        /// Gets the parameter.
        /// </summary>
        /// <value>
        /// The parameter.
        /// </value>
        object Parameter { get; }
    }
}
