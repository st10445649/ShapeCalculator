namespace ShapeCalculator{

    public abstract class Shape {
        public string Name {get; set; }

        public Shape(string name){
            this.Name = name;
        }

        public virtual void Display(){
            Console.WriteLine("This method will be overriden");
        }

    }
}