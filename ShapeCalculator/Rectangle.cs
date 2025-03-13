namespace ShapeCalculator{
    internal class Rectangle: Shape{

        public string ShapeLength {get; set; }
        public string ShapeWidth {get; set; }

        public Rectangle (string shapeLength, string shapeWidth){
            this.ShapeLength = shapeLength;
            this.ShapeWidth = shapeWidth;
        }

    }
}