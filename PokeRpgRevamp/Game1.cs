using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using PokeRpgRevamp.UI;

namespace PokeRpgRevamp;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private Color _corDeFundo = Color.CornflowerBlue;
    private Texture2D _pixel;
    private Button _loadButton;
    private SpriteFont _font;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        _graphics.PreferredBackBufferWidth = 1280;
        _graphics.PreferredBackBufferHeight = 720;
        _graphics.IsFullScreen = false;

        Window.AllowUserResizing = true;
        Window.Title = "Poke RPG";

        Content.RootDirectory = "Content";

        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        int _loadButtonX = 490;
        int _loadButtonY = 250;

        int _buttonWidth = 300;
        int _buttonHeight = 60;


        _loadButton = new Button (new Rectangle (_loadButtonX, _loadButtonY, _buttonWidth, _buttonHeight), "Load Game", Color.OrangeRed);

        base.Initialize();
    }

    protected override void LoadContent()
    {
        // TODO: use this.Content to load your game content here
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        _pixel = new Texture2D(GraphicsDevice, 1, 1);
        _pixel.SetData(new[] { Color.White });
        _font = Content.Load<SpriteFont>("Font");

    }

    protected override void Update(GameTime gameTime)
    {
        // TODO: Add your update logic here
        if (Keyboard.GetState().IsKeyDown(Keys.Escape)) 
            Exit();

        _loadButton.Update(Mouse.GetState());

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        // TODO: Add your drawing code here
        GraphicsDevice.Clear(_corDeFundo);
        
        _spriteBatch.Begin();
        _loadButton.Draw(_spriteBatch, _pixel, _font);
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
