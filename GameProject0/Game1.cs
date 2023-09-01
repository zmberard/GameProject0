using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.Direct2D1;
using SpriteBatch = Microsoft.Xna.Framework.Graphics.SpriteBatch;

namespace GameProject0
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch spriteBatch;

        private Campfire campfire;
        private Background background;
        private SpriteFont titleText;
        private SpriteFont exitText;
        private CamperOne camperOne;
        private CamperTwo camperTwo;
        private CreepyShadow creepyShadow;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            campfire = new Campfire(new Vector2(163, 180));
            background = new Background(new Vector2(0, 0));
            camperOne = new CamperOne(new Vector2(170, 170));
            camperTwo = new CamperTwo(new Vector2(119, 170));
            creepyShadow = new CreepyShadow(new Vector2(425, 155));
            base.Initialize();


        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            campfire.LoadContent(Content);
            background.LoadContent(Content);
            camperTwo.LoadContent(Content);
            camperOne.LoadContent(Content);
            creepyShadow.LoadContent(Content);
            exitText = Content.Load<SpriteFont>("Cormorant Garamond");
            titleText = Content.Load<SpriteFont>("Cormorant Garamond");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            
            background.Draw(gameTime, spriteBatch);
            campfire.Draw(gameTime, spriteBatch);
            camperOne.Draw(gameTime, spriteBatch);
            camperTwo.Draw(gameTime, spriteBatch);
            creepyShadow.Draw(gameTime, spriteBatch);
            spriteBatch.DrawString(titleText, "C A M P", new Vector2(34, 34), Color.White);
            spriteBatch.DrawString(exitText, "P r e s s  E s c  t o  e x i t  t h e  g a m e", new Vector2(0, 280), Color.White);
            // TODO: Add your drawing code here
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}