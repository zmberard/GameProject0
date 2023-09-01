using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace GameProject0
{
    public class CamperOne
    {
        private Texture2D texture;

        public Vector2 Position;

        public CamperOne(Vector2 position)
        {
            Position = position;
        }

        public void LoadContent(ContentManager content)
        {
            //backgroud art taken from @scixels on twitter
            texture = content.Load<Texture2D>("Camper1-Resized");

        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //draws the animation
            spriteBatch.Draw(texture, Position, null, Color.White);

        }
    }
}
