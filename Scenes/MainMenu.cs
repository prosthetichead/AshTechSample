using AshTech.Core;
using FontStashSharp;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshTechSample.Scenes
{
    internal class MainMenu : Scene
    {

        SpriteFontBase font;

        public override void LoadContent()
        {
            font = AssetManager.LoadFont("Content/AshTechSample.zip", "m5x7.ttf", 16);
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

        }

        public override void UnloadContent()
        {
        }


    }
}
