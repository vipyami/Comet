﻿using System;
using System.Collections;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HotForms {


	public class Stack : BaseControl<StackLayout>, IEnumerable, IEnumerable<View> {
		
		public IEnumerator<View> GetEnumerator () => FormsControl.Children.GetEnumerator ();


		IEnumerator IEnumerable.GetEnumerator () => FormsControl.Children.GetEnumerator ();


		public void Add (View view)
		{
			if (view == null)
				return;
			FormsControl.Children.Add (view);
		}

		public Stack AsHorizontal()
		{
			FormsControl.Orientation = StackOrientation.Horizontal;
			return this;
		}

		public Stack AsVertical ()
		{
			FormsControl.Orientation = StackOrientation.Vertical;
			return this;
		}
	}
}