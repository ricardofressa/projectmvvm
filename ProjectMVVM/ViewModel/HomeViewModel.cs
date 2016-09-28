
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjectMVVM
{
	public class HomeViewModel : ViewModelBase
	{
		private ICommand _registerCommand;
		private ICommand _galleryCommand;

		public ICommand RegisterCommand 
		{
			get
			{
				return _registerCommand ?? (_registerCommand = new Command(() =>
				{

				}));
			}
		}

		public ICommand GalleryCommand
		{
			get
			{
				return _galleryCommand ?? (_galleryCommand = new Command(() =>
				{

				}));
			}
		}
	}
}
