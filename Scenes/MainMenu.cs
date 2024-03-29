﻿using AshTech.Core;
using AshTech.UI;
using AshTech.UI.Widgets;
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
        Desktop mainMenu;
        Button startButton;
        

        public override void LoadContent()
        {           

            font = AssetManager.LoadFontSystem("m5x7.ttf", "Content/AshTechSample.zip").GetFont(16);

            mainMenu = new Desktop(GraphicsDevice.Viewport.Bounds, Game);
            
            startButton = new Button(new Rectangle(0, 0, 200, 100), DesktopAnchor.TopLeft, font);
            mainMenu.AddWidget("startButton", startButton);
            startButton.value = "START GAME";

            //setup events
            GameSettings.SettingsChanaged += GameSettings_SettingsChanaged;

        }

        private void GameSettings_SettingsChanaged(object sender, EventArgs e)
        {
            mainMenu.bounds = GraphicsDevice.Viewport.Bounds;
        }

        public override void Update(GameTime gameTime, bool sceneHasFocus)
        {
            mainMenu.Update(gameTime);
        }

        public override void HandleInput(GameTime gameTime, bool sceneHasFocus, InputManager input)
        {
            mainMenu.HandleInput(gameTime, input);
        }

        public override void Draw(GameTime gameTime, bool sceneHasFocus)
        {
           // GraphicsDevice.Clear(Color.Black);
            SpriteBatch.Begin();

            mainMenu.Draw(SpriteBatch);
            
            SpriteBatch.DrawString(font, "AshTech Sample. Main Menu ", new Vector2(10,10), Color.Black) ;

            SpriteBatch.End();            
        }

        public override void UnloadContent()
        {
        }


    }
}
