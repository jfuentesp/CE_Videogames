using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace RaylibEngine
{
    /**************************************************************************
     * 
     *  Engine class represents the GameLoop. This is the core of the engine.
     *  
     *  It's a Singleton. 
     * 
     **************************************************************************/

    public sealed class Engine
    {
        private Engine() { }

        private static Engine m_Instance;

        private double m_DeltaTime;
        private int m_FixedFrameRate = 60;

        public static Engine GetInstance()
        {
            if(m_Instance == null)
                m_Instance = new Engine();
            return m_Instance;
        }

        public void Init()
        {
            Raylib.InitWindow(1920, 1080, "Raylib Engine");
            Raylib.SetTargetFPS(m_FixedFrameRate); //This sets the fixed frames per second and calculates its elapsed time. 

            while (!Raylib.WindowShouldClose())
            {
                m_DeltaTime = Raylib.GetFrameTime(); //Gets the frame time per second (0.016 at 60 frames or 1/60)
                ProcessInput();
                Update();
                Render();

                Raylib.DrawText("FPS: " + (1 / m_DeltaTime), 12, 12, 20, Color.Black);
            }
            Raylib.CloseWindow();
        }

        private void Update()
        {

        }

        private void Render()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);
            Raylib.EndDrawing();
        }

        private void ProcessInput()
        {
            if(Raylib.IsKeyDown(KeyboardKey.D) || Raylib.IsKeyDown(KeyboardKey.Right))
            {
                Raylib.DrawText("Right pressed", 12, 12, 20, Color.Black);
            }

            if(Raylib.IsKeyDown(KeyboardKey.A) || Raylib.IsKeyDown(KeyboardKey.Left))
            {
                Raylib.DrawText("Left pressed", 12, 12, 20, Color.Black);
            }

            if(Raylib.IsKeyDown(KeyboardKey.Space))
            {
                Raylib.DrawText("Space pressed", 12, 12, 20, Color.Black);
            }
        }

    }
}
