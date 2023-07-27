namespace AppSvcScaleUpTest1.Controllers;

public static class Tester {
    private static int _counter;
    static Tester(){ _counter=0; }
    public static int Count {
        get {
            _counter += 1;
            return _counter;
        }
    }

}