public class Phone : Product
{
    int Apera {get; set;}
    int Pamyat {get; set;}
    public Phone (){}
    public Phone (string n,double pr,int apr, int pam) : base(n, pr)
    {
        Apera = apr;
        Pamyat = pam;
    }
}