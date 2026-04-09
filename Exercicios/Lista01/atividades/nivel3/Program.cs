using System;

class Program {
    public int Soma(int a, int b) {
        return a + b;
    }

    public bool EhPar(int n) {
        return n % 2 == 0;
    }

    public int Maior(int a, int b) {
        if (a > b) return a;
        return b;
    }

    public double Media(double a, double b, double c) {
        return (a + b + c) / 3.0;
    }
}