using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

namespace squareInHole
{
    class Program
    {
        static void Main(string[] args)
        {
            RoundHole roundHole = new RoundHole(11);
            RoundPeg roundPeg = new RoundPeg { Radius = 11 };
            WriteLine(roundHole.isFits(roundPeg));

            SquarePeg squarePeg = new SquarePeg() { Width = 10 };
            SquarePegAdapter squarePegAdapter = new SquarePegAdapter(squarePeg);
            WriteLine(roundHole.isFits(squarePegAdapter));



        }
    }
    class RoundHole
    {
        public int radius { get; set; }
        public RoundHole(int radius)
        {
            this.radius = radius;
        }
        public bool isFits(RoundPeg peg)
        {
            return (this.radius >= peg.Radius ? true : false);
        }
    }

    public class RoundPeg
    {
        public virtual int Radius { get; set; }
        //public RoundPeg(int radius)
        //{
        //    this.radius = radius;
        //}
        public virtual double getRadius()
        {
            return Radius;
        }
    }
    public class SquarePeg
    {
        public int Width { get; set; }
        //public SquarePeg()
        //{
        //    this.Width = width;
        //}
        public virtual int getWidth()
        {
            return Width;
        }
    }
    public class SquarePegAdapter : RoundPeg
    {
        SquarePeg peg;
        public SquarePegAdapter(SquarePeg peg)
        {
            this.peg = peg;
        }
        //public SquarePegAdapter(SquarePeg peg)
        //{
        //    this.peg = peg;
        //}

        public override int Radius { get => base.Radius; set => base.Radius = value; }
        //public virtual double get()
        //{
        //    double halfWidth = peg.getWidth() / 2;
        //    return Sqrt(Pow(halfWidth, 2) * 2);
        //}
    }

}
