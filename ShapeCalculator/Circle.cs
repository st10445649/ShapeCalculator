namespace ShapeCalculator{
    class Circle: Shape, Area {

         public double Radius {get; set; }

        public Circle(string name, double Radius): base(name) {
            this.Radius= Radius;
        }

        public  double CalculateArea(){
           double area= Math.PI*(Radius*Radius);
           return area;
        }

        public override void Display()
    {
        base.Display();
        Console.WriteLine($"Radius: {Radius}, Area: {CalculateArea()}");
    }


    }
}