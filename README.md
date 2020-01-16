
Madelbrot-fractal-and-Julia-sets
A visualisation of the Mandelbrot fractal and Julia sets using the .NET framework in visual studio through an interactive windows form app. 

How It Works: 
Complex numbers are computed using Mandelbrots formula f(z) = z^2 + c, where  
    f(z)= z^2 + c 
     f(z)= new position 
     z = current position (complex number)
     c = starting position (comlpex)
     Note: z can be represented as a+bi, where a is the real component and b*i is the imaginary component. 
     z^2 = (a + bi)(a + bi) such that the (a^2 - b^2) is the real component and (2abi) is the imaginary component  
The function is computed for each point on the graphical display spanning from -6,+6 (top left) +6,-6 (bottom right), where the point (0,0) is the center of the display. 
This is recursively graphed until the magnitude of the line from the origin to the point is greater than some magnitude value, (higher magnitude -> better resolution). 
In the graph, the x-axis represents real numbers, while the y-axis represents imaginary numbers. 
The point c is the initial point of the recurrsion. By altering this to be constant values, the user can generate Julia sets, which are sections of the Mandelbrot fractal. 
Sample values for c in the Julia set can be found here: https://en.wikipedia.org/wiki/Julia_set 

Overall this was a fun project to understand how complex numbers and fractals work. Feel free to copy, change and alter the code to help in your own understanding. Below are some links you may find useful to understand in grater detail how fractals work and if your unfamiliar with constructors. 

Complex Struct documentation.https://docs.microsoft.com/en-us/dotnet/api/system.numerics.complex?view=netframework-4.8
Video Explaining Mandelbrot sets.https://www.youtube.com/watch?v=6IWXkV82oyY
How Constructors work.http://www.informit.com/articles/article.aspx?p=2438407&seqNum=7
Constructor documentation.https://docs.microsoft.com/en-us/dotnet/api/system.numerics.complex.-ctor?view=netframework-4.S

