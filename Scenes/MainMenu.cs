using AshTech.Core;
using FontStashSharp;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myra;
using Myra.Graphics2D.UI;

namespace AshTechSample.Scenes
{
    internal class MainMenu : Scene
    {

        SpriteFontBase font;
        Desktop desktop;

        public override void LoadContent()
        {
            desktop = new Desktop();

            font = AshAssetManager.LoadFontSystem("m5x7.ttf", "Content/AshTechSample.zip").GetFont(16);

            var mainMenu = new GUI.MainMenu();

            mainMenu.txtbtnStart.Click += StartButtonClicked;

            desktop.Root = mainMenu;
        }

        private void StartButtonClicked(object sender, EventArgs e)
        {
            
        }

        public override void Update(GameTime gameTime, bool sceneHasFocus)
        {
            
        }

        public override void HandleInput(GameTime gameTime, bool sceneHasFocus, InputManager input)
        {

        }

        public override void Draw(GameTime gameTime, bool sceneHasFocus)
        {
            GraphicsDevice.Clear(Color.Black);
            SpriteBatch.Begin();
            SpriteBatch.DrawString(font, "AshTech Sample. Main Menu ", new Vector2(10,10), Color.Green) ;
            SpriteBatch.End();

            desktop.Render();
        }

        public override void UnloadContent()
        {
        }


    }
}
