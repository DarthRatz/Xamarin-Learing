﻿using System;

using Xamarin.Forms;

namespace XamarinTestApp
{
	public class App : Application
	{
		public App ()
		{
			Button btn = new Button ();
			btn.Text = "This is a button";

			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Eamonn Xamarin Learning"
						},
						btn
					}
				}
			};
			btn.Clicked += (sender, e) => {
				btn.Text = "Clicked";
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

