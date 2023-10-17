using AshTech.Core;
using AshTechSample.Scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AshTechSample
{
    public class AshTechSampleGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private AshTechEngine ashTech;

        public AshTechSampleGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            ashTech = new AshTechEngine(this, _graphics);
            Components.Add(ashTech);
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            MainMenu mainMenu = new MainMenu();
            GameScene gameScene = new GameScene();

            ashTech.AddScene("mainMenu", mainMenu);
            ashTech.AddScene("game", gameScene);

            ashTech.ActivateScene("mainMenu");
        }

        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
        }
    }
}