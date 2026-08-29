using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PokeRpgRevamp.UI;

public class Button
{
    public Rectangle Area { get; set; }
    public string Text { get; set; }
    public Color Fill { get; set; }
    public bool IsHovered { get; private set;}

    public Button (Rectangle area, string text, Color color)
    {
        Area = area;
        Text = text;
        Fill = color;
    }


    public void Update (MouseState mouse)
    {
        IsHovered = Area.Contains(mouse.Position);
    }
    public void Draw (SpriteBatch spriteBatch, Texture2D pixel, SpriteFont font)
    {
        Color currentColor = IsHovered ? Color.Orange : Fill;
        spriteBatch.Draw(pixel, Area, currentColor);

        Vector2 textSize = font.MeasureString(Text);
        Vector2 position = new Vector2(
            Area.Center.X - textSize.X / 2,
            Area.Center.Y - textSize.Y / 2
        );

        spriteBatch.DrawString(font, Text, position, Color.White);
            
    }
}