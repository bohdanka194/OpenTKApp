using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.Drawing;

namespace CubeOpenGLApp
{
    class Game
    {
        GameWindow window;
        public Game(GameWindow window)
        {
            this.window = window;

            window.Load += window_Load;
            window.UpdateFrame += window_UpdateFrame;
            window.RenderFrame += window_RenderFrame;
        }
        void window_Load(object sender, EventArgs args)
        {
            GL.ClearColor(Color.CornflowerBlue);
            GL.Clear(ClearBufferMask.ColorBufferBit);

            window.SwapBuffers();
            //throw new NotImplementedException();
        }
        void window_UpdateFrame(object sender, FrameEventArgs args)
        {
            //throw new NotImplementedException();
        }
        void window_RenderFrame(object sender, FrameEventArgs args)
        {
            GL.ClearColor(Color.CornflowerBlue);
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.Begin(PrimitiveType.Triangles);
            GL.Vertex2(0, 0);
            GL.Vertex2(0.8, 0);
            GL.Vertex2(0, 0.8);
            GL.End();
            window.SwapBuffers();
        }

    }
}
