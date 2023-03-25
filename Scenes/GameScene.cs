using AshTech.Core;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshTechSample.Scenes
{
    internal class GameScene : Scene
    {

        public override void LoadContent()
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
            GraphicsDevice.Clear(Color.Purple);
            SpriteBatch.Begin();
            SpriteBatch.End();
        }

        public override void UnloadContent()
        {

        }
    }
}
