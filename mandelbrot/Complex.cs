using System;

namespace mandelbrot
{
    // f(z)= Z^2 + c 
    // f(z)= new position 
    // z = current position (complex)
    // c = starting position (comlpex) !!reamins constant per position!!/ unless using julia sets
    // x is the plane for real number (increments by real numbers Ex: 1,2,3,4,5,6,7)
    // y is the plane for imaginary number (increments by imaginary numbers Ex: 1i,2i,3i,4i,5i,6i,7i)
    // diff rules Ex 1*1 = 1 or r*r = r while i*i = -r or -1; real*real = real while imaginary*imaginary = real 
    class Complex
    {

        public double real;
        public double imaginary;
        
        public Complex(double reala, double imaginarya)
        {
            // constructor same name as class with no return type
            // this.real ie real in Complex.cs code
            this.real = reala;
            this.imaginary = imaginarya;
        }

        public void squared()
        {
            // z^2 = (x+yi) * (x+yi)
            // x^2 + 2xyi + y^2 * i^2 and i^2 = -1
            // x^2-y^2 (real component) + 2xyi(imaginary component) -----> creates another imaginary number
            double temp = (real * real) - (imaginary * imaginary);
            imaginary = 2 * real * imaginary;
            real = temp;
        }

        public double magnitude()
        {
            // checks magnitude for coordinates of complex number using pythagorean theorem
            return Math.Sqrt((real * real) + (imaginary * imaginary)); 
        }

        public void addition(Complex c)
        {
            // real is z value (current position) in x coordinate (real value )
            // c is sent by z.addition(c) as starting position of pixel in x coordinate (real value )
            // process repeated in y coordinate for imaginary value 

            real = real + c.real;
            imaginary =imaginary + c.imaginary;
        }
    }
}






// Links I found useful 
// Constructor documentation.https://docs.microsoft.com/en-us/dotnet/api/system.numerics.complex.-ctor?view=netframework-4.8
// Complex Struct documentation.https://docs.microsoft.com/en-us/dotnet/api/system.numerics.complex?view=netframework-4.8
// Video Explaining Mandelbrot sets.https://www.youtube.com/watch?v=6IWXkV82oyY
// How Constructors work.http://www.informit.com/articles/article.aspx?p=2438407&seqNum=7