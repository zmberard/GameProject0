using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace GameProject0
{
    public class Campfire
    {
        //private const float ANIMATION_SPEED = 1f;

        private double animationTimer;

        private short animationFrame = 1;

        private Vector2 position;

        private Texture2D texture;

        /// <summary>
        /// Creates a new campfire
        /// </summary>
        /// <param name="position"></param>
        public Campfire(Vector2 position)
        {
            this.position = position;
        }

        /// <summary>
        /// Loads the sprite texture using the provided ContentManager
        /// </summary>
        /// <param name="content">The ContentManager to load with</param>
        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("campfire");
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            animationTimer += gameTime.ElapsedGameTime.TotalSeconds;

            if (animationTimer > 0.3)
            {
                animationFrame++;
                if (animationFrame > 3) animationFrame = 0;
                animationTimer -= 0.3;
            }

            var source = new Rectangle(animationFrame * 64, 0, 64, 64);
            spriteBatch.Draw(texture, position, source, Color.White);
        }
    }
}
