﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Timetable.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TuesdayTabPage : ContentPage
	{
		public TuesdayTabPage ()
		{
			InitializeComponent ();
		}

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}