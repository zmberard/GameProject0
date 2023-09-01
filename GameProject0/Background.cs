using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace GameProject0
{
    public class Background
    {
        private Texture2D texture;

        public Vector2 Position;

        public Background(Vector2 position)
        {
            Position = position;
        }

        public void LoadContent(ContentManager content)
        {
            //backgroud art taken from @scixels on twitter
            texture = content.Load<Texture2D>("background");

        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //draws the animation
            spriteBatch.Draw(texture, Position, null, Color.White);

        }
    }
}
