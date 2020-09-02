using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms.Controls.Issues
{
    public partial class Issue9045_Item : Grid
    {
        public Issue9045_Item()
        {
#if APP
			InitializeComponent();
#endif
		}

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();

			if (BindingContext is OfflineMonkey monkey)
			{
				Debug.WriteLine($"Bound {nameof(Issue9045_Item)}_{Id} for {monkey.Name}");
			}
		}
	}
}