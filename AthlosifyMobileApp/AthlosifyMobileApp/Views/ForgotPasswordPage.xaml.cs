﻿using AthlosifyMobileApp.Services;
using AthlosifyMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AthlosifyMobileApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ForgotPasswordPage : ContentPage
	{
		private ForgotPasswordViewModel _viewModel;

		public ForgotPasswordPage ()
		{
			InitializeComponent();
			BindingContext = _viewModel = new ForgotPasswordViewModel()
			{
				Navigation = Navigation
			};
		}
	}
}