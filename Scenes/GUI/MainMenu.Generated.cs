/* Generated by MyraPad at 3/01/2023 10:56:36 PM */
using Myra;
using Myra.Graphics2D;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.Brushes;
using Myra.Graphics2D.UI.Properties;
using FontStashSharp.RichText;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AshTechSample.Scenes.GUI
{
	partial class MainMenu: VerticalStackPanel
	{
		private void BuildUI()
		{
			txtbtnStart = new TextButton();
			txtbtnStart.Text = "Start";
			txtbtnStart.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			txtbtnStart.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			txtbtnStart.Id = "txtbtnStart";

			txtbtnOptions = new TextButton();
			txtbtnOptions.Text = "Options";
			txtbtnOptions.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			txtbtnOptions.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			txtbtnOptions.Id = "txtbtnOptions";

			txtbtnExit = new TextButton();
			txtbtnExit.Text = "Exit";
			txtbtnExit.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			txtbtnExit.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			txtbtnExit.Id = "txtbtnExit";

			
			Spacing = 10;
			HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			Widgets.Add(txtbtnStart);
			Widgets.Add(txtbtnOptions);
			Widgets.Add(txtbtnExit);
		}

		
		public TextButton txtbtnStart;
		public TextButton txtbtnOptions;
		public TextButton txtbtnExit;
	}
}