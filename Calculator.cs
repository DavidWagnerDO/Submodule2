using Submodule1;

namespace Submodule2;
public static class Calculator2
{
    public static int Add(int s1, int s2){
        return Calculator1.Add(s1, s2);
    }

    public static int Subtract(int m, int s){
        return m - s;
    }
}
