
using Most;

Figure figure = new Rectangle(new Blue(), new Small());
figure.GetFigure();
figure.GetSize();
figure.GetColor();
Console.WriteLine("--------------------");
figure.Color = new White();
figure.Size = new Big();
figure.GetFigure();
figure.GetSize();
figure.GetColor();
Console.WriteLine("--------------------");
Figure figure1 = new Circle(new Red(), new Big());
figure1.GetFigure();
figure1.GetSize();
figure1.GetColor();
Console.WriteLine("--------------------");
figure1.Color = new White();
figure1.GetFigure();
figure1.GetSize();
figure1.GetColor();