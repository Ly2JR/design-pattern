namespace Design_Pattern
{
    /// <summary>
    /// 桥接模式
    /// </summary>
    public  class BridgePattern
    {
        /**"Implementor"*/
        public interface IDrawingApi
        {
            void DrawCircle(double x, double y, double radius);
        }

        /**"ConcreteImplementor" 1/2*/
        public class DrawingApi1 : IDrawingApi
        {
            public void DrawCircle(double x, double y, double radius)
            {
                Console.WriteLine($"API1.circle at {x}:{y} radius {radius}");
            }
        }

        /**"ConcreteImplementor" 2/2*/
        public class DrawingApi2 : IDrawingApi
        {
            public void DrawCircle(double x, double y, double radius)
            {
                Console.WriteLine($"API2.circle at {x}:{y} radius {radius}");
            }
        }

        /**“Abstraction“*/
        public interface IShape
        {

            void Draw();
            //low-level(i.e. Implementation-specific)
            void ResizeByPercentage(double pct);
        }

        /**"Refined Abstraction"*/
        public class CircleShape : IShape
        {
            private readonly double _x;
            private readonly double _y;
            private double _radius;
            private readonly IDrawingApi _drawingApi;

            public CircleShape(double x, double y, double radius, IDrawingApi drawingApi)
            {
                this._x = x;
                this._y = y;
                this._radius = radius;
                this._drawingApi = drawingApi;
            }
            //low-level(i.e. Implementation-specific)
            public void Draw()
            {
                _drawingApi.DrawCircle(_x, _y, _radius);
            }

            //high-level (i.e. Abstraction-specific)
            public void ResizeByPercentage(double pct)
            {
                _radius *= pct;
            }
        }
    }
}
