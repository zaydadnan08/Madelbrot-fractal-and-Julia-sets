using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mandelbrot
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate(object sender, EventArgs e)
        {
           

            Bitmap pixel = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int maxiterations = 100;

            // loops and gives x,y coordinates for all values on the complex plane to 2 decimal places
            // Example when x=1; real = (1-(400/2))(400/4) or -1.99; when x=400 real = 2.0


            for (int x = 0; x < pictureBox1.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Height; y++)
                {

                    double realval = (double)(x - (pictureBox1.Width / 2)) / (double)(pictureBox1.Width / 4);
                    double imaginaryval = (double)(y - (pictureBox1.Height / 2)) / (double)(pictureBox1.Height / 4);
                    // The area used is 600,600 with 0,0 at top left and 599,599 bottom right. 
                    //In order to have this as a complex plane need 0,0 at the middle, -6,+6 top left +6,-6 bottom right
                    //take 300 from each x,y to give a range of -300 to +299; divide by a quarter of 150 (100) 
                    // get from -2 to +2 (approx). x,y then becomes 
                    //a +bi on the complex plane. use +/-2 as max magnitude is set to 2 below

                    Complex c = new Complex(realval, imaginaryval);

                    if (textBox1.Text != "" && (textBox2.Text != "")) {
                        double ax = Double.Parse(textBox1.Text);
                        double ay = Double.Parse(textBox2.Text);
                        c = new Complex(ax, ay);
                    }
                    Complex z = new Complex(realval, imaginaryval);
                    // these two lines call on constructor in Complex.cs class to set values
                    // sends c value as const (starting position) 
                    // as f(z) starts as z=0; but 0^2 +c = c so z becomes value of c
                    int iter = 0; // for every pixel code runs until condition is met

                    while (iter < maxiterations)
                    {
                        iter++;
                        // FORMULA for mandelbrot is f(z) = Z^2 + c  
                        z.squared();
                        z.addition(c);
                        if (z.magnitude() > 500) { break; }
                        // checking if beyond bounds of complex plane (circle of radius 2) aka dancefloor
                        // if so breaks from loop 

                    }
                   
                    int extra = iter*iter;
                    if (iter * iter > 255)
                    {
                         extra = (int) iter * iter / 40;
                    }

                    pixel.SetPixel(x, y, iter < 100 ? Color.FromArgb(iter*2, iter, extra) : Color.FromArgb(255, 255, 255));
                    
                    // ? evauates boolean expression if true or false for iteration 
                    // if iter<100 is true turn pixel colour, if false (iter==100) turn pixel black
                    // iter values from when code breaks, 
                }
            }
            pictureBox1.Image = pixel;
        }

     
    }
}






