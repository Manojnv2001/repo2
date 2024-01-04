public partial class Program
{
    public static void Main(string[] args){
    for (int i=1; i<=6; ++i)  {
        if(i==2){
            continue;
        }
            for (int j = 1; j <= i; ++j) {
                Console.Write("*");
            }
            Console.WriteLine( );
            }
        }
}
        
    
